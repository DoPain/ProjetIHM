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
    public class IndexedValueView : Control {

        #region Properties & variables
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

            g.FillEllipse(
                new SolidBrush(indexedValue.Active.GetValueOrDefault(true)? BackgroundColor : DisabledBackgroundColor), 
                geometry
            );
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
        }

        protected override void OnMouseDoubleClick(MouseEventArgs e) {
            if(!Mutable) return;

            ValueExplorer infos = new ValueExplorer(indexedValue);

            if(infos.ShowDialog() == DialogResult.OK) {
                int amount = infos.getValue();
                int mCost = 0, gCost = 0;

                if (amount == 0) {
                    theWorld.DeactivatePolicy(indexedValue, out mCost, out gCost);
                }

                indexedValue.PreviewPolicyChange(ref amount, out mCost, out gCost);

                if (gCost < 0) {
                    if (theWorld.CostGlory(gCost)) {
                        indexedValue.ChangeTo(amount, out mCost, out gCost);

                    }
                }

                indexedValue.ChangeTo(amount, out mCost, out gCost);

                Refresh();
                Console.Write(indexedValue.Value);
            }
        }
        
    }
}
