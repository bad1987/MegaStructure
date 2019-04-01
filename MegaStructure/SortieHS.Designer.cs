namespace MegaStructure
{
    partial class SortieHS
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
            this.materiaux = new System.Windows.Forms.ComboBox();
            this.qtehs = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.enregistrer = new System.Windows.Forms.Button();
            this.fermer = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.okFermer = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Materiel";
            // 
            // materiaux
            // 
            this.materiaux.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.materiaux.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.materiaux.FormattingEnabled = true;
            this.materiaux.Location = new System.Drawing.Point(83, 34);
            this.materiaux.Name = "materiaux";
            this.materiaux.Size = new System.Drawing.Size(290, 25);
            this.materiaux.TabIndex = 0;
            // 
            // qtehs
            // 
            this.qtehs.Location = new System.Drawing.Point(83, 95);
            this.qtehs.Name = "qtehs";
            this.qtehs.Size = new System.Drawing.Size(156, 25);
            this.qtehs.TabIndex = 1;
            this.qtehs.KeyDown += new System.Windows.Forms.KeyEventHandler(this.qtehs_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Quantite";
            // 
            // enregistrer
            // 
            this.enregistrer.BackColor = System.Drawing.SystemColors.Highlight;
            this.enregistrer.FlatAppearance.BorderSize = 2;
            this.enregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enregistrer.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enregistrer.Location = new System.Drawing.Point(151, 162);
            this.enregistrer.Name = "enregistrer";
            this.enregistrer.Size = new System.Drawing.Size(75, 27);
            this.enregistrer.TabIndex = 2;
            this.enregistrer.Text = "Enregistrer";
            this.enregistrer.UseVisualStyleBackColor = false;
            this.enregistrer.Click += new System.EventHandler(this.enregistrer_Click);
            // 
            // fermer
            // 
            this.fermer.BackColor = System.Drawing.SystemColors.ControlDark;
            this.fermer.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.fermer.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.fermer.FlatAppearance.BorderSize = 2;
            this.fermer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.fermer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fermer.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fermer.Location = new System.Drawing.Point(382, 227);
            this.fermer.Name = "fermer";
            this.fermer.Size = new System.Drawing.Size(75, 28);
            this.fermer.TabIndex = 4;
            this.fermer.Text = "Annuler";
            this.fermer.UseVisualStyleBackColor = false;
            this.fermer.Click += new System.EventHandler(this.fermer_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.materiaux);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.enregistrer);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.qtehs);
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(456, 200);
            this.panel1.TabIndex = 4;
            // 
            // okFermer
            // 
            this.okFermer.BackColor = System.Drawing.SystemColors.ControlDark;
            this.okFermer.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okFermer.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.okFermer.FlatAppearance.BorderSize = 2;
            this.okFermer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.okFermer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okFermer.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okFermer.Location = new System.Drawing.Point(288, 227);
            this.okFermer.Name = "okFermer";
            this.okFermer.Size = new System.Drawing.Size(75, 28);
            this.okFermer.TabIndex = 3;
            this.okFermer.Text = "OK";
            this.okFermer.UseVisualStyleBackColor = false;
            this.okFermer.Click += new System.EventHandler(this.fermer_Click);
            // 
            // SortieHS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(480, 267);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.okFermer);
            this.Controls.Add(this.fermer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SortieHS";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SortieHS";
            this.TopMost = true;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox materiaux;
        private System.Windows.Forms.TextBox qtehs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button enregistrer;
        private System.Windows.Forms.Button fermer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button okFermer;
    }
}