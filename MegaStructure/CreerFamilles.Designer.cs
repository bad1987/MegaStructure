namespace MegaStructure
{
    partial class CreerFamilles
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
            this.validerFamille = new System.Windows.Forms.Button();
            this.familleDesign = new System.Windows.Forms.TextBox();
            this.familleRef = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fermer = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.validerFamille);
            this.panel1.Controls.Add(this.familleDesign);
            this.panel1.Controls.Add(this.familleRef);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(541, 173);
            this.panel1.TabIndex = 0;
            // 
            // validerFamille
            // 
            this.validerFamille.BackColor = System.Drawing.SystemColors.Highlight;
            this.validerFamille.Location = new System.Drawing.Point(252, 130);
            this.validerFamille.Name = "validerFamille";
            this.validerFamille.Size = new System.Drawing.Size(75, 27);
            this.validerFamille.TabIndex = 2;
            this.validerFamille.Text = "Valider";
            this.validerFamille.UseVisualStyleBackColor = false;
            this.validerFamille.Click += new System.EventHandler(this.validerFamille_Click);
            // 
            // familleDesign
            // 
            this.familleDesign.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.familleDesign.Location = new System.Drawing.Point(124, 77);
            this.familleDesign.Name = "familleDesign";
            this.familleDesign.Size = new System.Drawing.Size(407, 22);
            this.familleDesign.TabIndex = 1;
            this.familleDesign.KeyDown += new System.Windows.Forms.KeyEventHandler(this.familleDesign_KeyDown);
            // 
            // familleRef
            // 
            this.familleRef.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.familleRef.Location = new System.Drawing.Point(124, 24);
            this.familleRef.Name = "familleRef";
            this.familleRef.Size = new System.Drawing.Size(214, 22);
            this.familleRef.TabIndex = 0;
            this.familleRef.KeyDown += new System.Windows.Forms.KeyEventHandler(this.familleRef_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Designation";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reference";
            // 
            // fermer
            // 
            this.fermer.BackColor = System.Drawing.SystemColors.ControlDark;
            this.fermer.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.fermer.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fermer.FlatAppearance.BorderSize = 2;
            this.fermer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumAquamarine;
            this.fermer.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace;
            this.fermer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fermer.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fermer.Location = new System.Drawing.Point(381, 200);
            this.fermer.Name = "fermer";
            this.fermer.Size = new System.Drawing.Size(75, 27);
            this.fermer.TabIndex = 3;
            this.fermer.Text = "Ok";
            this.fermer.UseVisualStyleBackColor = false;
            this.fermer.Click += new System.EventHandler(this.fermer_Click);
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cancel.FlatAppearance.BorderSize = 2;
            this.cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumAquamarine;
            this.cancel.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace;
            this.cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel.Location = new System.Drawing.Point(478, 200);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 27);
            this.cancel.TabIndex = 3;
            this.cancel.Text = "Annuler";
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.fermer_Click);
            // 
            // CreerFamilles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(565, 239);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.fermer);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreerFamilles";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreerFamilles";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CreerFamilles_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox familleDesign;
        private System.Windows.Forms.TextBox familleRef;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button validerFamille;
        private System.Windows.Forms.Button fermer;
        private System.Windows.Forms.Button cancel;
    }
}