namespace BenouKaiss_Morax_IHM
{
    partial class ValueExplorer
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
            this.Decription = new System.Windows.Forms.Label();
            this.annuler = new System.Windows.Forms.Button();
            this.ok = new System.Windows.Forms.Button();
            this.nom = new System.Windows.Forms.Label();
            this.moinsCinq = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.plusCinq = new System.Windows.Forms.Button();
            this.champValeur = new System.Windows.Forms.NumericUpDown();
            this.historique = new System.Windows.Forms.Button();
            this.listeValeursAffectées = new System.Windows.Forms.ListBox();
            this.titreEffets = new System.Windows.Forms.Label();
            this.financesTexte = new System.Windows.Forms.Label();
            this.gloireTexte = new System.Windows.Forms.Label();
            this.financesValeur = new System.Windows.Forms.Label();
            this.gloireValeur = new System.Windows.Forms.Label();
            this.titreValeursAffectées = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.champValeur)).BeginInit();
            this.SuspendLayout();
            // 
            // Decription
            // 
            this.Decription.Location = new System.Drawing.Point(9, 48);
            this.Decription.Name = "Decription";
            this.Decription.Size = new System.Drawing.Size(311, 95);
            this.Decription.TabIndex = 0;
            this.Decription.Text = "?";
            // 
            // annuler
            // 
            this.annuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.annuler.Location = new System.Drawing.Point(23, 225);
            this.annuler.Name = "annuler";
            this.annuler.Size = new System.Drawing.Size(75, 23);
            this.annuler.TabIndex = 4;
            this.annuler.Text = "Annuler";
            this.annuler.UseVisualStyleBackColor = true;
            // 
            // ok
            // 
            this.ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ok.Location = new System.Drawing.Point(235, 225);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(75, 23);
            this.ok.TabIndex = 5;
            this.ok.Text = "OK";
            this.ok.UseVisualStyleBackColor = true;
            // 
            // nom
            // 
            this.nom.AutoSize = true;
            this.nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nom.Location = new System.Drawing.Point(21, 17);
            this.nom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(20, 24);
            this.nom.TabIndex = 6;
            this.nom.Text = "?";
            // 
            // moinsCinq
            // 
            this.moinsCinq.Location = new System.Drawing.Point(115, 180);
            this.moinsCinq.Name = "moinsCinq";
            this.moinsCinq.Size = new System.Drawing.Size(27, 22);
            this.moinsCinq.TabIndex = 7;
            this.moinsCinq.Text = "-5";
            this.moinsCinq.UseVisualStyleBackColor = true;
            this.moinsCinq.Click += new System.EventHandler(this.moinsCinq_Click);
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(147, 181);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(38, 22);
            this.reset.TabIndex = 9;
            this.reset.Text = "?";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // plusCinq
            // 
            this.plusCinq.Location = new System.Drawing.Point(191, 180);
            this.plusCinq.Name = "plusCinq";
            this.plusCinq.Size = new System.Drawing.Size(27, 22);
            this.plusCinq.TabIndex = 10;
            this.plusCinq.Text = "+5";
            this.plusCinq.UseVisualStyleBackColor = true;
            this.plusCinq.Click += new System.EventHandler(this.plusCinq_Click);
            // 
            // champValeur
            // 
            this.champValeur.Location = new System.Drawing.Point(115, 157);
            this.champValeur.Name = "champValeur";
            this.champValeur.Size = new System.Drawing.Size(102, 20);
            this.champValeur.TabIndex = 11;
            this.champValeur.ValueChanged += new System.EventHandler(this.champValeur_ValueChanged);
            // 
            // historique
            // 
            this.historique.Location = new System.Drawing.Point(142, 225);
            this.historique.Margin = new System.Windows.Forms.Padding(2);
            this.historique.Name = "historique";
            this.historique.Size = new System.Drawing.Size(75, 23);
            this.historique.TabIndex = 12;
            this.historique.Text = "Historique";
            this.historique.UseVisualStyleBackColor = true;
            this.historique.Click += new System.EventHandler(this.historique_Click);
            // 
            // listeValeursAffectées
            // 
            this.listeValeursAffectées.FormattingEnabled = true;
            this.listeValeursAffectées.Location = new System.Drawing.Point(326, 39);
            this.listeValeursAffectées.Name = "listeValeursAffectées";
            this.listeValeursAffectées.Size = new System.Drawing.Size(143, 108);
            this.listeValeursAffectées.TabIndex = 13;
            // 
            // titreEffets
            // 
            this.titreEffets.AutoSize = true;
            this.titreEffets.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titreEffets.Location = new System.Drawing.Point(326, 157);
            this.titreEffets.Name = "titreEffets";
            this.titreEffets.Size = new System.Drawing.Size(111, 20);
            this.titreEffets.TabIndex = 14;
            this.titreEffets.Text = "Effets par tour";
            // 
            // financesTexte
            // 
            this.financesTexte.AutoSize = true;
            this.financesTexte.Location = new System.Drawing.Point(340, 191);
            this.financesTexte.Name = "financesTexte";
            this.financesTexte.Size = new System.Drawing.Size(59, 13);
            this.financesTexte.TabIndex = 15;
            this.financesTexte.Text = "Finances : ";
            // 
            // gloireTexte
            // 
            this.gloireTexte.AutoSize = true;
            this.gloireTexte.Location = new System.Drawing.Point(340, 216);
            this.gloireTexte.Name = "gloireTexte";
            this.gloireTexte.Size = new System.Drawing.Size(43, 13);
            this.gloireTexte.TabIndex = 16;
            this.gloireTexte.Text = "Gloire : ";
            // 
            // financesValeur
            // 
            this.financesValeur.AutoSize = true;
            this.financesValeur.Location = new System.Drawing.Point(393, 191);
            this.financesValeur.Name = "financesValeur";
            this.financesValeur.Size = new System.Drawing.Size(13, 13);
            this.financesValeur.TabIndex = 17;
            this.financesValeur.Text = "?";
            // 
            // gloireValeur
            // 
            this.gloireValeur.AutoSize = true;
            this.gloireValeur.Location = new System.Drawing.Point(377, 216);
            this.gloireValeur.Name = "gloireValeur";
            this.gloireValeur.Size = new System.Drawing.Size(13, 13);
            this.gloireValeur.TabIndex = 18;
            this.gloireValeur.Text = "?";
            // 
            // titreValeursAffectées
            // 
            this.titreValeursAffectées.AutoSize = true;
            this.titreValeursAffectées.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titreValeursAffectées.Location = new System.Drawing.Point(326, 13);
            this.titreValeursAffectées.Name = "titreValeursAffectées";
            this.titreValeursAffectées.Size = new System.Drawing.Size(134, 20);
            this.titreValeursAffectées.TabIndex = 19;
            this.titreValeursAffectées.Text = "Valeurs affectées";
            // 
            // ValueExplorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 263);
            this.Controls.Add(this.titreValeursAffectées);
            this.Controls.Add(this.gloireValeur);
            this.Controls.Add(this.financesValeur);
            this.Controls.Add(this.gloireTexte);
            this.Controls.Add(this.financesTexte);
            this.Controls.Add(this.titreEffets);
            this.Controls.Add(this.listeValeursAffectées);
            this.Controls.Add(this.historique);
            this.Controls.Add(this.champValeur);
            this.Controls.Add(this.plusCinq);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.moinsCinq);
            this.Controls.Add(this.nom);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.annuler);
            this.Controls.Add(this.Decription);
            this.Name = "ValueExplorer";
            this.Text = "ValueExplorer";
            ((System.ComponentModel.ISupportInitialize)(this.champValeur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Decription;
        private System.Windows.Forms.Button annuler;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.Label nom;
        private System.Windows.Forms.Button moinsCinq;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button plusCinq;
        private System.Windows.Forms.NumericUpDown champValeur;
        private System.Windows.Forms.Button historique;
        private System.Windows.Forms.ListBox listeValeursAffectées;
        private System.Windows.Forms.Label titreEffets;
        private System.Windows.Forms.Label financesTexte;
        private System.Windows.Forms.Label gloireTexte;
        private System.Windows.Forms.Label financesValeur;
        private System.Windows.Forms.Label gloireValeur;
        private System.Windows.Forms.Label titreValeursAffectées;
    }
}