using Core.Selenium.Interface.Control;

namespace Core.Selenium.Interface.Table
{
    /// <summary>
    /// Интерфейс колонок таблицы.
    /// </summary>
    public interface ITableColumn :IControl, IClickable
    {
        /// <summary>
        /// Название колонки.
        /// </summary>
        string? Name { get; set; }

        /// <summary>
        /// Метод нажатия на колонку сортировки.
        /// </summary>
        void Sort();

        /// <summary>
        /// Фильтрация по строке.
        /// </summary>
        IInput SearchInput { get; }
    }
}
