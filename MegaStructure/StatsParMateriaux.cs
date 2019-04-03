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
    public partial class StatsParMateriaux : Form
    {
        private DatabaseLite lite;
        private DataTable listeMateriaux;
        private string debut, fin;

        public StatsParMateriaux()
        {
            InitializeComponent();
            lite = new DatabaseLite();
            lite.creatConnection();

            listeMateriaux = new DataTable();
            listeMateriaux.Columns.Add("reference", typeof(Int64));
            listeMateriaux.Columns.Add("designation", typeof(String));
            loadDataTable();
            materiauxListCombo.DataSource = listeMateriaux;
            materiauxListCombo.DisplayMember = "designation";
            materiauxListCombo.ValueMember = "reference";
        }

        private void fermerStat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void okStat_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(typeDocCombo.SelectedIndex.ToString());
            if(typeDocCombo.Text == "")
            {
                MessageBox.Show("Vous devez choisir un type de mouvement","type de mouvement incorrect",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            if (materiauxListCombo.Text == "")
            {
                MessageBox.Show("Vous devez choisir un materiau", "materiau incorrect", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int typeDoc = typeDocCombo.SelectedIndex + 1;
            long matIndex = long.Parse(listeMateriaux.Rows[materiauxListCombo.SelectedIndex][0].ToString());
            debut = dateDebut.Value.Date.ToString("yyyy-MM-dd");
            fin = dateFin.Value.Date.ToString("yyyy-MM-dd");
            processLigneDocument(matIndex, typeDoc);
        }

        public void processLigneDocument(long mat_ref,int typedoc)
        {
            dataGridView1.Rows.Clear();
            qteTotale.Text = "";
            String request = @"
                SELECT MA_DESIGN,MO_QTE,MO_DATE,MO_PIECE
                FROM F_MATERIEL,F_LIGNEMOUVEMENT
                WHERE F_MATERIEL.MA_NO = F_LIGNEMOUVEMENT.MA_NO
                    AND MO_TYPE = {0} AND F_LIGNEMOUVEMENT.MA_NO = {1}
                    AND MO_DATE >= '{2}' AND MO_DATE <= '{3}'
            ";
            request = String.Format(request, typedoc, mat_ref,debut,fin);
            string[] row;
            Double total = 0;
            using(SQLiteCommand cmd = new SQLiteCommand(request, lite.getConnector()))
            {
                using(SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        row = new string[4];
                        row[0] = dr.GetString(3);
                        row[1] = dr.GetString(0);
                        row[2] = dr.GetString(2);
                        row[3] = dr.GetDouble(1).ToString();
                        total += dr.GetDouble(1);
                        dataGridView1.Rows.Add(row);
                    }
                }
            }

            if(dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.ClearSelection();
            }

            qteTotale.Text = total.ToString();
        }

        public void loadDataTable()
        {
            listeMateriaux.Rows.Clear();
            String request = @"SELECT * FROM F_MATERIEL";
            using (SQLiteCommand cmd = new SQLiteCommand(request, lite.getConnector()))
            {
                using (SQLiteDataReader sd = cmd.ExecuteReader())
                {
                    while (sd.Read())
                    {
                        listeMateriaux.Rows.Add(sd.GetInt64(0), sd.GetString(1));
                    }
                }
            }

        }
    }
}
