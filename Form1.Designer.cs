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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonClearTrackArtist = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.comboBoxGenre = new System.Windows.Forms.ComboBox();
            this.comboBoxMood = new System.Windows.Forms.ComboBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxArtistTrack = new System.Windows.Forms.TextBox();
            this.radioButtonYandexSound = new System.Windows.Forms.RadioButton();
            this.radioButtonMuzoFon = new System.Windows.Forms.RadioButton();
            this.comboBoxCount = new System.Windows.Forms.ComboBox();
            this.comboBoxDuration = new System.Windows.Forms.ComboBox();
            this.panelHead = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxSelectAll = new System.Windows.Forms.CheckBox();
            this.panelControl.SuspendLayout();
            this.panelHead.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelResult
            // 
            this.panelResult.AutoScroll = true;
            this.panelResult.Location = new System.Drawing.Point(12, 230);
            this.panelResult.Name = "panelResult";
            this.panelResult.Size = new System.Drawing.Size(860, 306);
            this.panelResult.TabIndex = 10;
            // 
            // panelControl
            // 
            this.panelControl.Controls.Add(this.button2);
            this.panelControl.Controls.Add(this.button1);
            this.panelControl.Controls.Add(this.buttonClearTrackArtist);
            this.panelControl.Controls.Add(this.buttonSave);
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
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(642, 103);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(46, 23);
            this.button2.TabIndex = 20;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(331, 103);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // buttonClearTrackArtist
            // 
            this.buttonClearTrackArtist.Location = new System.Drawing.Point(642, 53);
            this.buttonClearTrackArtist.Name = "buttonClearTrackArtist";
            this.buttonClearTrackArtist.Size = new System.Drawing.Size(46, 23);
            this.buttonClearTrackArtist.TabIndex = 18;
            this.buttonClearTrackArtist.Text = "X";
            this.buttonClearTrackArtist.UseVisualStyleBackColor = true;
            this.buttonClearTrackArtist.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Enabled = false;
            this.buttonSave.Location = new System.Drawing.Point(383, 16);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 17;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // comboBoxGenre
            // 
            this.comboBoxGenre.FormattingEnabled = true;
            this.comboBoxGenre.Location = new System.Drawing.Point(16, 103);
            this.comboBoxGenre.Name = "comboBoxGenre";
            this.comboBoxGenre.Size = new System.Drawing.Size(292, 21);
            this.comboBoxGenre.TabIndex = 14;
            this.comboBoxGenre.Text = "Жанр";
            this.comboBoxGenre.SelectedIndexChanged += new System.EventHandler(this.comboBoxGenre_SelectedIndexChanged);
            // 
            // comboBoxMood
            // 
            this.comboBoxMood.FormattingEnabled = true;
            this.comboBoxMood.Location = new System.Drawing.Point(398, 103);
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
            this.buttonSearch.Size = new System.Drawing.Size(75, 72);
            this.buttonSearch.TabIndex = 12;
            this.buttonSearch.Text = "Поиск";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxArtistTrack
            // 
            this.textBoxArtistTrack.Location = new System.Drawing.Point(16, 55);
            this.textBoxArtistTrack.Name = "textBoxArtistTrack";
            this.textBoxArtistTrack.Size = new System.Drawing.Size(608, 20);
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
            this.radioButtonMuzoFon.Text = "МузоФон";
            this.radioButtonMuzoFon.UseVisualStyleBackColor = true;
            this.radioButtonMuzoFon.CheckedChanged += new System.EventHandler(this.radioButtonMuzoFon_CheckedChanged);
            // 
            // comboBoxCount
            // 
            this.comboBoxCount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCount.FormattingEnabled = true;
            this.comboBoxCount.Location = new System.Drawing.Point(669, 37);
            this.comboBoxCount.Name = "comboBoxCount";
            this.comboBoxCount.Size = new System.Drawing.Size(75, 21);
            this.comboBoxCount.TabIndex = 16;
            // 
            // comboBoxDuration
            // 
            this.comboBoxDuration.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDuration.FormattingEnabled = true;
            this.comboBoxDuration.Location = new System.Drawing.Point(470, 37);
            this.comboBoxDuration.Name = "comboBoxDuration";
            this.comboBoxDuration.Size = new System.Drawing.Size(72, 21);
            this.comboBoxDuration.TabIndex = 15;
            // 
            // panelHead
            // 
            this.panelHead.Controls.Add(this.label4);
            this.panelHead.Controls.Add(this.label3);
            this.panelHead.Controls.Add(this.label2);
            this.panelHead.Controls.Add(this.comboBoxDuration);
            this.panelHead.Controls.Add(this.comboBoxCount);
            this.panelHead.Controls.Add(this.label1);
            this.panelHead.Controls.Add(this.checkBoxSelectAll);
            this.panelHead.Location = new System.Drawing.Point(13, 157);
            this.panelHead.Name = "panelHead";
            this.panelHead.Size = new System.Drawing.Size(859, 67);
            this.panelHead.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(638, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Показывать на странице";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(447, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Длительность треков";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(242, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Трек";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Артист";
            // 
            // checkBoxSelectAll
            // 
            this.checkBoxSelectAll.AutoSize = true;
            this.checkBoxSelectAll.Enabled = false;
            this.checkBoxSelectAll.Location = new System.Drawing.Point(39, 9);
            this.checkBoxSelectAll.Name = "checkBoxSelectAll";
            this.checkBoxSelectAll.Size = new System.Drawing.Size(15, 14);
            this.checkBoxSelectAll.TabIndex = 4;
            this.checkBoxSelectAll.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 562);
            this.Controls.Add(this.panelHead);
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.panelResult);
            this.Name = "Form1";
            this.Text = "Музыка для спорта";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.panelControl.ResumeLayout(false);
            this.panelControl.PerformLayout();
            this.panelHead.ResumeLayout(false);
            this.panelHead.PerformLayout();
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
        private System.Windows.Forms.Panel panelHead;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxSelectAll;
        private System.Windows.Forms.Button buttonClearTrackArtist;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
    }
}

