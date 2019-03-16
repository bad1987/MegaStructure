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
            this.proevenance = new System.Windows.Forms.ComboBox();
            this.valider = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.fermer = new System.Windows.Forms.Button();
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
            this.materiel.FormattingEnabled = true;
            this.materiel.Location = new System.Drawing.Point(88, 15);
            this.materiel.Name = "materiel";
            this.materiel.Size = new System.Drawing.Size(285, 21);
            this.materiel.TabIndex = 1;
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
            this.qteHs.Location = new System.Drawing.Point(88, 74);
            this.qteHs.Name = "qteHs";
            this.qteHs.Size = new System.Drawing.Size(144, 20);
            this.qteHs.TabIndex = 2;
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
            // proevenance
            // 
            this.proevenance.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.proevenance.FormattingEnabled = true;
            this.proevenance.Items.AddRange(new object[] {
            "Stock reel encours",
            "inventaire initial"});
            this.proevenance.Location = new System.Drawing.Point(367, 74);
            this.proevenance.Name = "proevenance";
            this.proevenance.Size = new System.Drawing.Size(212, 21);
            this.proevenance.TabIndex = 3;
            // 
            // valider
            // 
            this.valider.BackColor = System.Drawing.SystemColors.Highlight;
            this.valider.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valider.Location = new System.Drawing.Point(245, 138);
            this.valider.Name = "valider";
            this.valider.Size = new System.Drawing.Size(75, 30);
            this.valider.TabIndex = 4;
            this.valider.Text = "Valider";
            this.valider.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.materiel);
            this.panel1.Controls.Add(this.valider);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.proevenance);
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
            this.fermer.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fermer.Location = new System.Drawing.Point(517, 242);
            this.fermer.Name = "fermer";
            this.fermer.Size = new System.Drawing.Size(75, 23);
            this.fermer.TabIndex = 4;
            this.fermer.Text = "Fermer";
            this.fermer.UseVisualStyleBackColor = true;
            this.fermer.Click += new System.EventHandler(this.fermer_Click);
            // 
            // EntreeHS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 277);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.fermer);
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
        private System.Windows.Forms.ComboBox proevenance;
        private System.Windows.Forms.Button valider;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button fermer;
    }
}