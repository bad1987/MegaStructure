namespace MegaStructure
{
    partial class Familles
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ouvrirFamille = new System.Windows.Forms.Button();
            this.nouveauFamille = new System.Windows.Forms.Button();
            this.fermerFamille = new System.Windows.Forms.Button();
            this.listefamilleDatagrid = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CODEFAM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.INTITUFAM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.listefamilleDatagrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ouvrirFamille
            // 
            this.ouvrirFamille.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ouvrirFamille.Location = new System.Drawing.Point(91, 432);
            this.ouvrirFamille.Name = "ouvrirFamille";
            this.ouvrirFamille.Size = new System.Drawing.Size(75, 26);
            this.ouvrirFamille.TabIndex = 1;
            this.ouvrirFamille.Text = "Ouvrir";
            this.ouvrirFamille.UseVisualStyleBackColor = true;
            // 
            // nouveauFamille
            // 
            this.nouveauFamille.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nouveauFamille.Location = new System.Drawing.Point(194, 432);
            this.nouveauFamille.Name = "nouveauFamille";
            this.nouveauFamille.Size = new System.Drawing.Size(75, 26);
            this.nouveauFamille.TabIndex = 1;
            this.nouveauFamille.Text = "Nouveau";
            this.nouveauFamille.UseVisualStyleBackColor = true;
            this.nouveauFamille.Click += new System.EventHandler(this.nouveauFamille_Click);
            // 
            // fermerFamille
            // 
            this.fermerFamille.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fermerFamille.Location = new System.Drawing.Point(292, 432);
            this.fermerFamille.Name = "fermerFamille";
            this.fermerFamille.Size = new System.Drawing.Size(75, 26);
            this.fermerFamille.TabIndex = 1;
            this.fermerFamille.Text = "Fermer";
            this.fermerFamille.UseVisualStyleBackColor = true;
            this.fermerFamille.Click += new System.EventHandler(this.fermerFamille_Click);
            // 
            // listefamilleDatagrid
            // 
            this.listefamilleDatagrid.AllowUserToAddRows = false;
            this.listefamilleDatagrid.AllowUserToDeleteRows = false;
            this.listefamilleDatagrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listefamilleDatagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.listefamilleDatagrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.listefamilleDatagrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.listefamilleDatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listefamilleDatagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODEFAM,
            this.INTITUFAM});
            this.listefamilleDatagrid.Location = new System.Drawing.Point(-1, 3);
            this.listefamilleDatagrid.Name = "listefamilleDatagrid";
            this.listefamilleDatagrid.RowHeadersVisible = false;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.listefamilleDatagrid.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.listefamilleDatagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listefamilleDatagrid.Size = new System.Drawing.Size(437, 335);
            this.listefamilleDatagrid.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.listefamilleDatagrid);
            this.panel1.Location = new System.Drawing.Point(1, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(441, 343);
            this.panel1.TabIndex = 0;
            // 
            // CODEFAM
            // 
            this.CODEFAM.HeaderText = "Code famille";
            this.CODEFAM.Name = "CODEFAM";
            this.CODEFAM.ReadOnly = true;
            this.CODEFAM.Width = 89;
            // 
            // INTITUFAM
            // 
            this.INTITUFAM.HeaderText = "Intitule de la famille";
            this.INTITUFAM.Name = "INTITUFAM";
            this.INTITUFAM.ReadOnly = true;
            this.INTITUFAM.Width = 85;
            // 
            // Familles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 468);
            this.Controls.Add(this.fermerFamille);
            this.Controls.Add(this.nouveauFamille);
            this.Controls.Add(this.ouvrirFamille);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Familles";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Familles";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Familles_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.listefamilleDatagrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button ouvrirFamille;
        private System.Windows.Forms.Button nouveauFamille;
        private System.Windows.Forms.Button fermerFamille;
        private System.Windows.Forms.DataGridView listefamilleDatagrid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODEFAM;
        private System.Windows.Forms.DataGridViewTextBoxColumn INTITUFAM;
    }
}