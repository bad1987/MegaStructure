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
    public partial class ChoixTypeDoc : Form
    {
        private int userChoice;
        public ChoixTypeDoc()
        {
            InitializeComponent();
            userChoice = 0;
        }

        public int getUserChoice()
        {
            return userChoice;
        }

        private void ok_Click(object sender, EventArgs e)
        {
            var btn = from RadioButton rb in groupBox1.Controls where rb.Checked == true select rb.Name;
            
            try
            {
                String choix = btn.First();
                //MessageBox.Show(choix,"radio button test",MessageBoxButtons.OK);
                if (choix == "mvtEntree")
                {
                    userChoice = 1;
                }
                else if (choix == "mvtSortie")
                {
                    userChoice = 2;
                }
                else
                {
                    userChoice = 3;
                }
            }
            catch
            {
                ok.DialogResult = DialogResult.Cancel;
            }
        }

        public DialogResult getOkDialogResult()
        {
            return ok.DialogResult;
    }
    }
}
