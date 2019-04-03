namespace MegaStructure
{
    partial class EntreeHS
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
            this.materiel = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.qteHs = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.provenance = new System.Windows.Forms.ComboBox();
            this.valider = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.fermer = new System.Windows.Forms.Button();
            this.ok = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Materiel";
            // 
            // materiel
            // 
            this.materiel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.materiel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.materiel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materiel.FormattingEnabled = true;
            this.materiel.Location = new System.Drawing.Point(88, 15);
            this.materiel.Name = "materiel";
            this.materiel.Size = new System.Drawing.Size(285, 25);
            this.materiel.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Quantite hs";
            // 
            // qteHs
            // 
            this.qteHs.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qteHs.Location = new System.Drawing.Point(88, 74);
            this.qteHs.Name = "qteHs";
            this.qteHs.Size = new System.Drawing.Size(144, 25);
            this.qteHs.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(277, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Provenance";
            // 
            // provenance
            // 
            this.provenance.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.provenance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.provenance.FormattingEnabled = true;
            this.provenance.Location = new System.Drawing.Point(367, 74);
            this.provenance.Name = "provenance";
            this.provenance.Size = new System.Drawing.Size(212, 25);
            this.provenance.TabIndex = 2;
            // 
            // valider
            // 
            this.valider.BackColor = System.Drawing.SystemColors.Highlight;
            this.valider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.valider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.valider.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valider.Location = new System.Drawing.Point(245, 138);
            this.valider.Name = "valider";
            this.valider.Size = new System.Drawing.Size(75, 30);
            this.valider.TabIndex = 3;
            this.valider.Text = "Valider";
            this.valider.UseVisualStyleBackColor = false;
            this.valider.Click += new System.EventHandler(this.valider_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.materiel);
            this.panel1.Controls.Add(this.valider);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.provenance);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.qteHs);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(592, 193);
            this.panel1.TabIndex = 5;
            // 
            // fermer
            // 
            this.fermer.BackColor = System.Drawing.SystemColors.ControlDark;
            this.fermer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fermer.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.fermer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.fermer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fermer.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fermer.Location = new System.Drawing.Point(517, 236);
            this.fermer.Name = "fermer";
            this.fermer.Size = new System.Drawing.Size(75, 29);
            this.fermer.TabIndex = 5;
            this.fermer.Text = "Fermer";
            this.fermer.UseVisualStyleBackColor = false;
            this.fermer.Click += new System.EventHandler(this.fermer_Click);
            // 
            // ok
            // 
            this.ok.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ok.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ok.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ok.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ok.Location = new System.Drawing.Point(421, 236);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(75, 29);
            this.ok.TabIndex = 4;
            this.ok.Text = "OK";
            this.ok.UseVisualStyleBackColor = false;
            this.ok.Click += new System.EventHandler(this.fermer_Click);
            // 
            // EntreeHS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(616, 277);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.fermer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EntreeHS";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EntreeHS";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox materiel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox qteHs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox provenance;
        private System.Windows.Forms.Button valider;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button fermer;
        private System.Windows.Forms.Button ok;
    }
}