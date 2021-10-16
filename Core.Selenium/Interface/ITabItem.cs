namespace Core.Selenium.Interface
{
    /// <summary>
    /// Интерфейс для таб элементов.
    /// </summary>
    public interface ITabItem : IClickable, IControl
    {
        /// <summary>
        /// Название кнопки.
        /// </summary>
        string? Title { get; }

        /// <summary>
        /// Состояние, показывающее активен ли данный таб элемент.
        /// </summary>
        bool IsActive { get; }
    }
}
