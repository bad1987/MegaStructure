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
    public partial class GestionRisques : Form
    {
        private DatabaseLite lite;
        private int choixRupture;

        public GestionRisques()
        {
            InitializeComponent();
            lite = new DatabaseLite();
            lite.creatConnection();
            choixRupture = 1;

            getMateriaux();
        }

        public void getMateriaux()
        {
            dataGridView1.Rows.Clear();
            String request = @"
                SELECT F_MATERIEL.MA_NO,MA_DESIGN,ST_QTESTOCK,ST_HORSERVICE
                FROM F_MATERIEL,F_MATSTOCK
                WHERE F_MATERIEL.MA_NO = F_MATSTOCK.MA_NO 
            ";
            if(choixRupture == 1)
            {
                request += " AND ST_QTESTOCK <= ST_QTEMIN";
            }
            else
            {
                request += " AND ST_QTESTOCK > ST_QTEMIN AND ST_QTESTOCK <= (ST_QTEMIN + (ST_QTEMIN * 1.5))";
            }
            String[] row;
            using(SQLiteCommand cmde = new SQLiteCommand(request, lite.getConnector()))
            {
                using(SQLiteDataReader dr = cmde.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        row = new string[4];
                        row[0] = dr.GetInt64(0).ToString();
                        row[1] = dr.GetString(1);
                        row[2] = dr.GetDouble(2).ToString();
                        row[3] = dr.GetDouble(3).ToString();

                        dataGridView1.Rows.Add(row);
                    }
                }
            }

            if(dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.ClearSelection();
            }
        }

        private void fermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GestionRisques_Load(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.ClearSelection();
            }
        }

        private void enrupture_Click(object sender, EventArgs e)
        {
            choixRupture = 1;
            getMateriaux();
        }

        private void proche_Click(object sender, EventArgs e)
        {
            choixRupture = 2;
            getMateriaux();
        }

        object misValue = System.Reflection.Missing.Value;

        private void exporter_Click(object sender, EventArgs e)
        {
           if(dataGridView1.RowCount > 0)
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
                if (choixRupture == 1)
                {
                    xlworksheet.Cells[1, 1] = "MATERIAUX EN RUPTURE";
                }
                else
                {
                    xlworksheet.Cells[1, 1] = "RUPTURE PROCHE";
                }

                xlworksheet.Range["A1", "C3"].Merge();
                xlworksheet.Range["A1", "C3"].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                xlworksheet.Range["A1", "C3"].Font.Bold = true;
                xlworksheet.Range["A1", "C3"].Font.Size = 16;
                xlworksheet.Range["A1", "C3"].EntireColumn.AutoFit();

                xlworksheet.Range["A4", "C4"].Merge();


                for (int i = 1; i < dataGridView1.ColumnCount; i++)
                {
                    xlworksheet.Cells[5, i] = dataGridView1.Columns[i].HeaderText;
                }

                xlworksheet.Range["A5", "C5"].Font.Bold = true;

                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    for (int j = 1; j < dataGridView1.ColumnCount; j++)
                    {
                        if (j > 1)
                        {
                            if (dataGridView1.Rows[i].Cells[j].Value != null)
                            {
                                xlworksheet.Cells[i + 6, j] = Double.Parse(dataGridView1.Rows[i].Cells[j].Value.ToString(), CultureInfo.InvariantCulture);
                            }

                        }
                        else
                        {
                            xlworksheet.Cells[i + 6, j] = dataGridView1.Rows[i].Cells[j].Value;
                        }

                    }
                }

                //string col = $"A{dataGridView1.RowCount - 2}";
                string col = $"A{dataGridView1.RowCount + 5}";
                xlworksheet.Range["A1", col].EntireColumn.AutoFit();
                xlworksheet.Range["A1", $"B{dataGridView1.RowCount + 5}"].EntireColumn.AutoFit();

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
