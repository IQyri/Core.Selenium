namespace Core.Selenium.Interface.Control
{
    /// <summary>
    /// Интерфейс для чекбоксов
    /// </summary>
    public interface ICheckBox : IControl, IClickable
    {
        /// <summary>
        /// Состояние, показывающее выделен ли чекбокс.
        /// </summary>
        bool IsChecked { get; }
    }
}