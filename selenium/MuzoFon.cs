using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SportMusic.pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using System.Threading;
using System.Windows.Forms;
using System.Drawing;
using System.Net;
using System.IO;
using System.ComponentModel;

namespace SportMusic.selenium
{
    class MuzoFon : ITrackFinder, IParser, ICleaner
    {
        public readonly Main_Form mainForm;

        /// <summary>
        /// Формы для вывода индикации о процессе загрузки.
        /// Используется при загрузке категорий в момент открытия формы и при загрузке треков.
        /// Выводится в основном процессе, закрывается из параллельного процесса при его завершении.
        /// </summary>
        public Form formPreloaderTracks;
        public Form formPreloaderGenre;
        public Form formPreloaderMood;

        public IWebDriver Browser { get; set; }
        public PageHomeMuzoFon PageHome { get; set; }
        public PageSportMuzoFon PageSport { get; set; }
        public PageSearchMuzoFon PageSearch { get; set; }

        public List<IWebElement> ListMood { get; set; }
        public List<IWebElement> ListGenre { get; set; }
        public List<IWebElement> ListArtists { get; set; }
        public List<IWebElement> ListTracks { get; set; }
        public List<IWebElement> ListDurations { get; set; }
        public List<IWebElement> ListDownloads { get; set; }
        public List<IWebElement> ListPlays { get; set; }
        public List<TrackOptions> ListTrackOptions { get; set; }
        public List<TrackOptions> ListSelectTrackOptions { get; set; }

        public int CountChecking { get; set; }

        /// <summary>
        /// Путь для сохранения скачиваемых файлов.
        /// </summary>
        public readonly string PATH_DOWNLOAD = Directory.GetCurrentDirectory() + "\\download\\";

        public MuzoFon(Main_Form form)
        {
            mainForm = form;

            ChromeOptions options = new ChromeOptions();
            ChromeDriverService service = ChromeDriverService.CreateDefaultService();
            service.HideCommandPromptWindow = true;
            Browser = new ChromeDriver(service, options);

            PageHome = new PageHomeMuzoFon(Browser);
            PageSport = new PageSportMuzoFon();
            PageSearch = new PageSearchMuzoFon(Browser);

            ListMood = new List<IWebElement>();
            ListGenre = new List<IWebElement>();
            ListArtists = new List<IWebElement>();
            ListTracks = new List<IWebElement>();
            ListDurations = new List<IWebElement>();
            ListDownloads = new List<IWebElement>();
            ListPlays = new List<IWebElement>();
            ListTrackOptions = new List<TrackOptions>();
            ListSelectTrackOptions = new List<TrackOptions>();
        }

        /// <summary>
        /// Вводит поискову фразу и запускает поиск.
        /// </summary>
        /// <param name="search"></param>
        public void GoArtistTrackSearch(string search)
        {
            PageHome.InputSearch.Clear();
            PageHome.InputSearch.SendKeys(search);
            PageHome.ButtonSearch.Click();
        }

        /// <summary>
        /// Скачивает полную информацию по трекам в отдельном потоке.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void LoadTraksThread(object sender, EventArgs e)
        {
            //Создние нового процесса. 
            ThreadPool.QueueUserWorkItem((object o) =>
            {
                if (PageSearch.GetElement(PageSearch.TextErrorFindBy) == null)
                {
                    ListArtists = Browser.FindElements(PageSearch.TextArtistBy).ToList();
                    ListTracks = Browser.FindElements(PageSearch.TextTrackBy).ToList();
                    ListDurations = Browser.FindElements(PageSearch.TextDurationBy).ToList();
                    ListDownloads = Browser.FindElements(PageSearch.IconDownloadBy).ToList();
                    ListPlays = Browser.FindElements(PageSearch.IconPlayBy).ToList();

                    for (int i = 0; i < ListArtists.Count; i++)
                    {
                        int durationTrack = mainForm.TimeStringToInt(ListDurations[i].Text);

                        if ((durationTrack < mainForm.DurationSetUser) || (mainForm.DurationSetUser == -1))
                        {
                            TrackOptions trackOptions = new TrackOptions(
                                                                            i,
                                                                            ListArtists[i].Text,
                                                                            ListTracks[i].Text,
                                                                            ListDurations[i].Text,
                                                                            ListDownloads[i].GetAttribute("href"),
                                                                            ListTracks[i].Text + ".mp3");
                            ListTrackOptions.Add(trackOptions);
                        }
                    }

                    //Обращение к элементам формы основного потока и закрытие прелоадера в основном потоке.
                    mainForm.Invoke(new MethodInvoker(() =>
                    {
                        mainForm.ShowFromSiteToForm(this.ListTrackOptions, mainForm.GetPanelResult(), mainForm.SetCountShowTracks());
                        formPreloaderTracks.Close();

                    }));

                }
                else
                {
                    //Обращение к элементам формы основного потока и закрытие прелоадера в основном потоке.
                    mainForm.Invoke(new MethodInvoker(() =>
                    {
                        mainForm.ShowFromSiteToForm(this.ListTrackOptions, mainForm.GetPanelResult(), mainForm.SetCountShowTracks());
                        formPreloaderTracks.Close();

                    }));

                    MessageBox.Show("Запрашиваемые треки не найдены");
                }

            });

        }


        public void LoadMoodThread(object sender, EventArgs e)
        {
            //Создние нового процесса. 
            ThreadPool.QueueUserWorkItem((object o) =>
            {

                Browser.FindElement(PageHome.LinkSportMusicBy).Click();
                ListMood = Browser.FindElements(PageSport.LinkCatalogSportMusicBy).ToList();

                //Загрузка данных и закрытие прелоадера в основном потоке.
                mainForm.Invoke(new MethodInvoker(() =>
                {

                    foreach (IWebElement element in ListMood)
                    {
                        mainForm.GetComboBoxMood().Items.Add(element.Text);
                    }

                    mainForm.GetComboBoxMood().SelectedItem = -1;
                    mainForm.GetComboBoxMood().Enabled = true;

                    formPreloaderMood.Close();

                    mainForm.GetPanelControl().Visible = true;
                    mainForm.GetPanelResult().Visible = true;
                    mainForm.GetPanelHead().Visible = true;

                }));
            });

        }


        public void LoadGenreThread(object sender, EventArgs e)
        {
            //Создние нового процесса. 
            ThreadPool.QueueUserWorkItem((object o) =>
            {

                ListGenre = Browser.FindElements(PageHome.ButtonGenreBy).ToList();

                for (int i = 0; i < ListGenre.Count; i++)
                {
                    if ((ListGenre[i].Text == "Все сборники"))
                    {
                        ListGenre.RemoveAt(i);
                    }
                }

                //Загрузка данных и закрытие прелоадера в основном потоке.
                mainForm.Invoke(new MethodInvoker(() =>
                {

                    for (int i = 0; i < 18; i++)
                    {
                        mainForm.GetComboBoxGenre().Items.Add(ListGenre[i].Text);
                    }

                    formPreloaderGenre.Close();

                }));
            });

        }


        public void GoToSelectGenre()
        {

            Browser.Navigate().GoToUrl(PageHome.Url);
            ListGenre = Browser.FindElements(PageHome.ButtonGenreBy).ToList();

            for (int i = 0; i < ListGenre.Count; i++)
            {
                if (ListGenre[i].Text == mainForm.GetComboBoxGenre().Text)
                {
                    Browser.Navigate().GoToUrl(ListGenre[i].GetAttribute("href"));
                    break;
                }
            }
        }


        public void GoToSelectMood()
        {
            for (int i = 0; i < ListMood.Count; i++)
            {
                if (ListMood[i].Text == mainForm.GetComboBoxMood().Text)
                {
                    Browser.Navigate().GoToUrl(ListMood[i].GetAttribute("href"));
                    break;
                }
            }
        }


        public void DownLoadind(int index, string target)
        {
            string name;
            string url;
            url = ListDownloads[index].GetAttribute("href").ToString();

            name = target+ "\\" + ListTracks[index].Text + ".mp3";
            url = ListDownloads[index].GetAttribute("href");
            //mainForm.textBox1.Text = url;
            MessageBox.Show(url);
            
            Download(url, name);
           


            //ListDownloads[index].Click();
            //DownloadFromLink(ListDownloads[index].GetAttribute("href"), PATH_DOWNLOAD, ListTracks[index].Text + ".mp3");
        }

        private void Download(string link, string name)
        {
            WebClient webload = new WebClient();
            webload.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
            webload.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressDown);

            webload.DownloadFileAsync(new Uri(link), name);
        }


        private void ProgressDown(object sender, DownloadProgressChangedEventArgs e)
        {
            mainForm.bunifuProgressBar1.Value = e.ProgressPercentage;
            mainForm.textBox1.Text = "Загружено :" + e.ProgressPercentage + " %";
            if (mainForm.bunifuProgressBar1.Value == 100)
            {
                mainForm.textBox1.Text = "Загрузка завершена";
            }
        }

        private void Completed(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show(e.Error.Message);
            }
            else
            {
                //mainForm.textBox1.Text = "Загрузка файла завершена";
            }
        }

        public void ClearLists()
        {
            if (ListArtists != null)
            {
                ListArtists.Clear();
            }

            if (ListTracks != null)
            {
                ListTracks.Clear();
            }

            if (ListDurations != null)
            {
                ListDurations.Clear();
            }

            if (ListDownloads != null)
            {
                ListDownloads.Clear();
            }

            if (ListPlays != null)
            {
                ListPlays.Clear();
            }

            if (ListTrackOptions != null)
            {
                ListTrackOptions.Clear();
            }

        }


        /// <summary>
        /// Вывод формы для индикации о процессе загрузки.
        /// Используется при загрузке категорий в момент открытия формы и при загрузке треков.
        /// Выводится в основном процессе, закрывается из параллельного процесса при его завершении.
        /// </summary>
        public void ShowPreloaderTracksForm()
        {
            PictureBox pic = new PictureBox();
            pic.ImageLocation = (Directory.GetCurrentDirectory() + "\\gif\\preloader_line_2.gif");

            formPreloaderTracks = new Form();
            formPreloaderTracks.Size = new Size(140, 21);
            formPreloaderTracks.FormBorderStyle = FormBorderStyle.None;
            formPreloaderTracks.StartPosition = FormStartPosition.CenterScreen;
            formPreloaderTracks.Shown += LoadTraksThread;
            formPreloaderTracks.Controls.Add(pic);
            formPreloaderTracks.TopMost = true;
            formPreloaderTracks.Show();
        }

        public void ShowPreloaderGenreForm()
        {
            PictureBox pic = new PictureBox();
            pic.ImageLocation = (Directory.GetCurrentDirectory() + "\\gif\\preloader_line_2.gif");

            formPreloaderGenre = new Form();
            formPreloaderGenre.Size = new Size(140, 21);
            formPreloaderGenre.FormBorderStyle = FormBorderStyle.None;
            formPreloaderGenre.StartPosition = FormStartPosition.CenterScreen;
            formPreloaderGenre.Shown += LoadGenreThread;
            formPreloaderGenre.Controls.Add(pic);
            formPreloaderGenre.TopMost = true;
            formPreloaderGenre.Show();
        }

        public void ShowPreloaderMoodForm()
        {
            PictureBox pic = new PictureBox();
            pic.ImageLocation = (Directory.GetCurrentDirectory() + "\\gif\\preloader_line_2.gif");

            formPreloaderMood = new Form();
            formPreloaderMood.Size = new Size(140, 21);
            formPreloaderMood.FormBorderStyle = FormBorderStyle.None;
            formPreloaderMood.StartPosition = FormStartPosition.CenterScreen;
            formPreloaderMood.Shown += LoadMoodThread;
            formPreloaderMood.Controls.Add(pic);
            formPreloaderMood.TopMost = true;
            formPreloaderMood.Show();
        }


        /// <summary>
        /// Клонирование объектов для передачи в следующие модули.
        /// </summary>
        /// <returns></returns>
        public List<TrackOptions> Result()
        {
            List<TrackOptions> forNextModules = new List<TrackOptions>();

            foreach (TrackOptions trackOptions in ListTrackOptions)
            {
                forNextModules.Add((TrackOptions)trackOptions.Clone());
            }

            return forNextModules;
        }

    }
}
