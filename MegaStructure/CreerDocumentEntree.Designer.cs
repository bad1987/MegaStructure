namespace MegaStructure
{
    partial class CreerDocumentEntree
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.depotCombo = new System.Windows.Forms.ComboBox();
            this.motif = new System.Windows.Forms.TextBox();
            this.numDoc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.quantite = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.materiel = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.enregistrer = new System.Windows.Forms.Button();
            this.materiauxDatagrid = new System.Windows.Forms.DataGridView();
            this.ligneRef = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ligneDesign = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ligneQuant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ligneMo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.supprimer = new System.Windows.Forms.ToolStripMenuItem();
            this.ok = new System.Windows.Forms.Button();
            this.annuler = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.materiauxDatagrid)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.depotCombo);
            this.panel1.Controls.Add(this.motif);
            this.panel1.Controls.Add(this.numDoc);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.quantite);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.materiel);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.date);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(630, 198);
            this.panel1.TabIndex = 0;
            // 
            // depotCombo
            // 
            this.depotCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.depotCombo.FormattingEnabled = true;
            this.depotCombo.Location = new System.Drawing.Point(336, 19);
            this.depotCombo.Name = "depotCombo";
            this.depotCombo.Size = new System.Drawing.Size(202, 21);
            this.depotCombo.TabIndex = 6;
            // 
            // motif
            // 
            this.motif.Location = new System.Drawing.Point(336, 53);
            this.motif.MaxLength = 80;
            this.motif.Name = "motif";
            this.motif.Size = new System.Drawing.Size(202, 20);
            this.motif.TabIndex = 0;
            // 
            // numDoc
            // 
            this.numDoc.Enabled = false;
            this.numDoc.Location = new System.Drawing.Point(120, 53);
            this.numDoc.Name = "numDoc";
            this.numDoc.Size = new System.Drawing.Size(149, 20);
            this.numDoc.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(293, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Depot";
            // 
            // quantite
            // 
            this.quantite.Location = new System.Drawing.Point(484, 131);
            this.quantite.Name = "quantite";
            this.quantite.Size = new System.Drawing.Size(122, 20);
            this.quantite.TabIndex = 2;
            this.quantite.KeyDown += new System.Windows.Forms.KeyEventHandler(this.quantite_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(293, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Motif";
            // 
            // materiel
            // 
            this.materiel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.materiel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.materiel.FormattingEnabled = true;
            this.materiel.Location = new System.Drawing.Point(120, 127);
            this.materiel.Name = "materiel";
            this.materiel.Size = new System.Drawing.Size(270, 21);
            this.materiel.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "№ document";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(425, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Quantite";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Materiel";
            // 
            // date
            // 
            this.date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date.Location = new System.Drawing.Point(120, 18);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(149, 20);
            this.date.TabIndex = 7;
            // 
            // enregistrer
            // 
            this.enregistrer.BackColor = System.Drawing.SystemColors.HotTrack;
            this.enregistrer.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enregistrer.ForeColor = System.Drawing.SystemColors.Control;
            this.enregistrer.Location = new System.Drawing.Point(365, 227);
            this.enregistrer.Name = "enregistrer";
            this.enregistrer.Size = new System.Drawing.Size(84, 29);
            this.enregistrer.TabIndex = 3;
            this.enregistrer.Text = "Enregistrer";
            this.enregistrer.UseVisualStyleBackColor = false;
            this.enregistrer.Click += new System.EventHandler(this.enregistrer_Click);
            // 
            // materiauxDatagrid
            // 
            this.materiauxDatagrid.AllowUserToAddRows = false;
            this.materiauxDatagrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.materiauxDatagrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.materiauxDatagrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materiauxDatagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.materiauxDatagrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.materiauxDatagrid.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.materiauxDatagrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.materiauxDatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.materiauxDatagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ligneRef,
            this.ligneDesign,
            this.ligneQuant,
            this.ligneMo});
            this.materiauxDatagrid.ContextMenuStrip = this.contextMenuStrip1;
            this.materiauxDatagrid.EnableHeadersVisualStyles = false;
            this.materiauxDatagrid.Location = new System.Drawing.Point(12, 262);
            this.materiauxDatagrid.MultiSelect = false;
            this.materiauxDatagrid.Name = "materiauxDatagrid";
            this.materiauxDatagrid.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materiauxDatagrid.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.materiauxDatagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.materiauxDatagrid.Size = new System.Drawing.Size(625, 269);
            this.materiauxDatagrid.TabIndex = 8;
            // 
            // ligneRef
            // 
            this.ligneRef.HeaderText = "REFERENCE";
            this.ligneRef.Name = "ligneRef";
            this.ligneRef.ReadOnly = true;
            this.ligneRef.Width = 118;
            // 
            // ligneDesign
            // 
            this.ligneDesign.HeaderText = "DESIGNATION";
            this.ligneDesign.Name = "ligneDesign";
            this.ligneDesign.ReadOnly = true;
            this.ligneDesign.Width = 132;
            // 
            // ligneQuant
            // 
            this.ligneQuant.HeaderText = "QUANTITE";
            this.ligneQuant.Name = "ligneQuant";
            this.ligneQuant.ReadOnly = true;
            this.ligneQuant.Width = 109;
            // 
            // ligneMo
            // 
            this.ligneMo.HeaderText = "MOTIF";
            this.ligneMo.Name = "ligneMo";
            this.ligneMo.ReadOnly = true;
            this.ligneMo.Width = 79;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.supprimer});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(130, 26);
            // 
            // supprimer
            // 
            this.supprimer.Name = "supprimer";
            this.supprimer.Size = new System.Drawing.Size(129, 22);
            this.supprimer.Text = "Supprimer";
            this.supprimer.Click += new System.EventHandler(this.supprimer_Click);
            // 
            // ok
            // 
            this.ok.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ok.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ok.FlatAppearance.BorderSize = 2;
            this.ok.FlatAppearance.CheckedBackColor = System.Drawing.Color.Honeydew;
            this.ok.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumAquamarine;
            this.ok.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace;
            this.ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ok.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ok.Location = new System.Drawing.Point(441, 548);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(75, 29);
            this.ok.TabIndex = 3;
            this.ok.Text = "OK";
            this.ok.UseVisualStyleBackColor = false;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // annuler
            // 
            this.annuler.BackColor = System.Drawing.SystemColors.ControlDark;
            this.annuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.annuler.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.annuler.FlatAppearance.BorderSize = 2;
            this.annuler.FlatAppearance.CheckedBackColor = System.Drawing.Color.Honeydew;
            this.annuler.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumAquamarine;
            this.annuler.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace;
            this.annuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.annuler.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.annuler.Location = new System.Drawing.Point(537, 548);
            this.annuler.Name = "annuler";
            this.annuler.Size = new System.Drawing.Size(75, 29);
            this.annuler.TabIndex = 4;
            this.annuler.Text = "Annuler";
            this.annuler.UseVisualStyleBackColor = false;
            // 
            // CreerDocumentEntree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(649, 589);
            this.Controls.Add(this.annuler);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.materiauxDatagrid);
            this.Controls.Add(this.enregistrer);
            this.Controls.Add(this.panel1);
            this.Name = "CreerDocumentEntree";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Document d\'Entree";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.materiauxDatagrid)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox motif;
        private System.Windows.Forms.TextBox numDoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.ComboBox materiel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox quantite;
        private System.Windows.Forms.Button enregistrer;
        private System.Windows.Forms.DataGridView materiauxDatagrid;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.Button annuler;
        private System.Windows.Forms.ComboBox depotCombo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn ligneRef;
        private System.Windows.Forms.DataGridViewTextBoxColumn ligneDesign;
        private System.Windows.Forms.DataGridViewTextBoxColumn ligneQuant;
        private System.Windows.Forms.DataGridViewTextBoxColumn ligneMo;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem supprimer;
    }
}