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
            this.ok = new System.Windows.Forms.Button();
            this.fermer = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.materiaux.FormattingEnabled = true;
            this.materiaux.Location = new System.Drawing.Point(83, 34);
            this.materiaux.Name = "materiaux";
            this.materiaux.Size = new System.Drawing.Size(290, 21);
            this.materiaux.TabIndex = 1;
            // 
            // qtehs
            // 
            this.qtehs.Location = new System.Drawing.Point(83, 95);
            this.qtehs.Name = "qtehs";
            this.qtehs.Size = new System.Drawing.Size(156, 20);
            this.qtehs.TabIndex = 2;
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
            // ok
            // 
            this.ok.BackColor = System.Drawing.SystemColors.Highlight;
            this.ok.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ok.Location = new System.Drawing.Point(151, 162);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(75, 27);
            this.ok.TabIndex = 3;
            this.ok.Text = "OK";
            this.ok.UseVisualStyleBackColor = false;
            // 
            // fermer
            // 
            this.fermer.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fermer.Location = new System.Drawing.Point(382, 232);
            this.fermer.Name = "fermer";
            this.fermer.Size = new System.Drawing.Size(75, 23);
            this.fermer.TabIndex = 3;
            this.fermer.Text = "Fermer";
            this.fermer.UseVisualStyleBackColor = true;
            this.fermer.Click += new System.EventHandler(this.fermer_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.materiaux);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ok);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.qtehs);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(456, 200);
            this.panel1.TabIndex = 4;
            // 
            // SortieHS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 267);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.fermer);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SortieHS";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SortieHS";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox materiaux;
        private System.Windows.Forms.TextBox qtehs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.Button fermer;
        private System.Windows.Forms.Panel panel1;
    }
}