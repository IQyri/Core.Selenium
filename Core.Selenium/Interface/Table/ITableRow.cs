using System.Collections.Generic;

namespace Core.Selenium.Interface.Table
{
    /// <summary>
    /// Интрефейс строк таблицы.
    /// </summary>
    public interface ITableRow : IControl
    {
        /// <summary>
        /// Выбрана ли строка.
        /// </summary>
        bool IsSelected { get; }

        /// <summary>
        /// Ячейки строки.
        /// </summary>
        IReadOnlyList<ITableCell> Cells { get; }
    }
}
