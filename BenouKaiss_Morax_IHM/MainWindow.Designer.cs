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
            this.groupes = new System.Windows.Forms.ListBox();
            this.idk = new System.Windows.Forms.GroupBox();
            this.quitter = new System.Windows.Forms.Button();
            this.historique = new System.Windows.Forms.Button();
            this.politiques = new System.Windows.Forms.FlowLayoutPanel();
            this.indicateursBox = new System.Windows.Forms.GroupBox();
            this.indicateurs = new System.Windows.Forms.FlowLayoutPanel();
            this.beneficesProblemesBox = new System.Windows.Forms.GroupBox();
            this.beneficesProblemes = new System.Windows.Forms.FlowLayoutPanel();
            this.informations.SuspendLayout();
            this.grid.SuspendLayout();
            this.idk.SuspendLayout();
            this.indicateursBox.SuspendLayout();
            this.beneficesProblemesBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // tourTexte
            // 
            this.tourTexte.Name = "tourTexte";
            this.tourTexte.Size = new System.Drawing.Size(155, 29);
            this.tourTexte.Text = "Numéro du tour : ";
            // 
            // tourValeur
            // 
            this.tourValeur.Name = "tourValeur";
            this.tourValeur.Size = new System.Drawing.Size(20, 29);
            this.tourValeur.Text = "?";
            this.tourValeur.Click += new System.EventHandler(this.numéroTour_Click);
            // 
            // financesTexte
            // 
            this.financesTexte.Name = "financesTexte";
            this.financesTexte.Size = new System.Drawing.Size(93, 29);
            this.financesTexte.Text = "Finances : ";
            // 
            // financesValeur
            // 
            this.financesValeur.Name = "financesValeur";
            this.financesValeur.Size = new System.Drawing.Size(20, 29);
            this.financesValeur.Text = "?";
            // 
            // gloireTexte
            // 
            this.gloireTexte.Name = "gloireTexte";
            this.gloireTexte.Size = new System.Drawing.Size(72, 29);
            this.gloireTexte.Text = "Gloire : ";
            // 
            // gloireValeur
            // 
            this.gloireValeur.Name = "gloireValeur";
            this.gloireValeur.Size = new System.Drawing.Size(20, 29);
            this.gloireValeur.Text = "?";
            this.gloireValeur.Click += new System.EventHandler(this.gloire_Click);
            // 
            // tourSuivant
            // 
            this.tourSuivant.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tourSuivant.Image = ((System.Drawing.Image)(resources.GetObject("tourSuivant.Image")));
            this.tourSuivant.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tourSuivant.Name = "tourSuivant";
            this.tourSuivant.Size = new System.Drawing.Size(111, 29);
            this.tourSuivant.Text = "Tour suivant";
            this.tourSuivant.Click += new System.EventHandler(this.tourSuivant_Click);
            // 
            // informations
            // 
            this.informations.ImageScalingSize = new System.Drawing.Size(24, 24);
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
            this.informations.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.informations.Size = new System.Drawing.Size(993, 32);
            this.informations.TabIndex = 0;
            this.informations.Text = "toolStrip1";
            // 
            // separateur
            // 
            this.separateur.Name = "separateur";
            this.separateur.Size = new System.Drawing.Size(6, 32);
            // 
            // grid
            // 
            this.grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid.AutoSize = true;
            this.grid.ColumnCount = 3;
            this.grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.grid.Controls.Add(this.groupes, 1, 1);
            this.grid.Controls.Add(this.idk, 2, 1);
            this.grid.Controls.Add(this.politiques, 0, 2);
            this.grid.Controls.Add(this.indicateursBox, 0, 1);
            this.grid.Controls.Add(this.beneficesProblemesBox, 0, 0);
            this.grid.Location = new System.Drawing.Point(13, 46);
            this.grid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grid.Name = "grid";
            this.grid.RowCount = 3;
            this.grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.grid.Size = new System.Drawing.Size(980, 379);
            this.grid.TabIndex = 1;
            // 
            // groupes
            // 
            this.groupes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupes.FormattingEnabled = true;
            this.groupes.ItemHeight = 20;
            this.groupes.Location = new System.Drawing.Point(330, 99);
            this.groupes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupes.Name = "groupes";
            this.groupes.Size = new System.Drawing.Size(318, 84);
            this.groupes.TabIndex = 4;
            // 
            // idk
            // 
            this.idk.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.idk.Controls.Add(this.quitter);
            this.idk.Controls.Add(this.historique);
            this.idk.Location = new System.Drawing.Point(656, 99);
            this.idk.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.idk.Name = "idk";
            this.idk.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.idk.Size = new System.Drawing.Size(320, 84);
            this.idk.TabIndex = 6;
            this.idk.TabStop = false;
            this.idk.Text = "idk";
            // 
            // quitter
            // 
            this.quitter.Location = new System.Drawing.Point(263, 186);
            this.quitter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.quitter.Name = "quitter";
            this.quitter.Size = new System.Drawing.Size(112, 35);
            this.quitter.TabIndex = 1;
            this.quitter.Text = "Quitter";
            this.quitter.UseVisualStyleBackColor = true;
            this.quitter.Click += new System.EventHandler(this.quitter_Click);
            // 
            // historique
            // 
            this.historique.Location = new System.Drawing.Point(9, 183);
            this.historique.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.historique.Name = "historique";
            this.historique.Size = new System.Drawing.Size(112, 35);
            this.historique.TabIndex = 0;
            this.historique.Text = "Historique";
            this.historique.UseVisualStyleBackColor = true;
            // 
            // politiques
            // 
            this.politiques.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.politiques.AutoScroll = true;
            this.grid.SetColumnSpan(this.politiques, 3);
            this.politiques.Location = new System.Drawing.Point(4, 203);
            this.politiques.Margin = new System.Windows.Forms.Padding(4, 15, 4, 5);
            this.politiques.Name = "politiques";
            this.politiques.Size = new System.Drawing.Size(972, 171);
            this.politiques.TabIndex = 8;
            // 
            // indicateursBox
            // 
            this.indicateursBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.indicateursBox.Controls.Add(this.indicateurs);
            this.indicateursBox.Location = new System.Drawing.Point(4, 99);
            this.indicateursBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.indicateursBox.Name = "indicateursBox";
            this.indicateursBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.indicateursBox.Size = new System.Drawing.Size(318, 84);
            this.indicateursBox.TabIndex = 9;
            this.indicateursBox.TabStop = false;
            this.indicateursBox.Text = "Indicateurs";
            // 
            // indicateurs
            // 
            this.indicateurs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.indicateurs.AutoScroll = true;
            this.indicateurs.Location = new System.Drawing.Point(9, 29);
            this.indicateurs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.indicateurs.Name = "indicateurs";
            this.indicateurs.Size = new System.Drawing.Size(300, 45);
            this.indicateurs.TabIndex = 8;
            // 
            // beneficesProblemesBox
            // 
            this.beneficesProblemesBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid.SetColumnSpan(this.beneficesProblemesBox, 3);
            this.beneficesProblemesBox.Controls.Add(this.beneficesProblemes);
            this.beneficesProblemesBox.Location = new System.Drawing.Point(4, 5);
            this.beneficesProblemesBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.beneficesProblemesBox.Name = "beneficesProblemesBox";
            this.beneficesProblemesBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.beneficesProblemesBox.Size = new System.Drawing.Size(972, 84);
            this.beneficesProblemesBox.TabIndex = 10;
            this.beneficesProblemesBox.TabStop = false;
            this.beneficesProblemesBox.Text = "Bénéfices et problèmes";
            // 
            // beneficesProblemes
            // 
            this.beneficesProblemes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.beneficesProblemes.AutoScroll = true;
            this.beneficesProblemes.Location = new System.Drawing.Point(9, 29);
            this.beneficesProblemes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.beneficesProblemes.Name = "beneficesProblemes";
            this.beneficesProblemes.Size = new System.Drawing.Size(950, 45);
            this.beneficesProblemes.TabIndex = 0;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 439);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.informations);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainWindow";
            this.Text = "Kyriù";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.informations.ResumeLayout(false);
            this.informations.PerformLayout();
            this.grid.ResumeLayout(false);
            this.idk.ResumeLayout(false);
            this.indicateursBox.ResumeLayout(false);
            this.beneficesProblemesBox.ResumeLayout(false);
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
        private System.Windows.Forms.ListBox groupes;
        private System.Windows.Forms.GroupBox idk;
        private System.Windows.Forms.Button quitter;
        private System.Windows.Forms.Button historique;
        private System.Windows.Forms.FlowLayoutPanel politiques;
        private System.Windows.Forms.GroupBox indicateursBox;
        private System.Windows.Forms.FlowLayoutPanel indicateurs;
        private System.Windows.Forms.GroupBox beneficesProblemesBox;
        private System.Windows.Forms.FlowLayoutPanel beneficesProblemes;
    }
}

