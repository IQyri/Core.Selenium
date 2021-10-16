using System;
using OpenQA.Selenium;

namespace Core.Selenium
{
    /// <summary>
    /// Базовый движок для тестов Selenium.
    /// </summary>
    public static class BaseSeleniumEngineTest
    {
        /// <summary>
        /// Веб драйвер.
        /// </summary>
        public static IWebDriver? _driver { get; private set; }

        /// <summary>
        /// Создатель скриншотов.
        /// </summary>
        public static ITakesScreenshot? ScreenShot { get; private set; }

        /// <summary>
        /// Инициализация веб драйвера.
        /// </summary>
        /// <param name="initializeWebDriver">Функция получения веб драйвера.</param>
        ///[AssemblyInitialize]
        public static void AssemblyInitialize(Func<IWebDriver> initializeWebDriver)
        {
            DisposeDriverService.TestRunStartTime = DateTime.Now;
            _driver = initializeWebDriver();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(0);
            ScreenShot = _driver as ITakesScreenshot;
        }

        /// <summary>
        /// Утилизация веб драйвера.
        /// </summary>
        ///[AssemblyCleanup]
        public static void AssemblyCleanUp()
        {
            if (_driver == null)
            {
                return;
            }
            DisposeDriverService.FinishHim(_driver);
        }

    }
}
