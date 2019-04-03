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
    public partial class CreerMateriaux : Form
    {
        private DatabaseLite lite;
        private DataTable listeFamille;
        private DataTable typesuivi;
        public CreerMateriaux()
        {
            InitializeComponent();
            lite = new DatabaseLite();
            lite.creatConnection();
            listeFamille = new DataTable();
            listeFamille.Columns.Add("reference",typeof(int));
            listeFamille.Columns.Add("designation",typeof(String));
            listeFamille.Rows.Add(-1,"");
            initFamille();
            artFamille.DataSource = listeFamille;
            artFamille.DisplayMember = "designation";
            artFamille.ValueMember = "reference";

            typesuivi = new DataTable();
            typesuivi.Columns.Add("reference", typeof(int));
            typesuivi.Columns.Add("designation", typeof(String));
            typesuivi.Rows.Add(1, "Entree/Sortie");
            typesuivi.Rows.Add(2, "Sortie Uniquement");
            suivistock.DataSource = typesuivi;
            suivistock.DisplayMember = "designation";
            suivistock.ValueMember = "reference";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String designM = lite.stripString(artDesign.Text);
            if( designM == "" ||artFamille.Text == "")
            {
                MessageBox.Show("Tous les champs doivent etre remplis", "champ invalide", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            long refFamille = long.Parse(listeFamille.Rows[artFamille.SelectedIndex][0].ToString());
            int choixsuivi = int.Parse(typesuivi.Rows[suivistock.SelectedIndex][0].ToString());
            String designArt = lite.stripString(artDesign.Text);
            String date = DateTime.Now.Date.ToString("yyyy-MM-dd");
            String request = @"INSERT INTO F_MATERIEL (MA_DESIGN,MA_DATE,FA_CODE,MA_SUIVISTOCK) 
                        VALUES('{0}','{1}',{2},{3})
                    ";
            request = String.Format(request, designArt.ToUpper(), date, refFamille,choixsuivi);


            SQLiteCommand cmd = new SQLiteCommand(request, lite.getConnector());
            cmd.ExecuteNonQuery();
            artDesign.Text = "";
            artFamille.SelectedIndex = 0;
            //MessageBox.Show(designArt + " " + refFamille, "champ a enregistrer", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void fermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void artRef_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }

        private void artDesign_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }

        private void artFamille_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }

        public void initFamille()
        {
            SQLiteConnection conn = lite.getConnector();
            String request = @"SELECT * from F_FAMILLE";

            using (SQLiteCommand cmd = new SQLiteCommand(request, conn))
            {
                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    while(dr.Read())
                    {
                        listeFamille.Rows.Add(dr.GetInt64(0), dr.GetString(1));
                    }
                }
            }
        }
    }
}
