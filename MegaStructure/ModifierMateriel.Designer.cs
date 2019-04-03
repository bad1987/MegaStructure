namespace MegaStructure
{
    partial class ModifierMateriel
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
            this.matref = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.matdesign = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.famille = new System.Windows.Forms.ComboBox();
            this.enregistrer = new System.Windows.Forms.Button();
            this.annuler = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.suivistock = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(37, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reference";
            // 
            // matref
            // 
            this.matref.Enabled = false;
            this.matref.Location = new System.Drawing.Point(120, 43);
            this.matref.Name = "matref";
            this.matref.Size = new System.Drawing.Size(188, 26);
            this.matref.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(28, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Designation";
            // 
            // matdesign
            // 
            this.matdesign.Location = new System.Drawing.Point(120, 81);
            this.matdesign.Name = "matdesign";
            this.matdesign.Size = new System.Drawing.Size(311, 26);
            this.matdesign.TabIndex = 1;
            this.matdesign.Leave += new System.EventHandler(this.matdesign_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(55, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Famille";
            // 
            // famille
            // 
            this.famille.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.famille.FormattingEnabled = true;
            this.famille.Location = new System.Drawing.Point(120, 125);
            this.famille.Name = "famille";
            this.famille.Size = new System.Drawing.Size(311, 27);
            this.famille.TabIndex = 2;
            // 
            // enregistrer
            // 
            this.enregistrer.BackColor = System.Drawing.SystemColors.Control;
            this.enregistrer.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.enregistrer.FlatAppearance.BorderSize = 2;
            this.enregistrer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.enregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enregistrer.Location = new System.Drawing.Point(135, 231);
            this.enregistrer.Name = "enregistrer";
            this.enregistrer.Size = new System.Drawing.Size(87, 32);
            this.enregistrer.TabIndex = 3;
            this.enregistrer.Text = "Enregistrer";
            this.enregistrer.UseVisualStyleBackColor = false;
            this.enregistrer.Click += new System.EventHandler(this.enregistrer_Click);
            // 
            // annuler
            // 
            this.annuler.BackColor = System.Drawing.SystemColors.Control;
            this.annuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.annuler.FlatAppearance.BorderSize = 2;
            this.annuler.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.annuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.annuler.Location = new System.Drawing.Point(253, 231);
            this.annuler.Name = "annuler";
            this.annuler.Size = new System.Drawing.Size(75, 32);
            this.annuler.TabIndex = 4;
            this.annuler.Text = "Annuler";
            this.annuler.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Suivi en Stock";
            // 
            // suivistock
            // 
            this.suivistock.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.suivistock.FormattingEnabled = true;
            this.suivistock.Location = new System.Drawing.Point(120, 167);
            this.suivistock.Name = "suivistock";
            this.suivistock.Size = new System.Drawing.Size(188, 27);
            this.suivistock.TabIndex = 2;
            // 
            // ModifierMateriel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(450, 275);
            this.Controls.Add(this.annuler);
            this.Controls.Add(this.enregistrer);
            this.Controls.Add(this.suivistock);
            this.Controls.Add(this.famille);
            this.Controls.Add(this.matdesign);
            this.Controls.Add(this.matref);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ModifierMateriel";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modifier les informations du materiel";
            this.Load += new System.EventHandler(this.ModifierMateriel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox matref;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox matdesign;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox famille;
        private System.Windows.Forms.Button enregistrer;
        private System.Windows.Forms.Button annuler;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox suivistock;
    }
}