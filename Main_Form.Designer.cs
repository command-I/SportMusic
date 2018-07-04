namespace SportMusic
{
    partial class Main_Form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            this.panelResult = new System.Windows.Forms.Panel();
            this.panelControl = new System.Windows.Forms.Panel();
            this.buttonSave = new System.Windows.Forms.Button();
            this.comboBoxCount = new System.Windows.Forms.ComboBox();
            this.comboBoxDuration = new System.Windows.Forms.ComboBox();
            this.comboBoxGenre = new System.Windows.Forms.ComboBox();
            this.comboBoxMood = new System.Windows.Forms.ComboBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxArtistTrack = new System.Windows.Forms.TextBox();
            this.radioButtonYandexSound = new System.Windows.Forms.RadioButton();
            this.radioButtonMuzoFon = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.panelControl.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelResult
            // 
            this.panelResult.AutoScroll = true;
            this.panelResult.Location = new System.Drawing.Point(12, 156);
            this.panelResult.Name = "panelResult";
            this.panelResult.Size = new System.Drawing.Size(860, 380);
            this.panelResult.TabIndex = 10;
            // 
            // panelControl
            // 
            this.panelControl.Controls.Add(this.buttonSave);
            this.panelControl.Controls.Add(this.comboBoxCount);
            this.panelControl.Controls.Add(this.comboBoxDuration);
            this.panelControl.Controls.Add(this.comboBoxGenre);
            this.panelControl.Controls.Add(this.comboBoxMood);
            this.panelControl.Controls.Add(this.buttonSearch);
            this.panelControl.Controls.Add(this.textBoxArtistTrack);
            this.panelControl.Controls.Add(this.radioButtonYandexSound);
            this.panelControl.Controls.Add(this.radioButtonMuzoFon);
            this.panelControl.Location = new System.Drawing.Point(12, 13);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(860, 137);
            this.panelControl.TabIndex = 11;
            // 
            // buttonSave
            // 
            this.buttonSave.Enabled = false;
            this.buttonSave.Location = new System.Drawing.Point(320, 13);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 17;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // comboBoxCount
            // 
            this.comboBoxCount.FormattingEnabled = true;
            this.comboBoxCount.Location = new System.Drawing.Point(591, 103);
            this.comboBoxCount.Name = "comboBoxCount";
            this.comboBoxCount.Size = new System.Drawing.Size(97, 21);
            this.comboBoxCount.TabIndex = 16;
            this.comboBoxCount.Text = "Количество";
            // 
            // comboBoxDuration
            // 
            this.comboBoxDuration.FormattingEnabled = true;
            this.comboBoxDuration.Location = new System.Drawing.Point(476, 103);
            this.comboBoxDuration.Name = "comboBoxDuration";
            this.comboBoxDuration.Size = new System.Drawing.Size(100, 21);
            this.comboBoxDuration.TabIndex = 15;
            this.comboBoxDuration.Text = "Длительность";
            // 
            // comboBoxGenre
            // 
            this.comboBoxGenre.FormattingEnabled = true;
            this.comboBoxGenre.Location = new System.Drawing.Point(16, 103);
            this.comboBoxGenre.Name = "comboBoxGenre";
            this.comboBoxGenre.Size = new System.Drawing.Size(199, 21);
            this.comboBoxGenre.TabIndex = 14;
            this.comboBoxGenre.Text = "Жанр";
            this.comboBoxGenre.SelectedIndexChanged += new System.EventHandler(this.comboBoxGenre_SelectedIndexChanged);
            // 
            // comboBoxMood
            // 
            this.comboBoxMood.FormattingEnabled = true;
            this.comboBoxMood.Location = new System.Drawing.Point(230, 103);
            this.comboBoxMood.Name = "comboBoxMood";
            this.comboBoxMood.Size = new System.Drawing.Size(226, 21);
            this.comboBoxMood.TabIndex = 13;
            this.comboBoxMood.Text = "Настроение";
            this.comboBoxMood.SelectedIndexChanged += new System.EventHandler(this.comboBoxMood_SelectedIndexChanged);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(731, 52);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 75);
            this.buttonSearch.TabIndex = 12;
            this.buttonSearch.Text = "Поиск";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxArtistTrack
            // 
            this.textBoxArtistTrack.Location = new System.Drawing.Point(16, 55);
            this.textBoxArtistTrack.Name = "textBoxArtistTrack";
            this.textBoxArtistTrack.Size = new System.Drawing.Size(672, 20);
            this.textBoxArtistTrack.TabIndex = 11;
            this.textBoxArtistTrack.Text = "Трек, исполнитель";
            this.textBoxArtistTrack.TextChanged += new System.EventHandler(this.textBoxArtistTrack_TextChanged);
            // 
            // radioButtonYandexSound
            // 
            this.radioButtonYandexSound.AutoSize = true;
            this.radioButtonYandexSound.Enabled = false;
            this.radioButtonYandexSound.Location = new System.Drawing.Point(153, 16);
            this.radioButtonYandexSound.Name = "radioButtonYandexSound";
            this.radioButtonYandexSound.Size = new System.Drawing.Size(103, 17);
            this.radioButtonYandexSound.TabIndex = 10;
            this.radioButtonYandexSound.TabStop = true;
            this.radioButtonYandexSound.Text = "ЯндексМузыка";
            this.radioButtonYandexSound.UseVisualStyleBackColor = true;
            // 
            // radioButtonMuzoFon
            // 
            this.radioButtonMuzoFon.AutoSize = true;
            this.radioButtonMuzoFon.Location = new System.Drawing.Point(16, 16);
            this.radioButtonMuzoFon.Name = "radioButtonMuzoFon";
            this.radioButtonMuzoFon.Size = new System.Drawing.Size(74, 17);
            this.radioButtonMuzoFon.TabIndex = 9;
            this.radioButtonMuzoFon.TabStop = true;
            this.radioButtonMuzoFon.Text = "МузоФон";
            this.radioButtonMuzoFon.UseVisualStyleBackColor = true;
            this.radioButtonMuzoFon.CheckedChanged += new System.EventHandler(this.radioButtonMuzoFon_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.progressBar1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.trackBar1);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(878, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(307, 524);
            this.panel1.TabIndex = 12;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(19, 423);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(276, 45);
            this.trackBar1.TabIndex = 0;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(217, 358);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(54, 59);
            this.button5.TabIndex = 7;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.Location = new System.Drawing.Point(157, 358);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(54, 59);
            this.button6.TabIndex = 6;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(35, 358);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(54, 59);
            this.button4.TabIndex = 4;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(97, 358);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(54, 59);
            this.button3.TabIndex = 3;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.button2, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 289);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(307, 60);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 54);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(156, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 54);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.axWindowsMediaPlayer1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.listBox1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 37);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.29952F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.70049F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(307, 252);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(3, 3);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(301, 80);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(3, 89);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(301, 160);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(17)))), ((int)(((byte)(60)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(307, 37);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Adobe Gothic Std B", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Music Player";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "mp3 files|*.mp3|wav files|*.wav";
            this.openFileDialog1.Multiselect = true;
            this.openFileDialog1.Title = "Выберите файлы";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(19, 463);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(262, 20);
            this.textBox1.TabIndex = 8;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(19, 490);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(262, 23);
            this.progressBar1.TabIndex = 9;
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 562);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.panelResult);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Музыка для спорта";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.panelControl.ResumeLayout(false);
            this.panelControl.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelResult;
        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.ComboBox comboBoxCount;
        private System.Windows.Forms.ComboBox comboBoxDuration;
        private System.Windows.Forms.ComboBox comboBoxGenre;
        private System.Windows.Forms.ComboBox comboBoxMood;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxArtistTrack;
        private System.Windows.Forms.RadioButton radioButtonYandexSound;
        private System.Windows.Forms.RadioButton radioButtonMuzoFon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

