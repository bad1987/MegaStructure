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
    public partial class ModifierDepot : Form
    {
        private int refDepot;
        private String intitu, adrdepot;
        private DatabaseLite lite;
              
        public ModifierDepot(int refdepot, String intitudepot,String adrd)
        {
            InitializeComponent();

            lite = new DatabaseLite();
            lite.creatConnection();
            
            refDepot = refdepot;
            intitu = intitudepot;
            adrdepot = adrd;
            intitule.Text = intitu;
            adr.Text = adrd;

            Text = "DEPOT:  " + intitu;
        }

        private void intitule_Leave(object sender, EventArgs e)
        {
            if (intitule.Text == "")
            {
                MessageBox.Show("Une valeur vide n'est pas autorisee", "designation incorrecte", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ActiveControl = intitule;
                return;
            }
        }

        private void enregistrer_Click(object sender, EventArgs e)
        {
            updatedepot();
        }

        public void updatedepot()
        {
            String design = intitule.Text.ToUpper(), adress = adr.Text.ToUpper();
            String request = @"UPDATE F_DEPOT SET DE_DESIGN = '{0}', DE_ADR='{1}' WHERE DE_NO = {2}";
            request = string.Format(request, design, adress, refDepot);

            using (SQLiteCommand cmd = new SQLiteCommand(request, lite.getConnector()))
            {
                cmd.ExecuteNonQuery();
            }
        }

        private void adr_Leave(object sender, EventArgs e)
        {
            if (adr.Text == "")
            {
                MessageBox.Show("Une valeur vide n'est pas autorisee", "designation incorrecte", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ActiveControl = adr;
                return;
            }
        }
    }
}
