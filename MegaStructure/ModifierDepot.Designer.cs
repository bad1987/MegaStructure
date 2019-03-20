namespace MegaStructure
{
    partial class ModifierDepot
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
            this.intitule = new System.Windows.Forms.TextBox();
            this.adresse = new System.Windows.Forms.Label();
            this.adr = new System.Windows.Forms.TextBox();
            this.enregistrer = new System.Windows.Forms.Button();
            this.annuler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(22, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Intitule";
            // 
            // intitule
            // 
            this.intitule.Location = new System.Drawing.Point(85, 21);
            this.intitule.Name = "intitule";
            this.intitule.Size = new System.Drawing.Size(263, 26);
            this.intitule.TabIndex = 1;
            this.intitule.Leave += new System.EventHandler(this.intitule_Leave);
            // 
            // adresse
            // 
            this.adresse.AutoSize = true;
            this.adresse.ForeColor = System.Drawing.Color.White;
            this.adresse.Location = new System.Drawing.Point(12, 68);
            this.adresse.Name = "adresse";
            this.adresse.Size = new System.Drawing.Size(59, 19);
            this.adresse.TabIndex = 0;
            this.adresse.Text = "Adresse";
            // 
            // adr
            // 
            this.adr.Location = new System.Drawing.Point(85, 68);
            this.adr.Name = "adr";
            this.adr.Size = new System.Drawing.Size(263, 26);
            this.adr.TabIndex = 1;
            this.adr.Leave += new System.EventHandler(this.adr_Leave);
            // 
            // enregistrer
            // 
            this.enregistrer.BackColor = System.Drawing.SystemColors.Control;
            this.enregistrer.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.enregistrer.FlatAppearance.BorderSize = 2;
            this.enregistrer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.enregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enregistrer.Location = new System.Drawing.Point(85, 147);
            this.enregistrer.Name = "enregistrer";
            this.enregistrer.Size = new System.Drawing.Size(91, 33);
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
            this.annuler.Location = new System.Drawing.Point(200, 147);
            this.annuler.Name = "annuler";
            this.annuler.Size = new System.Drawing.Size(91, 33);
            this.annuler.TabIndex = 2;
            this.annuler.Text = "Annuler";
            this.annuler.UseVisualStyleBackColor = false;
            // 
            // ModifierDepot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(386, 192);
            this.Controls.Add(this.annuler);
            this.Controls.Add(this.enregistrer);
            this.Controls.Add(this.adr);
            this.Controls.Add(this.adresse);
            this.Controls.Add(this.intitule);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ModifierDepot";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModifierDepot";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox intitule;
        private System.Windows.Forms.Label adresse;
        private System.Windows.Forms.TextBox adr;
        private System.Windows.Forms.Button enregistrer;
        private System.Windows.Forms.Button annuler;
    }
}