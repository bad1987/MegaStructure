namespace MegaStructure
{
    partial class StatsParMateriaux
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.fermerStat = new System.Windows.Forms.Button();
            this.okStat = new System.Windows.Forms.Button();
            this.materiauxListCombo = new System.Windows.Forms.ComboBox();
            this.typeDocCombo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateFin = new System.Windows.Forms.DateTimePicker();
            this.dateDebut = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TypeDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DesignMat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qteDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qteHs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imprimer = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Criteres ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.fermerStat);
            this.panel1.Controls.Add(this.okStat);
            this.panel1.Controls.Add(this.materiauxListCombo);
            this.panel1.Controls.Add(this.typeDocCombo);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dateFin);
            this.panel1.Controls.Add(this.dateDebut);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(291, 224);
            this.panel1.TabIndex = 1;
            // 
            // fermerStat
            // 
            this.fermerStat.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fermerStat.Location = new System.Drawing.Point(145, 183);
            this.fermerStat.Name = "fermerStat";
            this.fermerStat.Size = new System.Drawing.Size(75, 29);
            this.fermerStat.TabIndex = 4;
            this.fermerStat.Text = "Fermer";
            this.fermerStat.UseVisualStyleBackColor = true;
            this.fermerStat.Click += new System.EventHandler(this.fermerStat_Click);
            // 
            // okStat
            // 
            this.okStat.BackColor = System.Drawing.SystemColors.Highlight;
            this.okStat.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okStat.Location = new System.Drawing.Point(47, 183);
            this.okStat.Name = "okStat";
            this.okStat.Size = new System.Drawing.Size(75, 29);
            this.okStat.TabIndex = 4;
            this.okStat.Text = "OK";
            this.okStat.UseVisualStyleBackColor = false;
            // 
            // materiauxListCombo
            // 
            this.materiauxListCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.materiauxListCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.materiauxListCombo.FormattingEnabled = true;
            this.materiauxListCombo.Location = new System.Drawing.Point(73, 90);
            this.materiauxListCombo.Name = "materiauxListCombo";
            this.materiauxListCombo.Size = new System.Drawing.Size(210, 21);
            this.materiauxListCombo.TabIndex = 3;
            // 
            // typeDocCombo
            // 
            this.typeDocCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeDocCombo.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeDocCombo.FormattingEnabled = true;
            this.typeDocCombo.Items.AddRange(new object[] {
            "Tous les documents",
            "Documents d\'entree",
            "Documents de sortie"});
            this.typeDocCombo.Location = new System.Drawing.Point(112, 50);
            this.typeDocCombo.Name = "typeDocCombo";
            this.typeDocCombo.Size = new System.Drawing.Size(171, 23);
            this.typeDocCombo.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Materiel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Type document";
            // 
            // dateFin
            // 
            this.dateFin.CustomFormat = "";
            this.dateFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateFin.Location = new System.Drawing.Point(181, 11);
            this.dateFin.Name = "dateFin";
            this.dateFin.Size = new System.Drawing.Size(107, 20);
            this.dateFin.TabIndex = 1;
            // 
            // dateDebut
            // 
            this.dateDebut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateDebut.Location = new System.Drawing.Point(58, 11);
            this.dateDebut.Name = "dateDebut";
            this.dateDebut.Size = new System.Drawing.Size(95, 20);
            this.dateDebut.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(159, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "à";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Date de";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TypeDoc,
            this.DesignMat,
            this.dateDoc,
            this.qteDoc,
            this.qteHs});
            this.dataGridView1.Location = new System.Drawing.Point(309, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(721, 330);
            this.dataGridView1.TabIndex = 2;
            // 
            // TypeDoc
            // 
            this.TypeDoc.HeaderText = "Type document";
            this.TypeDoc.Name = "TypeDoc";
            // 
            // DesignMat
            // 
            this.DesignMat.HeaderText = "Designation ";
            this.DesignMat.Name = "DesignMat";
            // 
            // dateDoc
            // 
            this.dateDoc.HeaderText = "Date";
            this.dateDoc.Name = "dateDoc";
            // 
            // qteDoc
            // 
            this.qteDoc.HeaderText = "Quantite";
            this.qteDoc.Name = "qteDoc";
            // 
            // qteHs
            // 
            this.qteHs.HeaderText = "Quantite HS";
            this.qteHs.Name = "qteHs";
            // 
            // imprimer
            // 
            this.imprimer.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imprimer.Location = new System.Drawing.Point(917, 30);
            this.imprimer.Name = "imprimer";
            this.imprimer.Size = new System.Drawing.Size(86, 29);
            this.imprimer.TabIndex = 3;
            this.imprimer.Text = "Imprimer";
            this.imprimer.UseVisualStyleBackColor = true;
            // 
            // StatsParMateriaux
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 462);
            this.Controls.Add(this.imprimer);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "StatsParMateriaux";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StatsParMateriaux";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button fermerStat;
        private System.Windows.Forms.Button okStat;
        private System.Windows.Forms.ComboBox materiauxListCombo;
        private System.Windows.Forms.ComboBox typeDocCombo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateFin;
        private System.Windows.Forms.DateTimePicker dateDebut;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn DesignMat;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn qteDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn qteHs;
        private System.Windows.Forms.Button imprimer;
    }
}