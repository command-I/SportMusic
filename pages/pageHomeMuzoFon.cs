using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;

namespace SportMusic.pages
{
    /// <summary>
    /// Главная страница поиска сайта МузоФон.
    /// </summary>
    public class PageHomeMuzoFon
    {
        public IWebDriver Browser { get; set; }

        readonly public string Url = "https://muzofond.org/";

        public PageHomeMuzoFon(IWebDriver browser)
        {
            Browser = browser;
            Browser.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            Browser.Navigate().GoToUrl(Url);
            PageFactory.InitElements(Browser, this);
        }

        /// <summary>
        /// Поле для поиска "Трек, исполнитель"
        /// </summary>
        [FindsBy(How = How.CssSelector, Using = ".inInputSearch input")]
        public IWebElement InputSearch { get; set; }

        /// <summary>
        /// Кнопка поиска "Трек, исполнитель".
        /// </summary>
        [FindsBy(How = How.CssSelector, Using = ".module-search button")]
        public IWebElement ButtonSearch { get; set; }

        /// <summary>
        /// Ссылка на категорию в колонке справа.
        /// </summary>
        [FindsBy(How = How.LinkText, Using = "Популярные сборники")]
        public IWebElement LinkPopularCollections { get; set; }

        /// <summary>
        /// Ссылка на категорию в колонке справа.
        /// </summary>
        [FindsBy(How = How.LinkText, Using = "Музыка на радио и ТВ")]
        public IWebElement LinkRadioTv { get; set; }

        /// <summary>
        /// Ссылка на категорию в колонке справа.
        /// </summary>
        [FindsBy(How = How.LinkText, Using = "Спортивная музыка")]
        public IWebElement LinkSportMusic { get; set; }
        public By LinkSportMusicBy { get { return By.LinkText("Спортивная музыка"); } }

        /// <summary>
        /// Ссылка на категорию в колонке справа.
        /// </summary>
        [FindsBy(How = How.LinkText, Using = "Саундтреки")]
        public IWebElement LinkSoundTraks { get; set; }

        /// <summary>
        /// Кнопка выбора категории "Жанр".
        /// </summary>
        [FindsBy(How = How.CssSelector, Using = ".module-popular a")]
        public IWebElement ButtonGenre { get; set; }
        public By ButtonGenreBy { get { return By.CssSelector(".module-popular a"); } }
        
    }

}
