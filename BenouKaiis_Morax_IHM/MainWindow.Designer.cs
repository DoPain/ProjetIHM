namespace BenouKaiis_Morax_IHM
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.label1 = new System.Windows.Forms.ToolStripLabel();
            this.numéroTour = new System.Windows.Forms.ToolStripLabel();
            this.label2 = new System.Windows.Forms.ToolStripLabel();
            this.finances = new System.Windows.Forms.ToolStripLabel();
            this.label3 = new System.Windows.Forms.ToolStripLabel();
            this.gloire = new System.Windows.Forms.ToolStripLabel();
            this.tourSuivant = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.label1,
            this.numéroTour,
            this.label2,
            this.finances,
            this.label3,
            this.gloire,
            this.tourSuivant});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1541, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // label1
            // 
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 22);
            this.label1.Text = "Numéro du tour : ";
            // 
            // numéroTour
            // 
            this.numéroTour.Name = "numéroTour";
            this.numéroTour.Size = new System.Drawing.Size(86, 22);
            this.numéroTour.Text = "toolStripLabel1";
            // 
            // label2
            // 
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 22);
            this.label2.Text = "Finances : ";
            // 
            // finances
            // 
            this.finances.Name = "finances";
            this.finances.Size = new System.Drawing.Size(86, 22);
            this.finances.Text = "toolStripLabel2";
            // 
            // label3
            // 
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 22);
            this.label3.Text = "Gloire : ";
            // 
            // gloire
            // 
            this.gloire.Name = "gloire";
            this.gloire.Size = new System.Drawing.Size(86, 22);
            this.gloire.Text = "toolStripLabel3";
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
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1541, 631);
            this.Controls.Add(this.toolStrip1);
            this.DoubleBuffered = true;
            this.Name = "MainWindow";
            this.Text = "Kyriù";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel label1;
        private System.Windows.Forms.ToolStripLabel label2;
        private System.Windows.Forms.ToolStripLabel label3;
        private System.Windows.Forms.ToolStripButton tourSuivant;
        private System.Windows.Forms.ToolStripLabel numéroTour;
        private System.Windows.Forms.ToolStripLabel finances;
        private System.Windows.Forms.ToolStripLabel gloire;
    }
}

