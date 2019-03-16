using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaStructure
{
    public partial class Form1 : Form
    {
        private Color fichierBack;
        private Color fichierFor;
        //private Boolean connected = false;

        //bjects
        private DatabaseLite lite;
        private ConnexionUtilisateur user;

        public Form1()
        {
            InitializeComponent();
            lite = new DatabaseLite();
            lite.initDatabase();
            //connection();
            connectedUser();
        }

        private void connection()
        {
            user = new ConnexionUtilisateur();
            DialogResult state = user.ShowDialog();
            /*while (state == DialogResult.Cancel)
            {
                state = user.ShowDialog();
            }*/

            if(state == DialogResult.OK)
            {
                String uname = user.getUserName(), pass = user.getPassword();
                while(!lite.userConnection(uname, pass))
                {
                    MessageBox.Show("vos identifiants sont incorrects", "erreur connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    user.initPassword();
                    user.setpasswordFocus();
                    state = user.ShowDialog();
                    if (state == DialogResult.Cancel)
                    {
                        break;
                    }
                    uname = user.getUserName();
                    pass = user.getPassword();
                }
                if (state == DialogResult.Cancel)
                {
                    guessAccess();
                }
                else
                {
                    //MessageBox.Show("connexion reussie", "succes connexion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    connectedUser();
                    //connected = true;
                }
            }
            else
            {
                guessAccess();
            }
            user.Dispose();
            menuStrip1.BackColor = Color.Black;
            menuStrip1.ForeColor = Color.White;
        }

        private void guessAccess()
        {
            structure.Enabled = false;
            traitement.Enabled = false;
            etat.Enabled = false;
            deconnexion.Enabled = false;
            connexion.Enabled = true;
        }

        private void connectedUser()
        {
            structure.Enabled = true;
            traitement.Enabled = true;
            etat.Enabled = true;
            deconnexion.Enabled = true;
            connexion.Enabled = false;
        }

        private void fichierToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            //sauvegarde des config
            fichierBack = fichier.BackColor;
            fichierFor = fichier.ForeColor;

            fichier.BackColor = Color.White;
            fichier.ForeColor = Color.Black;
            
        }

        private void fichier_MouseLeave(object sender, EventArgs e)
        {
            fichier.BackColor = fichierBack;
            fichier.ForeColor = fichierFor;
        }

        private void structureToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            //sauvegarde des config
            fichierBack = fichier.BackColor;
            fichierFor = fichier.ForeColor;

            structure.BackColor = Color.White;
            structure.ForeColor = Color.Black;
        }

        private void structure_MouseLeave(object sender, EventArgs e)
        {
            structure.BackColor = fichierBack;
            structure.ForeColor = fichierFor;
        }

        private void traitement_MouseHover(object sender, EventArgs e)
        {
            //sauvegarde des config
            fichierBack = fichier.BackColor;
            fichierFor = fichier.ForeColor;

            traitement.BackColor = Color.White;
            traitement.ForeColor = Color.Black;
        }

        private void traitement_MouseLeave(object sender, EventArgs e)
        {
            traitement.BackColor = fichierBack;
            traitement.ForeColor = fichierFor;
        }

        private void aide_MouseHover(object sender, EventArgs e)
        {
            //sauvegarde des config
            fichierBack = fichier.BackColor;
            fichierFor = fichier.ForeColor;

            aide.BackColor = Color.White;
            aide.ForeColor = Color.Black;
        }

        private void aide_MouseLeave(object sender, EventArgs e)
        {
            aide.BackColor = fichierBack;
            aide.ForeColor = fichierFor;
        }

        private void etatToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            //sauvegarde des config
            fichierBack = fichier.BackColor;
            fichierFor = fichier.ForeColor;

            etat.BackColor = Color.White;
            etat.ForeColor = Color.Black;
        }

        private void etatToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            etat.BackColor = fichierBack;
            etat.ForeColor = fichierFor;
        }

        private void connexionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ConnexionUtilisateur cnu = new ConnexionUtilisateur();
            //cnu.Show();
            connection();
        }

        private void documentsDeStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DocumentsStocks ds = new DocumentsStocks();
            ds.Show();
        }

        private void parMaterielToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StatsParMateriaux spm = new StatsParMateriaux();
            spm.Show();
        }

        private void familleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Familles fa = new Familles();
            fa.Show();
        }

        private void materielToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Materiaux ma = new Materiaux();
            ma.Show();
        }

        private void depotsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Depots de = new Depots();
            de.Show();
        }

        private void entreeHSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EntreeHS ehs = new EntreeHS();
            ehs.Show();
        }

        private void sortieHSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SortieHS shs = new SortieHS();
            shs.Show();
        }

        private void fermerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!lite.isCreated())
            {
                lite.initDatabase();
            }
        }

        private void deconnexion_Click(object sender, EventArgs e)
        {
            guessAccess();
            //connected = false;
        }

        private void sauvegarderLaBaseDeDonneesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vous allez proceder a la sauvegarde de la base de donnees. Cliquez sur OK pour commencer le traitement", "Sauvegarde de la bd", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            lite.sauvegarde();
        }

        private void restorerLaBaseDeDonneesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cliquez sur OK pour commencer la restauration de votre base de donnees", "restauration de la base de donnees de la bd", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            lite.restorer();
        }

        private void exporterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lite.exporter();
        }

        private void importerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lite.importer();
        }
    }
}
