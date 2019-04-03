using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaStructure
{
    
    public partial class CreerDocumentEntree : Form
    {
        private DatabaseLite lite;
        private DataTable listeMateriaux,listeDepots;
        private int typePiece;
        private CultureInfo decimalSeprerator;
        private int artSuivi;

        public CreerDocumentEntree(int piece = 0)
        {
            InitializeComponent();

            decimalSeprerator = new CultureInfo("us-US");
            Thread.CurrentThread.CurrentCulture = decimalSeprerator;

            lite = new DatabaseLite();
            lite.creatConnection();

            listeMateriaux = new DataTable();
            listeDepots = new DataTable();

            listeMateriaux.Columns.Add("reference",typeof(Int64));
            listeMateriaux.Columns.Add("designation", typeof(String));

            listeDepots.Columns.Add("reference", typeof(Int64));
            listeDepots.Columns.Add("designation", typeof(String));

            materiel.DataSource = listeMateriaux;
            materiel.DisplayMember = "designation";
            materiel.ValueMember = "reference";

            depotCombo.DataSource = listeDepots;
            depotCombo.DisplayMember = "designation";
            depotCombo.ValueMember = "reference";

            this.typePiece = piece;
            initField();
            //materiel.SelectedIndex = -1;

            changeTitle();
        }

        private void changeTitle()
        {
            if(typePiece == 1)
            {
                Text = "Document d'Entree";
            }
            else if(typePiece == 2)
            {
                Text = "Document de Sortie";
            }
            else
            {
                Text = "Document de Retour";
            }
        }

        public void initField()
        {
            loadDataTable();
            initDepot();

            String lastPieceNum = lite.getLastLigneMvtPiece(typePiece);
            numDoc.Text = buildPiece(lastPieceNum);
        }

        public void setTypePiece(int piece)
        {
            this.typePiece = piece;
        }

        private String returnPrefixPiece()
        {
            //MessageBox.Show(typePiece.ToString());
            DateTime date = DateTime.Now;
            String year = date.Date.ToString("yy"),pref="";
            if (typePiece == 1)
                pref = year + "ME";
            else if (typePiece == 2)
                pref = year + "MS";
            else
                pref = year + "MR";

            return pref;
        }

        public String buildPiece(String current)
        {
            String newpiece = "", pieceDate="", curdate="";
            if (current.Length > 0)
                pieceDate = current[0] +""+ current[1];
            curdate = DateTime.Now.Date.ToString("yy");
            if (current.Length == 0 || pieceDate.CompareTo(curdate) != 0)
            {
                newpiece = returnPrefixPiece() + "0000001";
            }
            else
            {
                String prefix = "", suffix = "";
                int i = 0;
                foreach(char car in current)
                {
                    if (i <= 3)
                    {
                        prefix += car;
                    }
                    else
                    {
                        suffix += car;
                    }
                    i += 1;
                }
                String temp = (int.Parse(suffix) + 1).ToString();

                if(temp.Length < suffix.Length)
                {
                    int len = (suffix.Length - temp.Length) - 1;
                    while(len >= 0)
                    {
                        temp = suffix[len] + temp;
                        len--;
                    }
                }
                newpiece = prefix + temp;
            }

            return newpiece;
        }

        public void loadDataTable()
        {
            listeMateriaux.Rows.Clear();
            SQLiteConnection conn = lite.getConnector();
            String request = @"SELECT * FROM F_MATERIEL";
            using (SQLiteCommand cmd = new SQLiteCommand(request, conn))
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

        private void ok_Click(object sender, EventArgs e)
        {
            
            if(materiauxDatagrid.Rows.Count > 0)
            {
                String dateligne = date.Value.Date.ToString("yyyy-MM-dd"), num, docmotif;
                int depot = int.Parse(listeDepots.Rows[depotCombo.SelectedIndex][0].ToString()), docmate;
                Double docquant, minqte = 0, qteactuelle, qte;
                for(int i=0;i<materiauxDatagrid.Rows.Count;i++)
                {
                    num = numDoc.Text;
                    docmotif = materiauxDatagrid.Rows[i].Cells[3].Value.ToString().ToUpper();
                    docmate = int.Parse(materiauxDatagrid.Rows[i].Cells[0].Value.ToString());
                    docquant = Double.Parse(materiauxDatagrid.Rows[i].Cells[2].Value.ToString());
                    qteactuelle = getQuantiteReelle(docmate);

                    //mouvement d'entree ou de retour = addition; mouvement de sortie = soustraction
                    if (typePiece == 2)
                    {
                        if(artSuivi == 1)// mode de suivi en stock = entree/sortie
                        {
                            qte = qteactuelle - docquant;
                        }
                        else
                        {
                            qte = qteactuelle + docquant;
                        }
                    }
                    else
                    {
                        qte = docquant + qteactuelle;
                    }

                    minqte = Math.Round(qte / 3);

                    // insertion dans la table depot
                    Boolean exists = existsInMatStock(docmate);
                    if (exists)
                    {
                        if (typePiece == 1)
                        {
                            matStockUpdate(docmate, qte, minqte);
                        }
                        else
                        {
                            matStockUpdateSR(docmate, qte);
                        }

                    }
                    else
                    {
                        if(artSuivi == 1)
                        {
                            matStockInsertion(docmate, depot, minqte, qte);
                        }
                        else
                        {
                            matStockInsertion(docmate, depot, 0, qte);
                        }
                    }

                    //insertion dans ligneMouvement
                    ligneMouvInsertion(docquant, typePiece, dateligne, num, docmotif, docmate, depot);
                }
                
            }
        }

        private void enregistrer_Click(object sender, EventArgs e)
        {
            if (motif.Text == "" || materiel.Text == "" || quantite.Text == "")
            {
                MessageBox.Show("Tous les champs sont obligatoires", "Champs invalides", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Double qtereelle = getQuantiteReelle(int.Parse(listeMateriaux.Rows[materiel.SelectedIndex][0].ToString())),qte;
            int artIndex = int.Parse(listeMateriaux.Rows[materiel.SelectedIndex][0].ToString());
            artSuivi = lite.getMaterielTypeSuivi(artIndex);
            if (artSuivi == 2 && (typePiece == 1 || typePiece == 3))
            {
                MessageBox.Show("Le type de mouvement choisi n'est pas autorise pour ce materiel", "Mouvement non autorise", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            qte = Double.Parse(quantite.Text.Replace(",", "."));

            if(typePiece == 2 && qtereelle < qte && artSuivi == 1)
            {
                MessageBox.Show("l'etat du stock n'autorise pas la quantite saisie", "erreur sur la quantite saisie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            String[] rows = new string[4];
            String item = listeMateriaux.Rows[materiel.SelectedIndex][1].ToString();
            rows[0] = listeMateriaux.Rows[materiel.SelectedIndex][0].ToString();
            rows[1] = listeMateriaux.Rows[materiel.SelectedIndex][1].ToString();
            rows[2] = quantite.Text.Replace(",", ".");
            rows[3] = motif.Text;

            materiauxDatagrid.Rows.Add(rows);
            motif.Text = "";
            quantite.Text = "";
            //materiel.SelectedIndex = -1;

            try
            {
                materiauxDatagrid.SelectedRows[0].Selected = false;
            }
            catch { }

            //MessageBox.Show(item, "Champs invalides", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public Double getQuantiteReelle(int ma_ref)
        {
            String request = @"
                SELECT ST_QTESTOCK
                FROM F_MATERIEL, F_MATSTOCK
                WHERE F_MATERIEL.MA_NO = F_MATSTOCK.MA_NO
                    AND F_MATERIEL.MA_NO = {0}
            ";
            request = string.Format(request, ma_ref);
            Double qte = 0;
            using(SQLiteCommand cmd = new SQLiteCommand(request, lite.getConnector()))
            {
                using(SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        qte = dr.GetDouble(0);
                    }
                }
            }
            return qte;
        }

        public Boolean existsInMatStock(int ma_ref)
        {
            String request = @"
                SELECT *
                FROM F_MATSTOCK
                WHERE F_MATSTOCK.MA_NO = {0}
            ";
            request = string.Format(request, ma_ref);
            Boolean exists = false;
            using (SQLiteCommand cmd = new SQLiteCommand(request, lite.getConnector()))
            {
                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        exists = true;
                    }
                }
            }

            return exists;
        }

        public void matStockInsertion(int ma_no,int de_no,Double st_qtemin,Double st_qtestock)
        {
            String request = @"
                INSERT INTO F_MATSTOCK (ST_QTEMIN,ST_QTESTOCK,ST_HORSERVICE,MA_NO,DE_NO)
                VALUES({0},{1},{2},{3},{4})
            ";
            request = String.Format(request, st_qtemin, st_qtestock, 0, ma_no, de_no);
            using (SQLiteCommand cmd = new SQLiteCommand(request, lite.getConnector()))
            {
                cmd.ExecuteNonQuery();
            }
        }

        public void matStockUpdate(int ma_no,Double qtestock,Double qtemin)
        {
            String request = @"
                UPDATE  F_MATSTOCK SET ST_QTEMIN = {0},ST_QTESTOCK = {1}
                WHERE MA_NO = {2}
            ";
            request = String.Format(request, qtemin, qtestock, ma_no);
            using (SQLiteCommand cmd = new SQLiteCommand(request, lite.getConnector()))
            {
                cmd.ExecuteNonQuery();
            }
        }

        public void matStockUpdateSR(int ma_no, Double qtestock)
        {
            String request = @"
                UPDATE  F_MATSTOCK SET ST_QTESTOCK = {0}
                WHERE MA_NO = {1}
            ";
            request = String.Format(request, qtestock, ma_no);
            using (SQLiteCommand cmd = new SQLiteCommand(request, lite.getConnector()))
            {
                cmd.ExecuteNonQuery();
            }
        }

        public void ligneMouvInsertion(Double mo_qte,int mo_type,String mo_date,String mo_piece,String mo_motif,int ma_no,int de_no)
        {
            mo_motif = lite.stripString(mo_motif);
            String request = @"
                INSERT INTO F_LIGNEMOUVEMENT (MO_QTE,MO_DATE,MO_TYPE,MO_PIECE,MO_MOTIF,MA_NO,DE_NO)
                VALUES({0},'{1}',{2},'{3}','{4}',{5},{6})
            ";
            request = String.Format(request, mo_qte, mo_date, mo_type, mo_piece, mo_motif,ma_no,de_no);
            using (SQLiteCommand cmd = new SQLiteCommand(request, lite.getConnector()))
            {
                cmd.ExecuteNonQuery();
            }
        }

        private void quantite_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                enregistrer_Click(sender, e);
            }
        }

        private void supprimer_Click(object sender, EventArgs e)
        {
            if(materiauxDatagrid.SelectedRows.Count == 0)
            {
                MessageBox.Show("Echec de suppression! Aucun element selectionne", "Erreur de suppression", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            materiauxDatagrid.Rows.Remove(materiauxDatagrid.SelectedRows[0]);
        }

        public void initDepot()
        {
            listeDepots.Rows.Clear();
            SQLiteConnection conn = lite.getConnector();
            String request = @"SELECT * FROM F_DEPOT";
            using (SQLiteCommand cmd = new SQLiteCommand(request, conn))
            {
                using (SQLiteDataReader sd = cmd.ExecuteReader())
                {
                    while (sd.Read())
                    {
                        listeDepots.Rows.Add(sd.GetInt64(0), sd.GetString(1));
                    }
                }
            }
        }
    }
}
