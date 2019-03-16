namespace MegaStructure
{
    partial class DocumentsStocks
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ligneStock = new System.Windows.Forms.DataGridView();
            this.typeDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numPiece = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.designMat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateMouv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qteTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motif = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filtreLigneStock = new System.Windows.Forms.Label();
            this.nouveauDoc = new System.Windows.Forms.Button();
            this.fermerDocStock = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mvtRetour = new System.Windows.Forms.Button();
            this.mvtSortie = new System.Windows.Forms.Button();
            this.mvtEntree = new System.Windows.Forms.Button();
            this.allDocs = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ligneStock)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cancel)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ligneStock
            // 
            this.ligneStock.AllowUserToAddRows = false;
            this.ligneStock.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ligneStock.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ligneStock.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ligneStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.ligneStock.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ligneStock.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ligneStock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ligneStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ligneStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.typeDoc,
            this.numPiece,
            this.designMat,
            this.dateMouv,
            this.qteTotal,
            this.motif});
            this.ligneStock.EnableHeadersVisualStyles = false;
            this.ligneStock.Location = new System.Drawing.Point(202, 47);
            this.ligneStock.MultiSelect = false;
            this.ligneStock.Name = "ligneStock";
            this.ligneStock.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ligneStock.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.ligneStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ligneStock.Size = new System.Drawing.Size(577, 405);
            this.ligneStock.TabIndex = 1;
            // 
            // typeDoc
            // 
            this.typeDoc.HeaderText = "Type";
            this.typeDoc.Name = "typeDoc";
            this.typeDoc.Width = 56;
            // 
            // numPiece
            // 
            this.numPiece.HeaderText = "Num Piece";
            this.numPiece.Name = "numPiece";
            this.numPiece.Width = 78;
            // 
            // designMat
            // 
            this.designMat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.designMat.HeaderText = "Designation";
            this.designMat.Name = "designMat";
            this.designMat.Width = 88;
            // 
            // dateMouv
            // 
            this.dateMouv.HeaderText = "Date";
            this.dateMouv.Name = "dateMouv";
            this.dateMouv.Width = 55;
            // 
            // qteTotal
            // 
            this.qteTotal.HeaderText = "Quantite";
            this.qteTotal.Name = "qteTotal";
            this.qteTotal.Width = 72;
            // 
            // motif
            // 
            this.motif.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.motif.HeaderText = "Motif du mouvement";
            this.motif.Name = "motif";
            this.motif.Width = 117;
            // 
            // filtreLigneStock
            // 
            this.filtreLigneStock.AutoSize = true;
            this.filtreLigneStock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.filtreLigneStock.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filtreLigneStock.ForeColor = System.Drawing.Color.Blue;
            this.filtreLigneStock.Location = new System.Drawing.Point(46, 11);
            this.filtreLigneStock.Name = "filtreLigneStock";
            this.filtreLigneStock.Size = new System.Drawing.Size(49, 18);
            this.filtreLigneStock.TabIndex = 2;
            this.filtreLigneStock.Text = "Filtrer";
            this.filtreLigneStock.Click += new System.EventHandler(this.filtreLigneStock_Click);
            // 
            // nouveauDoc
            // 
            this.nouveauDoc.BackColor = System.Drawing.SystemColors.ControlDark;
            this.nouveauDoc.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nouveauDoc.FlatAppearance.BorderSize = 2;
            this.nouveauDoc.FlatAppearance.CheckedBackColor = System.Drawing.Color.Honeydew;
            this.nouveauDoc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumAquamarine;
            this.nouveauDoc.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace;
            this.nouveauDoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nouveauDoc.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nouveauDoc.Location = new System.Drawing.Point(583, 476);
            this.nouveauDoc.Name = "nouveauDoc";
            this.nouveauDoc.Size = new System.Drawing.Size(75, 27);
            this.nouveauDoc.TabIndex = 3;
            this.nouveauDoc.Text = "Nouveau";
            this.nouveauDoc.UseVisualStyleBackColor = false;
            this.nouveauDoc.Click += new System.EventHandler(this.nouveauDoc_Click);
            // 
            // fermerDocStock
            // 
            this.fermerDocStock.BackColor = System.Drawing.SystemColors.ControlDark;
            this.fermerDocStock.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fermerDocStock.FlatAppearance.BorderSize = 2;
            this.fermerDocStock.FlatAppearance.CheckedBackColor = System.Drawing.Color.Honeydew;
            this.fermerDocStock.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumAquamarine;
            this.fermerDocStock.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace;
            this.fermerDocStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fermerDocStock.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fermerDocStock.Location = new System.Drawing.Point(674, 476);
            this.fermerDocStock.Name = "fermerDocStock";
            this.fermerDocStock.Size = new System.Drawing.Size(75, 27);
            this.fermerDocStock.TabIndex = 3;
            this.fermerDocStock.Text = "Fermer";
            this.fermerDocStock.UseVisualStyleBackColor = false;
            this.fermerDocStock.Click += new System.EventHandler(this.fermerDocStock_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.mvtRetour);
            this.panel1.Controls.Add(this.mvtSortie);
            this.panel1.Controls.Add(this.mvtEntree);
            this.panel1.Controls.Add(this.allDocs);
            this.panel1.Location = new System.Drawing.Point(12, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(184, 133);
            this.panel1.TabIndex = 4;
            // 
            // mvtRetour
            // 
            this.mvtRetour.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mvtRetour.FlatAppearance.BorderSize = 0;
            this.mvtRetour.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.mvtRetour.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.mvtRetour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mvtRetour.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mvtRetour.Location = new System.Drawing.Point(-1, 65);
            this.mvtRetour.Name = "mvtRetour";
            this.mvtRetour.Size = new System.Drawing.Size(182, 23);
            this.mvtRetour.TabIndex = 0;
            this.mvtRetour.Text = "Mouvements de retour";
            this.mvtRetour.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mvtRetour.UseVisualStyleBackColor = true;
            this.mvtRetour.Click += new System.EventHandler(this.mvtRetour_Click);
            this.mvtRetour.MouseHover += new System.EventHandler(this.allDocs_MouseHover);
            // 
            // mvtSortie
            // 
            this.mvtSortie.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mvtSortie.FlatAppearance.BorderSize = 0;
            this.mvtSortie.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.mvtSortie.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.mvtSortie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mvtSortie.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mvtSortie.Location = new System.Drawing.Point(-1, 43);
            this.mvtSortie.Name = "mvtSortie";
            this.mvtSortie.Size = new System.Drawing.Size(182, 23);
            this.mvtSortie.TabIndex = 0;
            this.mvtSortie.Text = "Mouvements de sortie";
            this.mvtSortie.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mvtSortie.UseVisualStyleBackColor = true;
            this.mvtSortie.Click += new System.EventHandler(this.mvtSortie_Click);
            this.mvtSortie.MouseHover += new System.EventHandler(this.allDocs_MouseHover);
            // 
            // mvtEntree
            // 
            this.mvtEntree.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mvtEntree.FlatAppearance.BorderSize = 0;
            this.mvtEntree.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.mvtEntree.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.mvtEntree.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mvtEntree.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mvtEntree.Location = new System.Drawing.Point(-1, 21);
            this.mvtEntree.Name = "mvtEntree";
            this.mvtEntree.Size = new System.Drawing.Size(182, 23);
            this.mvtEntree.TabIndex = 0;
            this.mvtEntree.Text = "Mouvements d\'entree";
            this.mvtEntree.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mvtEntree.UseVisualStyleBackColor = true;
            this.mvtEntree.Click += new System.EventHandler(this.mvtEntree_Click);
            this.mvtEntree.MouseHover += new System.EventHandler(this.allDocs_MouseHover);
            // 
            // allDocs
            // 
            this.allDocs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.allDocs.FlatAppearance.BorderSize = 0;
            this.allDocs.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.allDocs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.allDocs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.allDocs.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allDocs.Location = new System.Drawing.Point(-1, -1);
            this.allDocs.Name = "allDocs";
            this.allDocs.Size = new System.Drawing.Size(182, 23);
            this.allDocs.TabIndex = 0;
            this.allDocs.Text = "Tous les Documents";
            this.allDocs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.allDocs.UseVisualStyleBackColor = true;
            this.allDocs.Click += new System.EventHandler(this.allDocs_Click);
            this.allDocs.MouseHover += new System.EventHandler(this.allDocs_MouseHover);
            // 
            // cancel
            // 
            this.cancel.Image = global::MegaStructure.Properties.Resources.cancel;
            this.cancel.Location = new System.Drawing.Point(99, 12);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(19, 18);
            this.cancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cancel.TabIndex = 5;
            this.cancel.TabStop = false;
            this.toolTip1.SetToolTip(this.cancel, "Reinitialiser");
            this.cancel.Visible = false;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 100;
            this.toolTip1.ReshowDelay = 100;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.filtreLigneStock);
            this.panel2.Controls.Add(this.cancel);
            this.panel2.Location = new System.Drawing.Point(12, 181);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(183, 42);
            this.panel2.TabIndex = 6;
            // 
            // DocumentsStocks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(791, 515);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.fermerDocStock);
            this.Controls.Add(this.nouveauDoc);
            this.Controls.Add(this.ligneStock);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "DocumentsStocks";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DocumentsStocks";
            this.Load += new System.EventHandler(this.DocumentsStocks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ligneStock)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cancel)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView ligneStock;
        private System.Windows.Forms.Label filtreLigneStock;
        private System.Windows.Forms.Button nouveauDoc;
        private System.Windows.Forms.Button fermerDocStock;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button allDocs;
        private System.Windows.Forms.Button mvtRetour;
        private System.Windows.Forms.Button mvtSortie;
        private System.Windows.Forms.Button mvtEntree;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn numPiece;
        private System.Windows.Forms.DataGridViewTextBoxColumn designMat;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateMouv;
        private System.Windows.Forms.DataGridViewTextBoxColumn qteTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn motif;
        private System.Windows.Forms.PictureBox cancel;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel2;
    }
}