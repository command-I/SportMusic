namespace SportMusic
{
    partial class MyTracks
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_Listen = new System.Windows.Forms.Button();
            this.button_intoPlaylist = new System.Windows.Forms.Button();
            this.button_Download = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label_Login = new System.Windows.Forms.Label();
            this.label_Name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Artist = new System.Windows.Forms.TextBox();
            this.textBox_Title = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_Genre = new System.Windows.Forms.TextBox();
            this.label_Mood = new System.Windows.Forms.Label();
            this.textBox_Mood = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(628, 340);
            this.dataGridView1.TabIndex = 0;
            // 
            // button_Listen
            // 
            this.button_Listen.Location = new System.Drawing.Point(662, 68);
            this.button_Listen.Name = "button_Listen";
            this.button_Listen.Size = new System.Drawing.Size(103, 38);
            this.button_Listen.TabIndex = 1;
            this.button_Listen.Text = "Слушать";
            this.button_Listen.UseVisualStyleBackColor = true;
            // 
            // button_intoPlaylist
            // 
            this.button_intoPlaylist.Location = new System.Drawing.Point(662, 112);
            this.button_intoPlaylist.Name = "button_intoPlaylist";
            this.button_intoPlaylist.Size = new System.Drawing.Size(103, 38);
            this.button_intoPlaylist.TabIndex = 2;
            this.button_intoPlaylist.Text = "Объединить";
            this.button_intoPlaylist.UseVisualStyleBackColor = true;
            this.button_intoPlaylist.Click += new System.EventHandler(this.button_intoPlaylist_Click);
            // 
            // button_Download
            // 
            this.button_Download.Location = new System.Drawing.Point(662, 156);
            this.button_Download.Name = "button_Download";
            this.button_Download.Size = new System.Drawing.Size(103, 38);
            this.button_Download.TabIndex = 3;
            this.button_Download.Text = "Скачать";
            this.button_Download.UseVisualStyleBackColor = true;
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(662, 200);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(103, 38);
            this.button_Delete.TabIndex = 4;
            this.button_Delete.Text = "Удалить";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(662, 400);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(103, 38);
            this.button5.TabIndex = 5;
            this.button5.Text = "Главная";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label_Login
            // 
            this.label_Login.AutoSize = true;
            this.label_Login.Location = new System.Drawing.Point(661, 9);
            this.label_Login.Name = "label_Login";
            this.label_Login.Size = new System.Drawing.Size(61, 13);
            this.label_Login.TabIndex = 6;
            this.label_Login.Text = "label_Login";
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Location = new System.Drawing.Point(659, 32);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(63, 13);
            this.label_Name.TabIndex = 7;
            this.label_Name.Text = "label_Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(228, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "Список композиций";
            // 
            // textBox_Artist
            // 
            this.textBox_Artist.Location = new System.Drawing.Point(12, 74);
            this.textBox_Artist.Name = "textBox_Artist";
            this.textBox_Artist.Size = new System.Drawing.Size(100, 20);
            this.textBox_Artist.TabIndex = 9;
            // 
            // textBox_Title
            // 
            this.textBox_Title.Location = new System.Drawing.Point(118, 74);
            this.textBox_Title.Name = "textBox_Title";
            this.textBox_Title.Size = new System.Drawing.Size(119, 20);
            this.textBox_Title.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Название композиции";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Исполнитель";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(499, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Поиск";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Enabled = false;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.Location = new System.Drawing.Point(662, 278);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(109, 116);
            this.richTextBox1.TabIndex = 13;
            this.richTextBox1.Text = "Для выделения нескольких треков зажмите Ctrl\n\nДля выделения последовательности тр" +
    "еков зажмите Shift\n\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(662, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Управление:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(243, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Жанр";
            // 
            // textBox_Genre
            // 
            this.textBox_Genre.Location = new System.Drawing.Point(246, 74);
            this.textBox_Genre.Name = "textBox_Genre";
            this.textBox_Genre.Size = new System.Drawing.Size(119, 20);
            this.textBox_Genre.TabIndex = 15;
            // 
            // label_Mood
            // 
            this.label_Mood.AutoSize = true;
            this.label_Mood.Location = new System.Drawing.Point(371, 58);
            this.label_Mood.Name = "label_Mood";
            this.label_Mood.Size = new System.Drawing.Size(68, 13);
            this.label_Mood.TabIndex = 18;
            this.label_Mood.Text = "Настроение";
            // 
            // textBox_Mood
            // 
            this.textBox_Mood.Location = new System.Drawing.Point(374, 74);
            this.textBox_Mood.Name = "textBox_Mood";
            this.textBox_Mood.Size = new System.Drawing.Size(119, 20);
            this.textBox_Mood.TabIndex = 17;
            // 
            // MyTracks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 450);
            this.Controls.Add(this.label_Mood);
            this.Controls.Add(this.textBox_Mood);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_Genre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_Title);
            this.Controls.Add(this.textBox_Artist);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_Name);
            this.Controls.Add(this.label_Login);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_Download);
            this.Controls.Add(this.button_intoPlaylist);
            this.Controls.Add(this.button_Listen);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MyTracks";
            this.Text = "Мои композиции";
            this.Load += new System.EventHandler(this.MyTracks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_Listen;
        private System.Windows.Forms.Button button_intoPlaylist;
        private System.Windows.Forms.Button button_Download;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label_Login;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Artist;
        private System.Windows.Forms.TextBox textBox_Title;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_Genre;
        private System.Windows.Forms.Label label_Mood;
        private System.Windows.Forms.TextBox textBox_Mood;
    }
}