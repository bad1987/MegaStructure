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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ouvrirFamille = new System.Windows.Forms.Button();
            this.nouveauFamille = new System.Windows.Forms.Button();
            this.fermerFamille = new System.Windows.Forms.Button();
            this.listefamilleDatagrid = new System.Windows.Forms.DataGridView();
            this.CODEFAM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.INTITUFAM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supprimer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listefamilleDatagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ouvrirFamille
            // 
            this.ouvrirFamille.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ouvrirFamille.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ouvrirFamille.FlatAppearance.BorderSize = 2;
            this.ouvrirFamille.FlatAppearance.CheckedBackColor = System.Drawing.Color.Honeydew;
            this.ouvrirFamille.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumAquamarine;
            this.ouvrirFamille.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace;
            this.ouvrirFamille.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ouvrirFamille.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ouvrirFamille.Location = new System.Drawing.Point(109, 232);
            this.ouvrirFamille.Name = "ouvrirFamille";
            this.ouvrirFamille.Size = new System.Drawing.Size(75, 28);
            this.ouvrirFamille.TabIndex = 1;
            this.ouvrirFamille.Text = "Ouvrir";
            this.ouvrirFamille.UseVisualStyleBackColor = false;
            this.ouvrirFamille.Click += new System.EventHandler(this.ouvrirFamille_Click);
            // 
            // nouveauFamille
            // 
            this.nouveauFamille.BackColor = System.Drawing.SystemColors.ControlDark;
            this.nouveauFamille.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nouveauFamille.FlatAppearance.BorderSize = 2;
            this.nouveauFamille.FlatAppearance.CheckedBackColor = System.Drawing.Color.Honeydew;
            this.nouveauFamille.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumAquamarine;
            this.nouveauFamille.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.nouveauFamille.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nouveauFamille.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nouveauFamille.Location = new System.Drawing.Point(201, 232);
            this.nouveauFamille.Name = "nouveauFamille";
            this.nouveauFamille.Size = new System.Drawing.Size(75, 28);
            this.nouveauFamille.TabIndex = 1;
            this.nouveauFamille.Text = "Nouveau";
            this.nouveauFamille.UseVisualStyleBackColor = false;
            this.nouveauFamille.Click += new System.EventHandler(this.nouveauFamille_Click);
            // 
            // fermerFamille
            // 
            this.fermerFamille.BackColor = System.Drawing.SystemColors.ControlDark;
            this.fermerFamille.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fermerFamille.FlatAppearance.BorderSize = 2;
            this.fermerFamille.FlatAppearance.CheckedBackColor = System.Drawing.Color.Honeydew;
            this.fermerFamille.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumAquamarine;
            this.fermerFamille.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.fermerFamille.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fermerFamille.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fermerFamille.Location = new System.Drawing.Point(292, 232);
            this.fermerFamille.Name = "fermerFamille";
            this.fermerFamille.Size = new System.Drawing.Size(75, 28);
            this.fermerFamille.TabIndex = 1;
            this.fermerFamille.Text = "Fermer";
            this.fermerFamille.UseVisualStyleBackColor = false;
            this.fermerFamille.Click += new System.EventHandler(this.fermerFamille_Click);
            // 
            // listefamilleDatagrid
            // 
            this.listefamilleDatagrid.AllowUserToAddRows = false;
            this.listefamilleDatagrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.listefamilleDatagrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.listefamilleDatagrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listefamilleDatagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.listefamilleDatagrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.listefamilleDatagrid.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listefamilleDatagrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.listefamilleDatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listefamilleDatagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODEFAM,
            this.INTITUFAM});
            this.listefamilleDatagrid.EnableHeadersVisualStyles = false;
            this.listefamilleDatagrid.Location = new System.Drawing.Point(12, 12);
            this.listefamilleDatagrid.Name = "listefamilleDatagrid";
            this.listefamilleDatagrid.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.listefamilleDatagrid.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.listefamilleDatagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listefamilleDatagrid.Size = new System.Drawing.Size(362, 203);
            this.listefamilleDatagrid.TabIndex = 1;
            // 
            // CODEFAM
            // 
            this.CODEFAM.HeaderText = "Code famille";
            this.CODEFAM.Name = "CODEFAM";
            this.CODEFAM.ReadOnly = true;
            this.CODEFAM.Width = 98;
            // 
            // INTITUFAM
            // 
            this.INTITUFAM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.INTITUFAM.HeaderText = "Intitule de la famille";
            this.INTITUFAM.Name = "INTITUFAM";
            this.INTITUFAM.ReadOnly = true;
            this.INTITUFAM.Width = 250;
            // 
            // supprimer
            // 
            this.supprimer.BackColor = System.Drawing.SystemColors.ControlDark;
            this.supprimer.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.supprimer.FlatAppearance.BorderSize = 2;
            this.supprimer.FlatAppearance.CheckedBackColor = System.Drawing.Color.Honeydew;
            this.supprimer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumAquamarine;
            this.supprimer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.supprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.supprimer.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supprimer.Location = new System.Drawing.Point(13, 232);
            this.supprimer.Name = "supprimer";
            this.supprimer.Size = new System.Drawing.Size(87, 28);
            this.supprimer.TabIndex = 1;
            this.supprimer.Text = "Supprimer";
            this.supprimer.UseVisualStyleBackColor = false;
            this.supprimer.Click += new System.EventHandler(this.supprimer_Click);
            // 
            // Familles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(386, 284);
            this.Controls.Add(this.listefamilleDatagrid);
            this.Controls.Add(this.fermerFamille);
            this.Controls.Add(this.nouveauFamille);
            this.Controls.Add(this.supprimer);
            this.Controls.Add(this.ouvrirFamille);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Familles";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Familles";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Familles_FormClosing);
            this.Load += new System.EventHandler(this.Familles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listefamilleDatagrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button ouvrirFamille;
        private System.Windows.Forms.Button nouveauFamille;
        private System.Windows.Forms.Button fermerFamille;
        private System.Windows.Forms.DataGridView listefamilleDatagrid;
        private System.Windows.Forms.Button supprimer;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODEFAM;
        private System.Windows.Forms.DataGridViewTextBoxColumn INTITUFAM;
    }
}