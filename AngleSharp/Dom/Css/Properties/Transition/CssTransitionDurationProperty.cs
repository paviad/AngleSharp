﻿namespace AngleSharp.Dom.Css
{
    using AngleSharp.Css;
    using AngleSharp.Css.Values;
    using AngleSharp.Extensions;

    /// <summary>
    /// More information available at:
    /// https://developer.mozilla.org/en-US/docs/CSS/transition-duration
    /// Gets the durations for the transitions.
    /// </summary>
    sealed class CssTransitionDurationProperty : CssProperty
    {
        #region Fields

        static readonly IValueConverter<Time[]> ListConverter =
            Converters.TimeConverter.FromList();

        #endregion

        #region ctor

        internal CssTransitionDurationProperty()
            : base(PropertyNames.TransitionDuration)
        {
        }

        #endregion

        #region Properties

        internal override IValueConverter Converter
        {
            // Default: Time.Zero
            get { return ListConverter; }
        }

        #endregion
    }
}
