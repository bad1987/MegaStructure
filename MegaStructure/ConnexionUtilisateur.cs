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
    public partial class ConnexionUtilisateur : Form
    {
        public ConnexionUtilisateur()
        {
            InitializeComponent();
            this.ActiveControl = username;
        }

        private void annulerConnexion_Click(object sender, EventArgs e)
        {
            
        }

        private void ConnexionUtilisateur_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void okConnexion_Click(object sender, EventArgs e)
        {
            if(username.Text == "" || password.Text == "")
            {
                MessageBox.Show("Tous les champs sont obligatoires", "Echec connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.DialogResult = DialogResult.OK;
                //this.Close();
            }
        }

        public String getUserName()
        {
            return this.username.Text;
        }

        public String getPassword()
        {
            return this.password.Text;
        }

        public void initPassword()
        {
            password.Text = "";
        }

        public void setpasswordFocus()
        {
            ActiveControl = password;
        }

        private void username_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Tab)
            {
                MessageBox.Show("tab pressed");
            }
        }

        private void username_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void password_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                ActiveControl = okConnexion;
                okConnexion_Click(sender, e);
            }
        }
    }
}
