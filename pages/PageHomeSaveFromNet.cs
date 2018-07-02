using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.PageObjects;

namespace SportMusic.pages
{
    public class PageHomeSaveFromNet
    {
        readonly public string urlSaveFromNet = "http://ru.savefrom.net";
        public readonly IWebDriver browser;

        public PageHomeSaveFromNet(IWebDriver browser)
        {
            browser.Manage().Window.Minimize();
            browser.Navigate().GoToUrl(urlSaveFromNet);            
            PageFactory.InitElements(browser, this);
        }

        /// <summary>
        /// Поле ввода ссылки для поиска.
        /// </summary>
        [FindsBy(How = How.Id, Using = "sf_url")]
        public IWebElement InputSearch { get; set; }

        /// <summary>
        /// Ссылка "Скачать без установки".
        /// </summary>
        [FindsBy(How = How.LinkText, Using = "Скачать без установки")]
        public IWebElement LinkDownloadNoInst { get; set; }

        /// <summary>
        /// Кнопка "Скачать".
        /// </summary>
        [FindsBy(How = How.ClassName, Using = ("def-btn-box"))]
        public IWebElement ButtonDowmload { get; set; }

        /// <summary>
        /// Иконка для выбора формата скачиваемого файла.
        /// </summary>
        [FindsBy(How = How.ClassName, Using = ("def-btn-name"))]
        public IWebElement IconSelectFormat
        {
            get
            {
                WebDriverWait ruSaveFromNetWait = new WebDriverWait(browser, TimeSpan.FromSeconds(15));
                IWebElement iconSelectFormat = ruSaveFromNetWait.Until(ExpectedConditions.ElementIsVisible(By.ClassName("def-btn-name")));

                return iconSelectFormat;
            }
        }

        //[FindsBy(How = How.ClassName, Using = ("def-btn-name"))]
        //public By IconSelectFormatBy { get { return By.ClassName("def-btn-name"); } }

        /// <summary>
        /// Список доступных форматов для скачивания.
        /// </summary>
        public List<IWebElement> ListFileFormat
        {
            get
            {
                WebDriverWait ruSaveFromNetWait = new WebDriverWait(browser, TimeSpan.FromSeconds(15));
                IWebElement listFileFormat = ruSaveFromNetWait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".link-group a")));

                return browser.FindElements(By.CssSelector(".link-group a")).ToList();
            }
        }

    }
}
