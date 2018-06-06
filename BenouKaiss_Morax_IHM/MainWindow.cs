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
    public partial class MainWindow : Form
    {

        private WorldState w = new WorldState(WorldState.Difficulty.Easy, "..\\..\\Logres.xml");

        public MainWindow()
        {
            InitializeComponent();
            refresh();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void tourSuivant_Click(object sender, EventArgs e)
        {
            w.NextTurn();
            refresh();

            if(w.Finished()) {
                tourSuivant.Enabled = false;
            }
        }

        private void refresh() {
            tourValeur.Text = w.Turns.ToString();
            financesValeur.Text = w.Money.ToString();
            gloireValeur.Text = w.Glory.ToString();

            indicateurs.Controls.Clear();
            w.Indicators.FindAll(i => i.Active != false).ForEach(i => indicateurs.Controls.Add(new IndexedValueView(i)));

            beneficesProblemes.Items.Clear();
            foreach (IndexedValue i in w.Crises) {
                beneficesProblemes.Items.Add(i.Name);
            }

            groupes.Items.Clear();
            foreach (IndexedValue i in w.Groups) {
                groupes.Items.Add(i.Name);
            }

            politiquesActives.Items.Clear();
            w.Expenses.FindAll(p => p.Active != false).ForEach(p => politiquesActives.Items.Add(p));
            politiquesDisponibles.Items.Clear();
            w.Expenses.FindAll(p => p.Active == false && p.AvailableAt <= w.Turns).ForEach(p => politiquesDisponibles.Items.Add(p));
        }
        
        private void numéroTour_Click(object sender, EventArgs e) {

        }

        private void gloire_Click(object sender, EventArgs e) {

        }

        private void quitter_Click(object sender, EventArgs e) {
            Application.Exit();
        }
    }
}
