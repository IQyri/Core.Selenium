using System.Collections.Generic;
using OpenQA.Selenium;

namespace Core.Selenium.Tools.Extensions
{
    /// <summary>
    /// Класс расширения поиска.
    /// </summary>
    public static class SearchContextExtensions
    {
        /// <summary>
        /// Поиск элемента по идентификатору.
        /// </summary>
        /// <param name="searchContext">Элемент <see cref="ISearchContext"/>.</param>
        /// <param name="id">Идентификатор.</param>
        /// <returns>Элемент <see cref="IWebElement"/>.</returns>
        public static IWebElement FindElementById(this ISearchContext searchContext, string id)
        {
            return searchContext.FindElement(By.Id(id));
        }

        /// <summary>
        /// Поиск элементов по идентификатору.
        /// </summary>
        /// <param name="searchContext">Элемент <see cref="ISearchContext"/>.</param>
        /// <param name="id">Идентификатор.</param>
        /// <returns>Коллекция элементов <see cref="IWebElement"/>.</returns>
        public static IReadOnlyCollection<IWebElement> FindElementsById(this ISearchContext searchContext, string id)
        {
            return searchContext.FindElements(By.Id(id));
        }

        /// <summary>
        /// Поиск элемента по LinkText.
        /// </summary>
        /// <param name="searchContext">Элемент <see cref="ISearchContext"/>.</param>
        /// <param name="linkText">LinkText.</param>
        /// <returns>Элемент <see cref="IWebElement"/>.</returns>
        public static IWebElement FindElementByLinkText(this ISearchContext searchContext, string linkText)
        {
            return searchContext.FindElement(By.LinkText(linkText));
        }

        /// <summary>
        /// Поиск элементов по LinkText.
        /// </summary>
        /// <param name="searchContext">Элемент <see cref="ISearchContext"/>.</param>
        /// <param name="linkText">LinkText.</param>
        /// <returns>Коллекция элементов <see cref="IWebElement"/>.</returns>
        public static IReadOnlyCollection<IWebElement> FindElementsByLinkText(this ISearchContext searchContext, string linkText)
        {
            return searchContext.FindElements(By.LinkText(linkText));
        }

        /// <summary>
        /// Поиск элемента по имени элемента.
        /// </summary>
        /// <param name="searchContext">Элемент <see cref="ISearchContext"/>.</param>
        /// <param name="name">Имя элемента.</param>
        /// <returns>Элемент <see cref="IWebElement"/>.</returns>
        public static IWebElement FindElementByName(this ISearchContext searchContext, string name)
        {
            return searchContext.FindElement(By.Name(name));
        }

        /// <summary>
        /// Поиск элементов по имени элемента.
        /// </summary>
        /// <param name="searchContext">Элемент <see cref="ISearchContext"/>.</param>
        /// <param name="name">Имя элемента.</param>
        /// <returns>Коллекция элементов <see cref="IWebElement"/>.</returns>
        public static IReadOnlyCollection<IWebElement> FindElementsByName(this ISearchContext searchContext, string name)
        {
            return searchContext.FindElements(By.Name(name));
        }

        /// <summary>
        /// Поиск элемента по XPath.
        /// </summary>
        /// <param name="searchContext">Элемент <see cref="ISearchContext"/>.</param>
        /// <param name="xPath">XPath.</param>
        /// <returns>Элемент <see cref="IWebElement"/>.</returns>
        public static IWebElement FindElementByXPath(this ISearchContext searchContext, string xPath)
        {
            return searchContext.FindElement(By.XPath(xPath));
        }

        /// <summary>
        /// Поиск элементов по XPath.
        /// </summary>
        /// <param name="searchContext">Элемент <see cref="ISearchContext"/>.</param>
        /// <param name="xPath">XPath.</param>
        /// <returns>Коллекция элементов <see cref="IWebElement"/>.</returns>
        public static IReadOnlyCollection<IWebElement> FindElementsByXPath(this ISearchContext searchContext, string xPath)
        {
            return searchContext.FindElements(By.XPath(xPath));
        }

        /// <summary>
        /// Поиск элемента по имени класса.
        /// </summary>
        /// <param name="searchContext">Элемент <see cref="ISearchContext"/>.</param>
        /// <param name="className">Имя класса.</param>
        /// <returns>Элемент <see cref="IWebElement"/>.</returns>
        public static IWebElement FindElementByClassName(this ISearchContext searchContext, string className)
        {
            return searchContext.FindElement(By.ClassName(className));
        }

        /// <summary>
        /// Поиск элементов по имени класса.
        /// </summary>
        /// <param name="searchContext">Элемент <see cref="ISearchContext"/>.</param>
        /// <param name="className">Имя класса.</param>
        /// <returns>Коллекция элементов <see cref="IWebElement"/>.</returns>
        public static IReadOnlyCollection<IWebElement> FindElementsByClassName(this ISearchContext searchContext, string className)
        {
            return searchContext.FindElements(By.ClassName(className));
        }

        /// <summary>
        /// Поиск элемента по PartialLinkText.
        /// </summary>
        /// <param name="searchContext">Элемент <see cref="ISearchContext"/>.</param>
        /// <param name="partialLinkText">PartialLinkText.</param>
        /// <returns>Элемент <see cref="IWebElement"/>.</returns>
        public static IWebElement FindElementByPartialLinkText(this ISearchContext searchContext, string partialLinkText)
        {
            return searchContext.FindElement(By.PartialLinkText(partialLinkText));
        }

        /// <summary>
        /// Поиск элементов по PartialLinkText.
        /// </summary>
        /// <param name="searchContext">Элемент <see cref="ISearchContext"/>.</param>
        /// <param name="partialLinkText">PartialLinkText.</param>
        /// <returns>Коллекция элементов <see cref="IWebElement"/>.</returns>
        public static IReadOnlyCollection<IWebElement> FindElementsByPartialLinkText(this ISearchContext searchContext, string partialLinkText)
        {
            return searchContext.FindElements(By.PartialLinkText(partialLinkText));
        }

        /// <summary>
        /// Поиск элемента по имени тага.
        /// </summary>
        /// <param name="searchContext">Элемент <see cref="ISearchContext"/>.</param>
        /// <param name="tagName">Имя тага.</param>
        /// <returns>Элемент <see cref="IWebElement"/>.</returns>
        public static IWebElement FindElementByTagName(this ISearchContext searchContext, string tagName)
        {
            return searchContext.FindElement(By.TagName(tagName));
        }

        /// <summary>
        /// Поиск элементов по имени тага.
        /// </summary>
        /// <param name="searchContext">Элемент <see cref="ISearchContext"/>.</param>
        /// <param name="tagName">Имя тага.</param>
        /// <returns>Коллекция элементов <see cref="IWebElement"/>.</returns>
        public static IReadOnlyCollection<IWebElement> FindElementsByTagName(this ISearchContext searchContext, string tagName)
        {
            return searchContext.FindElements(By.TagName(tagName));
        }

        /// <summary>
        /// Поиск элемента по Css селектору.
        /// </summary>
        /// <param name="searchContext">Элемент <see cref="ISearchContext"/>.</param>
        /// <param name="cssSelector">Css селектор.</param>
        /// <returns>Элемент <see cref="IWebElement"/>.</returns>
        public static IWebElement FindElementByCssSelector(this ISearchContext searchContext, string cssSelector)
        {
            return searchContext.FindElement(By.CssSelector(cssSelector));
        }

        /// <summary>
        /// Поиск элементов по Css селектору.
        /// </summary>
        /// <param name="searchContext">Элемент <see cref="ISearchContext"/>.</param>
        /// <param name="cssSelector">Css селектор.</param>
        /// <returns>Коллекция элементов <see cref="IWebElement"/>.</returns>
        public static IReadOnlyCollection<IWebElement> FindElementsByCssSelector(this ISearchContext searchContext, string cssSelector)
        {
            return searchContext.FindElements(By.CssSelector(cssSelector));
        }
    }

}
