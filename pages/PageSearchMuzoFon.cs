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
    /// <summary>
    /// Страница поиска сайта МузоФон.
    /// </summary>
    public class PageSearchMuzoFon
    {
        /// <summary>
        /// Конструктор страницы поиска сайта МузоФон.
        /// </summary>
        /// <param name="browser">Принимает драйвер.</param>
        public PageSearchMuzoFon(IWebDriver browser)
        {            
            browser.Manage().Window.Minimize();
            PageFactory.InitElements(browser, this);
        }       

        /// <summary>
        /// Иконка "Play".
        /// </summary>
        [FindsBy(How = How.CssSelector, Using = "div.actions > ul > li.play")]
        public IWebElement IconPlay { get; set; }

        /// <summary>
        /// Иконка "Скачать".
        /// </summary>
        [FindsBy(How = How.CssSelector, Using = "div.actions > ul > li.download > a")]
        public IWebElement IconDownload { get; set; }
        public By IconDownloadBy { get { return By.CssSelector("div.actions > ul > li.download > a"); } }


        /// <summary>
        /// Имя артиста.
        /// </summary>
        [FindsBy(How = How.CssSelector, Using = "div.desc > h3 > span.artist")]
        public IWebElement TextArtist { get; set; }
        public By TextArtistBy { get { return By.CssSelector("div.desc > h3 > span.artist"); } }

        /// <summary>
        /// Название трека.
        /// </summary>
        [FindsBy(How = How.CssSelector, Using = "div.desc > h3 > span.track")]
        public IWebElement TextTrack { get; set; }
        public By TextTrackBy { get { return By.CssSelector("div.desc > h3 > span.track"); } }

        /// <summary>
        /// Длительность трека.
        /// </summary>
        [FindsBy(How = How.CssSelector, Using = "div.duration")]
        public IWebElement TextDuration { get; set; }
        public By TextDurationBy { get { return By.CssSelector("div.duration"); } }

    }
}
