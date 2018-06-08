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
    public partial class ValueExplorer : Form
    {
        IndexedValue v;
        WorldState theWorld;

        public ValueExplorer(IndexedValue v,WorldState w )
        {
            InitializeComponent();
            this.Decription.Text = v.Description;
            this.valeur.Text = v.Value.ToString();
            this.v = v;
            this.theWorld = w;
        }

        private void plus_Click(object sender, MouseEventArgs e)
        {
            valeur.Text = (int.Parse(valeur.Text) + 1).ToString();
        }

        private void moins_Click(object sender, MouseEventArgs e)
        {
            valeur.Text = (int.Parse(valeur.Text) - 1).ToString();
        }

        private void annuler_MouseClick(object sender, MouseEventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void ok_Click(object sender, EventArgs e)
        {
            int amount = -1;
            int mCost = 0, gCost = 0;
            if (amount == 0)
            {
                theWorld.DeactivatePolicy(v, out mCost, out gCost);

            }
            v.PreviewPolicyChange(ref amount, out mCost, out gCost);
            if (gCost < 0)
            {
                if (theWorld.CostGlory(gCost))
                {
                    v.ChangeTo(amount, out mCost, out gCost);

                }
            }
            v.ChangeTo(amount, out mCost, out gCost);
        

            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
