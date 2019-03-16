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
    public partial class DocumentsStocks : Form
    {
        private Filtre filtre;
        private ChoixTypeDoc typedocument;
        private CreerDocumentEntree docEntree;
        private DatabaseLite lite;
        private String dateDebutFiltre;
        private String dateFinFiltre;
        private int choixDocument;
        private int formLoaded;

        public DocumentsStocks()
        {
            InitializeComponent();
            lite = new DatabaseLite();
            lite.creatConnection();
            dateDebutFiltre = DateTime.Now.AddYears(-1).Date.ToString("yyyy-MM-dd");
            dateFinFiltre = DateTime.Now.AddYears(1).Date.ToString("yyyy-MM-dd");
            choixDocument = 0;
            formLoaded = 0;
            getAllDocuments();
        }

        private void filtreLigneStock_Click(object sender, EventArgs e)
        {
            filtre = new Filtre();
            //filtre.ShowDialog();
            if(filtre.ShowDialog() == DialogResult.Cancel)
            {
                MessageBox.Show("filter canceled");
            }
            else
            {
                MessageBox.Show("after the execution of the filter");
                dateDebutFiltre = filtre.getDateDebut();
                dateFinFiltre = filtre.getDateFin();
                cancel.Visible = true;
                getAllDocuments();
            }
            //MessageBox.Show("after the execution of the filter");
        }

        public void test(DateTime dd,DateTime df)
        {
            //d.Text = dd.ToString();
            //f.Text = df.ToString();
        }

        private void fermerDocStock_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void allDocs_MouseHover(object sender, EventArgs e)
        {
            //allDocs.BackColor = Color.SlateBlue;
        }

        private void changeBackForeColor(Button btn)
        {
            Color currentB = btn.BackColor;
            Color currentF = btn.ForeColor;

            Color newB = Color.Blue;
            Color newF = Color.White;

            List<Button> buttons = new List<Button>();
            buttons.Add(allDocs);
            buttons.Add(mvtEntree);
            buttons.Add(mvtSortie);
            buttons.Add(mvtRetour);

            foreach(Button bt in buttons)
            {
                if(bt == btn)
                {
                    bt.BackColor = newB;
                    bt.ForeColor = newF;
                }
                else
                {
                    bt.BackColor = currentB;
                    bt.ForeColor = currentF;
                }
            }
        }

        private void allDocs_Click(object sender, EventArgs e)
        {
            changeBackForeColor(allDocs);
            choixDocument = 0;
            getAllDocuments();
        }

        private void mvtEntree_Click(object sender, EventArgs e)
        {
            changeBackForeColor(mvtEntree);
            choixDocument = 1;
            getAllDocuments();
        }

        private void mvtSortie_Click(object sender, EventArgs e)
        {
            changeBackForeColor(mvtSortie);
            choixDocument = 2;
            getAllDocuments();
        }

        private void mvtRetour_Click(object sender, EventArgs e)
        {
            changeBackForeColor(mvtRetour);
            choixDocument = 3;
            getAllDocuments();
        }

        private void nouveauDoc_Click(object sender, EventArgs e)
        {
            typedocument = new ChoixTypeDoc();
            DialogResult result = typedocument.ShowDialog();

            if (result == DialogResult.Cancel || typedocument.getOkDialogResult() == DialogResult.Cancel)
                return;
            int typeDoc = typedocument.getUserChoice();
            //MessageBox.Show("type document: " + typeDoc, "radio button test", MessageBoxButtons.OK);
            docEntree = new CreerDocumentEntree(typeDoc);
            //docEntree.setTypePiece(typeDoc);
            DialogResult documentresult = docEntree.ShowDialog();
            if(documentresult == DialogResult.OK)
            {
                getAllDocuments();
            }
        }

        public String codeType(long type)
        {
            if (type == 1)
                return "ME";
            else if (type == 2)
                return "MS";
            else
                return "MR";
        }

        public void getAllDocuments()
        {
            ligneStock.Rows.Clear();

            String request = @"
                SELECT MO_TYPE,MO_PIECE,MO_MOTIF,MA_DESIGN,MO_DATE,MO_QTE
                FROM F_LIGNEMOUVEMENT,F_MATERIEL
                WHERE F_LIGNEMOUVEMENT.MA_NO = F_MATERIEL.MA_NO AND MO_DATE BETWEEN '{0}' AND '{1}'
            ";
            if(choixDocument > 0)
            {
                request += String.Format(" AND MO_TYPE = {0}",choixDocument);
            }
            request = string.Format(request,dateDebutFiltre,dateFinFiltre);
            String[] row;
            long type;
            using (SQLiteCommand cmd = new SQLiteCommand(request, lite.getConnector()))
            {
                using(SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        row = new string[6];
                        type = dr.GetInt64(0);
                        row[0] = codeType(type);
                        row[1] = dr.GetString(1);
                        row[2] = dr.GetString(3);
                        row[3] = dr.GetString(4);
                        row[4] = dr.GetDouble(5).ToString();
                        row[5] = dr.GetString(2);

                        ligneStock.Rows.Add(row);
                    }
                }
            }
            if(formLoaded == 1 && ligneStock.RowCount>0)
            {
                ligneStock.SelectedRows[0].Selected = false;
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            dateDebutFiltre = DateTime.Now.AddYears(-1).Date.ToString("yyyy-MM-dd");
            dateFinFiltre = DateTime.Now.AddYears(1).Date.ToString("yyyy-MM-dd");
            getAllDocuments();
            cancel.Visible = false;
        }

        private void DocumentsStocks_Load(object sender, EventArgs e)
        {
            if (ligneStock.SelectedRows.Count > 0)
            {
                ligneStock.SelectedRows[0].Selected = false;
                formLoaded = 1;
            }
        }
    }
}
