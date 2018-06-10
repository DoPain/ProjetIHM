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
    public partial class ValueExplorer : Form {

        private IndexedValue v;
        private int value;

        public ValueExplorer(IndexedValue v) {
            this.v = v;
            this.value = v.Value;

            InitializeComponent();
            this.Decription.Text = v.Description;
            this.valeur.Text = v.Value.ToString();
        }

        public int getValue() {
            return this.value;
        }

        private void plus_Click(object sender, MouseEventArgs e) {
            valeur.Text = (++this.value).ToString();
        }

        private void moins_Click(object sender, MouseEventArgs e) {
            valeur.Text = (--this.value).ToString();
        }

        private void annuler_MouseClick(object sender, MouseEventArgs e) {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void ok_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.OK;
            this.Close();
        }

    }
}
