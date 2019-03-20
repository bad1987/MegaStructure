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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.listeDepotDatagrid = new System.Windows.Forms.DataGridView();
            this.ouvrirDepot = new System.Windows.Forms.Button();
            this.nouveauDepot = new System.Windows.Forms.Button();
            this.fermerDepot = new System.Windows.Forms.Button();
            this.ref_depot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IntiDepot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.villeDepot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.listeDepotDatagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // listeDepotDatagrid
            // 
            this.listeDepotDatagrid.AllowUserToAddRows = false;
            this.listeDepotDatagrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.listeDepotDatagrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.listeDepotDatagrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listeDepotDatagrid.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listeDepotDatagrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.listeDepotDatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listeDepotDatagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ref_depot,
            this.IntiDepot,
            this.villeDepot});
            this.listeDepotDatagrid.EnableHeadersVisualStyles = false;
            this.listeDepotDatagrid.Location = new System.Drawing.Point(12, 12);
            this.listeDepotDatagrid.Name = "listeDepotDatagrid";
            this.listeDepotDatagrid.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listeDepotDatagrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.listeDepotDatagrid.RowHeadersVisible = false;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.listeDepotDatagrid.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.listeDepotDatagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listeDepotDatagrid.Size = new System.Drawing.Size(324, 275);
            this.listeDepotDatagrid.TabIndex = 0;
            // 
            // ouvrirDepot
            // 
            this.ouvrirDepot.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ouvrirDepot.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ouvrirDepot.FlatAppearance.BorderSize = 2;
            this.ouvrirDepot.FlatAppearance.CheckedBackColor = System.Drawing.Color.Honeydew;
            this.ouvrirDepot.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumAquamarine;
            this.ouvrirDepot.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace;
            this.ouvrirDepot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ouvrirDepot.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ouvrirDepot.Location = new System.Drawing.Point(61, 293);
            this.ouvrirDepot.Name = "ouvrirDepot";
            this.ouvrirDepot.Size = new System.Drawing.Size(75, 27);
            this.ouvrirDepot.TabIndex = 1;
            this.ouvrirDepot.Text = "Ouvrir";
            this.ouvrirDepot.UseVisualStyleBackColor = false;
            this.ouvrirDepot.Click += new System.EventHandler(this.ouvrirDepot_Click);
            // 
            // nouveauDepot
            // 
            this.nouveauDepot.BackColor = System.Drawing.SystemColors.ControlDark;
            this.nouveauDepot.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nouveauDepot.FlatAppearance.BorderSize = 2;
            this.nouveauDepot.FlatAppearance.CheckedBackColor = System.Drawing.Color.Honeydew;
            this.nouveauDepot.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumAquamarine;
            this.nouveauDepot.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.nouveauDepot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nouveauDepot.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nouveauDepot.Location = new System.Drawing.Point(153, 293);
            this.nouveauDepot.Name = "nouveauDepot";
            this.nouveauDepot.Size = new System.Drawing.Size(75, 27);
            this.nouveauDepot.TabIndex = 1;
            this.nouveauDepot.Text = "Nouveau";
            this.nouveauDepot.UseVisualStyleBackColor = false;
            this.nouveauDepot.Click += new System.EventHandler(this.nouveauDepot_Click);
            // 
            // fermerDepot
            // 
            this.fermerDepot.BackColor = System.Drawing.SystemColors.ControlDark;
            this.fermerDepot.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fermerDepot.FlatAppearance.BorderSize = 2;
            this.fermerDepot.FlatAppearance.CheckedBackColor = System.Drawing.Color.Honeydew;
            this.fermerDepot.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumAquamarine;
            this.fermerDepot.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.fermerDepot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fermerDepot.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fermerDepot.Location = new System.Drawing.Point(244, 293);
            this.fermerDepot.Name = "fermerDepot";
            this.fermerDepot.Size = new System.Drawing.Size(75, 27);
            this.fermerDepot.TabIndex = 1;
            this.fermerDepot.Text = "Fermer";
            this.fermerDepot.UseVisualStyleBackColor = false;
            this.fermerDepot.Click += new System.EventHandler(this.fermerDepot_Click);
            // 
            // ref_depot
            // 
            this.ref_depot.HeaderText = "Reference";
            this.ref_depot.Name = "ref_depot";
            this.ref_depot.ReadOnly = true;
            this.ref_depot.Visible = false;
            // 
            // IntiDepot
            // 
            this.IntiDepot.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.IntiDepot.HeaderText = "Intitule";
            this.IntiDepot.Name = "IntiDepot";
            this.IntiDepot.ReadOnly = true;
            this.IntiDepot.Width = 150;
            // 
            // villeDepot
            // 
            this.villeDepot.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.villeDepot.HeaderText = "Adresse";
            this.villeDepot.Name = "villeDepot";
            this.villeDepot.ReadOnly = true;
            this.villeDepot.Width = 170;
            // 
            // Depots
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(348, 334);
            this.Controls.Add(this.fermerDepot);
            this.Controls.Add(this.nouveauDepot);
            this.Controls.Add(this.ouvrirDepot);
            this.Controls.Add(this.listeDepotDatagrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Depots";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Depots";
            this.Load += new System.EventHandler(this.Depots_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listeDepotDatagrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView listeDepotDatagrid;
        private System.Windows.Forms.Button ouvrirDepot;
        private System.Windows.Forms.Button nouveauDepot;
        private System.Windows.Forms.Button fermerDepot;
        private System.Windows.Forms.DataGridViewTextBoxColumn ref_depot;
        private System.Windows.Forms.DataGridViewTextBoxColumn IntiDepot;
        private System.Windows.Forms.DataGridViewTextBoxColumn villeDepot;
    }
}