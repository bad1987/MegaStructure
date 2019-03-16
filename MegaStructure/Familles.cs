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
    public partial class Familles : Form
    {
        private DatabaseLite lite;
        public Familles()
        {
            InitializeComponent();
            lite = new DatabaseLite();
            lite.creatConnection();
            loadFamille();
        }

        private void fermerFamille_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nouveauFamille_Click(object sender, EventArgs e)
        {
            CreerFamilles cf = new CreerFamilles();
            cf.Show();
        }

        public void loadFamille()
        {
            Dictionary<String, String> listfamille = lite.getAllFamilles();
            listefamilleDatagrid.Rows.Clear();
            String[] row;
            foreach (KeyValuePair<String,String> famille in listfamille)
            {
                row = new string[2];
                row[0] = famille.Key;
                row[1] = famille.Value;
                listefamilleDatagrid.Rows.Add(row);
            }
        }

        private void Familles_FormClosing(object sender, FormClosingEventArgs e)
        {
            lite.closeConnection();
        }
    }
}
