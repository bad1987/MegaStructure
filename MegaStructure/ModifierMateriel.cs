using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaStructure
{
    public partial class ModifierMateriel : Form
    {
        private DatabaseLite lite;
        private DataTable listeFamille;
        private long matId;
        private int index;
        private DataTable typesuivi;

        public ModifierMateriel(long matid)
        {
            matId = matid;
            InitializeComponent();
            index = -1;
            lite = new DatabaseLite();
            lite.creatConnection();

            typesuivi = new DataTable();
            typesuivi.Columns.Add("reference", typeof(int));
            typesuivi.Columns.Add("designation", typeof(String));
            suivistock.DataSource = typesuivi;
            suivistock.DisplayMember = "designation";
            suivistock.ValueMember = "reference";

            listeFamille = new DataTable();
            listeFamille.Columns.Add("reference", typeof(Int64));
            listeFamille.Columns.Add("designation", typeof(String));
            listeFamille.Columns.Add("code", typeof(String));

            initFamille();
            famille.DataSource = listeFamille;
            famille.DisplayMember = "designation";
            famille.ValueMember = "reference";
                        
            if (index != -1)
            {
                famille.SelectedIndex = index;
            }

            matref.Text = matId.ToString();
        }

        public void initFamille()
        {
            SQLiteConnection conn = lite.getConnector();
            String request = @"SELECT * from F_FAMILLE";
            String famcode = getFamCodeFromMat();
            int cpt = 0;
            using (SQLiteCommand cmd = new SQLiteCommand(request, conn))
            {
                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        if(famcode == dr.GetString(2))
                        {
                            index = cpt;
                            cpt = -1;
                        }
                        listeFamille.Rows.Add(dr.GetInt64(0), dr.GetString(1), dr.GetString(2));
                        if (cpt >= 0)
                            cpt++;
                    }
                }
            }

        }

        public String getFamCodeFromMat()
        {
            String request = @"SELECT FA_CODE,MA_DESIGN,MA_SUIVISTOCK FROM F_MATERIEL WHERE MA_NO = {0}";
            request = String.Format(request, matId);
            String code = "";
            using (SQLiteCommand cmd = new SQLiteCommand(request, lite.getConnector()))
            {
                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    if(dr.Read())
                    {
                        code = dr.GetString(0);
                        matdesign.Text = dr.GetString(1);
                        Text = "MATERIAU:  " + dr.GetString(1);
                        int type = dr.GetInt32(2);
                        if(type == 1)
                        {
                            typesuivi.Rows.Add(1, "Entree/Sortie");
                            typesuivi.Rows.Add(2, "Sortie Uniquement");
                        }
                        else
                        {
                            typesuivi.Rows.Add(2, "Sortie Uniquement");
                            typesuivi.Rows.Add(1, "Entree/Sortie");
                        }
                    }
                }
            }
            return code;
        }

        private void enregistrer_Click(object sender, EventArgs e)
        {
            updateMat();
        }

        public void updateMat()
        {
            String design = matdesign.Text.ToUpper();
            int famId = int.Parse(listeFamille.Rows[famille.SelectedIndex][0].ToString());
            int suivstock = int.Parse(typesuivi.Rows[suivistock.SelectedIndex][0].ToString());
            String codefam = listeFamille.Rows[famille.SelectedIndex][2].ToString();
            //MessageBox.Show(famId + ' ' + design + ' ' + codefam);
            String request = @"UPDATE F_MATERIEL SET MA_DESIGN = '{0}', FA_CODE='{1}',MA_SUIVISTOCK = {3} WHERE MA_NO = {2}";
            request = string.Format(request, lite.stripString(design), lite.stripString(codefam), matId,suivstock);

            using(SQLiteCommand cmd = new SQLiteCommand(request, lite.getConnector()))
            {
                cmd.ExecuteNonQuery();
            }
        }

        private void matdesign_Leave(object sender, EventArgs e)
        {
            if(matdesign.Text == "")
            {
                MessageBox.Show("Une valeur vide n'est pas autorisee", "designation incorrecte", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ActiveControl = matdesign;
                return;
            }
        }

        private void ModifierMateriel_Load(object sender, EventArgs e)
        {
            ActiveControl = matref;
        }
    }
}
