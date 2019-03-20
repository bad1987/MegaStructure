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
    public partial class ModifierFamille : Form
    {
        private String fa_code,fa_design;
        private DatabaseLite lite;
        public ModifierFamille(String code,String design)
        {
            fa_code = code;
            fa_design = design;
           
            InitializeComponent();
            codefam.Text = code;
            designfam.Text = design;

            lite = new DatabaseLite();
            lite.creatConnection();

            Text = "FAMILLE:  " + fa_design;
        }

        private void designfam_Leave(object sender, EventArgs e)
        {
            if (designfam.Text == "")
            {
                MessageBox.Show("Une valeur vide n'est pas autorisee", "designation incorrecte", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ActiveControl = designfam;
                return;
            }
        }

        public void updatefamille()
        {
            String design = designfam.Text.ToUpper();
            String request = @"UPDATE F_FAMILLE SET FA_INTITULE = '{0}', FA_CODE='{1}' WHERE FA_CODE = '{2}'";
            request = string.Format(request, design, fa_code,fa_code);

            using (SQLiteCommand cmd = new SQLiteCommand(request, lite.getConnector()))
            {
                cmd.ExecuteNonQuery();
            }
        }

        private void enregistrer_Click(object sender, EventArgs e)
        {
            updatefamille();
        }

        private void ModifierFamille_Load(object sender, EventArgs e)
        {
            ActiveControl = codefam;
        }
    }
}
