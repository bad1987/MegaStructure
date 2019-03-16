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
    public partial class CreerFamilles : Form
    {
        private DatabaseLite lite;
        public CreerFamilles()
        {
            InitializeComponent();
            lite = new DatabaseLite();
            lite.creatConnection();
        }

        private void fermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void validerFamille_Click(object sender, EventArgs e)
        {
            if(familleRef.Text == "" || familleDesign.Text == "")
            {
                MessageBox.Show("Tous les champs sont obligatoires", "champ invalide", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (lite.familleExists(familleRef.Text.ToUpper()))
            {
                MessageBox.Show("Cette reference existe deja", "reference invalide", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            lite.createFamille(familleRef.Text.ToUpper(), familleDesign.Text.ToUpper());
            familleRef.Text = "";
            familleDesign.Text = "";
            ActiveControl = familleRef;
        }

        private void familleRef_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                validerFamille_Click(sender, e);
            }
        }

        private void familleDesign_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                validerFamille_Click(sender, e);
            }
        }

        private void CreerFamilles_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
