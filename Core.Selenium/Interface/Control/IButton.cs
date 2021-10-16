namespace Core.Selenium.Interface.Control
{
    /// <summary>
    /// Интерфейс для кнопки.
    /// </summary>
    public interface IButton : IControl, IClickable
    {
        /// <summary>
        /// Уникальный идентификатор кнопки.
        /// </summary>
        string? Id { get; }

        /// <summary>
        /// Название кнопки.
        /// </summary>
        string? Title { get; }

        /// <summary>
        /// Доступна ли кнопка.
        /// </summary>
        bool IsEnabled { get; }
    }
}