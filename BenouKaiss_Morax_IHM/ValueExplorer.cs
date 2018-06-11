using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VivianeProject;

namespace BenouKaiss_Morax_IHM
{
    internal partial class ValueExplorer : Form {

        private IndexedValue indexedValue;
        private int valeur;

        public ValueExplorer(IndexedValue v) {
            this.indexedValue = v;
            this.valeur = v.Value;

            InitializeComponent();
            this.nom.Text = v.Name;
            this.Decription.Text = v.Description;
            this.valeurLabel.Text = v.Value.ToString();
            this.reset.Text = v.Value.ToString();
        }

        public int getValue() {
            return this.valeur;
        }

        private void plus_Click(object sender, MouseEventArgs e) {
            if (++this.valeur > indexedValue.MaxValue) this.valeur = indexedValue.MaxValue;
            actualiserValeur();
        }

        private void moins_Click(object sender, MouseEventArgs e) {
            if (--this.valeur < indexedValue.MinValue) this.valeur = indexedValue.MinValue;
            actualiserValeur();
        }

        private void plusCinq_Click(object sender, EventArgs e) {
            if ((this.valeur += 5) > indexedValue.MaxValue) this.valeur = indexedValue.MaxValue;
            actualiserValeur();
        }

        private void moinsCinq_Click(object sender, EventArgs e) {
            if ((this.valeur -= 5) < indexedValue.MinValue) this.valeur = indexedValue.MinValue;
            actualiserValeur();
        }

        private void reset_Click(object sender, EventArgs e) {
            valeurLabel.Text = indexedValue.Value.ToString();
        }

        private void annuler_MouseClick(object sender, MouseEventArgs e) {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void ok_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void actualiserValeur() {
            this.valeurLabel.Text = valeur.ToString();
        }
    }
}
