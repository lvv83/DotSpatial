// ********************************************************************************************************
// Product Name: DotSpatial.Symbology.dll
// Description:  Contains the business logic for symbology layers and symbol categories.
// ********************************************************************************************************
//
// The Original Code is from MapWindow.dll version 6.0
//
// The Initial Developer of this Original Code is Ted Dunsford. Created 5/19/2009 3:08:53 PM
//
// Contributor(s): (Open source contributors should list themselves and their modifications here).
//
// ********************************************************************************************************

using System.Drawing;

namespace DotSpatial.Symbology
{
    /// <summary>
    /// IOutlined
    /// </summary>
    public interface IOutlined
    {
        /// <summary>
        /// Gets or sets the outline color that surrounds this specific symbol.
        /// (this will have the same shape as the symbol, but be larger.
        /// </summary>
        Color OutlineColor
        {
            get;
            set;
        }

        /// <summary>
        /// This redefines the Alpha channel of the color to a floating point opacity
        /// that ranges from 0 to 1.
        /// </summary>
        float OutlineOpacity
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the size of the outline beyond the size of this symbol.
        /// </summary>
        double OutlineWidth
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the boolean outline
        /// </summary>
        bool UseOutline
        {
            get;
            set;
        }
    }
}