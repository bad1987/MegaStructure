namespace MegaStructure
{
    partial class ConnexionUtilisateur
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
            this.annulerConnexion = new System.Windows.Forms.Button();
            this.okConnexion = new System.Windows.Forms.Button();
            this.password = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.annulerConnexion);
            this.panel1.Controls.Add(this.okConnexion);
            this.panel1.Controls.Add(this.password);
            this.panel1.Controls.Add(this.username);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(401, 175);
            this.panel1.TabIndex = 0;
            // 
            // annulerConnexion
            // 
            this.annulerConnexion.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.annulerConnexion.Location = new System.Drawing.Point(210, 127);
            this.annulerConnexion.Name = "annulerConnexion";
            this.annulerConnexion.Size = new System.Drawing.Size(75, 33);
            this.annulerConnexion.TabIndex = 4;
            this.annulerConnexion.Text = "Annuler";
            this.annulerConnexion.UseVisualStyleBackColor = true;
            this.annulerConnexion.Click += new System.EventHandler(this.annulerConnexion_Click);
            // 
            // okConnexion
            // 
            this.okConnexion.BackColor = System.Drawing.Color.RoyalBlue;
            this.okConnexion.ForeColor = System.Drawing.Color.White;
            this.okConnexion.Location = new System.Drawing.Point(129, 127);
            this.okConnexion.Name = "okConnexion";
            this.okConnexion.Size = new System.Drawing.Size(75, 33);
            this.okConnexion.TabIndex = 3;
            this.okConnexion.Text = "OK";
            this.okConnexion.UseVisualStyleBackColor = false;
            this.okConnexion.Click += new System.EventHandler(this.okConnexion_Click);
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(170, 66);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(218, 25);
            this.password.TabIndex = 2;
            this.password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.password_KeyDown);
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(170, 23);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(218, 25);
            this.username.TabIndex = 1;
            this.username.KeyDown += new System.Windows.Forms.KeyEventHandler(this.username_KeyDown);
            this.username.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.username_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mot de Passe";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom de l\'Utilisateur";
            // 
            // ConnexionUtilisateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 175);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConnexionUtilisateur";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConnexionUtilisateur";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ConnexionUtilisateur_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button annulerConnexion;
        private System.Windows.Forms.Button okConnexion;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}