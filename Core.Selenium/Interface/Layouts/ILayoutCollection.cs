using System.Collections.Generic;

namespace Core.Selenium.Interface.Layouts
{
    /// <summary>
    /// ИНтерфейс для коллекций контролов размещения.
    /// </summary>
    public interface ILayoutCollection : ILayout
    {
        /// <summary>
        /// Коллекция размещенных контролов.
        /// </summary>
        IReadOnlyList<IControl> Controls { get; }
    }
}
