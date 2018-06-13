using System;

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
            this.informations = new System.Windows.Forms.ToolStrip();
            this.tourTexte = new System.Windows.Forms.ToolStripLabel();
            this.tourValeur = new System.Windows.Forms.ToolStripLabel();
            this.financesTexte = new System.Windows.Forms.ToolStripLabel();
            this.financesValeur = new System.Windows.Forms.ToolStripLabel();
            this.gloireTexte = new System.Windows.Forms.ToolStripLabel();
            this.gloireValeur = new System.Windows.Forms.ToolStripLabel();
            this.separateur = new System.Windows.Forms.ToolStripSeparator();
            this.tourSuivant = new System.Windows.Forms.ToolStripButton();
            this.grid = new System.Windows.Forms.TableLayoutPanel();
            this.indicateursBox = new System.Windows.Forms.GroupBox();
            this.indicateurs = new System.Windows.Forms.FlowLayoutPanel();
            this.beneficesProblemesBox = new System.Windows.Forms.GroupBox();
            this.beneficesProblemes = new System.Windows.Forms.FlowLayoutPanel();
            this.politiques = new System.Windows.Forms.FlowLayoutPanel();
            this.Grou = new System.Windows.Forms.GroupBox();
            this.groupes = new System.Windows.Forms.FlowLayoutPanel();
            this.informations.SuspendLayout();
            this.grid.SuspendLayout();
            this.indicateursBox.SuspendLayout();
            this.beneficesProblemesBox.SuspendLayout();
            this.Grou.SuspendLayout();
            this.SuspendLayout();
            // 
            // informations
            // 
            this.informations.Dock = System.Windows.Forms.DockStyle.None;
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
            this.informations.Size = new System.Drawing.Size(342, 25);
            this.informations.TabIndex = 0;
            this.informations.Text = "toolStrip1";
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
            // separateur
            // 
            this.separateur.Name = "separateur";
            this.separateur.Size = new System.Drawing.Size(6, 25);
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
            // grid
            // 
            this.grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid.AutoSize = true;
            this.grid.ColumnCount = 2;
            this.grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 509F));
            this.grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.grid.Controls.Add(this.indicateursBox, 0, 1);
            this.grid.Controls.Add(this.beneficesProblemesBox, 0, 0);
            this.grid.Controls.Add(this.politiques, 0, 2);
            this.grid.Controls.Add(this.Grou, 1, 1);
            this.grid.Location = new System.Drawing.Point(13, 46);
            this.grid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grid.Name = "grid";
            this.grid.RowCount = 3;
            this.grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 171F));
            this.grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 115F));
            this.grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.grid.Size = new System.Drawing.Size(711, 463);
            this.grid.TabIndex = 1;
            // 
            // indicateursBox
            // 
            this.indicateursBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.indicateursBox.Controls.Add(this.indicateurs);
            this.indicateursBox.Location = new System.Drawing.Point(4, 176);
            this.indicateursBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.indicateursBox.Name = "indicateursBox";
            this.indicateursBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.indicateursBox.Size = new System.Drawing.Size(501, 105);
            this.indicateursBox.TabIndex = 9;
            this.indicateursBox.TabStop = false;
            this.indicateursBox.Text = "Indicateurs";
            // 
            // indicateurs
            // 
            this.indicateurs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.indicateurs.Location = new System.Drawing.Point(6, 19);
            this.indicateurs.Name = "indicateurs";
            this.indicateurs.Size = new System.Drawing.Size(483, 77);
            this.indicateurs.TabIndex = 8;
            // 
            // beneficesProblemesBox
            // 
            this.beneficesProblemesBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid.SetColumnSpan(this.beneficesProblemesBox, 2);
            this.beneficesProblemesBox.Controls.Add(this.beneficesProblemes);
            this.beneficesProblemesBox.Location = new System.Drawing.Point(3, 3);
            this.beneficesProblemesBox.Name = "beneficesProblemesBox";
            this.beneficesProblemesBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.beneficesProblemesBox.Size = new System.Drawing.Size(705, 165);
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
            this.beneficesProblemes.Location = new System.Drawing.Point(6, 19);
            this.beneficesProblemes.Name = "beneficesProblemes";
            this.beneficesProblemes.Size = new System.Drawing.Size(692, 126);
            this.beneficesProblemes.TabIndex = 0;
            // 
            // politiques
            // 
            this.politiques.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.politiques.AutoScroll = true;
            this.grid.SetColumnSpan(this.politiques, 2);
            this.politiques.Location = new System.Drawing.Point(3, 296);
            this.politiques.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.politiques.Name = "politiques";
            this.politiques.Size = new System.Drawing.Size(705, 164);
            this.politiques.TabIndex = 12;
            // 
            // Grou
            // 
            this.Grou.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Grou.Controls.Add(this.groupes);
            this.Grou.Location = new System.Drawing.Point(511, 173);
            this.Grou.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Grou.Name = "Grou";
            this.Grou.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Grou.Size = new System.Drawing.Size(198, 111);
            this.Grou.TabIndex = 13;
            this.Grou.TabStop = false;
            this.Grou.Text = "Groupes";
            // 
            // groupes
            // 
            this.groupes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupes.Location = new System.Drawing.Point(11, 22);
            this.groupes.Name = "groupes";
            this.groupes.Size = new System.Drawing.Size(182, 77);
            this.groupes.TabIndex = 13;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 520);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.informations);
            this.DoubleBuffered = true;
            this.Name = "MainWindow";
            this.Text = "Kyriù";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainWindow_Paint);
            this.informations.ResumeLayout(false);
            this.informations.PerformLayout();
            this.grid.ResumeLayout(false);
            this.indicateursBox.ResumeLayout(false);
            this.beneficesProblemesBox.ResumeLayout(false);
            this.Grou.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.ToolStrip informations;
        private System.Windows.Forms.ToolStripLabel tourTexte;
        private System.Windows.Forms.ToolStripLabel tourValeur;
        private System.Windows.Forms.ToolStripLabel financesTexte;
        private System.Windows.Forms.ToolStripLabel financesValeur;
        private System.Windows.Forms.ToolStripLabel gloireTexte;
        private System.Windows.Forms.ToolStripLabel gloireValeur;
        private System.Windows.Forms.ToolStripSeparator separateur;
        private System.Windows.Forms.ToolStripButton tourSuivant;
        private System.Windows.Forms.TableLayoutPanel grid;
        private System.Windows.Forms.GroupBox indicateursBox;
        private System.Windows.Forms.FlowLayoutPanel indicateurs;
        private System.Windows.Forms.GroupBox beneficesProblemesBox;
        private System.Windows.Forms.FlowLayoutPanel beneficesProblemes;
        private System.Windows.Forms.FlowLayoutPanel politiques;
        private System.Windows.Forms.GroupBox Grou;
        private System.Windows.Forms.FlowLayoutPanel groupes;
    }
}

