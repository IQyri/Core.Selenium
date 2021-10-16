using System;

namespace Core.Selenium.Interface
{
    /// <summary>
    /// Базовый интерфейс для контролов.
    /// </summary>
    public interface IControl
    {
        /// <summary>
        /// Выделить элемент.
        /// </summary>
        /// <returns>Объект выделения.</returns>
        IDisposable Highlight();
    }
}
