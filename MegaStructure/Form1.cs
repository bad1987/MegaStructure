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

        //form objects
        Materiaux ma;
        Familles fa;
        Depots de;
        EntreeHS ehs;
        SortieHS shs;
        GestionRisques risque;
        StatsParMateriaux spm;
        DocumentsStocks ds;

        //position
        private int X, Y;

        public Form1()
        {
            InitializeComponent();
            lite = new DatabaseLite();
            lite.initDatabase();
            connection();
            //connectedUser();

            //init objects
            fa = null;
            ma = null;
            de = null;
            ehs = null;
            shs = null;
            risque = null;
            spm = null;
            ds = null;

            //position
            X = this.Top;
            Y = this.Left;

            menuStrip1.BackColor = Color.Black;
            menuStrip1.ForeColor = Color.White;
        }

        public void closeAllForms()
        {
            for(int i = Application.OpenForms.Count - 1; i>=0; i--)
            {
                if(Application.OpenForms[i].Name != "Form1")
                {
                    Application.OpenForms[i].Close();
                }
            }
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
            outils.Enabled = false;
        }

        private void connectedUser()
        {
            structure.Enabled = true;
            traitement.Enabled = true;
            etat.Enabled = true;
            deconnexion.Enabled = true;
            connexion.Enabled = false;
            outils.Enabled = true;
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
            if (ds == null)
            {
                DocumentsStocks ds = new DocumentsStocks();
                ds.SetDesktopLocation(this.Top + 25, this.Left + 40);
                ds.Show();
            }
            else
            {
                ds.Activate();
            }
        }

        private void parMaterielToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (spm == null)
            {
                StatsParMateriaux spm = new StatsParMateriaux();
                spm.Show();
            }
            else
            {
                spm.Activate();
            }
        }

        private void familleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fa = new Familles();
            //fa.SetDesktopLocation(this.Top + 25, this.Left + 40);
            fa.Show();
            /*
            if (fa == null)
            {
                fa = new Familles();
                fa.Show();
            }
            else
            {
                fa.Activate();
            }*/
        }

        private void materielToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ma == null)
            {
                Materiaux ma = new Materiaux();
                ma.SetDesktopLocation(this.Top + 25, this.Left + 40);
                ma.Show();
            }
            else
            {
                ma.Activate();
            }
        }

        private void depotsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (de == null)
            {
                Depots de = new Depots();
                de.Show();
            }
            else
            {
                de.Activate();
            }
        }

        private void entreeHSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ehs == null)
            {
                EntreeHS ehs = new EntreeHS();
                ehs.Show();
            }
            else
            {
                ehs.Activate();
            }
        }

        private void sortieHSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (shs == null)
            {
                shs = new SortieHS();
                shs.Show();
            }
            else
            {
                shs.Activate();
            }
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
            closeAllForms();
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

        private void rupturesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (risque == null)
            {
                GestionRisques risque = new GestionRisques();
                risque.SetDesktopLocation(this.Top + 25, this.Left + 40);
                risque.Show();
            }
            else
            {
                risque.Activate();
            }
        }
    }
}
