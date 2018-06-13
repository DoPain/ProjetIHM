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

namespace BenouKaiss_Morax_IHM {
    public partial class Menu : Form {

        #region Propriétés
        public WorldState.Difficulty Difficulté {
            get; private set;
        } = WorldState.Difficulty.Easy;

        public bool ToursLimités {
            get; private set;
        } = false;

        public int ToursMaximum {
            get; private set;
        } = 30;
        #endregion

        #region Constructeurs
        public Menu() {
            InitializeComponent();
            DialogResult = DialogResult.Abort;
        }
        #endregion

        #region Interactions interface graphique
        private void easy_CheckedChanged(object sender, EventArgs e) {
            Difficulté = WorldState.Difficulty.Easy;
        }

        private void medium_CheckedChanged(object sender, EventArgs e) {
            Difficulté = WorldState.Difficulty.Medium;
        }

        private void hard_CheckedChanged(object sender, EventArgs e) {
            Difficulté = WorldState.Difficulty.Hard;
        }

        private void toursLimités_CheckedChanged(object sender, EventArgs e) {
            ToursLimités = !ToursLimités;
            nombreTours.Enabled = ToursLimités;
        }

        private void nombreTours_ValueChanged(object sender, EventArgs e) {
            ToursMaximum = (int) nombreTours.Value;
        }

        private void commencer_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void quitter_Click(object sender, EventArgs e) {
            Close();
        }
        #endregion

    }
}
