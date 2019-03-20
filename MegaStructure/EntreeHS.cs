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
    public partial class EntreeHS : Form
    {
        private DatabaseLite lite;
        private DataTable listMateriaux,provenancehs;
        private String mo_piece;
        private int de_no,mo_type;
        private traitementHS traitement;

        public EntreeHS()
        {
            InitializeComponent();
            lite = new DatabaseLite();
            lite.creatConnection();

            traitement = new traitementHS();

            listMateriaux = new DataTable();
            listMateriaux.Columns.Add("reference", typeof(Int64));
            listMateriaux.Columns.Add("designation", typeof(String));
            listMateriaux.Rows.Add(-1, "");

            provenancehs = new DataTable();
            provenancehs.Columns.Add("reference", typeof(int));
            provenancehs.Columns.Add("designation", typeof(String));
            initProvenance();

            loadMateriaux();
            materiel.DataSource = listMateriaux;
            materiel.DisplayMember = "designation";
            materiel.ValueMember = "reference";
        }

        public void loadMateriaux()
        {
            String request = @"
                SELECT * FROM F_MATERIEL ORDER BY MA_DESIGN ASC
            ";
            String[] row;
            using (SQLiteCommand cmd = new SQLiteCommand(request, lite.getConnector()))
            {
                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        listMateriaux.Rows.Add(dr.GetInt64(0), dr.GetString(1));
                    }
                }
            }
        }

        private void fermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void valider_Click(object sender, EventArgs e)
        {
            Double quantite;
            if (materiel.Text =="" || qteHs.Text == "")
            {
                MessageBox.Show("Tous les champs sont obligatoire", "Champs incorrects", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                quantite = double.Parse(qteHs.Text,CultureInfo.InvariantCulture);
                if(quantite <= 0)
                {
                    MessageBox.Show("Quantite saisie non valide,une quantite positive est attendue", "Quantite incorrect", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                    
            }
            catch(Exception ex)
            {
                MessageBox.Show("Quantite saisie non valide", "Quantite incorrect", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int source = int.Parse(provenancehs.Rows[provenance.SelectedIndex][0].ToString());
            int refmat = int.Parse(listMateriaux.Rows[materiel.SelectedIndex][0].ToString());
            String[] info = getQuantiteMateriel(refmat);
            Double stockreel, stockhs,nouveaustockreel;
            String msg, piecehs,piece,date,motif;

            if (info == null)
            {
                msg = @"
                    Cet Materiau n'a jamais fait l'ojet d'un mouvement d'entree en stock.
                    Il est fortement conseille de commencer par un mouvement d'entree pour ce materiau.
                ";
                MessageBox.Show(msg, "Gestion de stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                traitement.setType(1);//mouvement d'entree

                stockreel = Double.Parse(info[0]);
                stockhs = double.Parse(info[1]);
                piecehs = lite.getLastLigneMvtPieceHS(1);
                piecehs = traitement.buildPieceHS(piecehs);

                traitement.setType(2);//mouvement de sortie
                piece = lite.getLastLigneMvtPiece(2);
                piece = traitement.buildPiece(piece);
                date = DateTime.Now.Date.ToString("yyyy-MM-dd");

                if (source == 1) // stock encours
                {
                    if(quantite > stockreel)
                    {
                        msg = @"
                            L'etat du stock ne permet pas cette action.
                            la quantite entree est superieure au stock du materiau
                        ";
                        MessageBox.Show(msg, "Quantite incorrecte", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    { // determiner la nouvelle valeur du stock et generer deux documents: entree et sortie
                        nouveaustockreel = stockreel - quantite;
                        double min = Math.Round(nouveaustockreel / 3); //stock minimum

                        //mise a jour du stock
                        traitement.updateStock(refmat, nouveaustockreel, quantite + stockhs, min);

                        //sortie en stock
                        motif = string.Format("inv.au {0} entree HS provenant du stock reel",date);
                        traitement.ligneMouvInsertion(quantite, 2, date, piece, motif.ToUpper(), refmat, de_no);

                        //entree en stock HS
                        motif = string.Format("inv.au {0} quantite HS sortie du stock", date);
                        traitement.ligneMouvInsertion(quantite, 1, date, piecehs, motif.ToUpper(), refmat, de_no);
                    }
                }
                else
                { // une seule ligne de document generee


                    traitement.updateStockHS(refmat, quantite);

                  //entree en stock HS
                    motif = string.Format("inv.au {0} stock physique inventorie", date);
                    traitement.ligneMouvInsertion(quantite, 1, date, piecehs, motif.ToUpper(), refmat, de_no);
                }

                //reinitialisation de l'interface
                materiel.SelectedIndex = 0;
                qteHs.Text = "";
                provenance.SelectedIndex = 0;
            }
            //MessageBox.Show(refmat.ToString());
        }


        public String[] getQuantiteMateriel(int refmat)
        {
            String request = @"
                SELECT ST_QTESTOCK,ST_HORSERVICE,DE_NO FROM F_MATSTOCK WHERE MA_NO = {0}
            ";
            request = string.Format(request, refmat);

            String[] row = null;
            using (SQLiteCommand cmd = new SQLiteCommand(request, lite.getConnector()))
            {
                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        row = new string[2];
                        row[0] = dr.GetDouble(0).ToString();
                        row[1] = dr.GetDouble(1).ToString();
                        de_no = dr.GetInt32(2);
                    }
                }
            }
            return row;
        }

        public void initProvenance()
        {
            provenancehs.Rows.Add(1, "Stock reel encours");
            provenancehs.Rows.Add(2, "Inventaire initial");
            provenance.DataSource = provenancehs;
            provenance.DisplayMember = "designation";
            provenance.ValueMember = "reference";
        }
    }
}
