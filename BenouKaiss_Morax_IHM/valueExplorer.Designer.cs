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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // Decription
            // 
            this.Decription.Location = new System.Drawing.Point(21, 48);
            this.Decription.Name = "Decription";
            this.Decription.Size = new System.Drawing.Size(333, 77);
            this.Decription.TabIndex = 0;
            this.Decription.Text = "?";
            // 
            // valeurLabel
            // 
            this.valeurLabel.Location = new System.Drawing.Point(123, 136);
            this.valeurLabel.Name = "valeurLabel";
            this.valeurLabel.Size = new System.Drawing.Size(124, 22);
            this.valeurLabel.TabIndex = 1;
            this.valeurLabel.Text = "?";
            this.valeurLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plus
            // 
            this.plus.Location = new System.Drawing.Point(210, 162);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(21, 22);
            this.plus.TabIndex = 2;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.MouseClick += new System.Windows.Forms.MouseEventHandler(this.plus_Click);
            // 
            // moins
            // 
            this.moins.Location = new System.Drawing.Point(139, 161);
            this.moins.Name = "moins";
            this.moins.Size = new System.Drawing.Size(22, 22);
            this.moins.TabIndex = 3;
            this.moins.Text = "-";
            this.moins.UseVisualStyleBackColor = true;
            this.moins.MouseClick += new System.Windows.Forms.MouseEventHandler(this.moins_Click);
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
            this.ok.Location = new System.Drawing.Point(279, 225);
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
            this.moinsCinq.Location = new System.Drawing.Point(107, 161);
            this.moinsCinq.Name = "moinsCinq";
            this.moinsCinq.Size = new System.Drawing.Size(27, 22);
            this.moinsCinq.TabIndex = 7;
            this.moinsCinq.Text = "-5";
            this.moinsCinq.UseVisualStyleBackColor = true;
            this.moinsCinq.Click += new System.EventHandler(this.moinsCinq_Click);
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(167, 162);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(38, 22);
            this.reset.TabIndex = 9;
            this.reset.Text = "?";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // plusCinq
            // 
            this.plusCinq.Location = new System.Drawing.Point(237, 161);
            this.plusCinq.Name = "plusCinq";
            this.plusCinq.Size = new System.Drawing.Size(27, 22);
            this.plusCinq.TabIndex = 10;
            this.plusCinq.Text = "+5";
            this.plusCinq.UseVisualStyleBackColor = true;
            this.plusCinq.Click += new System.EventHandler(this.plusCinq_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(126, 190);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 11;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // ValueExplorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 263);
            this.Controls.Add(this.numericUpDown1);
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
            this.Name = "ValueExplorer";
            this.Text = "ValueExplorer";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
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
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}