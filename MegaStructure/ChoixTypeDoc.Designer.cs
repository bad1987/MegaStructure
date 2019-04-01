namespace MegaStructure
{
    partial class ChoixTypeDoc
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
            this.mvtEntree = new System.Windows.Forms.RadioButton();
            this.mvtSortie = new System.Windows.Forms.RadioButton();
            this.mvtRetour = new System.Windows.Forms.RadioButton();
            this.ok = new System.Windows.Forms.Button();
            this.annuler = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quel type de document voulez vous ajouter?";
            // 
            // mvtEntree
            // 
            this.mvtEntree.AutoSize = true;
            this.mvtEntree.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mvtEntree.Location = new System.Drawing.Point(22, 14);
            this.mvtEntree.Name = "mvtEntree";
            this.mvtEntree.Size = new System.Drawing.Size(135, 19);
            this.mvtEntree.TabIndex = 1;
            this.mvtEntree.TabStop = true;
            this.mvtEntree.Text = "Mouvement d\'entree";
            this.mvtEntree.UseVisualStyleBackColor = true;
            // 
            // mvtSortie
            // 
            this.mvtSortie.AutoSize = true;
            this.mvtSortie.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mvtSortie.Location = new System.Drawing.Point(22, 33);
            this.mvtSortie.Name = "mvtSortie";
            this.mvtSortie.Size = new System.Drawing.Size(139, 19);
            this.mvtSortie.TabIndex = 1;
            this.mvtSortie.TabStop = true;
            this.mvtSortie.Text = "Mouvement de sortie";
            this.mvtSortie.UseVisualStyleBackColor = true;
            // 
            // mvtRetour
            // 
            this.mvtRetour.AutoSize = true;
            this.mvtRetour.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mvtRetour.Location = new System.Drawing.Point(22, 54);
            this.mvtRetour.Name = "mvtRetour";
            this.mvtRetour.Size = new System.Drawing.Size(141, 19);
            this.mvtRetour.TabIndex = 1;
            this.mvtRetour.TabStop = true;
            this.mvtRetour.Text = "Mouvement de retour";
            this.mvtRetour.UseVisualStyleBackColor = true;
            // 
            // ok
            // 
            this.ok.BackColor = System.Drawing.SystemColors.Highlight;
            this.ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ok.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ok.Location = new System.Drawing.Point(92, 116);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(75, 28);
            this.ok.TabIndex = 0;
            this.ok.Text = "OK";
            this.ok.UseVisualStyleBackColor = false;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // annuler
            // 
            this.annuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.annuler.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.annuler.Location = new System.Drawing.Point(173, 116);
            this.annuler.Name = "annuler";
            this.annuler.Size = new System.Drawing.Size(75, 28);
            this.annuler.TabIndex = 0;
            this.annuler.Text = "Annuler";
            this.annuler.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mvtEntree);
            this.groupBox1.Controls.Add(this.mvtSortie);
            this.groupBox1.Controls.Add(this.mvtRetour);
            this.groupBox1.Location = new System.Drawing.Point(0, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 83);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // ChoixTypeDoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 156);
            this.Controls.Add(this.annuler);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChoixTypeDoc";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajouter un document";
            this.TopMost = true;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton mvtEntree;
        private System.Windows.Forms.RadioButton mvtSortie;
        private System.Windows.Forms.RadioButton mvtRetour;
        private System.Windows.Forms.Button annuler;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}