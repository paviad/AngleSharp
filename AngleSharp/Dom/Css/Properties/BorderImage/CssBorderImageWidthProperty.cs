﻿namespace AngleSharp.Dom.Css
{
    using System;
    using AngleSharp.Css;
    using AngleSharp.Css.Values;
    using AngleSharp.Extensions;

    /// <summary>
    /// More information available at:
    /// https://developer.mozilla.org/en-US/docs/Web/CSS/border-image-width
    /// </summary>
    sealed class CssBorderImageWidthProperty : CssProperty
    {
        #region Fields

        internal static readonly IValueConverter<Tuple<Length, Length, Length, Length>> StyleConverter = 
            Converters.ImageBorderWidthConverter.Periodic();

        #endregion

        #region ctor

        internal CssBorderImageWidthProperty()
            : base(PropertyNames.BorderImageWidth)
        {
        }

        #endregion

        #region Properties

        internal override IValueConverter Converter
        {
            // Default: Length.Full
            get { return StyleConverter; }
        }

        #endregion
    }
}
