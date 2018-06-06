namespace BenouKaiss_Morax_IHM {
    partial class MainWindow {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.tourTexte = new System.Windows.Forms.ToolStripLabel();
            this.tourValeur = new System.Windows.Forms.ToolStripLabel();
            this.financesTexte = new System.Windows.Forms.ToolStripLabel();
            this.financesValeur = new System.Windows.Forms.ToolStripLabel();
            this.gloireTexte = new System.Windows.Forms.ToolStripLabel();
            this.gloireValeur = new System.Windows.Forms.ToolStripLabel();
            this.tourSuivant = new System.Windows.Forms.ToolStripButton();
            this.informations = new System.Windows.Forms.ToolStrip();
            this.separateur = new System.Windows.Forms.ToolStripSeparator();
            this.grid = new System.Windows.Forms.TableLayoutPanel();
            this.beneficesProblemes = new System.Windows.Forms.ListBox();
            this.politiquesActives = new System.Windows.Forms.ListBox();
            this.groupes = new System.Windows.Forms.ListBox();
            this.politiquesDisponibles = new System.Windows.Forms.ListBox();
            this.idk = new System.Windows.Forms.GroupBox();
            this.quitter = new System.Windows.Forms.Button();
            this.historique = new System.Windows.Forms.Button();
            this.indicateurs = new System.Windows.Forms.FlowLayoutPanel();
            this.informations.SuspendLayout();
            this.grid.SuspendLayout();
            this.idk.SuspendLayout();
            this.SuspendLayout();
            // 
            // tourTexte
            // 
            this.tourTexte.Name = "tourTexte";
            this.tourTexte.Size = new System.Drawing.Size(102, 22);
            this.tourTexte.Text = "Numéro du tour : ";
            // 
            // tourValeur
            // 
            this.tourValeur.Name = "tourValeur";
            this.tourValeur.Size = new System.Drawing.Size(12, 22);
            this.tourValeur.Text = "?";
            this.tourValeur.Click += new System.EventHandler(this.numéroTour_Click);
            // 
            // financesTexte
            // 
            this.financesTexte.Name = "financesTexte";
            this.financesTexte.Size = new System.Drawing.Size(62, 22);
            this.financesTexte.Text = "Finances : ";
            // 
            // financesValeur
            // 
            this.financesValeur.Name = "financesValeur";
            this.financesValeur.Size = new System.Drawing.Size(12, 22);
            this.financesValeur.Text = "?";
            // 
            // gloireTexte
            // 
            this.gloireTexte.Name = "gloireTexte";
            this.gloireTexte.Size = new System.Drawing.Size(47, 22);
            this.gloireTexte.Text = "Gloire : ";
            // 
            // gloireValeur
            // 
            this.gloireValeur.Name = "gloireValeur";
            this.gloireValeur.Size = new System.Drawing.Size(12, 22);
            this.gloireValeur.Text = "?";
            this.gloireValeur.Click += new System.EventHandler(this.gloire_Click);
            // 
            // tourSuivant
            // 
            this.tourSuivant.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tourSuivant.Image = ((System.Drawing.Image)(resources.GetObject("tourSuivant.Image")));
            this.tourSuivant.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tourSuivant.Name = "tourSuivant";
            this.tourSuivant.Size = new System.Drawing.Size(76, 22);
            this.tourSuivant.Text = "Tour suivant";
            this.tourSuivant.Click += new System.EventHandler(this.tourSuivant_Click);
            // 
            // informations
            // 
            this.informations.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tourTexte,
            this.tourValeur,
            this.financesTexte,
            this.financesValeur,
            this.gloireTexte,
            this.gloireValeur,
            this.separateur,
            this.tourSuivant});
            this.informations.Location = new System.Drawing.Point(0, 0);
            this.informations.Name = "informations";
            this.informations.Size = new System.Drawing.Size(1429, 25);
            this.informations.TabIndex = 0;
            this.informations.Text = "toolStrip1";
            // 
            // separateur
            // 
            this.separateur.Name = "separateur";
            this.separateur.Size = new System.Drawing.Size(6, 25);
            // 
            // grid
            // 
            this.grid.ColumnCount = 4;
            this.grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.67F));
            this.grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.67F));
            this.grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.grid.Controls.Add(this.beneficesProblemes, 0, 0);
            this.grid.Controls.Add(this.politiquesActives, 0, 2);
            this.grid.Controls.Add(this.groupes, 1, 1);
            this.grid.Controls.Add(this.politiquesDisponibles, 2, 2);
            this.grid.Controls.Add(this.idk, 3, 1);
            this.grid.Controls.Add(this.indicateurs, 0, 1);
            this.grid.Location = new System.Drawing.Point(12, 28);
            this.grid.Name = "grid";
            this.grid.RowCount = 3;
            this.grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33111F));
            this.grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33778F));
            this.grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33111F));
            this.grid.Size = new System.Drawing.Size(1405, 515);
            this.grid.TabIndex = 1;
            // 
            // beneficesProblemes
            // 
            this.grid.SetColumnSpan(this.beneficesProblemes, 4);
            this.beneficesProblemes.FormattingEnabled = true;
            this.beneficesProblemes.Location = new System.Drawing.Point(3, 3);
            this.beneficesProblemes.Name = "beneficesProblemes";
            this.beneficesProblemes.Size = new System.Drawing.Size(1399, 160);
            this.beneficesProblemes.TabIndex = 0;
            // 
            // politiquesActives
            // 
            this.grid.SetColumnSpan(this.politiquesActives, 2);
            this.politiquesActives.FormattingEnabled = true;
            this.politiquesActives.Location = new System.Drawing.Point(3, 345);
            this.politiquesActives.Name = "politiquesActives";
            this.politiquesActives.Size = new System.Drawing.Size(696, 160);
            this.politiquesActives.TabIndex = 1;
            // 
            // groupes
            // 
            this.grid.SetColumnSpan(this.groupes, 2);
            this.groupes.FormattingEnabled = true;
            this.groupes.Location = new System.Drawing.Point(471, 174);
            this.groupes.Name = "groupes";
            this.groupes.Size = new System.Drawing.Size(462, 160);
            this.groupes.TabIndex = 4;
            // 
            // politiquesDisponibles
            // 
            this.grid.SetColumnSpan(this.politiquesDisponibles, 2);
            this.politiquesDisponibles.FormattingEnabled = true;
            this.politiquesDisponibles.Location = new System.Drawing.Point(705, 345);
            this.politiquesDisponibles.Name = "politiquesDisponibles";
            this.politiquesDisponibles.Size = new System.Drawing.Size(697, 160);
            this.politiquesDisponibles.TabIndex = 5;
            // 
            // idk
            // 
            this.idk.Controls.Add(this.quitter);
            this.idk.Controls.Add(this.historique);
            this.idk.Location = new System.Drawing.Point(939, 174);
            this.idk.Name = "idk";
            this.idk.Size = new System.Drawing.Size(463, 165);
            this.idk.TabIndex = 6;
            this.idk.TabStop = false;
            this.idk.Text = "idk";
            // 
            // quitter
            // 
            this.quitter.Location = new System.Drawing.Point(382, 136);
            this.quitter.Name = "quitter";
            this.quitter.Size = new System.Drawing.Size(75, 23);
            this.quitter.TabIndex = 1;
            this.quitter.Text = "Quitter";
            this.quitter.UseVisualStyleBackColor = true;
            this.quitter.Click += new System.EventHandler(this.quitter_Click);
            // 
            // historique
            // 
            this.historique.Location = new System.Drawing.Point(6, 136);
            this.historique.Name = "historique";
            this.historique.Size = new System.Drawing.Size(75, 23);
            this.historique.TabIndex = 0;
            this.historique.Text = "Historique";
            this.historique.UseVisualStyleBackColor = true;
            // 
            // indicateurs
            // 
            this.indicateurs.Location = new System.Drawing.Point(3, 174);
            this.indicateurs.Name = "indicateurs";
            this.indicateurs.Size = new System.Drawing.Size(462, 165);
            this.indicateurs.TabIndex = 7;
            this.indicateurs.AutoScroll = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1429, 555);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.informations);
            this.DoubleBuffered = true;
            this.Name = "MainWindow";
            this.Text = "Kyriù";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.informations.ResumeLayout(false);
            this.informations.PerformLayout();
            this.grid.ResumeLayout(false);
            this.idk.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripLabel tourTexte;
        private System.Windows.Forms.ToolStripLabel tourValeur;
        private System.Windows.Forms.ToolStripLabel financesTexte;
        private System.Windows.Forms.ToolStripLabel financesValeur;
        private System.Windows.Forms.ToolStripLabel gloireTexte;
        private System.Windows.Forms.ToolStripLabel gloireValeur;
        private System.Windows.Forms.ToolStripButton tourSuivant;
        private System.Windows.Forms.ToolStrip informations;
        private System.Windows.Forms.ToolStripSeparator separateur;
        private System.Windows.Forms.TableLayoutPanel grid;
        private System.Windows.Forms.ListBox beneficesProblemes;
        private System.Windows.Forms.ListBox politiquesActives;
        private System.Windows.Forms.ListBox groupes;
        private System.Windows.Forms.ListBox politiquesDisponibles;
        private System.Windows.Forms.GroupBox idk;
        private System.Windows.Forms.Button quitter;
        private System.Windows.Forms.Button historique;
        private System.Windows.Forms.FlowLayoutPanel indicateurs;
    }
}

