namespace MegaStructure
{
    partial class Filtre
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateF = new System.Windows.Forms.DateTimePicker();
            this.dateDebut = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.okFiltre = new System.Windows.Forms.Button();
            this.annulerFiltre = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dateF);
            this.panel1.Controls.Add(this.dateDebut);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(298, 56);
            this.panel1.TabIndex = 0;
            // 
            // dateF
            // 
            this.dateF.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateF.Location = new System.Drawing.Point(185, 10);
            this.dateF.Name = "dateF";
            this.dateF.Size = new System.Drawing.Size(99, 20);
            this.dateF.TabIndex = 1;
            // 
            // dateDebut
            // 
            this.dateDebut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateDebut.Location = new System.Drawing.Point(59, 10);
            this.dateDebut.Name = "dateDebut";
            this.dateDebut.Size = new System.Drawing.Size(99, 20);
            this.dateDebut.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(164, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "à";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date de";
            // 
            // okFiltre
            // 
            this.okFiltre.BackColor = System.Drawing.SystemColors.Highlight;
            this.okFiltre.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okFiltre.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okFiltre.Location = new System.Drawing.Point(58, 84);
            this.okFiltre.Name = "okFiltre";
            this.okFiltre.Size = new System.Drawing.Size(75, 31);
            this.okFiltre.TabIndex = 1;
            this.okFiltre.Text = "OK";
            this.okFiltre.UseVisualStyleBackColor = false;
            this.okFiltre.Click += new System.EventHandler(this.okFiltre_Click);
            // 
            // annulerFiltre
            // 
            this.annulerFiltre.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.annulerFiltre.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.annulerFiltre.Location = new System.Drawing.Point(150, 84);
            this.annulerFiltre.Name = "annulerFiltre";
            this.annulerFiltre.Size = new System.Drawing.Size(75, 31);
            this.annulerFiltre.TabIndex = 1;
            this.annulerFiltre.Text = "Annuler";
            this.annulerFiltre.UseVisualStyleBackColor = true;
            this.annulerFiltre.Click += new System.EventHandler(this.annulerFiltre_Click_1);
            // 
            // Filtre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 119);
            this.Controls.Add(this.annulerFiltre);
            this.Controls.Add(this.okFiltre);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Filtre";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filtre";
            this.TopMost = true;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateF;
        private System.Windows.Forms.DateTimePicker dateDebut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button okFiltre;
        private System.Windows.Forms.Button annulerFiltre;
    }
}