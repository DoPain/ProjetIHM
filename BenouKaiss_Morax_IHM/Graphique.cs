using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BenouKaiss_Morax_IHM {
    class Graphique : Form {

        #region Attributs
        private double valeurMaxX;
        private double valeurMaxY;

        /// <summary>
        /// Les valeurs qui doivent être affichées, la clé représente la
        /// valeur en x et la valeur représente la valeur en y
        /// </summary>
        private Dictionary<double, double> valeurs;
        #endregion

        #region Constructeurs
        public Graphique(Size size, Dictionary<double, double> valeurs) {
            this.Size = size;
            this.MinimumSize = new Size(300, 300);
            this.Padding = new Padding(30);
            this.valeurs = valeurs;

            if (valeurs.Count > 0) {
                this.valeurMaxX = valeurs.Keys.Max() + (valeurs.Keys.Max() - valeurs.Keys.Min()) * 0.1;
                this.valeurMaxY = valeurs.Values.Max() + (valeurs.Values.Max() - valeurs.Values.Min()) * 0.1;
            } else {
                this.valeurMaxX = 10;
                this.valeurMaxY = 10;
            }
        }
        #endregion

        #region Évènements
        protected override void OnClientSizeChanged(EventArgs e) {
            Refresh();
        }

        protected override void OnPaint(PaintEventArgs e) {
            Graphics g = e.Graphics;
            g.Clear(Color.LightSlateGray);
            Rectangle drawable = new Rectangle(Padding.Left, Padding.Top, ClientSize.Width - Padding.Right - Padding.Left, ClientSize.Height - Padding.Bottom - Padding.Top);
            g.DrawLine(new Pen(Color.Black, 3), drawable.Left, drawable.Bottom, drawable.Left, drawable.Top);
            g.DrawLine(new Pen(Color.Black, 3), drawable.Left, drawable.Bottom, drawable.Right, drawable.Bottom);

            Nullable<Point> previousPoint = null;

            foreach(KeyValuePair<double, double> paire in valeurs) {
                Point currentPoint = new Point(
                    (int)(drawable.Left + (paire.Key / valeurMaxX) * drawable.Width),
                    (int)(drawable.Bottom - (paire.Value / valeurMaxY) * drawable.Height)
                );

                Font font = new Font("Arial", 8);

                StringFormat format = new StringFormat();
                format.LineAlignment = StringAlignment.Center;
                format.Alignment = StringAlignment.Center;

                g.DrawString(paire.Value.ToString(), font, Brushes.Black, currentPoint.X, currentPoint.Y-10, format);
                g.DrawString(paire.Key.ToString(), font, Brushes.Black, currentPoint.X, drawable.Bottom + 15, format);

                if (previousPoint.HasValue)
                    g.DrawLine(Pens.Black, previousPoint.GetValueOrDefault(), currentPoint);

                previousPoint = currentPoint;
            }
        }
        #endregion

    }
}
