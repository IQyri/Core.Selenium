namespace Core.Selenium.Interface.Control
{
    /// <summary>
    /// Интерфейс для контролов ввода данных.
    /// </summary>
    public interface IInput : IControl
    {
        /// <summary>
        /// Ввод текста в инпут.
        /// </summary>
        void SetText (string text);
    }
}
