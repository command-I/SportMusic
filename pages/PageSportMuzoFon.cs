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
    public class PageSportMuzoFon
    {

        /// <summary>
        /// 
        /// </summary>
        [FindsBy(How = How.CssSelector, Using = ".module-layout a")]
        public IWebElement LinkCatalogSportMusic { get; set; }
        public By LinkCatalogSportMusicBy { get { return By.CssSelector(".module-layout a"); } }
    }
}
