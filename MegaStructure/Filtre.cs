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
    public partial class Filtre : Form
    {
        private string datedebut;
        private string datefin;
        public Filtre()
        {
            InitializeComponent();
            
        }

        public string getDateDebut()
        {
            return this.datedebut;
        }

        public string getDateFin()
        {
            return this.datefin;
        }

        private void okFiltre_Click(object sender, EventArgs e)
        {
            this.datedebut = dateDebut.Value.Date.ToString("yyyy-MM-dd");
            this.datefin = dateF.Value.Date.ToString("yyyy-MM-dd");
            //this.Hide();
        }

        private void annulerFiltre_Click_1(object sender, EventArgs e)
        {
            //this.Hide();
        }
    }
}
