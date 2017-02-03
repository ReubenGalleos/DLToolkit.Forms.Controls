namespace DLToolkit.Forms.Controls
{
    /// <summary>
	/// FlowListView auto column-count mode.
	/// </summary>
	public enum FlowColumnMode
    {
        /// <summary>
        /// Use single column only
        /// </summary>
        SingleColumn,

        /// <summary>
        /// Use Minimum width only
        /// </summary>
        MinimumWidth,

        /// <summary>
        /// Use a set amount of columns unless the resulting column width is out of provided bounds
        /// </summary>
        SetCountWithBounds,

        /// <summary>
        /// Use a set amount of columns unless the resulting column width is greater than given bound
        /// </summary>
        SetCountWithUpperBound,

        /// <summary>
        /// Use a set amount of columns unless the resulting column width is lower than given bound
        /// </summary>
        SetCountWithLowerBound,

        /// <summary>
        /// Use asssigned column count
        /// </summary>
        SetCount,

        /// <summary>
        /// Use user provided column count dependent on orientation
        /// </summary>
        SetCountPerOrientation,

        /// <summary>
        /// Use user provided column count dependent on orientation, with upper and lower bounds applied
        /// </summary>
        SetCountPerOrientationWithBounds,
    }
}
