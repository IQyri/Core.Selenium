using System;
using System.Collections.Generic;
using System.Diagnostics;
using OpenQA.Selenium;

namespace Core.Selenium
{
    /// <summary>
    /// Работа с драйвером браузера.
    /// </summary>
    public static class DisposeDriverService
    {
        /// <summary>
        /// Возможные драйвера браузеров.
        /// </summary>
        private static IReadOnlyList<string> _processesToCheck =
            new[]
            {
                "opera",
                "chrome",
                "firefox",
                "ie",
                "gecko",
                "phantomjs",
                "edge",
                "microsoftwebdriver",
                "webdriver"
            };
        
        /// <summary>
        /// Время старта теста.
        /// </summary>
        public static DateTime? TestRunStartTime { get; set; }

        /// <summary>
        /// Убийство драйвера. (Нераскрытое дело)
        /// </summary>
        /// <param name="driver">Веб-драйвер браузера <see cref="IWebDriver"/>.</param>
        public static void FinishHim(IWebDriver driver)
        {
            driver.Quit();
            driver?.Dispose();
            //return;
            var processes = Process.GetProcesses();
            foreach (var process in processes)
            {
                try
                {
                    Debug.WriteLine(process.ProcessName);
                    if (process.StartTime > TestRunStartTime)
                    {
                        var shouldKill = false;
                        foreach (var processName in _processesToCheck)
                        {
                            if (process.ProcessName.ToLower().Contains(processName))
                            {
                                shouldKill = true;
                                break;
                            }
                        }
                        if (shouldKill)
                        {
                            process.Kill();
                        }
                    }
                }
                catch (Exception e)
                {
                    Debug.WriteLine(e);
                }
            }
        }
    }
}
