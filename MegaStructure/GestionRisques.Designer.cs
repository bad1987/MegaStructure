namespace MegaStructure
{
    partial class GestionRisques
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.proche = new System.Windows.Forms.Button();
            this.enrupture = new System.Windows.Forms.Button();
            this.exporter = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.refmat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.designmat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sreel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fermer = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // proche
            // 
            this.proche.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.proche.Cursor = System.Windows.Forms.Cursors.Hand;
            this.proche.FlatAppearance.BorderSize = 0;
            this.proche.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.proche.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.proche.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proche.Location = new System.Drawing.Point(193, 7);
            this.proche.Name = "proche";
            this.proche.Size = new System.Drawing.Size(188, 37);
            this.proche.TabIndex = 0;
            this.proche.Text = "Rupture proche";
            this.proche.UseVisualStyleBackColor = false;
            this.proche.Click += new System.EventHandler(this.proche_Click);
            // 
            // enrupture
            // 
            this.enrupture.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.enrupture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.enrupture.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.enrupture.FlatAppearance.BorderSize = 0;
            this.enrupture.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.enrupture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enrupture.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enrupture.Location = new System.Drawing.Point(6, 7);
            this.enrupture.Name = "enrupture";
            this.enrupture.Size = new System.Drawing.Size(188, 37);
            this.enrupture.TabIndex = 0;
            this.enrupture.Text = "Materiaux en ruptures";
            this.enrupture.UseVisualStyleBackColor = false;
            this.enrupture.Click += new System.EventHandler(this.enrupture_Click);
            // 
            // exporter
            // 
            this.exporter.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.exporter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exporter.FlatAppearance.BorderSize = 2;
            this.exporter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exporter.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exporter.Location = new System.Drawing.Point(706, 65);
            this.exporter.Name = "exporter";
            this.exporter.Size = new System.Drawing.Size(85, 37);
            this.exporter.TabIndex = 0;
            this.exporter.Text = "Exporter";
            this.exporter.UseVisualStyleBackColor = false;
            this.exporter.Click += new System.EventHandler(this.exporter_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.refmat,
            this.designmat,
            this.sreel,
            this.shs});
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(12, 119);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(803, 319);
            this.dataGridView1.TabIndex = 1;
            // 
            // refmat
            // 
            this.refmat.HeaderText = "REFERENCE";
            this.refmat.Name = "refmat";
            this.refmat.ReadOnly = true;
            this.refmat.Visible = false;
            // 
            // designmat
            // 
            this.designmat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.designmat.HeaderText = "DESIGNATION";
            this.designmat.Name = "designmat";
            this.designmat.ReadOnly = true;
            this.designmat.Width = 500;
            // 
            // sreel
            // 
            this.sreel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.sreel.HeaderText = "STOCK REEL";
            this.sreel.Name = "sreel";
            this.sreel.ReadOnly = true;
            this.sreel.Width = 150;
            // 
            // shs
            // 
            this.shs.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.shs.HeaderText = "STOCK HS";
            this.shs.Name = "shs";
            this.shs.ReadOnly = true;
            this.shs.Width = 150;
            // 
            // fermer
            // 
            this.fermer.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.fermer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fermer.FlatAppearance.BorderSize = 2;
            this.fermer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fermer.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fermer.Location = new System.Drawing.Point(694, 8);
            this.fermer.Name = "fermer";
            this.fermer.Size = new System.Drawing.Size(85, 37);
            this.fermer.TabIndex = 0;
            this.fermer.Text = "Fermer";
            this.fermer.UseVisualStyleBackColor = false;
            this.fermer.Click += new System.EventHandler(this.fermer_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.fermer);
            this.panel1.Location = new System.Drawing.Point(12, 444);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(803, 52);
            this.panel1.TabIndex = 2;
            // 
            // GestionRisques
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(824, 499);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.enrupture);
            this.Controls.Add(this.exporter);
            this.Controls.Add(this.proche);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GestionRisques";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "GestionRisques";
            this.Load += new System.EventHandler(this.GestionRisques_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button proche;
        private System.Windows.Forms.Button enrupture;
        private System.Windows.Forms.Button exporter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn refmat;
        private System.Windows.Forms.DataGridViewTextBoxColumn designmat;
        private System.Windows.Forms.DataGridViewTextBoxColumn sreel;
        private System.Windows.Forms.DataGridViewTextBoxColumn shs;
        private System.Windows.Forms.Button fermer;
        private System.Windows.Forms.Panel panel1;
    }
}