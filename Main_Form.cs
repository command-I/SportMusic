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
using System.Data.Entity.Validation;
using System.Net;
using System.IO;

namespace SportMusic
{
    public partial class Main_Form : Form
    {

        /// <summary>
        /// Текущий адрес браузера. 
        /// </summary>
        private string Url { get; set; }
        
        /// <summary>
        /// Использует основной драйвер.
        /// Получает информацию с домашнней страницы.
        /// </summary>
        MuzoFon muzoFon;

        /// <summary>
        /// Использует дополнительный драйвер.
        /// Для получения информации переходит с главной страницы.
        /// </summary>
        MuzoFon muzoFonMood;

        /// <summary>
        /// Ограничение по длительности.
        /// Выбирает пользователь.
        /// </summary>
        public int DurationSetUser { get; set; }


        /// <summary>
        /// Ссылка на форму.
        /// </summary>
        Form2 form2;

        /// <summary>
        /// Переменные для хранения данных о пользователе
        /// </summary>
        int id;
        string login;
        string name;
        string surname;
        List<string> music, path;

        public Main_Form(int id, string login, string name, string surname)
        {
            this.id = id;
            this.login = login;
            this.name = name;
            this.surname = surname;
            
            music = new List<string>();
            path = new List<string>();

            InitializeComponent();

            label_Login.Text = login;
            label_Name.Text = surname + " " + name;
           
            axWindowsMediaPlayer1.uiMode = "none";
            axWindowsMediaPlayer1.settings.volume = 50;
            trackBar1.Value = 50;

            StartPosition = FormStartPosition.CenterScreen;
            panelControl.Visible = false;
            panelResult.Visible = false;
            panelHead.Visible = false;
            muzoFon = new MuzoFon(this);
            muzoFonMood = new MuzoFon(this);


            muzoFon.ShowPreloaderGenreForm();
            muzoFonMood.ShowPreloaderMoodForm();

            FormElementInit();

            if (radioButtonMuzoFon.Checked)
            {
                Url = muzoFon.PageHome.Url;
            }


        }



        //-----------------//-------------------//-------------------------//-----------------------------//-----------------------//---------


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
            comboBoxGenre.Text = "";

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

            muzoFon.ShowPreloaderGenreForm();
            muzoFonMood.ShowPreloaderMoodForm();

            FormElementInit();

            if (radioButton.Checked)
            {
                Url = muzoFon.PageHome.Url;
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
                muzoFon.CountChecking++;
                buttonSave.Enabled = true;
                muzoFon.ListSelectTrackOptions.Add(muzoFon.ListTrackOptions[num]);
            }
            else
            {
                muzoFon.CountChecking--;

                if (muzoFon.CountChecking == 0)
                {
                    buttonSave.Enabled = false;
                }

                for (int i = 0; i < muzoFon.ListSelectTrackOptions.Count; i++)
                {
                    if (muzoFon.ListSelectTrackOptions[i].Num == num)
                    {
                        muzoFon.ListSelectTrackOptions.RemoveAt(i);
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

            muzoFon.ClearLists();
            muzoFonMood.ClearLists();

            panelResult.Controls.Clear();

            if ((textBoxArtistTrack.Text == "") && (comboBoxMood.Text == "") && (comboBoxGenre.Text == ""))
            {
                MessageBox.Show("Необходимо выбрать один из критериев поиска");
            }
            else
            {

                muzoFon.CountChecking = 0;
                DurationSetUser = TimeStringToInt(comboBoxDuration.Text);

                buttonSearch.Enabled = false;

                if (radioButtonMuzoFon.Checked)
                {

                    if (comboBoxMood.Enabled == true)
                    {
                        muzoFonMood.GoToSelectMood();
                        muzoFonMood.ShowPreloaderTracksForm();
                    }
                    else if (comboBoxGenre.Enabled == true)
                    {
                        muzoFon.GoToSelectGenre();
                        muzoFon.ShowPreloaderTracksForm();
                    }
                    else
                    {
                        muzoFon.GoArtistTrackSearch(textBoxArtistTrack.Text);
                        muzoFon.ShowPreloaderTracksForm();
                    }

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

            if (comboBoxMood.Enabled)
            {
                muzoFonMood.DownloadBrowser(index);
            }
            else
            {
                muzoFon.DownloadBrowser(index);
            }
        }

        /// <summary>
        /// Действия по нажатию на кнопку "Play".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPlay_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (comboBoxMood.Enabled)
            {
                muzoFonMood.ListPlays[Int32.Parse(button.Name)].Click();
            }
            else
            {
                muzoFon.ListPlays[Int32.Parse(button.Name)].Click();
            }
        }

        /// <summary>
        /// Методы доступа к элементам формы.
        /// </summary>
        /// <returns></returns>
        public Panel GetPanelControl()
        {
            return panelControl;
        }

        public Panel GetPanelHead()
        {
            return panelHead;
        }

        public Panel GetPanelResult()
        {
            return panelResult;
        }

        public ComboBox GetComboBoxMood()
        {
            return comboBoxMood;
        }

        public ComboBox GetComboBoxGenre()
        {
            return comboBoxGenre;
        }

        /// <summary>
        /// Преобразование строки со значением длительности в числовое значение. 
        /// </summary>
        /// <param name="time">Принимает строку со значением времени.</param>
        /// <returns>Возврашает количество секунд.</returns>
        public int TimeStringToInt(string time)
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

        public void ShowFromSiteToForm(List<TrackOptions> listTrackOptions, Panel panel, int count)
        {

            int distanceTop = 40;
            int leftLabelNum = 10;
            int leftCheckBoxSelectTrack = 40;

            int leftButtonPlay = 70;
            int leftLabelArtist = 150;
            int leftLabelTrack = 300;
            int leftDurationTrack = 630;
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

            if (count != 0)
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
                buttonSearch.Enabled = true;
                buttonClearTrackArtist.Enabled = true;
                comboBoxMood.Enabled = false;
                comboBoxGenre.Enabled = false;
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

            if (muzoFon != null)
            {
                muzoFon.Browser.Quit();
            }

            if (muzoFon != null)
            {
                muzoFonMood.Browser.Quit();
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
                buttonSearch.Enabled = true;
                buttonClearMood.Enabled = true;
                comboBoxGenre.Enabled = false;
                textBoxArtistTrack.Enabled = false;
                buttonClearTrackArtist.Enabled = false;
                buttonClearGenre.Enabled = false;
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
                buttonSearch.Enabled = true;
                buttonClearGenre.Enabled = true;
                comboBoxMood.Enabled = false;
                textBoxArtistTrack.Enabled = false;
                buttonClearTrackArtist.Enabled = false;
                buttonClearMood.Enabled = false;
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

        /// <summary>
        /// Подготавливает элементы при открытии формы.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Shown(object sender, EventArgs e)
        {
            FormElementInit();
        }



        /// <summary>
        /// Ограничение количества выводимых треков в результатах поиска.
        /// Устанавливается пользователем на форме поиска треков.
        /// </summary>
        public int SetCountShowTracks()
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
        /// Выход из категори жанр.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click_1(object sender, EventArgs e)
        {
            buttonClearGenre.Enabled = false;
            buttonSearch.Enabled = false;
            comboBoxGenre.SelectedIndex = -1;
            comboBoxMood.Enabled = true;
            textBoxArtistTrack.Enabled = true;
        }

        /// <summary>
        /// Выход из категории настроение.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

            if (checkBox.Checked)
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











        //-----------------//-------------------//-------------------------//-----------------------------//-----------------------//---------


        /// <summary>
        /// Действия по нажатию на кнопку "Сохранить".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (muzoFon.ListTrackOptions.Count != 0)
            {
                //Кусок кода для проверки
                int downloader = 1; //Крашилось на нуле
                DatabaseFunctions function = new DatabaseFunctions();
                foreach (TrackOptions element in muzoFon.ListSelectTrackOptions)
                {
                    try
                    {
                        function.TrackEdit("Добавить", 0, downloader, element.Artist, element.Track, "жанр", "настроение", 0, element.DownloadUrl, "path", TimeSpan.Parse("00:" + element.Duration));
                    }
                    catch (DbEntityValidationException ex)
                    {
                        foreach (var eve in ex.EntityValidationErrors)
                        {
                            MessageBox.Show(String.Format("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                                eve.Entry.Entity.GetType().Name, eve.Entry.State));
                            foreach (var ve in eve.ValidationErrors)
                            {
                                MessageBox.Show(String.Format("- Property: \"{0}\", Error: \"{1}\"",
                                    ve.PropertyName, ve.ErrorMessage));
                            }
                        }
                        throw;
                    }

                }


                //form2 = new Form2(this);
                //form2.Show();
                //form2.PanelSelectedTracks.Controls.Clear();
                //ShowSelectToForm(listSelectTrackOptions, form2.PanelSelectedTracks);
                //form2.Activate();


            }
        }

        protected override void OnResize(EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
        }


        /// <summary>
        /// Скачивание файлов по url.
        /// </summary>
        /// <param name="url">Принимает ссылку.</param>
        /// <param name="path">Принимает путь для сохранения.</param>
        /// <param name="file">Принимает имя файла.</param>
        private void Download(string link, string name)
        {
            WebClient webload = new WebClient();
            webload.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
            webload.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressDown);

            webload.DownloadFileAsync(new Uri(link), name);
            Environment.ExpandEnvironmentVariables(muzoFon.PATH_DOWNLOAD);
        }


        private void ProgressDown(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            textBox1.Text = "Загружено :" + e.ProgressPercentage + " %";
        }

        private void Completed(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show(e.Error.Message);
            }
            else
            {
                textBox1.Text = "Загрузка файла завершена";
            }
        }


        private void button1_rename_Click(object sender, EventArgs e)
        {
            music.Clear();
            path.Clear();
            listBox1.Items.Clear();

            DirectoryInfo dir = new DirectoryInfo(".\\Download");
            FileInfo[] files = dir.GetFiles("*.mp3");

            foreach (FileInfo fi in files)
            {
                listBox1.Items.Add(fi.ToString());
                path.Add(fi.FullName);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = path[listBox1.SelectedIndex];
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        bool paused = false;
        private void button6_Click(object sender, EventArgs e)
        {
            if (paused == false)
            {
                axWindowsMediaPlayer1.Ctlcontrols.pause();
                paused = true;
            } else
            {
                axWindowsMediaPlayer1.Ctlcontrols.play();
                paused = false;
            }

            
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.fastForward();
        }

        private void tabPageSearch_Click(object sender, EventArgs e)
        {

        }

        private void моиКомпозицииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyTracks f = new MyTracks(id, login, name, surname);
            this.Hide();
            f.ShowDialog();
            this.Show();
            
        }

        private void моиПлейлистыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyPlaylist f = new MyPlaylist(id, login, name, surname);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }


        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.volume = trackBar1.Value;
        }

        private void radioButtonMuzoFon_CheckedChanged_1(object sender, EventArgs e)
        {

        }

       

        private void button2_rename_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                music.AddRange(openFileDialog1.SafeFileNames);
                path.AddRange(openFileDialog1.FileNames);
                for (var i = 0; i < music.Count; i++)
                {
                    listBox1.Items.Add(music[i]);
                }
            }
        }
    }
}
