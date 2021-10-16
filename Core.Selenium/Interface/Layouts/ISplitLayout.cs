namespace Core.Selenium.Interface.Layouts
{
    /// <summary>
    /// Интрефес для размещения контролов в двух областях.
    /// </summary>
    public interface ISplitLayout : ILayout
    {
        /// <summary>
        /// Левая область.
        /// </summary>
        IControl? Left { get; }

        /// <summary>
        /// Сепаратор.
        /// </summary>
        IControl? Separator { get; }

        /// <summary>
        /// Правая область.
        /// </summary>
        IControl? Right { get; }
    }
}