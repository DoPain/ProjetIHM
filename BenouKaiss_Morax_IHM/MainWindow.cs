using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VivianeProject;

namespace BenouKaiss_Morax_IHM {
    public partial class MainWindow : Form {

        #region Nécéssaire pour peindre au dessus des Controls
        [DllImport("user32")]
        private static extern IntPtr GetWindowDC(IntPtr hwnd);

        [DllImport("user32")]
        private static extern IntPtr ReleaseDC(IntPtr hwnd, IntPtr hdc);
        #endregion

        #region Attributs
        private WorldState w;
        private int toursMaximum;
        private Dictionary<IndexedValue, IndexedValueView> views = new Dictionary<IndexedValue, IndexedValueView>();
        private List<IndexedValue> crisesCommencées = new List<IndexedValue>();
        #endregion

        #region Constructeurs
        public MainWindow(WorldState.Difficulty difficulty, int toursMaximum = int.MaxValue) {
            this.w = new WorldState(difficulty, "..\\..\\Logres.xml");
            this.toursMaximum = toursMaximum;

            InitializeComponent();
            this.Size = new System.Drawing.Size(820, 620);
            initialisation();
        }
        #endregion

        #region Interactions interface graphique
        private void tourSuivant_Click(object sender, EventArgs e) {
            w.NextTurn();
            tourValeur.Text = w.Turns.ToString();
            financesValeur.Text = w.Money.ToString();
            gloireValeur.Text = w.Glory.ToString();
            this.Refresh();

            foreach (IndexedValue v in w.Crises) {
                if (v.Active == true && !(crisesCommencées.Contains(v))) {
                    crisesCommencées.Add(v);
                    String text = "Attention vous êtes en pleines crise! : " + v.Name;
                    MessageBox.Show(text, "Crise en cours", MessageBoxButtons.OK);
                }
            }

            if (w.Finished()) {
                tourSuivant.Enabled = false;
            }
            if (w.Turns >= toursMaximum) {
                MessageBox.Show("Le nombre de tours maximum a été atteint, partie perdue.", "Perdu", MessageBoxButtons.OK);
                tourSuivant.Enabled = false;
            }
        }

        private void quitter_Click(object sender, EventArgs e) {
            Application.Exit();
        }
        #endregion

        #region Controls et dessin
        private int GetThickness(double weight) {
            weight = Math.Abs(weight);

            if (weight >= 0.0 && weight < 0.01) return 2;
            if (weight >= 0.01 && weight < 0.1) return 8;
            if (weight >= 0.1 && weight < 1.0) return 15;
            return 0;
        }

        public Point GetPositionInForm(Control c) {
            return new Point(
                c.PointToScreen(Point.Empty).X - Location.X + c.Width / 2, 
                c.PointToScreen(Point.Empty).Y - Location.Y + c.Height / 2
                );
        }

        private void initialisation() {
            tourValeur.Text = w.Turns.ToString();
            financesValeur.Text = w.Money.ToString();
            gloireValeur.Text = w.Glory.ToString();

            indicateurs.Controls.Clear();
            foreach (IndexedValue i in w.Indicators) {
                IndexedValueView ivv = new IndexedValueView(
                    i, 70, 70,
                    this.w, false,
                    DisplayTag.EllipseShape,
                    DisplayTag.ShowValue,
                    DisplayTag.ShowArc
                );

                indicateurs.Controls.Add(ivv);
                views.Add(i, ivv);
            }

            beneficesProblemes.Controls.Clear();
            foreach (IndexedValue i in w.Perks) {
                IndexedValueView ivv = new IndexedValueView(
                    i, 110, 50,
                    this.w, false,
                    DisplayTag.EllipseShape,
                    DisplayTag.ShowValue
                ) {
                    BackgroundColor = Color.Green
                };

                beneficesProblemes.Controls.Add(ivv);
                views.Add(i, ivv);
            }

            foreach (IndexedValue i in w.Crises) {
                IndexedValueView ivv = new IndexedValueView(
                    i, 110, 50
                    , this.w, false,
                    DisplayTag.EllipseShape,
                    DisplayTag.ShowValue
                ) {
                    BackgroundColor = Color.Red
                };
                beneficesProblemes.Controls.Add(ivv);
                views.Add(i, ivv);
            }

            groupes.Controls.Clear();
            foreach (IndexedValue i in w.Groups) {
                IndexedValueView ivv = new IndexedValueView(
                    i, 70, 70,
                    this.w, false,
                    DisplayTag.EllipseShape,
                    DisplayTag.ShowValue,
                    DisplayTag.ShowArc
                );

                groupes.Controls.Add(ivv);
                views.Add(i, ivv);
            }

            politiques.Controls.Clear();
            foreach (IndexedValue i in w.Policies) {
                IndexedValueView ivv = new IndexedValueView(
                        i, 100, 50,
                        this.w, true,
                        DisplayTag.ShowValue
                    );

                politiques.Controls.Add(ivv);
                views.Add(i, ivv);
            }
        }

        public void peindreLiens(IndexedValue iv) {
            IntPtr hdc = GetWindowDC(this.Handle);
            Graphics g = Graphics.FromHdc(hdc);

            IndexedValueView associatedVV;
            views.TryGetValue(iv, out associatedVV);

            foreach (KeyValuePair<IndexedValue, double> pair in iv.OutputWeights) {
                IndexedValueView associatedLinkVV;
                views.TryGetValue(pair.Key, out associatedLinkVV);
                if (associatedLinkVV == null) continue;
                g.DrawLine(new Pen(pair.Value > 0 ? Color.FromArgb(200, Color.Green) : Color.FromArgb(200, Color.Red), GetThickness(pair.Value)), GetPositionInForm(associatedVV), GetPositionInForm(associatedLinkVV));
            }

            g.Dispose();
            ReleaseDC(this.Handle, hdc);
        }
        #endregion
    }
}
