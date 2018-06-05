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

namespace BenouKaiis_Morax_IHM
{
    public partial class MainWindow : Form
    {

        private WorldState w = new WorldState();

        public MainWindow()
        {
            InitializeComponent();
            numéroTour.Text = w.Turns.ToString();
            finances.Text = w.Money.ToString();
            gloire.Text = w.Glory.ToString();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void tourSuivant_Click(object sender, EventArgs e)
        {
            w.NextTurn();
            numéroTour.Text = w.Turns.ToString();
            finances.Text = w.Money.ToString();
            gloire.Text = w.Glory.ToString();

            showLoseDialog(w.Crises.Find(c => c.Result == IndexedValue.ResultType.Lose && c.Active == true));
        }

        private void showLoseDialog(IndexedValue indexedValue) {
            if (indexedValue == null) {
                MessageBox.Show("Partie perdue : dette insurmontable.", "Perdu");
            } else {
                MessageBox.Show("Partie perdue :" +
                 indexedValue.CompletePresentation());
            }

            tourSuivant.Enabled = false;
        }

        private void numéroTour_Click(object sender, EventArgs e) {

        }

        private void gloire_Click(object sender, EventArgs e) {

        }
    }
}
