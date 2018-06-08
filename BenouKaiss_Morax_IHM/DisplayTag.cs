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
        /// Shows the value as a number 
        /// in the circle.
        /// </summary>
        ShowValue,
        /// <summary>
        /// Show the value as an arc
        /// around the circle.
        /// </summary>
        ShowArc,
        /// <summary>
        /// Changes the background color
        /// if the indexed value is inactive.
        /// </summary>
        SameColorInactive,
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
