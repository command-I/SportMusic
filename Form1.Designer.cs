namespace SportMusic
{
    partial class Form1
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
            this.panelControl.SuspendLayout();
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
            this.comboBoxGenre.Location = new System.Drawing.Point(262, 103);
            this.comboBoxGenre.Name = "comboBoxGenre";
            this.comboBoxGenre.Size = new System.Drawing.Size(199, 21);
            this.comboBoxGenre.TabIndex = 14;
            this.comboBoxGenre.Text = "Жанр";
            // 
            // comboBoxMood
            // 
            this.comboBoxMood.FormattingEnabled = true;
            this.comboBoxMood.Location = new System.Drawing.Point(16, 103);
            this.comboBoxMood.Name = "comboBoxMood";
            this.comboBoxMood.Size = new System.Drawing.Size(226, 21);
            this.comboBoxMood.TabIndex = 13;
            this.comboBoxMood.Text = "Настроение";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 562);
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.panelResult);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.panelControl.ResumeLayout(false);
            this.panelControl.PerformLayout();
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
    }
}

