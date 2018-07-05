using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;

namespace SportMusic.selenium
{
    interface IParser
    {
        void LoadMoodThread(object sender, EventArgs e);

        void LoadGenreThread(object sender, EventArgs e);

        void LoadTraksThread(object sender, EventArgs e);

        void ShowPreloaderTracksForm();

        void ShowPreloaderGenreForm();

        void ShowPreloaderMoodForm();

    }
}
