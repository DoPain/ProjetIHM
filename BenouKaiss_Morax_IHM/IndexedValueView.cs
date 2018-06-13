using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VivianeProject;

namespace BenouKaiss_Morax_IHM {
    internal class IndexedValueView : Control {

        public enum Shape { Rectangle, Ellipse, EllipseWithArc }

        #region Propriétés et attributs
        private readonly IndexedValue indexedValue;
        private readonly WorldState theWorld;

        public bool Mutable {
            get; set;
        }

        public int ArcThickness {
            get; set;
        } = 5;

        public DisplayTag[] Tags {
            get; set;
        } = { };

        public Color ForegroundColor {
            get; set;
        } = Color.White;

        public Color BackgroundColor {
            get; set;
        } = Color.DarkCyan;

        public Color DisabledBackgroundColor {
            get; set;
        } = Color.DarkGray;

        #endregion

        #region Constructeurs
        public IndexedValueView(IndexedValue indexedValue, int w, int h, WorldState wo, bool mutable, params DisplayTag[] tags) {
            this.indexedValue = indexedValue;
            this.theWorld = wo;

            this.Width = w + ((ArcThickness % 2 == 0) ? ArcThickness : ArcThickness - 1);
            this.Height = h + ((ArcThickness % 2 == 0) ? ArcThickness : ArcThickness - 1);
            this.Mutable = mutable;
            this.Tags = tags;

            this.DoubleBuffered = true;

            ToolTip tt = new ToolTip();
            tt.SetToolTip(this, indexedValue.Description);
            this.Anchor = AnchorStyles.None;
        }

        public IndexedValueView(IndexedValue indexedValue, WorldState wo, bool mutable, params DisplayTag[] tags) : this(indexedValue, 100, 100, wo, mutable, tags) {
            
        }
        #endregion

        #region Evènements
        protected override void OnPaint(PaintEventArgs e) {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle geometry = new Rectangle(
                ArcThickness / 2, ArcThickness / 2,
                Width - ArcThickness, Height - ArcThickness
            );

            Font titleFont = new Font("Arial", 7);

            StringFormat format = new StringFormat {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };

            Brush background = new SolidBrush(indexedValue.Active.GetValueOrDefault(true)
                                    ? BackgroundColor
                                    : DisabledBackgroundColor);

            if (indexedValue.Type == IndexedValue.ValueType.Perk || indexedValue.Type == IndexedValue.ValueType.Crisis) {
                Point[] points = new Point[] {
                    new Point(Width/2, 0), new Point(Width, Height/2), new Point(Width/2, Height), new Point(0, Height/2)
                };

                g.FillPolygon(background, points);
            }  else if(indexedValue.Type == IndexedValue.ValueType.Policy) {
                g.FillRectangle(background, geometry);
            } else {
                g.FillEllipse(background, geometry);
            }

            g.DrawString(
                indexedValue.Name,
                titleFont, new SolidBrush(ForegroundColor), 
                new Point(Width / 2, Height / 2), format
            );

            if (Tags.Contains(DisplayTag.ShowArc)) {
                g.DrawArc(
                    new Pen(ForegroundColor, ArcThickness),
                    geometry,
                    -90,
                    ((float)indexedValue.Value) / indexedValue.MaxValue * 360
                );
            }

            if(Tags.Contains(DisplayTag.ShowValue)) {
                g.DrawString(
                    indexedValue.Value.ToString(),
                    new Font("Arial", 6), new SolidBrush(ForegroundColor),
                    new Point(Width / 2, Height / 2 + titleFont.Height + 5), format
                );
            }

            if (indexedValue.AvailableAt > theWorld.Turns) {
                Brush b = new SolidBrush(Color.FromArgb(150, Color.Gray));

                if (indexedValue.Type == IndexedValue.ValueType.Policy) {
                    g.FillRectangle(b, 0, 0, Width, Height);
                } else {
                    g.FillEllipse(b, 0, 0, Width, Height);
                }
            }
        }

        protected override void OnMouseClick(MouseEventArgs e) {
            FindForm().Enabled = false;

            if (indexedValue.AvailableAt.GetValueOrDefault(0) <= theWorld.Turns && indexedValue.Type == IndexedValue.ValueType.Policy) {
                ValueExplorer infos = new ValueExplorer(theWorld, indexedValue);
                
                if (infos.ShowDialog() == DialogResult.OK) {
                    int amount = infos.Valeur;
                    int mCost = 0, gCost = 0;

                    if (amount == 0) {
                        if (MessageBox.Show($"Vous êtes sur le point de désactiver la politique {indexedValue.Name}, continuer ?",
                                            "Désactivation", MessageBoxButtons.YesNo) == DialogResult.No) return;

                        theWorld.DeactivatePolicy(indexedValue, out mCost, out gCost);

                    } else {
                        indexedValue.PreviewPolicyChange(ref amount, out mCost, out gCost);

                        if (MessageBox.Show($"Cette politique va désormais coûter {-mCost} de monnaie et {-gCost} de gloire par tour.",
                                            "Modifications",
                                            MessageBoxButtons.OKCancel) == DialogResult.Cancel) return;

                        if (gCost < 0) {
                            if (theWorld.CostGlory(gCost)) {
                                indexedValue.ChangeTo(amount, out mCost, out gCost);
                            }
                        }

                        indexedValue.ChangeTo(amount, out mCost, out gCost);
                    }

                    this.Refresh();
                }
            } else {
                MessageBox.Show("Description complète : " + 
                    indexedValue.CompletePresentation().Substring(indexedValue.CompletePresentation().IndexOf("\n")), 
                    indexedValue.Name, MessageBoxButtons.OK
                );
            }

            FindForm().Enabled = true;
        }
        
        protected override void OnMouseEnter(EventArgs e) {
            if(!indexedValue.Active.GetValueOrDefault(true) || indexedValue.AvailableAt > theWorld.Turns) return;

            if(FindForm() is MainWindow mw) {
                mw.peindreLiens(indexedValue);
            }
        }

        protected override void OnMouseLeave(EventArgs e) {
            FindForm().Refresh();
        }
        #endregion

    }

}
