namespace MegaStructure
{
    partial class Materiaux
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
            this.listeMateriauxDatagrid = new System.Windows.Forms.DataGridView();
            this.REFMAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Design = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QteMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QteReel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ouvrirMateriaux = new System.Windows.Forms.Button();
            this.nouveauMateriaux = new System.Windows.Forms.Button();
            this.fermerMateriaux = new System.Windows.Forms.Button();
            this.inputSearch = new System.Windows.Forms.TextBox();
            this.rechercheMateriaux = new System.Windows.Forms.Button();
            this.print = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listeMateriauxDatagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // listeMateriauxDatagrid
            // 
            this.listeMateriauxDatagrid.AllowUserToAddRows = false;
            this.listeMateriauxDatagrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.listeMateriauxDatagrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.listeMateriauxDatagrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listeMateriauxDatagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.listeMateriauxDatagrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.listeMateriauxDatagrid.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listeMateriauxDatagrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.listeMateriauxDatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listeMateriauxDatagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.REFMAT,
            this.Design,
            this.QteMin,
            this.QteReel,
            this.HS});
            this.listeMateriauxDatagrid.EnableHeadersVisualStyles = false;
            this.listeMateriauxDatagrid.Location = new System.Drawing.Point(12, 67);
            this.listeMateriauxDatagrid.Name = "listeMateriauxDatagrid";
            this.listeMateriauxDatagrid.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.listeMateriauxDatagrid.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.listeMateriauxDatagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listeMateriauxDatagrid.Size = new System.Drawing.Size(569, 408);
            this.listeMateriauxDatagrid.TabIndex = 0;
            // 
            // REFMAT
            // 
            this.REFMAT.HeaderText = "Reference";
            this.REFMAT.Name = "REFMAT";
            this.REFMAT.ReadOnly = true;
            this.REFMAT.Visible = false;
            this.REFMAT.Width = 63;
            // 
            // Design
            // 
            this.Design.HeaderText = "Designation";
            this.Design.Name = "Design";
            this.Design.ReadOnly = true;
            this.Design.Width = 88;
            // 
            // QteMin
            // 
            this.QteMin.HeaderText = "Quantite Minimum";
            this.QteMin.Name = "QteMin";
            this.QteMin.ReadOnly = true;
            this.QteMin.Width = 106;
            // 
            // QteReel
            // 
            this.QteReel.HeaderText = "Quantite Reelle";
            this.QteReel.Name = "QteReel";
            this.QteReel.ReadOnly = true;
            this.QteReel.Width = 96;
            // 
            // HS
            // 
            this.HS.HeaderText = "Hors Service";
            this.HS.Name = "HS";
            this.HS.ReadOnly = true;
            this.HS.Width = 86;
            // 
            // ouvrirMateriaux
            // 
            this.ouvrirMateriaux.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ouvrirMateriaux.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.ouvrirMateriaux.FlatAppearance.BorderSize = 2;
            this.ouvrirMateriaux.FlatAppearance.CheckedBackColor = System.Drawing.Color.Honeydew;
            this.ouvrirMateriaux.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumAquamarine;
            this.ouvrirMateriaux.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace;
            this.ouvrirMateriaux.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ouvrirMateriaux.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ouvrirMateriaux.Location = new System.Drawing.Point(206, 494);
            this.ouvrirMateriaux.Name = "ouvrirMateriaux";
            this.ouvrirMateriaux.Size = new System.Drawing.Size(75, 27);
            this.ouvrirMateriaux.TabIndex = 1;
            this.ouvrirMateriaux.Text = "Ouvrir";
            this.ouvrirMateriaux.UseVisualStyleBackColor = false;
            this.ouvrirMateriaux.Click += new System.EventHandler(this.ouvrirMateriaux_Click);
            // 
            // nouveauMateriaux
            // 
            this.nouveauMateriaux.BackColor = System.Drawing.SystemColors.ControlDark;
            this.nouveauMateriaux.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.nouveauMateriaux.FlatAppearance.BorderSize = 2;
            this.nouveauMateriaux.FlatAppearance.CheckedBackColor = System.Drawing.Color.Honeydew;
            this.nouveauMateriaux.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumAquamarine;
            this.nouveauMateriaux.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.nouveauMateriaux.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nouveauMateriaux.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nouveauMateriaux.Location = new System.Drawing.Point(296, 494);
            this.nouveauMateriaux.Name = "nouveauMateriaux";
            this.nouveauMateriaux.Size = new System.Drawing.Size(75, 27);
            this.nouveauMateriaux.TabIndex = 1;
            this.nouveauMateriaux.Text = "Nouveau";
            this.nouveauMateriaux.UseVisualStyleBackColor = false;
            this.nouveauMateriaux.Click += new System.EventHandler(this.nouveauMateriaux_Click);
            // 
            // fermerMateriaux
            // 
            this.fermerMateriaux.BackColor = System.Drawing.SystemColors.ControlDark;
            this.fermerMateriaux.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.fermerMateriaux.FlatAppearance.BorderSize = 2;
            this.fermerMateriaux.FlatAppearance.CheckedBackColor = System.Drawing.Color.Honeydew;
            this.fermerMateriaux.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumAquamarine;
            this.fermerMateriaux.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fermerMateriaux.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fermerMateriaux.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fermerMateriaux.Location = new System.Drawing.Point(386, 494);
            this.fermerMateriaux.Name = "fermerMateriaux";
            this.fermerMateriaux.Size = new System.Drawing.Size(75, 27);
            this.fermerMateriaux.TabIndex = 1;
            this.fermerMateriaux.Text = "Fermer";
            this.fermerMateriaux.UseVisualStyleBackColor = false;
            this.fermerMateriaux.Click += new System.EventHandler(this.fermerMateriaux_Click);
            // 
            // inputSearch
            // 
            this.inputSearch.Location = new System.Drawing.Point(12, 19);
            this.inputSearch.Name = "inputSearch";
            this.inputSearch.Size = new System.Drawing.Size(366, 20);
            this.inputSearch.TabIndex = 2;
            this.inputSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputSearch_KeyDown);
            // 
            // rechercheMateriaux
            // 
            this.rechercheMateriaux.BackColor = System.Drawing.SystemColors.ControlDark;
            this.rechercheMateriaux.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rechercheMateriaux.FlatAppearance.BorderSize = 2;
            this.rechercheMateriaux.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumAquamarine;
            this.rechercheMateriaux.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace;
            this.rechercheMateriaux.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rechercheMateriaux.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rechercheMateriaux.Location = new System.Drawing.Point(384, 14);
            this.rechercheMateriaux.Name = "rechercheMateriaux";
            this.rechercheMateriaux.Size = new System.Drawing.Size(89, 29);
            this.rechercheMateriaux.TabIndex = 3;
            this.rechercheMateriaux.Text = "Rechercher";
            this.rechercheMateriaux.UseVisualStyleBackColor = false;
            this.rechercheMateriaux.Click += new System.EventHandler(this.rechercheMateriaux_Click);
            // 
            // print
            // 
            this.print.BackColor = System.Drawing.SystemColors.ControlDark;
            this.print.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.print.FlatAppearance.BorderSize = 2;
            this.print.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumAquamarine;
            this.print.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace;
            this.print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.print.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.print.Location = new System.Drawing.Point(492, 12);
            this.print.Name = "print";
            this.print.Size = new System.Drawing.Size(89, 29);
            this.print.TabIndex = 3;
            this.print.Text = "Exporter";
            this.print.UseVisualStyleBackColor = false;
            this.print.Click += new System.EventHandler(this.print_Click);
            // 
            // Materiaux
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(593, 538);
            this.Controls.Add(this.print);
            this.Controls.Add(this.rechercheMateriaux);
            this.Controls.Add(this.inputSearch);
            this.Controls.Add(this.fermerMateriaux);
            this.Controls.Add(this.nouveauMateriaux);
            this.Controls.Add(this.ouvrirMateriaux);
            this.Controls.Add(this.listeMateriauxDatagrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Materiaux";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Materiaux";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Materiaux_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.listeMateriauxDatagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView listeMateriauxDatagrid;
        private System.Windows.Forms.Button ouvrirMateriaux;
        private System.Windows.Forms.Button nouveauMateriaux;
        private System.Windows.Forms.Button fermerMateriaux;
        private System.Windows.Forms.TextBox inputSearch;
        private System.Windows.Forms.Button rechercheMateriaux;
        private System.Windows.Forms.Button print;
        private System.Windows.Forms.DataGridViewTextBoxColumn REFMAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Design;
        private System.Windows.Forms.DataGridViewTextBoxColumn QteMin;
        private System.Windows.Forms.DataGridViewTextBoxColumn QteReel;
        private System.Windows.Forms.DataGridViewTextBoxColumn HS;
    }
}