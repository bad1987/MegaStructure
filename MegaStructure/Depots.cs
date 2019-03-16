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
    public partial class Depots : Form
    {
        public Depots()
        {
            InitializeComponent();
        }

        private void fermerDepot_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nouveauDepot_Click(object sender, EventArgs e)
        {
            CreerDepot dp = new CreerDepot();
            dp.Show();
        }
    }
}
