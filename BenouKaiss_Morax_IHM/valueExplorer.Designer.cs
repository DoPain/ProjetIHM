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
            this.valeur = new System.Windows.Forms.Label();
            this.plus = new System.Windows.Forms.Button();
            this.moins = new System.Windows.Forms.Button();
            this.annuler = new System.Windows.Forms.Button();
            this.ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Decription
            // 
            this.Decription.Location = new System.Drawing.Point(12, 52);
            this.Decription.Name = "Decription";
            this.Decription.Size = new System.Drawing.Size(560, 87);
            this.Decription.TabIndex = 0;
            this.Decription.Text = "?";
            // 
            // valeur
            // 
            this.valeur.Location = new System.Drawing.Point(284, 149);
            this.valeur.Name = "valeur";
            this.valeur.Size = new System.Drawing.Size(100, 23);
            this.valeur.TabIndex = 1;
            this.valeur.Text = "?";
            // 
            // plus
            // 
            this.plus.Location = new System.Drawing.Point(302, 175);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(21, 23);
            this.plus.TabIndex = 2;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.MouseClick += new System.Windows.Forms.MouseEventHandler(this.plus_Click);
            // 
            // moins
            // 
            this.moins.Location = new System.Drawing.Point(253, 175);
            this.moins.Name = "moins";
            this.moins.Size = new System.Drawing.Size(22, 23);
            this.moins.TabIndex = 3;
            this.moins.Text = "-";
            this.moins.UseVisualStyleBackColor = true;
            this.moins.MouseClick += new System.Windows.Forms.MouseEventHandler(this.moins_Click);
            // 
            // annuler
            // 
            this.annuler.Location = new System.Drawing.Point(12, 304);
            this.annuler.Name = "annuler";
            this.annuler.Size = new System.Drawing.Size(75, 23);
            this.annuler.TabIndex = 4;
            this.annuler.Text = "Annuler";
            this.annuler.UseVisualStyleBackColor = true;
            this.annuler.MouseClick += new System.Windows.Forms.MouseEventHandler(this.annuler_MouseClick);
            // 
            // ok
            // 
            this.ok.Location = new System.Drawing.Point(497, 304);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(75, 23);
            this.ok.TabIndex = 5;
            this.ok.Text = "OK";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // ValueExplorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 339);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.annuler);
            this.Controls.Add(this.moins);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.valeur);
            this.Controls.Add(this.Decription);
            this.Name = "ValueExplorer";
            this.Text = "ValueExplorer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Decription;
        private System.Windows.Forms.Label valeur;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button moins;
        private System.Windows.Forms.Button annuler;
        private System.Windows.Forms.Button ok;
    }
}