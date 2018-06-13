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
            ((System.ComponentModel.ISupportInitialize)(this.champValeur)).BeginInit();
            this.SuspendLayout();
            // 
            // Decription
            // 
            this.Decription.Location = new System.Drawing.Point(13, 74);
            this.Decription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Decription.Name = "Decription";
            this.Decription.Size = new System.Drawing.Size(466, 146);
            this.Decription.TabIndex = 0;
            this.Decription.Text = "?";
            // 
            // annuler
            // 
            this.annuler.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.annuler.Location = new System.Drawing.Point(34, 346);
            this.annuler.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.annuler.Name = "annuler";
            this.annuler.Size = new System.Drawing.Size(112, 35);
            this.annuler.TabIndex = 4;
            this.annuler.Text = "Annuler";
            this.annuler.UseVisualStyleBackColor = true;
            // 
            // ok
            // 
            this.ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ok.Location = new System.Drawing.Point(352, 346);
            this.ok.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(112, 35);
            this.ok.TabIndex = 5;
            this.ok.Text = "OK";
            this.ok.UseVisualStyleBackColor = true;
            // 
            // nom
            // 
            this.nom.AutoSize = true;
            this.nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nom.Location = new System.Drawing.Point(32, 26);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(31, 32);
            this.nom.TabIndex = 6;
            this.nom.Text = "?";
            // 
            // moinsCinq
            // 
            this.moinsCinq.Location = new System.Drawing.Point(173, 277);
            this.moinsCinq.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.moinsCinq.Name = "moinsCinq";
            this.moinsCinq.Size = new System.Drawing.Size(40, 34);
            this.moinsCinq.TabIndex = 7;
            this.moinsCinq.Text = "-5";
            this.moinsCinq.UseVisualStyleBackColor = true;
            this.moinsCinq.Click += new System.EventHandler(this.moinsCinq_Click);
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(221, 278);
            this.reset.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(57, 34);
            this.reset.TabIndex = 9;
            this.reset.Text = "?";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // plusCinq
            // 
            this.plusCinq.Location = new System.Drawing.Point(286, 277);
            this.plusCinq.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.plusCinq.Name = "plusCinq";
            this.plusCinq.Size = new System.Drawing.Size(40, 34);
            this.plusCinq.TabIndex = 10;
            this.plusCinq.Text = "+5";
            this.plusCinq.UseVisualStyleBackColor = true;
            this.plusCinq.Click += new System.EventHandler(this.plusCinq_Click);
            // 
            // champValeur
            // 
            this.champValeur.Location = new System.Drawing.Point(173, 242);
            this.champValeur.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.champValeur.Name = "champValeur";
            this.champValeur.Size = new System.Drawing.Size(153, 26);
            this.champValeur.TabIndex = 11;
            this.champValeur.ValueChanged += new System.EventHandler(this.champValeur_ValueChanged);
            // 
            // historique
            // 
            this.historique.Location = new System.Drawing.Point(213, 346);
            this.historique.Name = "historique";
            this.historique.Size = new System.Drawing.Size(113, 35);
            this.historique.TabIndex = 12;
            this.historique.Text = "Historique";
            this.historique.UseVisualStyleBackColor = true;
            this.historique.Click += new System.EventHandler(this.historique_Click);
            // 
            // ValueExplorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 405);
            this.Controls.Add(this.historique);
            this.Controls.Add(this.champValeur);
            this.Controls.Add(this.plusCinq);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.moinsCinq);
            this.Controls.Add(this.nom);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.annuler);
            this.Controls.Add(this.Decription);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
    }
}