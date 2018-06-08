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

        public IndexedValueView(IndexedValue indexedValue, int w, int h, params DisplayTag[] tags) {
            this.indexedValue = indexedValue;
            this.Width = w + ((ArcThickness % 2 == 0) ? ArcThickness : ArcThickness - 1);
            this.Height = h + ((ArcThickness % 2 == 0) ? ArcThickness : ArcThickness - 1);

            if (tags.Length > 0) {
                Tags = tags;
            }

            this.DoubleBuffered = true;

            ToolTip tt = new ToolTip();
            tt.SetToolTip(this, indexedValue.Description);
        }

        public IndexedValueView(IndexedValue indexedValue, params DisplayTag[] tags) : this(indexedValue, 100, 100, tags) {
            
        }

        protected override void OnPaint(PaintEventArgs e) {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle geometry = new Rectangle(
                ArcThickness / 2, ArcThickness / 2,
                Width - ArcThickness, Height - ArcThickness
            );

            Font titleFont = new Font("Arial", 8);

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
                    new Font("Arial", 7), new SolidBrush(ForegroundColor),
                    new Point(Width / 2, Height / 2 + titleFont.Height + 5), format
                );
            }
        }
    }
}
