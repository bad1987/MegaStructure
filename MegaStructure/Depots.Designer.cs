namespace MegaStructure
{
    partial class Depots
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listeDepotDatagrid = new System.Windows.Forms.DataGridView();
            this.IntiDepot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.villeDepot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ouvrirDepot = new System.Windows.Forms.Button();
            this.nouveauDepot = new System.Windows.Forms.Button();
            this.fermerDepot = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listeDepotDatagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // listeDepotDatagrid
            // 
            this.listeDepotDatagrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.listeDepotDatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listeDepotDatagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IntiDepot,
            this.villeDepot});
            this.listeDepotDatagrid.Location = new System.Drawing.Point(12, 122);
            this.listeDepotDatagrid.Name = "listeDepotDatagrid";
            this.listeDepotDatagrid.RowHeadersVisible = false;
            this.listeDepotDatagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listeDepotDatagrid.Size = new System.Drawing.Size(568, 275);
            this.listeDepotDatagrid.TabIndex = 0;
            // 
            // IntiDepot
            // 
            this.IntiDepot.HeaderText = "Intitule";
            this.IntiDepot.Name = "IntiDepot";
            // 
            // villeDepot
            // 
            this.villeDepot.HeaderText = "Ville";
            this.villeDepot.Name = "villeDepot";
            // 
            // ouvrirDepot
            // 
            this.ouvrirDepot.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ouvrirDepot.Location = new System.Drawing.Point(191, 422);
            this.ouvrirDepot.Name = "ouvrirDepot";
            this.ouvrirDepot.Size = new System.Drawing.Size(75, 23);
            this.ouvrirDepot.TabIndex = 1;
            this.ouvrirDepot.Text = "Ouvrir";
            this.ouvrirDepot.UseVisualStyleBackColor = true;
            // 
            // nouveauDepot
            // 
            this.nouveauDepot.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nouveauDepot.Location = new System.Drawing.Point(283, 422);
            this.nouveauDepot.Name = "nouveauDepot";
            this.nouveauDepot.Size = new System.Drawing.Size(75, 23);
            this.nouveauDepot.TabIndex = 1;
            this.nouveauDepot.Text = "Nouveau";
            this.nouveauDepot.UseVisualStyleBackColor = true;
            this.nouveauDepot.Click += new System.EventHandler(this.nouveauDepot_Click);
            // 
            // fermerDepot
            // 
            this.fermerDepot.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fermerDepot.Location = new System.Drawing.Point(374, 422);
            this.fermerDepot.Name = "fermerDepot";
            this.fermerDepot.Size = new System.Drawing.Size(75, 23);
            this.fermerDepot.TabIndex = 1;
            this.fermerDepot.Text = "Fermer";
            this.fermerDepot.UseVisualStyleBackColor = true;
            this.fermerDepot.Click += new System.EventHandler(this.fermerDepot_Click);
            // 
            // Depots
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 450);
            this.Controls.Add(this.fermerDepot);
            this.Controls.Add(this.nouveauDepot);
            this.Controls.Add(this.ouvrirDepot);
            this.Controls.Add(this.listeDepotDatagrid);
            this.Name = "Depots";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Depots";
            ((System.ComponentModel.ISupportInitialize)(this.listeDepotDatagrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView listeDepotDatagrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn IntiDepot;
        private System.Windows.Forms.DataGridViewTextBoxColumn villeDepot;
        private System.Windows.Forms.Button ouvrirDepot;
        private System.Windows.Forms.Button nouveauDepot;
        private System.Windows.Forms.Button fermerDepot;
    }
}