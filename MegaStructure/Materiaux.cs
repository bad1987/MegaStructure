using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Globalization;
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
            request = String.Format(request, lite.stripString(motif));
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

        object misValue = System.Reflection.Missing.Value;

        private void print_Click(object sender, EventArgs e)
        {
            if (listeMateriauxDatagrid.RowCount > 0)
            {
                Microsoft.Office.Interop.Excel.Application xlapp = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel._Workbook xlworkbook;
                Microsoft.Office.Interop.Excel._Worksheet xlworksheet;

                //check if excel is install
                if (xlapp == null)
                {
                    MessageBox.Show("Excel n'est pas correctement installe sur votre ordinateur");
                    return;
                }

                //new book
                xlworkbook = (Microsoft.Office.Interop.Excel._Workbook)(xlapp.Workbooks.Add(misValue));
                xlworksheet = (Microsoft.Office.Interop.Excel._Worksheet)xlworkbook.ActiveSheet;

                //adding table header
                xlworksheet.Cells[1, 1] = "LISTING DES MATERIAUX";

                xlworksheet.Range["A1", "D3"].Merge();
                xlworksheet.Range["A1", "D3"].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                xlworksheet.Range["A1", "D3"].Font.Bold = true;
                xlworksheet.Range["A1", "D3"].Font.Size = 16;
                xlworksheet.Range["A1", "D3"].EntireColumn.AutoFit();

                xlworksheet.Range["A4", "D4"].Merge();


                for (int i = 1; i < listeMateriauxDatagrid.ColumnCount; i++)
                {
                    xlworksheet.Cells[5, i] = listeMateriauxDatagrid.Columns[i].HeaderText;
                }

                xlworksheet.Range["A5", "D5"].Font.Bold = true;

                for (int i = 0; i < listeMateriauxDatagrid.RowCount; i++)
                {
                    for (int j = 1; j < listeMateriauxDatagrid.ColumnCount; j++)
                    {
                        if (j > 1)
                        {
                            if (listeMateriauxDatagrid.Rows[i].Cells[j].Value != null)
                            {
                                xlworksheet.Cells[i + 6, j] = Double.Parse(listeMateriauxDatagrid.Rows[i].Cells[j].Value.ToString(), CultureInfo.InvariantCulture);
                            }

                        }
                        else
                        {
                            xlworksheet.Cells[i + 6, j] = listeMateriauxDatagrid.Rows[i].Cells[j].Value;
                        }

                    }
                }

                //string col = $"A{dataGridView1.RowCount - 2}";
                string col = $"A{listeMateriauxDatagrid.RowCount + 5}";
                xlworksheet.Range["A1", col].EntireColumn.AutoFit();
                xlworksheet.Range["A1", $"B{listeMateriauxDatagrid.RowCount + 5}"].EntireColumn.AutoFit();

                xlworksheet.Columns[1].ColumnWidth = 40;
                xlworksheet.Columns[2].ColumnWidth = 20;
                xlworksheet.Columns[3].ColumnWidth = 20;

                xlworksheet.Range["A:A"].Style.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

                xlapp.Visible = true;
            }
            else
            {
                MessageBox.Show("Error!! aucune donnee pour l'importation", "Erreur d'importation", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
