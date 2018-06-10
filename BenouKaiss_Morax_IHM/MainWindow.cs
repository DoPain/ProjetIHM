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
            foreach(IndexedValue i in w.Indicators) {
                indicateurs.Controls.Add(new IndexedValueView(
                    i, 70, 70, 
                    this.w, false,
                    DisplayTag.ShowValue,
                    DisplayTag.ShowArc
                    
                ));
            }

            beneficesProblemes.Controls.Clear();
            foreach (IndexedValue i in w.Perks) {
                if (i.Active.GetValueOrDefault(true)) {
                    beneficesProblemes.Controls.Add(new IndexedValueView(
                        i, 110, 110, 
                        this.w, false,
                        DisplayTag.ShowValue,
                        DisplayTag.ShowArc
                    ) {
                        BackgroundColor = Color.Green
                    });
                }
            }

            foreach (IndexedValue i in w.Crises) {
                if (i.Active.GetValueOrDefault(true)) {
                    beneficesProblemes.Controls.Add(new IndexedValueView(
                        i, this.w, false,
                        DisplayTag.ShowValue,
                        DisplayTag.ShowArc
                    ) {
                        BackgroundColor = Color.Red
                    });
                }
            }

            groupes.Controls.Clear();
            foreach (IndexedValue i in w.Groups) {
                groupes.Controls.Add(new IndexedValueView(
                    i,
                    this.w, false,
                    DisplayTag.ShowValue,
                    DisplayTag.ShowArc
                ));
            }

            politiques.Controls.Clear();
            w.Policies.ForEach(i => politiques.Controls.Add(new IndexedValueView(
                    i,
                    this.w, true,
                    DisplayTag.ShowValue
                )));
        }
        
        private void numéroTour_Click(object sender, EventArgs e) {

        }

        private void gloire_Click(object sender, EventArgs e) {

        }

        private void quitter_Click(object sender, EventArgs e) {
            Application.Exit();
        }
        
        protected void MainWindow_Paint(object sender, PaintEventArgs p) {
            Console.WriteLine(Width + " " + Height);
        }
    }
}
