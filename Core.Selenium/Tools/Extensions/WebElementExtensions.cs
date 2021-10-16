using System;
using System.Drawing;
using Core.Tools.Implementation;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace Core.Selenium.Tools.Extensions
{
    /// <summary>
    /// Класс расширение для работы с веб элементом.
    /// </summary>
    public static class WebElementExtensions
    {
        /// <summary>
        /// Подстветка элемента на странице.
        /// </summary>
        /// <param name="element">Веб-элемент <see cref="IWebElement"/>.</param>
        /// <returns>Подстветка элемента <see cref="IDisposable"/>.</returns>
        public static IDisposable Highlight(this IWebElement element)
        {
            var elementArea = new Rectangle(element.Location, element.Size);

            return Highlight(element, elementArea);
        }

        /// <summary>
        /// Подстветка элемента на странице по заданной области.
        /// </summary>
        /// <param name="element">Веб-элемент <see cref="IWebElement"/>.</param>
        /// <param name="elementArea">Область подсветки.</param>
        /// <returns>Подстветка области <see cref="IDisposable"/>.</returns>
        public static IDisposable Highlight(this IWebElement element, Rectangle elementArea)
        {
            var borderThickness = 4;
            var id = Guid.NewGuid().ToString();
            var cssStyle = new[]
            {
                "position: absolute;",
                $"border: {borderThickness}px solid red;",
                $"width: {elementArea.Width - borderThickness * 2}px;",
                $"height: {elementArea.Height - borderThickness * 2}px;",
                $"left: {elementArea.Left}px;",
                $"top: {elementArea.Top}px;",
                $"z-index: {Int32.MaxValue};",
                "pointer-events:none;"
                //"display: none;"
            };
            var javaScript = new[]
            {
                "let hightlightElement = document.createElement(\"div\");",
                $"hightlightElement.setAttribute(\"id\", \"{id}\");",
                $"hightlightElement.style.cssText = \"{string.Join("", cssStyle)}\";",
                "document.body.appendChild(hightlightElement);"
            };

            var script = string.Join("", javaScript);
            var rc = (RemoteWebElement) element;
            var driver = (IJavaScriptExecutor) rc.WrappedDriver;
            driver.ExecuteScript(script);

            var removeElement = new DisposableBag<IJavaScriptExecutor>(
                driver,
                webDriver =>
                {
                    var javaScriptRemove = new[]
                    {
                        $"var element = document.getElementById(\"{id}\");",
                        "element.parentNode.removeChild(element);",
                    };
                    driver.ExecuteScript(string.Join("", javaScriptRemove));
                }
            );

            return removeElement;
        }
    }
}