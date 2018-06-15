using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenouKaiss_Morax_IHM {

    /// <summary>
    /// Changes the way the indexed value is displayed
    /// </summary>
    public enum DisplayTag {

        /// <summary>
        /// Shows the indexed value as an ellipse.
        /// It is a rectangle by default.
        /// </summary>
        EllipseShape,
        /// <summary>
        /// Shows the value as a number 
        /// in the value view.
        /// </summary>
        ShowValue,
        /// <summary>
        /// Show the value as an arc around the 
        /// circle if the value is displayed as a circle.
        /// </summary>
        ShowArc,
        /// <summary>
        /// Hides the number value if the
        /// indexed value is inactive
        /// </summary>
        HideValueInactive,
        /// <summary>
        /// Hides the arc value if the
        /// indexed value is inactive
        /// </summary>
        HideArcInactive
    }
}
