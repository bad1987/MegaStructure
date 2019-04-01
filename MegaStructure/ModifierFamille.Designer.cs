namespace MegaStructure
{
    partial class ModifierFamille
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
            this.codefam = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.designfam = new System.Windows.Forms.TextBox();
            this.enregistrer = new System.Windows.Forms.Button();
            this.annuler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Code famille";
            // 
            // codefam
            // 
            this.codefam.Enabled = false;
            this.codefam.Location = new System.Drawing.Point(129, 23);
            this.codefam.Name = "codefam";
            this.codefam.Size = new System.Drawing.Size(147, 26);
            this.codefam.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(18, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Designation";
            // 
            // designfam
            // 
            this.designfam.Location = new System.Drawing.Point(129, 69);
            this.designfam.Name = "designfam";
            this.designfam.Size = new System.Drawing.Size(284, 26);
            this.designfam.TabIndex = 1;
            this.designfam.Leave += new System.EventHandler(this.designfam_Leave);
            // 
            // enregistrer
            // 
            this.enregistrer.BackColor = System.Drawing.SystemColors.Control;
            this.enregistrer.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.enregistrer.FlatAppearance.BorderSize = 2;
            this.enregistrer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.enregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enregistrer.Location = new System.Drawing.Point(108, 138);
            this.enregistrer.Name = "enregistrer";
            this.enregistrer.Size = new System.Drawing.Size(87, 33);
            this.enregistrer.TabIndex = 2;
            this.enregistrer.Text = "Enregistrer";
            this.enregistrer.UseVisualStyleBackColor = false;
            this.enregistrer.Click += new System.EventHandler(this.enregistrer_Click);
            // 
            // annuler
            // 
            this.annuler.BackColor = System.Drawing.SystemColors.Control;
            this.annuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.annuler.FlatAppearance.BorderSize = 2;
            this.annuler.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.annuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.annuler.Location = new System.Drawing.Point(213, 138);
            this.annuler.Name = "annuler";
            this.annuler.Size = new System.Drawing.Size(83, 33);
            this.annuler.TabIndex = 3;
            this.annuler.Text = "Annuler";
            this.annuler.UseVisualStyleBackColor = false;
            // 
            // ModifierFamille
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(434, 192);
            this.Controls.Add(this.annuler);
            this.Controls.Add(this.enregistrer);
            this.Controls.Add(this.designfam);
            this.Controls.Add(this.codefam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ModifierFamille";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModifierFamille";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ModifierFamille_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox codefam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox designfam;
        private System.Windows.Forms.Button enregistrer;
        private System.Windows.Forms.Button annuler;
    }
}