using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Runtime.InteropServices;
using SportMusic.pages;
using SportMusic.selenium;
using System.Net;
using System.IO;
using System.Threading;
using OpenQA.Selenium.Chrome;

namespace SportMusic
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Текущий адрес браузера. 
        /// </summary>
        string url;

        /// <summary>
        /// Драйвер управляющий браузером.
        /// </summary>
        IWebDriver browser;
        IWebDriver browserMood;

        /// <summary>
        /// Домашняя страница сайта МузоФон.
        /// </summary>
        PageHomeMuzoFon pageHomeMuzoFon;
        PageHomeMuzoFon pageHomeMuzoFonGenre;
        PageHomeMuzoFon pageHomeMuzoFonMood;

        /// <summary>
        /// Страница с результатами поиска сайта МузоФон.
        /// </summary>
        PageSearchMuzoFon pageSearchMuzoFon;

        /// <summary>
        /// Список элементов с именами артистов.
        /// </summary>
        List<IWebElement> listArtists;

        /// <summary>
        /// Список элементов с названиями треков.
        /// </summary>
        List<IWebElement> listTracks;

        /// <summary>
        /// Список элементов с длительностями треков.
        /// </summary>
        List<IWebElement> listDuration;

        /// <summary>
        /// Список элементов с длительностями треков.
        /// </summary>
        List<IWebElement> listDownload;

        /// <summary>
        /// Список элементов с кнпвами "Play".
        /// </summary>
        List<IWebElement> listPlay;

        /// <summary>
        /// Список с категориями "Настроение".
        /// </summary>
        List<IWebElement> listMoodMuzoFon;

        /// <summary>
        /// Список с категориями "Жанр".
        /// </summary>
        List<IWebElement> listGenreMuzoFon;

        /// <summary>
        /// Список с объектами, содержащими полную информацию по трекам.
        /// </summary>
        List<TrackOptions> listTrackOptions = new List<TrackOptions>();

        /// <summary>
        /// Список с выбранными объектами - для передачи в другие модули. 
        /// </summary>
        List<TrackOptions> listSelectTrackOptions = new List<TrackOptions>();

        /// <summary>
        /// Путь для сохранения скачиваемых файлов.
        /// </summary>
        string PATH_DOWNLOAD = Directory.GetCurrentDirectory() + "\\download\\";

        /// <summary>
        /// Счётчик выбранных треков.
        /// </summary>
        int countChecking = 0;

        /// <summary>
        /// Ссылка на форму.
        /// </summary>
        Form2 form2;

        /// <summary>
        /// Форма для вывода индикации о процессе загрузки.
        /// Используется при загрузке категорий в момент открытия формы и при загрузке треков.
        /// Выводится в основном процессе, закрывается из параллельного процесса при его завершении.
        /// </summary>
        Form formPreloaderTracks;
        Form formPreloaderGenre;
        Form formPreloaderMood;

        //PictureBox animation = new PictureBox();

        int durationTrack;
        int durationSetUser;

        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;                        
            panelControl.Visible = false;
            panelResult.Visible = false;
            panelHead.Visible = false;

            ChromeOptions options = new ChromeOptions();
            ChromeDriverService service = ChromeDriverService.CreateDefaultService();
            service.HideCommandPromptWindow = true;

            browser = new ChromeDriver(service, options);
            browserMood = new ChromeDriver(service, options);
                        
            browser.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            browserMood.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
        }

        /// <summary>
        /// Приведение элементов формы к исходному состоянию.
        /// </summary>
        private void FormElementInit()
        {
            panelResult.Controls.Clear();
            comboBoxMood.Items.Clear();
            comboBoxGenre.Items.Clear();

            textBoxArtistTrack.Text = "";
            comboBoxMood.Text = "";            

            comboBoxCount.Items.Clear();
            comboBoxCount.Items.Add("1");
            comboBoxCount.Items.Add("3");
            comboBoxCount.Items.Add("5");
            comboBoxCount.Items.Add("10");
            comboBoxCount.Items.Add("20");
            comboBoxCount.Items.Add("30");
            comboBoxCount.Items.Add("50");
            comboBoxCount.Items.Add("100");
            comboBoxCount.Text = comboBoxCount.Items[7].ToString();

            comboBoxDuration.Items.Clear();
            comboBoxDuration.Items.Add("Любая");
            comboBoxDuration.Items.Add("01:00");
            comboBoxDuration.Items.Add("01:30");
            comboBoxDuration.Items.Add("02:00");
            comboBoxDuration.Items.Add("02:30");
            comboBoxDuration.Items.Add("03:00");
            comboBoxDuration.Items.Add("03:30");
            comboBoxDuration.Items.Add("04:00");
            comboBoxDuration.Items.Add("04:30");
            comboBoxDuration.Items.Add("05:00");
            comboBoxDuration.Text = comboBoxDuration.Items[0].ToString();

            textBoxArtistTrack.Enabled = true;
            comboBoxDuration.Enabled = true;
            comboBoxCount.Enabled = true;
            comboBoxMood.Enabled = true;
            comboBoxGenre.Enabled = true;
            radioButtonMuzoFon.Checked = true;

            buttonSave.Enabled = false;
            buttonSearch.Enabled = false;
            buttonClearGenre.Enabled = false;
            buttonClearMood.Enabled = false;
            buttonClearTrackArtist.Enabled = false;            
            checkBoxSelectAll.Enabled = false;
            

        }

        /// <summary>
        /// Действия по выбору сайта "МузоФон".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButtonMuzoFon_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;

            ShowPreloaderGenreForm();
            ShowPreloaderMoodForm();
            FormElementInit();           

            if (pageHomeMuzoFon == null)
            {
                pageHomeMuzoFon = new PageHomeMuzoFon(browser);
            }

            if (radioButton.Checked)
            {
                url = pageHomeMuzoFon.urlMuzoFon;
            }

        }

        /// <summary>
        /// Действия по отметке трека как выбранного.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBoxSelect_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            int num = Int32.Parse(checkBox.Name);

            if (checkBox.Checked)
            {
                countChecking++;
                buttonSave.Enabled = true;
                listSelectTrackOptions.Add(listTrackOptions[num]);
            }
            else
            {
                countChecking--;

                if (countChecking == 0)
                {
                    buttonSave.Enabled = false;
                }

                for (int i = 0; i < listSelectTrackOptions.Count; i++)
                {
                    if (listSelectTrackOptions[i].Num == num)
                    {
                        listSelectTrackOptions.RemoveAt(i);
                    }
                }

            }

        }
       

        /// <summary>
        /// Действия по нажатию на кнопку "Поиск".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSearch_Click(object sender, EventArgs e)
        {

            checkBoxSelectAll.Checked = false;
            checkBoxSelectAll.Enabled = false;

            if (listArtists != null)
            {
                listArtists.Clear();
            }

            if (listTracks != null)
            {
                listTracks.Clear();
            }

            if (listDuration != null)
            {
                listDuration.Clear();
            }

            if (listDownload != null)
            {
                listDownload.Clear();
            }

            if (listPlay != null)
            {
                listPlay.Clear();
            }

            if (listTrackOptions != null)
            {
                listTrackOptions.Clear();
            }

            panelResult.Controls.Clear();

            if ((textBoxArtistTrack.Text == "") && (comboBoxMood.Text == "") && (comboBoxGenre.Text == ""))
            {
                MessageBox.Show("Необходимо выбрать один из критериев поиска");
            }
            else
            {               

                countChecking = 0;
                durationSetUser = TimeStringToInt(comboBoxDuration.Text);

                buttonSearch.Enabled = false;

                if (radioButtonMuzoFon.Checked)
                {
                    if (pageHomeMuzoFon == null)
                    {
                        pageHomeMuzoFon = new PageHomeMuzoFon(browser);
                    }

                    if ((comboBoxMood.Enabled == false) && (comboBoxGenre.Enabled == false))
                    {
                        ArtistTrackSearch();
                    }
                    else
                    {
                        if (comboBoxMood.Enabled == true)
                        {
                            GoToSelectMood();
                        }
                        else
                        {
                            GoToSelectGenre();
                        }

                    }

                    ShowPreloaderTracksForm();
                   
                }
                else
                {
                    // Здесь будет Яндекс.
                }
            }
            
            buttonSearch.Enabled = true;
        }


        /// <summary>
        /// Действия по нажатию на кнопку сохранить.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDownload_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            int index = Int32.Parse(button.Name);
            listDownload[index].Click();

            DownloadFromLink(listDownload[index].GetAttribute("href"), PATH_DOWNLOAD, listTracks[index].Text + ".mp3");
        }

        /// <summary>
        /// Действия по нажатию на кнопку "Play".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPlay_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            listPlay[Int32.Parse(button.Name)].Click();
        }


        // !!! на МузоФон не работает.
        private void buttonFindFormat_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            int num = Int32.Parse(button.Name);
            string loadUrl = listTrackOptions[num].DownloadUrl;

            PageHomeSaveFromNet pageHomeSaveFromNet = new PageHomeSaveFromNet(browser);
            pageHomeSaveFromNet.InputSearch.SendKeys(loadUrl + OpenQA.Selenium.Keys.Enter);
            pageHomeSaveFromNet.LinkDownloadNoInst.Click();
            pageHomeSaveFromNet.IconSelectFormat.Click();

            List<IWebElement> listFileFormat = pageHomeSaveFromNet.ListFileFormat;

            foreach (IWebElement element in listFileFormat)
            {
                ComboBox cmb = panelResult.Controls["comboBoxFindFormat_" + Int32.Parse(button.Name)] as ComboBox;
                cmb.Enabled = true;
                cmb.Items.Add(element.Text);
            }

        }

        /// <summary>
        /// Скачивание файлов по url.
        /// </summary>
        /// <param name="url">Принимает ссылку.</param>
        /// <param name="path">Принимает путь для сохранения.</param>
        /// <param name="file">Принимает имя файла.</param>
        private void DownloadFromLink(string url, string path, string file)
        {
            WebClient client = new WebClient();
            client.DownloadFile(url, path + file);
        }

        /// <summary>
        /// Преобразование строки со значением длительности в числовое значение. 
        /// </summary>
        /// <param name="time">Принимает строку со значением времени.</param>
        /// <returns>Возврашает количество секунд.</returns>
        private int TimeStringToInt(string time)
        {
            int minDec = 0;
            int minEd = 0;
            int secDec = 0;
            int secEd = 0;

            try
            {
                minDec = Int32.Parse(time[0].ToString()) * 600;
                minEd = Int32.Parse(time[1].ToString()) * 60;
                secDec = Int32.Parse(time[3].ToString()) * 10;
                secEd = Int32.Parse(time[4].ToString());
            }
            catch (Exception)
            {
                return -1;
            }


            return minDec + minEd + secDec + secEd;
        }

        /// <summary>
        /// Загрузка информации со страницы поиска.
        /// </summary>
        /// <returns>Возвращает список с элементами из результатов поиска.</returns>
        private List<TrackOptions> LoadTracksFromSite()
        {
            if (pageSearchMuzoFon == null)
            {
                pageSearchMuzoFon = new PageSearchMuzoFon(browser);
            }

            listArtists = browser.FindElements(pageSearchMuzoFon.TextArtistBy).ToList();
            listTracks = browser.FindElements(pageSearchMuzoFon.TextTrackBy).ToList();
            listDuration = browser.FindElements(pageSearchMuzoFon.TextDurationBy).ToList();
            listDownload = browser.FindElements(pageSearchMuzoFon.IconDownloadBy).ToList();
            listPlay = browser.FindElements(pageSearchMuzoFon.IconPlayBy).ToList();

            for (int i = 0; i < listArtists.Count; i++)
            {

                int durationTrack = TimeStringToInt(listDuration[i].Text);
                int durationSetUser = TimeStringToInt(comboBoxDuration.Text);

                if ((durationTrack < durationSetUser) || (durationSetUser == -1))
                {
                    TrackOptions trackOptions = new TrackOptions(
                                                                i,
                                                                listArtists[i].Text,
                                                                listTracks[i].Text,
                                                                listDuration[i].Text,
                                                                listDownload[i].GetAttribute("href"),
                                                                listTracks[i].Text + ".mp3");
                    listTrackOptions.Add(trackOptions);
                }

            }

            return listTrackOptions;
        }

        /// <summary>
        /// Вывод выбранных элементов, содержащих полную инфрмацию по трекам.
        /// </summary>
        /// <param name="listTrackOptions"></param>
        /// <param name="panel"></param>
        private void ShowSelectToForm(List<TrackOptions> listTrackOptions, Panel panel)
        {

            int distanceTop = 40;
            int leftLabelArtist = 160;
            int leftLabelTrack = 270;
            int leftDurationTrack = 500;
            int leftDownloadUrl = 600;


            for (int i = 0; i < listTrackOptions.Count; i++)
            {
                Label labelNum = new Label();
                labelNum.Width = 30;
                labelNum.Left = 10;
                labelNum.Top = 10 + i * distanceTop;
                labelNum.Text = (i + 1).ToString() + ".";
                panel.Controls.Add(labelNum);

                Label labelArtist = new Label();
                labelArtist.Left = leftLabelArtist;
                labelArtist.Top = 10 + i * distanceTop;
                labelArtist.Text = listTrackOptions[i].Artist;
                panel.Controls.Add(labelArtist);

                Label labelTrack = new Label();
                labelTrack.Left = leftLabelTrack;
                labelTrack.Top = 10 + i * distanceTop;
                labelTrack.Text = listTrackOptions[i].Track;
                panel.Controls.Add(labelTrack);

                Label labelDuration = new Label();
                labelDuration.Width = 40;
                labelDuration.Left = leftDurationTrack;
                labelDuration.Top = 10 + i * distanceTop;
                labelDuration.Text = listTrackOptions[i].Duration;
                panel.Controls.Add(labelDuration);

                Label labelDownloadUrl = new Label();
                labelDownloadUrl.Width = 300;
                labelDownloadUrl.Left = leftDownloadUrl;
                labelDownloadUrl.Top = 10 + i * distanceTop;
                labelDownloadUrl.Text = listTrackOptions[i].DownloadUrl;
                panel.Controls.Add(labelDownloadUrl);
            }
        }

        private void ShowFromSiteToForm(List<TrackOptions> listTrackOptions, Panel panel, int count)
        {

            int distanceTop = 40;
            int leftLabelNum = 10;
            int leftCheckBoxSelectTrack = 40;

            int leftButtonPlay = 70;
            int leftLabelArtist = 150;
            int leftLabelTrack = 300;
            int leftDurationTrack = 630;

            int leftButtonFindFormat = 520;
            int leftComboBoxFormats = 680;
            int leftButtonDownload = 750;

            if (listTrackOptions.Count < count)
            {
                count = listTrackOptions.Count;
            }            

            for (int i = 0; i < count; i++)
            {
                Label labelNum = new Label();
                labelNum.Width = 30;
                labelNum.Left = leftLabelNum;
                labelNum.Top = i * distanceTop;
                labelNum.Text = (i + 1).ToString() + ".";
                panel.Controls.Add(labelNum);

                CheckBox checkBoxSelectTrack = new CheckBox();
                checkBoxSelectTrack.Width = 20;
                checkBoxSelectTrack.Name = i.ToString();
                checkBoxSelectTrack.Left = leftCheckBoxSelectTrack;
                checkBoxSelectTrack.Top = i * distanceTop;
                checkBoxSelectTrack.CheckedChanged += checkBoxSelect_CheckedChanged;                
                panel.Controls.Add(checkBoxSelectTrack);

                Button buttonPlay = new Button();
                buttonPlay.Name = i.ToString();
                buttonPlay.Width = 40;
                buttonPlay.Left = leftButtonPlay;
                buttonPlay.Top = i * distanceTop;
                buttonPlay.Text = "Play";
                buttonPlay.Click += buttonPlay_Click;
                panel.Controls.Add(buttonPlay);

                Label labelArtist = new Label();
                labelArtist.Left = leftLabelArtist;
                labelArtist.Top = i * distanceTop;
                labelArtist.Text = listTrackOptions[i].Artist;
                panel.Controls.Add(labelArtist);

                Label labelTrack = new Label();
                labelTrack.Width = 300;
                labelTrack.Left = leftLabelTrack;
                labelTrack.Top = i * distanceTop;
                labelTrack.Text = listTrackOptions[i].Track;
                panel.Controls.Add(labelTrack);

                Label labelDuration = new Label();
                labelDuration.Width = 40;
                labelDuration.Left = leftDurationTrack;
                labelDuration.Top = i * distanceTop;
                labelDuration.Text = listTrackOptions[i].Duration;
                panel.Controls.Add(labelDuration);

                /*
                Button buttonFindFormat = new Button();
                buttonFindFormat.Name = i.ToString();
                buttonFindFormat.Width = 80;
                buttonFindFormat.Left = leftButtonFindFormat;
                buttonFindFormat.Top = 10 + i * distanceTop;
                buttonFindFormat.Text = "Запросить";
                buttonFindFormat.Click += buttonFindFormat_Click;                
                buttonFindFormat.Enabled = false;                
                panel.Controls.Add(buttonFindFormat);
                                
                ComboBox comboBoxSelectFormat = new ComboBox();
                comboBoxSelectFormat.Name = "comboBoxFindFormat_" + i.ToString();
                comboBoxSelectFormat.Width = 80;
                comboBoxSelectFormat.Left = leftComboBoxFormats;
                comboBoxSelectFormat.Top = 10 + i * distanceTop;
                buttonFindFormat.Click += buttonFindFormat_Click;
                comboBoxSelectFormat.Enabled = false;
                panel.Controls.Add(comboBoxSelectFormat);
                */

                Button buttonDownload = new Button();
                buttonDownload.Name = i.ToString();
                buttonDownload.Width = 80;
                buttonDownload.Left = leftButtonDownload;
                buttonDownload.Top = i * distanceTop;
                buttonDownload.Text = "Скачать";
                buttonDownload.Click += buttonDownload_Click;
                buttonDownload.Enabled = true;
                panel.Controls.Add(buttonDownload);
            }

            if(count != 0)
            {
                checkBoxSelectAll.Enabled = true;
            }
        }

        /// <summary>
        /// Действия по изменеию текста в поле для поиска.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxArtistTrack_TextChanged(object sender, EventArgs e)
        {
            if (textBoxArtistTrack.Text != "")
            {
                buttonClearTrackArtist.Enabled = true;
                comboBoxMood.Enabled = false;
                comboBoxGenre.Enabled = false;
                buttonSearch.Enabled = true;
                buttonClearGenre.Enabled = false;
                buttonClearMood.Enabled = false;
            }
            else
            {
                buttonClearTrackArtist.Enabled = false;
                comboBoxMood.Enabled = true;
                comboBoxGenre.Enabled = true;
                buttonSearch.Enabled = false;
            }
            
         
        }

        /// <summary>
        /// Действия при закрытии формы.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (browser != null)
            {
                browser.Quit();
            }

            if (browserMood != null)
            {
                browserMood.Quit();
            }
        }

        /// <summary>
        /// Клонирование объектов для передачи в следующие модули.
        /// </summary>
        /// <returns></returns>
        public List<TrackOptions> Result()
        {
            List<TrackOptions> forNextModules = new List<TrackOptions>();

            foreach (TrackOptions trackOptions in listTrackOptions)
            {
                forNextModules.Add((TrackOptions)trackOptions.Clone());
            }

            return forNextModules;
        }

        /// <summary>
        /// Действия по нажатию на кнопку "Сохранить".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (listTrackOptions.Count != 0)
            {
                form2 = new Form2(this);
                form2.Show();

                form2.PanelSelectedTracks.Controls.Clear();
                ShowSelectToForm(listSelectTrackOptions, form2.PanelSelectedTracks);
                form2.Activate();


            }
        }
       

        /// <summary>
        /// При поиске по "Настроение" блокируется выбор по "Жанр" и "Артист-Трек".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxMood_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;            

            if (comboBox.Text != "")
            {
                buttonClearMood.Enabled = true;
                comboBoxGenre.Enabled = false;
                textBoxArtistTrack.Enabled = false;
                buttonClearTrackArtist.Enabled = false;
                buttonClearGenre.Enabled = false;
                buttonSearch.Enabled = true;
            }
            else
            {      
                comboBoxGenre.Enabled = true;
                textBoxArtistTrack.Enabled = true;             
            }
        }

        /// <summary>
        /// При поиске по "Жанр" блокируется выбор по "Настроение" и "Артист-Трек".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxGenre_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            
            if (comboBox.Text != "")
            {
                buttonClearGenre.Enabled = true;
                comboBoxMood.Enabled = false;
                textBoxArtistTrack.Enabled = false;
                buttonClearTrackArtist.Enabled = false;
                buttonClearMood.Enabled = false;
                buttonSearch.Enabled = true;
            }
            else
            {
                comboBoxMood.Enabled = true;
                textBoxArtistTrack.Enabled = true;           
            }
        }

        /// <summary>
        /// Очистка элемента "Трек-Артист".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            textBoxArtistTrack.Text = "";            
            button.Enabled = false;
        }

        
        private void Form1_Shown(object sender, EventArgs e)
        {
            FormElementInit();           
        }

        /// <summary>
        /// Переход в выбранный раздел категории "Настроение" сайта МузоФон.
        /// Выполняется после выбора категории и нажатия кнопки "Поиск".
        /// </summary>
        private void GoToSelectMood()
        {
            for (int i = 0; i < listMoodMuzoFon.Count; i++)
            {
                if (listMoodMuzoFon[i].Text == comboBoxMood.Text)
                {
                    browser.Navigate().GoToUrl(listMoodMuzoFon[i].GetAttribute("href"));
                    break;
                }
            }
        }

        /// <summary>
        /// Поиск по критерию "Артист-Трек".
        /// Выпоняется после ввода имени артиста или названия трека и нажатия кнопки "Пуск".
        /// </summary>
        private void ArtistTrackSearch()
        {
            if (textBoxArtistTrack.Text != "Трек, исполнитель")
            {
                pageHomeMuzoFon.InputSearch.Clear();
                pageHomeMuzoFon.InputSearch.SendKeys(textBoxArtistTrack.Text);
                pageHomeMuzoFon.ButtonSearch.Click();
            }
        }


        /// <summary>
        /// Ограничение количества выводимых треков в результатах поиска.
        /// Устанавливается пользователем на форме поиска треков.
        /// </summary>
        private int SetCountShowTracks()
        {
            int countShowTreks = 0;

            try
            {
                countShowTreks = Int32.Parse(comboBoxCount.Text);

                if (countShowTreks > 100)
                {
                    countShowTreks = 100;
                    comboBoxCount.Text = "100";
                }
            }
            catch (Exception)
            {
                comboBoxCount.Text = "100";
                return countShowTreks = 100;
            }

            return countShowTreks;
        }


        /// <summary>
        /// Загрузка с сайта Музофон в категорию "Жанр".
        /// Производится при открытии формы для поиска треков.
        /// </summary>
        private void GoToSelectGenre()
        {
            if (pageHomeMuzoFon == null)
            {
                pageHomeMuzoFon = new PageHomeMuzoFon(browser);
            }

            browser.Navigate().GoToUrl(pageHomeMuzoFon.urlMuzoFon);
            listGenreMuzoFon = browser.FindElements(pageHomeMuzoFon.ButtonGenreBy).ToList();

            for (int i = 0; i < listGenreMuzoFon.Count; i++)
            {
                if (listGenreMuzoFon[i].Text == comboBoxGenre.Text)
                {
                    browser.Navigate().GoToUrl(listGenreMuzoFon[i].GetAttribute("href"));
                    break;
                }
            }
        }


        /// <summary>
        /// Вывод формы для индикации о процессе загрузки.
        /// Используется при загрузке категорий в момент открытия формы и при загрузке треков.
        /// Выводится в основном процессе, закрывается из параллельного процесса при его завершении.
        /// </summary>
        private void ShowPreloaderTracksForm()
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

        private void ShowPreloaderGenreForm()
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

        private void ShowPreloaderMoodForm()
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


        public void LoadTraksThread(object sender, EventArgs e)
        {
            //Создние нового процесса. 
            ThreadPool.QueueUserWorkItem((object o) =>
            {
                //Загрузка данных.                
                if (pageSearchMuzoFon == null)
                {
                    pageSearchMuzoFon = new PageSearchMuzoFon(browser);
                }

                listArtists = browser.FindElements(pageSearchMuzoFon.TextArtistBy).ToList();
                listTracks = browser.FindElements(pageSearchMuzoFon.TextTrackBy).ToList();
                listDuration = browser.FindElements(pageSearchMuzoFon.TextDurationBy).ToList();
                listDownload = browser.FindElements(pageSearchMuzoFon.IconDownloadBy).ToList();
                listPlay = browser.FindElements(pageSearchMuzoFon.IconPlayBy).ToList();                

                for (int i = 0; i < listArtists.Count; i++)
                {
                    durationTrack = TimeStringToInt(listDuration[i].Text);

                    if ((durationTrack < durationSetUser) || (durationSetUser == -1))
                    {
                        TrackOptions trackOptions = new TrackOptions(
                                                                    i,
                                                                    listArtists[i].Text,
                                                                    listTracks[i].Text,
                                                                    listDuration[i].Text,
                                                                    listDownload[i].GetAttribute("href"),
                                                                    listTracks[i].Text + ".mp3");
                        listTrackOptions.Add(trackOptions);
                    }
                }

                //Обращение к элементам формы основного потока и закрытие прелоадера в основном потоке.
                this.Invoke(new MethodInvoker(() =>
                {                    
                    formPreloaderTracks.Close();
                    ShowFromSiteToForm(listTrackOptions, panelResult, SetCountShowTracks());

                }));
            });

        }


        public void LoadGenreThread(object sender, EventArgs e)
        {
            //Создние нового процесса. 
            ThreadPool.QueueUserWorkItem((object o) =>
            {
                //Загрузка данных.                
                if (pageHomeMuzoFonGenre == null)
                {
                    pageHomeMuzoFonGenre = new PageHomeMuzoFon(browser);
                }

                listGenreMuzoFon = browser.FindElements(pageHomeMuzoFon.ButtonGenreBy).ToList();

                for (int i = 0; i < listGenreMuzoFon.Count; i++)
                {
                    if ((listGenreMuzoFon[i].Text == "Все сборники"))
                    {
                        listGenreMuzoFon.RemoveAt(i);
                    }
                }

                //Загрузка данных и закрытие прелоадера в основном потоке.
                this.Invoke(new MethodInvoker(() =>
                {

                    comboBoxGenre.Items.Add("--- Отменить выбор ---");

                    for (int i = 0; i < 18; i++)
                    {
                        comboBoxGenre.Items.Add(listGenreMuzoFon[i].Text);
                    }

                    formPreloaderGenre.Close();

                }));
            });

        }


        public void LoadMoodThread(object sender, EventArgs e)
        {
            //Создние нового процесса. 
            ThreadPool.QueueUserWorkItem((object o) =>
            {
                //Загрузка данных.                
                if (pageHomeMuzoFonMood == null)
                {
                    pageHomeMuzoFonMood = new PageHomeMuzoFon(browserMood);
                }

                browserMood.FindElement(pageHomeMuzoFonMood.LinkSportMusicBy).Click();

                PageSportMuzoFon pageSportMuzoFon = new PageSportMuzoFon();
                listMoodMuzoFon = browserMood.FindElements(pageSportMuzoFon.LinkCatalogSportMusicBy).ToList();

                //Загрузка данных и закрытие прелоадера в основном потоке.
                this.Invoke(new MethodInvoker(() =>
                {

                    comboBoxMood.Items.Add("--- Отменить выбор ---");

                    foreach (IWebElement element in listMoodMuzoFon)
                    {
                        comboBoxMood.Items.Add(element.Text);
                    }

                    //comboBoxMood.Text = listMoodMuzoFon[0].Text;
                    comboBoxMood.Enabled = true;
   //                 buttonSearch.Enabled = true;

                    formPreloaderMood.Close();                    
                    panelControl.Visible = true;
                    panelResult.Visible = true;
                    panelHead.Visible = true;

                }));
            });

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            buttonClearGenre.Enabled = false;
            buttonSearch.Enabled = false;
            comboBoxGenre.SelectedIndex = -1;            
            comboBoxMood.Enabled = true;
            textBoxArtistTrack.Enabled = true;            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            buttonClearMood.Enabled = false;
            buttonSearch.Enabled = false;
            comboBoxMood.SelectedIndex = -1;
            comboBoxGenre.Enabled = true;
            textBoxArtistTrack.Enabled = true;
        }

        /// <summary>
        /// Выделяет или отменяет выделение всез треков.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBoxSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;

            if(checkBox.Checked == true)
            {
                foreach (var element in panelResult.Controls.OfType<CheckBox>())
                {
                    element.Checked = true;
                }
            }
            else
            {
                foreach (var element in panelResult.Controls.OfType<CheckBox>())
                {
                    element.Checked = false;
                }
            }
        }
    }
}
