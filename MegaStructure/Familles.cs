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
        private int loaded;
        public Familles()
        {
            InitializeComponent();
            loaded = 0;
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
            DialogResult result = cf.ShowDialog();

            if(result == DialogResult.OK)
            {
                loadFamille();
            }
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

            if(loaded == 1 && listefamilleDatagrid.Rows.Count > 0)
            {
                listefamilleDatagrid.ClearSelection();
            }
        }

        private void Familles_FormClosing(object sender, FormClosingEventArgs e)
        {
            lite.closeConnection();
        }

        private void Familles_Load(object sender, EventArgs e)
        {
            if(listefamilleDatagrid.Rows.Count > 0)
            {
                listefamilleDatagrid.ClearSelection();
                loaded = 1;
            }
        }

        private void supprimer_Click(object sender, EventArgs e)
        {
            if(listefamilleDatagrid.SelectedRows.Count > 0)
            {
                string code = listefamilleDatagrid.SelectedRows[0].Cells[0].Value.ToString();
                if (lite.isUsed(code))
                {
                    String msg = @"Vous etes sur le point de supprimer une famille utilisee par certains materiaux.
                            Pour confirmer la suppression, cliquez sur [OK]";
                    if (MessageBox.Show(msg, "Erreur de suppression", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        lite.deleteFromFamille(code);
                        loadFamille();
                    }
                }
                else
                {
                    lite.deleteFromFamille(code);
                    loadFamille();
                }
                
                
            }
            else
            {
                MessageBox.Show("Suppression impossible! aucun element selectionne", "Erreur de suppression", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ouvrirFamille_Click(object sender, EventArgs e)
        {
            if(listefamilleDatagrid.SelectedRows.Count > 0)
            {
                String code, design;
                code = listefamilleDatagrid.SelectedRows[0].Cells[0].Value.ToString();
                design = listefamilleDatagrid.SelectedRows[0].Cells[1].Value.ToString();
                //MessageBox.Show(code + ' ' + design);

                ModifierFamille modfam = new ModifierFamille(code, design);
                if(modfam.ShowDialog() == DialogResult.OK)
                {
                    loadFamille();
                    if(listefamilleDatagrid.SelectedRows.Count > 0)
                    {
                        listefamilleDatagrid.ClearSelection();
                    }
                }
                else
                {

                }
            }
        }
    }
}
