using System.Collections.Generic;

namespace Core.Selenium.Interface.Control
{
    /// <summary>
    /// Интерфейс для тулбара.
    /// </summary>
    public interface IToolBar : IControl
    {
        /// <summary>
        /// Набор входящих в тулбар элементов.
        /// </summary>
        IReadOnlyList<IControl> Controls { get; }
    }
}
