namespace Core.Selenium.Interface.Control
{
    /// <summary>
    /// Интерфейс для текстовых блоков.
    /// </summary>
    public interface ITextBlock : IControl
    {
        /// <summary>
        /// Текст контрола.
        /// </summary>
        string Text { get; }
    }
}