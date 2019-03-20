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
    public partial class Depots : Form
    {
        private DatabaseLite lite;
        public Depots()
        {
            InitializeComponent();
            lite = new DatabaseLite();
            lite.creatConnection();
            fetchAllDepots();
        }

        private void fermerDepot_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void fetchAllDepots()
        {
            listeDepotDatagrid.Rows.Clear();
            String request = @"
                SELECT * FROM F_DEPOT
            ";
            String[] row;
            using (SQLiteCommand cmd = new SQLiteCommand(request, lite.getConnector()))
            {
                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        row = new string[3];
                        row[0] = dr.GetInt64(0).ToString();
                        row[1] = dr.GetString(1);
                        row[2] = dr.GetString(2);
                        listeDepotDatagrid.Rows.Add(row);
                    }
                }
            }
        }

        private void nouveauDepot_Click(object sender, EventArgs e)
        {
            CreerDepot dp = new CreerDepot();
            dp.Show();
        }

        private void Depots_Load(object sender, EventArgs e)
        {
            if(listeDepotDatagrid.SelectedRows.Count > 0)
            {
                listeDepotDatagrid.SelectedRows[0].Selected = false;
            }
        }

        private void ouvrirDepot_Click(object sender, EventArgs e)
        {
            if (listeDepotDatagrid.SelectedRows.Count > 0)
            {
                int refdepot = int.Parse(listeDepotDatagrid.SelectedRows[0].Cells[0].Value.ToString());
                String intitule = listeDepotDatagrid.SelectedRows[0].Cells[1].Value.ToString();
                String adr = listeDepotDatagrid.SelectedRows[0].Cells[2].Value.ToString();

                ModifierDepot modd = new ModifierDepot(refdepot,intitule,adr);

                if(modd.ShowDialog() == DialogResult.OK)
                {
                    fetchAllDepots();
                    if (listeDepotDatagrid.SelectedRows.Count > 0)
                    {
                        listeDepotDatagrid.ClearSelection();
                    }
                }
                else
                {

                }
            }
        }
    }
}
