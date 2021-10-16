using System.Drawing;
using System.IO;
using ImageMagick;
using OpenQA.Selenium;

namespace Core.Selenium.Tools.Extensions
{
    /// <summary>
    /// Расширение для создание скриншотов <see cref="ITakesScreenshot"/>.
    /// </summary>
    /// Copyright SotinNU aka VirRus77
    public static class TakesScreenshotExtensions
    {
        /// <summary>
        /// Сделать скриншот веб элемента <see cref="IWebElement"/>.
        /// </summary>
        /// <param name="takeScreenshot">Создатель скриншотов.</param>
        /// <param name="element">Веб элемент <see cref="IWebElement"/>.</param>
        /// <returns>Картинку скриншота.</returns>
        public static IMagickImage ElementScreenshot(this ITakesScreenshot takeScreenshot, IWebElement element)
        {
            var screenshot = takeScreenshot.GetScreenshot();
            var image = new MagickImage(new MemoryStream(screenshot.AsByteArray));
            var cropArea = new Rectangle(element.Location, element.Size);
            image.Crop(cropArea.Right, cropArea.Bottom, Gravity.Northwest);
            image.Crop(cropArea.Width, cropArea.Height, Gravity.Southeast);
            return image;
        }

        /// <summary>
        /// Сделать скриншот веб элемента <see cref="IWebElement"/>.
        /// </summary>
        /// <param name="takeScreenshot">Создатель скриншотов.</param>
        /// <param name="element">Веб элемент <see cref="IWebElement"/>.</param>
        /// <param name="filePath">Путь сохранения скриншота.</param>
        public static void ElementScreenshot(this ITakesScreenshot takeScreenshot, IWebElement element, string filePath)
        {
            using (var stream = File.Create(filePath))
            using (var image = takeScreenshot.ElementScreenshot(element))
            {
                image.Write(stream, MagickFormat.Png);
            }
        }

        /// <summary>
        /// Сделать скриншот всей страницы.
        /// </summary>
        /// <param name="takeScreenshot">Создатель скриншотов.</param>
        /// <param name="filePath">Путь сохранения скриншота.</param>
        public static void Screenshot(this ITakesScreenshot takeScreenshot, string filePath)
        {
            var sreenshot = takeScreenshot.GetScreenshot();
            sreenshot.SaveAsFile(filePath, ScreenshotImageFormat.Png);
        }
    }
}
