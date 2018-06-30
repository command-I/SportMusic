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
        static IWebDriver browser = new OpenQA.Selenium.Chrome.ChromeDriver();

        /// <summary>
        /// Домашняя страница сайта МузоФон.
        /// </summary>
        PageHomeMuzoFon pageHomeMuzoFon;

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
        /// Ссылка на форму.
        /// </summary>
        Form2 form2;

        public Form1()
        {
            InitializeComponent();

            form2 = new Form2(this);
            form2.Show();
        }

        /// <summary>
        /// Приведение элементов формы к исходному состоянию.
        /// </summary>
        private void FormElementInit()
        {
            panelResult.Controls.Clear();
            comboBoxMood.Items.Clear();
            comboBoxGenre.Items.Clear();

            textBoxArtistTrack.Text = "Трек, исполнитель";
            comboBoxMood.Text = "Настроение";
            comboBoxDuration.Text = "Длительность";
            comboBoxCount.Text = "Количество";
            comboBoxGenre.Text = "Жанр";

            textBoxArtistTrack.Enabled = true;
            comboBoxDuration.Enabled = false;
            comboBoxCount.Enabled = false;

            buttonSave.Enabled = false;
            buttonSearch.Enabled = false;
            comboBoxMood.Enabled = false;
            comboBoxGenre.Enabled = false;

        }

        /// <summary>
        /// Действия по выбору сайта "МузоФон".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButtonMuzoFon_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;

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

            if(checkBox.Checked)
            {
                buttonSave.Enabled = true;
                listSelectTrackOptions.Add(listTrackOptions[Int32.Parse(checkBox.Name)]);
            }

        }

        /// <summary>
        /// 
        /// </summary>
        private void IdentifityCheckBoxSelectStatus()
        {
            foreach(TrackOptions trackOptions in listTrackOptions)
            {
                
            }
        }

        /// <summary>
        /// Действия по нажатию на кнопку "Поиск".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (radioButtonMuzoFon.Checked)
            {
                if (pageHomeMuzoFon == null)
                {
                    pageHomeMuzoFon = new PageHomeMuzoFon(browser);
                }

                if (textBoxArtistTrack.Text != "Трек, исполнитель")
                {
                    pageHomeMuzoFon.InputSearch.SendKeys(textBoxArtistTrack.Text);
                    pageHomeMuzoFon.ButtonSearch.Click();
                }

                LoadTracksFromSite();
                ShowFromSiteToForm(listTrackOptions, panelResult);
            }
            else
            {

            }
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

            for (int i = 0; i < listArtists.Count; i++)
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
            int leftLabelArtist = 150;
            int leftLabelTrack = 250;
            int leftDurationTrack = 450;
            int leftDownloadUrl = 500;


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

        private void ShowFromSiteToForm(List<TrackOptions> listTrackOptions, Panel panel)
        {

            int distanceTop = 40;            
            int leftLabelNum = 10;
            int leftCheckBoxSelectTrack = 40;

            int leftButtonPlay = 100;
            int leftLabelArtist = 150;
            int leftLabelTrack = 250;
            int leftDurationTrack = 450;

            int leftButtonFindFormat = 520;
            int leftComboBoxFormats = 620;
            int leftButtonDownload = 720;

            for (int i = 0; i < listTrackOptions.Count; i++)
            {
                Label labelNum = new Label();
                labelNum.Width = 30;
                labelNum.Left = leftLabelNum;
                labelNum.Top = 10 + i * distanceTop;
                labelNum.Text = (i + 1).ToString() + ".";
                panel.Controls.Add(labelNum);

                CheckBox checkBoxSelectTrack = new CheckBox();
                checkBoxSelectTrack.Name = i.ToString();
                checkBoxSelectTrack.Left = leftCheckBoxSelectTrack;
                checkBoxSelectTrack.Top = 10 + i * distanceTop;
                checkBoxSelectTrack.CheckedChanged += checkBoxSelect_CheckedChanged;                
                panel.Controls.Add(checkBoxSelectTrack);

                Button buttonPlay = new Button();
                buttonPlay.Name = i.ToString();
                buttonPlay.Width = 40;
                buttonPlay.Left = leftButtonPlay;
                buttonPlay.Top = 10 + i * distanceTop;
                buttonPlay.Text = "Play";
                //buttonPlay.Click += ;
                panel.Controls.Add(buttonPlay);

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

                Button buttonFindFormat = new Button();
                buttonFindFormat.Name = i.ToString();
                buttonFindFormat.Width = 80;
                buttonFindFormat.Left = leftButtonFindFormat;
                buttonFindFormat.Top = 10 + i * distanceTop;
                buttonFindFormat.Text = "Запросить";
                panel.Controls.Add(buttonFindFormat);
                //buttonFindFormat.Click += buttonFindFormat_Click;
                buttonFindFormat.Enabled = false;

                ComboBox comboBox = new ComboBox();
                comboBox.Name = "comboBoxFindFormat_" + i.ToString();
                comboBox.Width = 80;
                comboBox.Left = leftComboBoxFormats;
                comboBox.Top = 10 + i * distanceTop;
                panel.Controls.Add(comboBox);
                comboBox.Enabled = false;

                Button buttonDownload = new Button();
                buttonDownload.Name = i.ToString();
                buttonDownload.Width = 80;
                buttonDownload.Left = leftButtonDownload;
                buttonDownload.Top = 10 + i * distanceTop;
                buttonDownload.Text = "Скачать";
                panel.Controls.Add(buttonDownload);
                buttonDownload.Click += buttonDownload_Click;
                buttonDownload.Enabled = true;

            }
        }

        /// <summary>
        /// Действия по изменеию текста в поле для поиска.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxArtistTrack_TextChanged(object sender, EventArgs e)
        {
            buttonSearch.Enabled = true;
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
            if(listTrackOptions.Count != 0)
            {
                Result();

                form2.PanelSelectedTracks.Controls.Clear();
                ShowSelectToForm(listSelectTrackOptions, form2.PanelSelectedTracks);
                form2.Activate();
            }
        }
    }
}
