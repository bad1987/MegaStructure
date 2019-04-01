namespace MegaStructure
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichier = new System.Windows.Forms.ToolStripMenuItem();
            this.utilisateurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connexion = new System.Windows.Forms.ToolStripMenuItem();
            this.deconnexion = new System.Windows.Forms.ToolStripMenuItem();
            this.outils = new System.Windows.Forms.ToolStripMenuItem();
            this.sauvegarderLaBaseDeDonneesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restorerLaBaseDeDonneesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exporterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fermerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.structure = new System.Windows.Forms.ToolStripMenuItem();
            this.familleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materielToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.depotsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.traitement = new System.Windows.Forms.ToolStripMenuItem();
            this.documentsDeStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesHSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entreeHSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortieHSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.etat = new System.Windows.Forms.ToolStripMenuItem();
            this.statistiquesMateriauxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parMaterielToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parFamillesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rupturesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aide = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichier,
            this.structure,
            this.traitement,
            this.etat,
            this.aide});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(888, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichier
            // 
            this.fichier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.utilisateurToolStripMenuItem,
            this.outils,
            this.fermerToolStripMenuItem});
            this.fichier.ForeColor = System.Drawing.Color.White;
            this.fichier.Name = "fichier";
            this.fichier.Size = new System.Drawing.Size(60, 21);
            this.fichier.Text = "Fichier";
            this.fichier.MouseLeave += new System.EventHandler(this.fichier_MouseLeave);
            this.fichier.MouseHover += new System.EventHandler(this.fichierToolStripMenuItem_MouseHover);
            // 
            // utilisateurToolStripMenuItem
            // 
            this.utilisateurToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connexion,
            this.deconnexion});
            this.utilisateurToolStripMenuItem.Enabled = false;
            this.utilisateurToolStripMenuItem.Name = "utilisateurToolStripMenuItem";
            this.utilisateurToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.utilisateurToolStripMenuItem.Text = "Utilisateurs";
            // 
            // connexion
            // 
            this.connexion.Name = "connexion";
            this.connexion.Size = new System.Drawing.Size(180, 22);
            this.connexion.Text = "Connexion";
            this.connexion.Click += new System.EventHandler(this.connexionToolStripMenuItem_Click);
            // 
            // deconnexion
            // 
            this.deconnexion.Name = "deconnexion";
            this.deconnexion.Size = new System.Drawing.Size(180, 22);
            this.deconnexion.Text = "Deconnexion";
            this.deconnexion.Click += new System.EventHandler(this.deconnexion_Click);
            // 
            // outils
            // 
            this.outils.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sauvegarderLaBaseDeDonneesToolStripMenuItem,
            this.restorerLaBaseDeDonneesToolStripMenuItem,
            this.importerToolStripMenuItem,
            this.exporterToolStripMenuItem});
            this.outils.Name = "outils";
            this.outils.Size = new System.Drawing.Size(180, 22);
            this.outils.Text = "Outils";
            // 
            // sauvegarderLaBaseDeDonneesToolStripMenuItem
            // 
            this.sauvegarderLaBaseDeDonneesToolStripMenuItem.Name = "sauvegarderLaBaseDeDonneesToolStripMenuItem";
            this.sauvegarderLaBaseDeDonneesToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.sauvegarderLaBaseDeDonneesToolStripMenuItem.Text = "Sauvegarder";
            this.sauvegarderLaBaseDeDonneesToolStripMenuItem.Click += new System.EventHandler(this.sauvegarderLaBaseDeDonneesToolStripMenuItem_Click);
            // 
            // restorerLaBaseDeDonneesToolStripMenuItem
            // 
            this.restorerLaBaseDeDonneesToolStripMenuItem.Name = "restorerLaBaseDeDonneesToolStripMenuItem";
            this.restorerLaBaseDeDonneesToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.restorerLaBaseDeDonneesToolStripMenuItem.Text = "Restorer";
            this.restorerLaBaseDeDonneesToolStripMenuItem.Click += new System.EventHandler(this.restorerLaBaseDeDonneesToolStripMenuItem_Click);
            // 
            // importerToolStripMenuItem
            // 
            this.importerToolStripMenuItem.Name = "importerToolStripMenuItem";
            this.importerToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.importerToolStripMenuItem.Text = "Importer";
            this.importerToolStripMenuItem.Click += new System.EventHandler(this.importerToolStripMenuItem_Click);
            // 
            // exporterToolStripMenuItem
            // 
            this.exporterToolStripMenuItem.Name = "exporterToolStripMenuItem";
            this.exporterToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.exporterToolStripMenuItem.Text = "Exporter";
            this.exporterToolStripMenuItem.Click += new System.EventHandler(this.exporterToolStripMenuItem_Click);
            // 
            // fermerToolStripMenuItem
            // 
            this.fermerToolStripMenuItem.Name = "fermerToolStripMenuItem";
            this.fermerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fermerToolStripMenuItem.Text = "Fermer";
            this.fermerToolStripMenuItem.Click += new System.EventHandler(this.fermerToolStripMenuItem_Click);
            // 
            // structure
            // 
            this.structure.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.familleToolStripMenuItem,
            this.materielToolStripMenuItem,
            this.depotsToolStripMenuItem});
            this.structure.ForeColor = System.Drawing.Color.White;
            this.structure.Name = "structure";
            this.structure.Size = new System.Drawing.Size(74, 21);
            this.structure.Text = "Structure";
            this.structure.MouseLeave += new System.EventHandler(this.structure_MouseLeave);
            this.structure.MouseHover += new System.EventHandler(this.structureToolStripMenuItem_MouseHover);
            // 
            // familleToolStripMenuItem
            // 
            this.familleToolStripMenuItem.Name = "familleToolStripMenuItem";
            this.familleToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.familleToolStripMenuItem.Text = "Familles";
            this.familleToolStripMenuItem.Click += new System.EventHandler(this.familleToolStripMenuItem_Click);
            // 
            // materielToolStripMenuItem
            // 
            this.materielToolStripMenuItem.Name = "materielToolStripMenuItem";
            this.materielToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.materielToolStripMenuItem.Text = "Materiels";
            this.materielToolStripMenuItem.Click += new System.EventHandler(this.materielToolStripMenuItem_Click);
            // 
            // depotsToolStripMenuItem
            // 
            this.depotsToolStripMenuItem.Name = "depotsToolStripMenuItem";
            this.depotsToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.depotsToolStripMenuItem.Text = "Depots";
            this.depotsToolStripMenuItem.Click += new System.EventHandler(this.depotsToolStripMenuItem_Click);
            // 
            // traitement
            // 
            this.traitement.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.documentsDeStockToolStripMenuItem,
            this.gestionDesHSToolStripMenuItem});
            this.traitement.ForeColor = System.Drawing.Color.White;
            this.traitement.Name = "traitement";
            this.traitement.Size = new System.Drawing.Size(83, 21);
            this.traitement.Text = "Traitement";
            this.traitement.MouseLeave += new System.EventHandler(this.traitement_MouseLeave);
            this.traitement.MouseHover += new System.EventHandler(this.traitement_MouseHover);
            // 
            // documentsDeStockToolStripMenuItem
            // 
            this.documentsDeStockToolStripMenuItem.Name = "documentsDeStockToolStripMenuItem";
            this.documentsDeStockToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.documentsDeStockToolStripMenuItem.Text = "Documents des Stocks";
            this.documentsDeStockToolStripMenuItem.Click += new System.EventHandler(this.documentsDeStockToolStripMenuItem_Click);
            // 
            // gestionDesHSToolStripMenuItem
            // 
            this.gestionDesHSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entreeHSToolStripMenuItem,
            this.sortieHSToolStripMenuItem});
            this.gestionDesHSToolStripMenuItem.Name = "gestionDesHSToolStripMenuItem";
            this.gestionDesHSToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.gestionDesHSToolStripMenuItem.Text = "Gestion des HS";
            // 
            // entreeHSToolStripMenuItem
            // 
            this.entreeHSToolStripMenuItem.Name = "entreeHSToolStripMenuItem";
            this.entreeHSToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.entreeHSToolStripMenuItem.Text = "Entree HS";
            this.entreeHSToolStripMenuItem.Click += new System.EventHandler(this.entreeHSToolStripMenuItem_Click);
            // 
            // sortieHSToolStripMenuItem
            // 
            this.sortieHSToolStripMenuItem.Name = "sortieHSToolStripMenuItem";
            this.sortieHSToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.sortieHSToolStripMenuItem.Text = "Sortie HS";
            this.sortieHSToolStripMenuItem.Click += new System.EventHandler(this.sortieHSToolStripMenuItem_Click);
            // 
            // etat
            // 
            this.etat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statistiquesMateriauxToolStripMenuItem,
            this.rupturesToolStripMenuItem});
            this.etat.ForeColor = System.Drawing.Color.White;
            this.etat.Name = "etat";
            this.etat.Size = new System.Drawing.Size(44, 21);
            this.etat.Text = "Etat";
            this.etat.MouseLeave += new System.EventHandler(this.etatToolStripMenuItem_MouseLeave);
            this.etat.MouseHover += new System.EventHandler(this.etatToolStripMenuItem_MouseHover);
            // 
            // statistiquesMateriauxToolStripMenuItem
            // 
            this.statistiquesMateriauxToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.parMaterielToolStripMenuItem,
            this.parFamillesToolStripMenuItem});
            this.statistiquesMateriauxToolStripMenuItem.Enabled = false;
            this.statistiquesMateriauxToolStripMenuItem.Name = "statistiquesMateriauxToolStripMenuItem";
            this.statistiquesMateriauxToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.statistiquesMateriauxToolStripMenuItem.Text = "Statistiques Materiaux";
            // 
            // parMaterielToolStripMenuItem
            // 
            this.parMaterielToolStripMenuItem.Name = "parMaterielToolStripMenuItem";
            this.parMaterielToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.parMaterielToolStripMenuItem.Text = "Par Materiaux";
            this.parMaterielToolStripMenuItem.Click += new System.EventHandler(this.parMaterielToolStripMenuItem_Click);
            // 
            // parFamillesToolStripMenuItem
            // 
            this.parFamillesToolStripMenuItem.Name = "parFamillesToolStripMenuItem";
            this.parFamillesToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.parFamillesToolStripMenuItem.Text = "Par Familles";
            // 
            // rupturesToolStripMenuItem
            // 
            this.rupturesToolStripMenuItem.Name = "rupturesToolStripMenuItem";
            this.rupturesToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.rupturesToolStripMenuItem.Text = "Gestion des Ruptures";
            this.rupturesToolStripMenuItem.Click += new System.EventHandler(this.rupturesToolStripMenuItem_Click);
            // 
            // aide
            // 
            this.aide.ForeColor = System.Drawing.Color.White;
            this.aide.Name = "aide";
            this.aide.Size = new System.Drawing.Size(48, 21);
            this.aide.Text = "Aide";
            this.aide.MouseLeave += new System.EventHandler(this.aide_MouseLeave);
            this.aide.MouseHover += new System.EventHandler(this.aide_MouseHover);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MegaStructure.Properties.Resources.Bagatelle_Valentina;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(888, 606);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mega Structure";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichier;
        private System.Windows.Forms.ToolStripMenuItem structure;
        private System.Windows.Forms.ToolStripMenuItem traitement;
        private System.Windows.Forms.ToolStripMenuItem aide;
        private System.Windows.Forms.ToolStripMenuItem fermerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem utilisateurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem familleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem materielToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem depotsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem etat;
        private System.Windows.Forms.ToolStripMenuItem documentsDeStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statistiquesMateriauxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parMaterielToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parFamillesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rupturesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connexion;
        private System.Windows.Forms.ToolStripMenuItem deconnexion;
        private System.Windows.Forms.ToolStripMenuItem gestionDesHSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entreeHSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortieHSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem outils;
        private System.Windows.Forms.ToolStripMenuItem sauvegarderLaBaseDeDonneesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restorerLaBaseDeDonneesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exporterToolStripMenuItem;
    }
}

