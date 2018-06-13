namespace BenouKaiss_Morax_IHM {
    partial class Menu {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.toursLimités = new System.Windows.Forms.CheckBox();
            this.nombreTours = new System.Windows.Forms.NumericUpDown();
            this.easy = new System.Windows.Forms.RadioButton();
            this.medium = new System.Windows.Forms.RadioButton();
            this.hard = new System.Windows.Forms.RadioButton();
            this.difficulté = new System.Windows.Forms.GroupBox();
            this.commencer = new System.Windows.Forms.Button();
            this.quitter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nombreTours)).BeginInit();
            this.difficulté.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(234, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Menu";
            // 
            // toursLimités
            // 
            this.toursLimités.AutoSize = true;
            this.toursLimités.Location = new System.Drawing.Point(114, 269);
            this.toursLimités.Name = "toursLimités";
            this.toursLimités.Size = new System.Drawing.Size(193, 24);
            this.toursLimités.TabIndex = 5;
            this.toursLimités.Text = "Nombre de tours limité";
            this.toursLimités.UseVisualStyleBackColor = true;
            this.toursLimités.CheckedChanged += new System.EventHandler(this.toursLimités_CheckedChanged);
            // 
            // nombreTours
            // 
            this.nombreTours.Enabled = false;
            this.nombreTours.Location = new System.Drawing.Point(313, 269);
            this.nombreTours.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nombreTours.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nombreTours.Name = "nombreTours";
            this.nombreTours.Size = new System.Drawing.Size(120, 26);
            this.nombreTours.TabIndex = 6;
            this.nombreTours.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nombreTours.ValueChanged += new System.EventHandler(this.nombreTours_ValueChanged);
            // 
            // easy
            // 
            this.easy.AutoSize = true;
            this.easy.Checked = true;
            this.easy.Location = new System.Drawing.Point(6, 25);
            this.easy.Name = "easy";
            this.easy.Size = new System.Drawing.Size(76, 24);
            this.easy.TabIndex = 7;
            this.easy.TabStop = true;
            this.easy.Text = "Facile";
            this.easy.UseVisualStyleBackColor = true;
            this.easy.CheckedChanged += new System.EventHandler(this.easy_CheckedChanged);
            // 
            // medium
            // 
            this.medium.AutoSize = true;
            this.medium.Location = new System.Drawing.Point(6, 55);
            this.medium.Name = "medium";
            this.medium.Size = new System.Drawing.Size(81, 24);
            this.medium.TabIndex = 8;
            this.medium.Text = "Moyen";
            this.medium.UseVisualStyleBackColor = true;
            this.medium.CheckedChanged += new System.EventHandler(this.medium_CheckedChanged);
            // 
            // hard
            // 
            this.hard.AutoSize = true;
            this.hard.Location = new System.Drawing.Point(6, 85);
            this.hard.Name = "hard";
            this.hard.Size = new System.Drawing.Size(85, 24);
            this.hard.TabIndex = 9;
            this.hard.Text = "Difficile";
            this.hard.UseVisualStyleBackColor = true;
            this.hard.CheckedChanged += new System.EventHandler(this.hard_CheckedChanged);
            // 
            // difficulté
            // 
            this.difficulté.Controls.Add(this.easy);
            this.difficulté.Controls.Add(this.hard);
            this.difficulté.Controls.Add(this.medium);
            this.difficulté.Location = new System.Drawing.Point(181, 113);
            this.difficulté.Name = "difficulté";
            this.difficulté.Size = new System.Drawing.Size(201, 119);
            this.difficulté.TabIndex = 10;
            this.difficulté.TabStop = false;
            this.difficulté.Text = "Difficulté";
            // 
            // commencer
            // 
            this.commencer.Location = new System.Drawing.Point(166, 325);
            this.commencer.Name = "commencer";
            this.commencer.Size = new System.Drawing.Size(225, 88);
            this.commencer.TabIndex = 11;
            this.commencer.Text = "Commencer";
            this.commencer.UseVisualStyleBackColor = true;
            this.commencer.Click += new System.EventHandler(this.commencer_Click);
            // 
            // quitter
            // 
            this.quitter.Location = new System.Drawing.Point(26, 381);
            this.quitter.Name = "quitter";
            this.quitter.Size = new System.Drawing.Size(97, 32);
            this.quitter.TabIndex = 12;
            this.quitter.Text = "Quitter";
            this.quitter.UseVisualStyleBackColor = true;
            this.quitter.Click += new System.EventHandler(this.quitter_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 450);
            this.Controls.Add(this.quitter);
            this.Controls.Add(this.commencer);
            this.Controls.Add(this.difficulté);
            this.Controls.Add(this.nombreTours);
            this.Controls.Add(this.toursLimités);
            this.Controls.Add(this.label1);
            this.Name = "Menu";
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.nombreTours)).EndInit();
            this.difficulté.ResumeLayout(false);
            this.difficulté.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox toursLimités;
        private System.Windows.Forms.NumericUpDown nombreTours;
        private System.Windows.Forms.RadioButton easy;
        private System.Windows.Forms.RadioButton medium;
        private System.Windows.Forms.RadioButton hard;
        private System.Windows.Forms.GroupBox difficulté;
        private System.Windows.Forms.Button commencer;
        private System.Windows.Forms.Button quitter;
    }
}