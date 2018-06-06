using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VivianeProject;

namespace BenouKaiss_Morax_IHM {
    public class IndexedValueView : GroupBox {

        private IndexedValue indexedValue;

        private Label description;
        private Label valeurTexte;
        private Label valeurValeur;

        public IndexedValueView(IndexedValue iv) {
            indexedValue = iv;
            
            if (!iv.Active.GetValueOrDefault(true)) {
                Enabled = false;
            }
            
            InitializeComponent();
        }

        #region Initialisation
        private void InitializeComponent() {
            this.SuspendLayout();

            // 
            // IndexedValueView
            // 
            this.ResumeLayout(false);
            this.Text = indexedValue.Name;

            int availableWidth = this.Width - this.Padding.Left - this.Padding.Right;

            //
            // description
            //
            this.description = new Label();
            this.description.Text = indexedValue.Description;
            this.description.Location = new Point(this.Padding.Left, 20);
            this.description.AutoSize = true;
            this.description.MaximumSize = new Size(availableWidth, 200);
            Controls.Add(description);

            //
            // valeurTexte
            //
            this.valeurTexte = new Label();
            this.valeurTexte.Text = "Valeur :";
            this.valeurTexte.Location = new Point(this.Padding.Left, 5 + description.Location.Y + description.Height);
            this.valeurTexte.AutoSize = true;
            Controls.Add(valeurTexte);

            //
            // valeurValeur
            //
            this.valeurValeur = new Label();
            this.valeurValeur.Text = indexedValue.Value.ToString();
            this.valeurValeur.Location = new Point(valeurTexte.Width, valeurTexte.Location.Y);
            this.valeurValeur.Height = 15;
            Controls.Add(valeurValeur);

            this.Height = Padding.Top + description.Height + valeurTexte.Height + 30 + Padding.Bottom;
            this.ResumeLayout();
        }
        #endregion Initialisation
    }
}
