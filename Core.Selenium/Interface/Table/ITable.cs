using System.Collections.Generic;

namespace Core.Selenium.Interface.Table
{
    /// <summary>
    /// Интерфейс таблиц.
    /// </summary>
    public interface ITable : IControl
    {
        /// <summary>
        /// Колонки таблицы.
        /// </summary>
        IReadOnlyList<ITableColumn> Columns { get; }

        /// <summary>
        /// Строки таблицы.
        /// </summary>
        IReadOnlyList<ITableRow> Rows { get; }
    }
}
