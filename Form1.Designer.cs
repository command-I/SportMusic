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
            this.panelControl = new System.Windows.Forms.Panel();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.comboBoxCount = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.comboBoxDuration = new System.Windows.Forms.ComboBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxArtistTrack = new System.Windows.Forms.TextBox();
            this.buttonClearTrackArtist = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonClearGenre = new System.Windows.Forms.Button();
            this.comboBoxGenre = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonClearMood = new System.Windows.Forms.Button();
            this.comboBoxMood = new System.Windows.Forms.ComboBox();
            this.radioButtonYandexSound = new System.Windows.Forms.RadioButton();
            this.radioButtonMuzoFon = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.checkBoxSelectAll = new System.Windows.Forms.CheckBox();
            this.panelResult = new System.Windows.Forms.Panel();
            this.panelHead = new System.Windows.Forms.Panel();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.panelControl.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panelHead.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl
            // 
            this.panelControl.Controls.Add(this.groupBox9);
            this.panelControl.Location = new System.Drawing.Point(12, 36);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(891, 130);
            this.panelControl.TabIndex = 11;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.buttonSave);
            this.groupBox9.Controls.Add(this.groupBox6);
            this.groupBox9.Controls.Add(this.groupBox5);
            this.groupBox9.Controls.Add(this.buttonSearch);
            this.groupBox9.Controls.Add(this.groupBox3);
            this.groupBox9.Controls.Add(this.groupBox1);
            this.groupBox9.Controls.Add(this.groupBox2);
            this.groupBox9.Location = new System.Drawing.Point(9, 3);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(869, 123);
            this.groupBox9.TabIndex = 26;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "                                                                            Выбер" +
    "ете один из критериев поиска";
            // 
            // buttonSave
            // 
            this.buttonSave.Enabled = false;
            this.buttonSave.Location = new System.Drawing.Point(723, 30);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(113, 28);
            this.buttonSave.TabIndex = 17;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.comboBoxCount);
            this.groupBox6.Location = new System.Drawing.Point(711, 71);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(138, 45);
            this.groupBox6.TabIndex = 25;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Количество треков";
            // 
            // comboBoxCount
            // 
            this.comboBoxCount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCount.FormattingEnabled = true;
            this.comboBoxCount.Location = new System.Drawing.Point(25, 19);
            this.comboBoxCount.Name = "comboBoxCount";
            this.comboBoxCount.Size = new System.Drawing.Size(75, 21);
            this.comboBoxCount.TabIndex = 16;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.comboBoxDuration);
            this.groupBox5.Location = new System.Drawing.Point(567, 72);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(138, 45);
            this.groupBox5.TabIndex = 24;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Длительность треков";
            // 
            // comboBoxDuration
            // 
            this.comboBoxDuration.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDuration.FormattingEnabled = true;
            this.comboBoxDuration.Location = new System.Drawing.Point(32, 19);
            this.comboBoxDuration.Name = "comboBoxDuration";
            this.comboBoxDuration.Size = new System.Drawing.Size(72, 21);
            this.comboBoxDuration.TabIndex = 15;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Enabled = false;
            this.buttonSearch.Location = new System.Drawing.Point(578, 30);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(113, 28);
            this.buttonSearch.TabIndex = 12;
            this.buttonSearch.Text = "Искать";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxArtistTrack);
            this.groupBox3.Controls.Add(this.buttonClearTrackArtist);
            this.groupBox3.Location = new System.Drawing.Point(6, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(555, 47);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Трек, исполнитель ";
            // 
            // textBoxArtistTrack
            // 
            this.textBoxArtistTrack.Location = new System.Drawing.Point(11, 19);
            this.textBoxArtistTrack.Name = "textBoxArtistTrack";
            this.textBoxArtistTrack.Size = new System.Drawing.Size(477, 20);
            this.textBoxArtistTrack.TabIndex = 11;
            this.textBoxArtistTrack.TextChanged += new System.EventHandler(this.textBoxArtistTrack_TextChanged);
            // 
            // buttonClearTrackArtist
            // 
            this.buttonClearTrackArtist.Location = new System.Drawing.Point(504, 16);
            this.buttonClearTrackArtist.Name = "buttonClearTrackArtist";
            this.buttonClearTrackArtist.Size = new System.Drawing.Size(40, 23);
            this.buttonClearTrackArtist.TabIndex = 18;
            this.buttonClearTrackArtist.Text = "X";
            this.buttonClearTrackArtist.UseVisualStyleBackColor = true;
            this.buttonClearTrackArtist.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonClearGenre);
            this.groupBox1.Controls.Add(this.comboBoxGenre);
            this.groupBox1.Location = new System.Drawing.Point(6, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 45);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Жанр";
            // 
            // buttonClearGenre
            // 
            this.buttonClearGenre.Location = new System.Drawing.Point(215, 16);
            this.buttonClearGenre.Name = "buttonClearGenre";
            this.buttonClearGenre.Size = new System.Drawing.Size(40, 23);
            this.buttonClearGenre.TabIndex = 19;
            this.buttonClearGenre.Text = "X";
            this.buttonClearGenre.UseVisualStyleBackColor = true;
            this.buttonClearGenre.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // comboBoxGenre
            // 
            this.comboBoxGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGenre.FormattingEnabled = true;
            this.comboBoxGenre.Location = new System.Drawing.Point(6, 18);
            this.comboBoxGenre.Name = "comboBoxGenre";
            this.comboBoxGenre.Size = new System.Drawing.Size(200, 21);
            this.comboBoxGenre.TabIndex = 14;
            this.comboBoxGenre.SelectedIndexChanged += new System.EventHandler(this.comboBoxGenre_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonClearMood);
            this.groupBox2.Controls.Add(this.comboBoxMood);
            this.groupBox2.Location = new System.Drawing.Point(280, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(281, 45);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Настроение";
            // 
            // buttonClearMood
            // 
            this.buttonClearMood.Location = new System.Drawing.Point(230, 19);
            this.buttonClearMood.Name = "buttonClearMood";
            this.buttonClearMood.Size = new System.Drawing.Size(40, 23);
            this.buttonClearMood.TabIndex = 20;
            this.buttonClearMood.Text = "X";
            this.buttonClearMood.UseVisualStyleBackColor = true;
            this.buttonClearMood.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBoxMood
            // 
            this.comboBoxMood.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMood.FormattingEnabled = true;
            this.comboBoxMood.Location = new System.Drawing.Point(14, 19);
            this.comboBoxMood.Name = "comboBoxMood";
            this.comboBoxMood.Size = new System.Drawing.Size(200, 21);
            this.comboBoxMood.TabIndex = 13;
            this.comboBoxMood.SelectedIndexChanged += new System.EventHandler(this.comboBoxMood_SelectedIndexChanged);
            // 
            // radioButtonYandexSound
            // 
            this.radioButtonYandexSound.AutoSize = true;
            this.radioButtonYandexSound.Enabled = false;
            this.radioButtonYandexSound.Location = new System.Drawing.Point(723, 19);
            this.radioButtonYandexSound.Name = "radioButtonYandexSound";
            this.radioButtonYandexSound.Size = new System.Drawing.Size(103, 17);
            this.radioButtonYandexSound.TabIndex = 10;
            this.radioButtonYandexSound.Text = "ЯндексМузыка";
            this.radioButtonYandexSound.UseVisualStyleBackColor = true;
            // 
            // radioButtonMuzoFon
            // 
            this.radioButtonMuzoFon.AutoSize = true;
            this.radioButtonMuzoFon.Location = new System.Drawing.Point(597, 19);
            this.radioButtonMuzoFon.Name = "radioButtonMuzoFon";
            this.radioButtonMuzoFon.Size = new System.Drawing.Size(74, 17);
            this.radioButtonMuzoFon.TabIndex = 9;
            this.radioButtonMuzoFon.Text = "МузоФон";
            this.radioButtonMuzoFon.UseVisualStyleBackColor = true;
            this.radioButtonMuzoFon.CheckedChanged += new System.EventHandler(this.radioButtonMuzoFon_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox7);
            this.groupBox4.Controls.Add(this.radioButtonYandexSound);
            this.groupBox4.Controls.Add(this.radioButtonMuzoFon);
            this.groupBox4.Location = new System.Drawing.Point(9, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(869, 50);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            // 
            // checkBoxSelectAll
            // 
            this.checkBoxSelectAll.AutoSize = true;
            this.checkBoxSelectAll.Location = new System.Drawing.Point(37, 17);
            this.checkBoxSelectAll.Name = "checkBoxSelectAll";
            this.checkBoxSelectAll.Size = new System.Drawing.Size(15, 14);
            this.checkBoxSelectAll.TabIndex = 4;
            this.checkBoxSelectAll.UseVisualStyleBackColor = true;
            this.checkBoxSelectAll.CheckedChanged += new System.EventHandler(this.checkBoxSelectAll_CheckedChanged);
            // 
            // panelResult
            // 
            this.panelResult.AutoScroll = true;
            this.panelResult.Location = new System.Drawing.Point(12, 228);
            this.panelResult.Name = "panelResult";
            this.panelResult.Size = new System.Drawing.Size(891, 401);
            this.panelResult.TabIndex = 10;
            // 
            // panelHead
            // 
            this.panelHead.Controls.Add(this.groupBox4);
            this.panelHead.Location = new System.Drawing.Point(12, 168);
            this.panelHead.Name = "panelHead";
            this.panelHead.Size = new System.Drawing.Size(891, 54);
            this.panelHead.TabIndex = 12;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.checkBoxSelectAll);
            this.groupBox7.Location = new System.Drawing.Point(6, 7);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(90, 37);
            this.groupBox7.TabIndex = 0;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Выбрать все";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 632);
            this.Controls.Add(this.panelHead);
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.panelResult);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Музыка для спорта";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.panelControl.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panelHead.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.ComboBox comboBoxCount;
        private System.Windows.Forms.ComboBox comboBoxDuration;
        private System.Windows.Forms.ComboBox comboBoxGenre;
        private System.Windows.Forms.ComboBox comboBoxMood;
        private System.Windows.Forms.TextBox textBoxArtistTrack;
        private System.Windows.Forms.RadioButton radioButtonYandexSound;
        private System.Windows.Forms.RadioButton radioButtonMuzoFon;
        private System.Windows.Forms.Button buttonClearTrackArtist;
        private System.Windows.Forms.Button buttonClearMood;
        private System.Windows.Forms.Button buttonClearGenre;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox checkBoxSelectAll;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Panel panelResult;
        private System.Windows.Forms.Panel panelHead;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.GroupBox groupBox7;
    }
}

