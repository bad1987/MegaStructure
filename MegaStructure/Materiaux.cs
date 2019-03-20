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
    public partial class Materiaux : Form
    {
        private DatabaseLite lite;
        public Materiaux()
        {
            InitializeComponent();
            lite = new DatabaseLite();
            lite.creatConnection();
            loadMateriaux();
        }

        private void fermerMateriaux_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void loadMateriaux()
        {
            listeMateriauxDatagrid.Rows.Clear();
            SQLiteConnection conn = lite.getConnector();
            String request = @"SELECT *
                               FROM F_MATERIEL";
            String[] rows;
            using(SQLiteCommand cmd = new SQLiteCommand(request, conn))
            {
                using(SQLiteDataReader sd = cmd.ExecuteReader())
                {
                    while (sd.Read())
                    {
                        Double[] result = getMaterielStock(sd.GetInt64(0));
                        rows = new string[5];
                        rows[0] = sd.GetInt64(0).ToString();
                        rows[1] = sd.GetString(1);
                        if(result[0] > 0)
                            rows[2] = result[0].ToString();
                        if (result[1] > 0)
                            rows[3] = result[1].ToString();
                        if (result[2] > 0)
                            rows[4] = result[2].ToString();
                        listeMateriauxDatagrid.Rows.Add(rows);
                    }
                }
            }
        }

        public void recherche(String motif)
        {
            listeMateriauxDatagrid.Rows.Clear();
            SQLiteConnection conn = lite.getConnector();
            String request = @"SELECT * FROM F_MATERIEL WHERE MA_DESIGN LIKE '%{0}%'";
            request = String.Format(request, motif);
            String[] rows;
            using (SQLiteCommand cmd = new SQLiteCommand(request, conn))
            {
                using (SQLiteDataReader sd = cmd.ExecuteReader())
                {
                    while (sd.Read())
                    {
                        Double[] result = getMaterielStock(sd.GetInt64(0));
                        rows = new string[5];
                        rows[0] = sd.GetInt64(0).ToString();
                        rows[1] = sd.GetString(1);
                        if (result[0] > 0)
                            rows[2] = result[0].ToString();
                        if (result[1] > 0)
                            rows[3] = result[1].ToString();
                        if (result[2] > 0)
                            rows[4] = result[2].ToString();
                        listeMateriauxDatagrid.Rows.Add(rows);
                    }
                }
            }

            if(listeMateriauxDatagrid.SelectedRows.Count > 0)
            {
                listeMateriauxDatagrid.SelectedRows[0].Selected = false;
            }
        }

        public double[] getMaterielStock(long ma_no)
        {
            SQLiteConnection conn = lite.getConnector();
            String request = @"SELECT ST_QTEMIN,ST_QTESTOCK,ST_HORSERVICE FROM F_MATSTOCK WHERE MA_NO = {0}";
            request = String.Format(request, ma_no);
            Double[] result = {0,0,0 };

            using(SQLiteCommand cmd = new SQLiteCommand(request, conn))
            {
                using(SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        result[0] = dr.GetDouble(0);
                        result[1] = dr.GetDouble(1);
                        result[2] = dr.GetDouble(2);
                    }
                }
            }
            return result;
        }

        private void nouveauMateriaux_Click(object sender, EventArgs e)
        {
            CreerMateriaux cm = new CreerMateriaux();
            cm.Show();
        }

        private void Materiaux_FormClosing(object sender, FormClosingEventArgs e)
        {
            lite.closeConnection();
        }

        private void rechercheMateriaux_Click(object sender, EventArgs e)
        {
            recherche(inputSearch.Text.ToUpper());
        }

        private void inputSearch_KeyDown(object sender, KeyEventArgs e)
        {
            recherche(inputSearch.Text.ToUpper());
        }

        private void ouvrirMateriaux_Click(object sender, EventArgs e)
        {
            if(listeMateriauxDatagrid.SelectedRows.Count > 0)
            {
                long matref = long.Parse(listeMateriauxDatagrid.SelectedRows[0].Cells[0].Value.ToString());
                //MessageBox.Show(matref.ToString());
                ModifierMateriel modmat = new ModifierMateriel(matref);

                if(modmat.ShowDialog() == DialogResult.OK)
                {
                    loadMateriaux();
                    listeMateriauxDatagrid.SelectedRows[0].Selected = false;
                }
                else
                {

                }
            }
        }
    }
}
