﻿namespace AngleSharp.Dom.Css
{
    using AngleSharp.Css;

    /// <summary>
    /// More information available at:
    /// https://developer.mozilla.org/en-US/docs/Web/CSS/text-indent
    /// Gets the indentation, which is either a percentage of the
    /// containing block width or specified as fixed length. Negative
    /// values are allowed.
    /// </summary>
    sealed class CssTextIndentProperty : CssProperty
    {
        #region ctor

        internal CssTextIndentProperty()
            : base(PropertyNames.TextIndent, PropertyFlags.Inherited | PropertyFlags.Animatable)
        {
        }

        #endregion

        #region Properties

        internal override IValueConverter Converter
        {
            // Default: Length.Zero
            get { return Converters.LengthOrPercentConverter; }
        }

        #endregion
    }
}
