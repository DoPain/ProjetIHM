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

        #region Propriétés et attributs
        private WorldState world;
        private IndexedValue indexedValue;

        public int Valeur {
            get; private set;
        }
        #endregion

        #region Constructeurs
        public ValueExplorer(WorldState w, IndexedValue v) {
            this.world = w;
            this.indexedValue = v;
            this.Valeur = v.Value;

            InitializeComponent();
            this.champValeur.Value = v.Value;
            this.nom.Text = v.Name;
            this.Decription.Text = v.CompletePresentation().Substring(v.CompletePresentation().IndexOf("\n")+1);
            this.champValeur.Value = v.Value;
            this.reset.Text = v.Value.ToString();

            foreach(KeyValuePair<IndexedValue, double> pair in v.OutputWeights) {
                listeValeursAffectées.Items.Add((pair.Value > 0 ? "Augmente " : "Diminue ") + pair.Key.Name);
            }

            int amount = Valeur;
            int mCost = 0, gCost = 0;
            indexedValue.PreviewPolicyChange(ref amount, out mCost, out gCost);

            this.financesValeur.Text = mCost.ToString();
            this.gloireValeur.Text = gCost.ToString();
        }
        #endregion, 

        #region Interactions interface graphique
        private void champValeur_ValueChanged(object sender, EventArgs e) {
            Valeur = (int) champValeur.Value;
        }

        private void plusCinq_Click(object sender, EventArgs e) {
            if ((Valeur += 5) > indexedValue.MaxValue) Valeur = indexedValue.MaxValue;
            actualiserValeur();
        }

        private void moinsCinq_Click(object sender, EventArgs e) {
            if ((Valeur -= 5) < 0) Valeur = 0;
            actualiserValeur();
        }

        private void reset_Click(object sender, EventArgs e) {
            champValeur.Value = indexedValue.Value;
        }

        private void historique_Click(object sender, EventArgs e) {
            int turn = 0;
            Dictionary<double, double> valeurs = new Dictionary<double, double>();

            world.ValuesLog.ForEach(vl => {
                vl.FindAll(v => v.Split(':')[0].ToLower().Equals(indexedValue.Name.ToLower())).ForEach(v => {
                    valeurs.Add(turn, double.Parse(v.Split(':')[1]));
                    turn++;
                });
            });

            Form historique = new Graphique(new Size(300, 300), valeurs);
            historique.Show();
        }
        #endregion

        private void actualiserValeur() {
            champValeur.Value = Valeur;

            int amount = Valeur;
            int mCost = 0, gCost = 0;
            indexedValue.PreviewPolicyChange(ref amount, out mCost, out gCost);

            this.financesValeur.Text = mCost.ToString();
            this.gloireValeur.Text = gCost.ToString();
        }
    }
}
