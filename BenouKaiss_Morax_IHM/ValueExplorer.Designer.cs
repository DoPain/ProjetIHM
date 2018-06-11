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
            this.valeurLabel = new System.Windows.Forms.Label();
            this.plus = new System.Windows.Forms.Button();
            this.moins = new System.Windows.Forms.Button();
            this.annuler = new System.Windows.Forms.Button();
            this.ok = new System.Windows.Forms.Button();
            this.nom = new System.Windows.Forms.Label();
            this.moinsCinq = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.plusCinq = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Decription
            // 
            this.Decription.Location = new System.Drawing.Point(31, 74);
            this.Decription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Decription.Name = "Decription";
            this.Decription.Size = new System.Drawing.Size(499, 119);
            this.Decription.TabIndex = 0;
            this.Decription.Text = "?";
            // 
            // valeurLabel
            // 
            this.valeurLabel.Location = new System.Drawing.Point(184, 209);
            this.valeurLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.valeurLabel.Name = "valeurLabel";
            this.valeurLabel.Size = new System.Drawing.Size(186, 34);
            this.valeurLabel.TabIndex = 1;
            this.valeurLabel.Text = "?";
            this.valeurLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plus
            // 
            this.plus.Location = new System.Drawing.Point(315, 249);
            this.plus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(32, 34);
            this.plus.TabIndex = 2;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.MouseClick += new System.Windows.Forms.MouseEventHandler(this.plus_Click);
            // 
            // moins
            // 
            this.moins.Location = new System.Drawing.Point(209, 248);
            this.moins.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.moins.Name = "moins";
            this.moins.Size = new System.Drawing.Size(33, 34);
            this.moins.TabIndex = 3;
            this.moins.Text = "-";
            this.moins.UseVisualStyleBackColor = true;
            this.moins.MouseClick += new System.Windows.Forms.MouseEventHandler(this.moins_Click);
            // 
            // annuler
            // 
            this.annuler.Location = new System.Drawing.Point(35, 346);
            this.annuler.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.annuler.Name = "annuler";
            this.annuler.Size = new System.Drawing.Size(112, 35);
            this.annuler.TabIndex = 4;
            this.annuler.Text = "Annuler";
            this.annuler.UseVisualStyleBackColor = true;
            this.annuler.MouseClick += new System.Windows.Forms.MouseEventHandler(this.annuler_MouseClick);
            // 
            // ok
            // 
            this.ok.Location = new System.Drawing.Point(418, 346);
            this.ok.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(112, 35);
            this.ok.TabIndex = 5;
            this.ok.Text = "OK";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // nom
            // 
            this.nom.AutoSize = true;
            this.nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nom.Location = new System.Drawing.Point(31, 26);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(31, 32);
            this.nom.TabIndex = 6;
            this.nom.Text = "?";
            // 
            // moinsCinq
            // 
            this.moinsCinq.Location = new System.Drawing.Point(161, 248);
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
            this.reset.Location = new System.Drawing.Point(250, 249);
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
            this.plusCinq.Location = new System.Drawing.Point(355, 248);
            this.plusCinq.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.plusCinq.Name = "plusCinq";
            this.plusCinq.Size = new System.Drawing.Size(40, 34);
            this.plusCinq.TabIndex = 10;
            this.plusCinq.Text = "+5";
            this.plusCinq.UseVisualStyleBackColor = true;
            this.plusCinq.Click += new System.EventHandler(this.plusCinq_Click);
            // 
            // ValueExplorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 404);
            this.Controls.Add(this.plusCinq);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.moinsCinq);
            this.Controls.Add(this.nom);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.annuler);
            this.Controls.Add(this.moins);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.valeurLabel);
            this.Controls.Add(this.Decription);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ValueExplorer";
            this.Text = "ValueExplorer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Decription;
        private System.Windows.Forms.Label valeurLabel;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button moins;
        private System.Windows.Forms.Button annuler;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.Label nom;
        private System.Windows.Forms.Button moinsCinq;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button plusCinq;
    }
}