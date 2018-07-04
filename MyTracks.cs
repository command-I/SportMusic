using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportMusic
{
    public partial class MyTracks : Form
    {
        DatabaseFunctions functions = new DatabaseFunctions();
        public int author;
        public string login;
        public string name;
        public string surname;
        public MyTracks(int id, string login, string name, string surname)
        {
            this.author = id;
            this.login = login;
            this.name = name;
            this.surname = surname;
            InitializeComponent();
            label_Login.Text = login;
            label_Name.Text = surname + " " + name;
        }

        private void MyTracks_Load(object sender, EventArgs e)
        {
            RefreshDGV();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RefreshDGV()
        {
            dataGridView1.DataSource = functions.Get_User_Track(author);
            dataGridView1.Columns.RemoveAt(13); //удаление лишних полей
            dataGridView1.Columns.RemoveAt(12);
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                int CurrentRow = row.Index;
                //    //получить значение id выбранной строки
                int valueId = Convert.ToInt32(dataGridView1[0, CurrentRow].Value);
                functions.User_Track_Edit("Удалить", valueId);
            }
            RefreshDGV();
        }

        private void button_intoPlaylist_Click(object sender, EventArgs e)
        {
            List<User_Track> user_Tracks = new List<User_Track>();
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                User_Track track = new User_Track();
                track.id = Convert.ToInt32(row.Cells[0].Value.ToString());
                track.author = Convert.ToInt32(row.Cells[1].Value.ToString());
                track.track_id = Convert.ToInt32(row.Cells[2].Value.ToString());
                track.artist = row.Cells[3].Value.ToString();
                track.title = row.Cells[4].Value.ToString();
                track.genre = row.Cells[5].Value.ToString();
                track.mood = row.Cells[6].Value.ToString();
                track.bitrate = Convert.ToInt32(row.Cells[7].Value.ToString());
                track.source = row.Cells[8].Value.ToString();
                track.path = row.Cells[9].Value.ToString();
                track.duration = TimeSpan.Parse(row.Cells[10].Value.ToString());
                track.date_add = Convert.ToDateTime(row.Cells[11].Value.ToString());
                user_Tracks.Add(track);
            }
            Edit_MyPlaylist f = new Edit_MyPlaylist("Добавить", user_Tracks, -1, author,login,name,surname);
            f.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string artist = "";
            string title = "";
            string genre = "";
            string mood = "";

            if (textBox_Artist.Text == "" && textBox_Title.Text == "" && textBox_Genre.Text == "" && textBox_Mood.Text == "")
            {
                MessageBox.Show("Для поиска введите значение хотя бы в одно поисковое поле");
                RefreshDGV();
            }
            else
            {
                if (textBox_Artist.Text != "")
                    artist = textBox_Artist.Text;
                if (textBox_Title.Text != "")
                    title = textBox_Title.Text;
                if (textBox_Genre.Text != "")
                    genre = textBox_Genre.Text;
                if (textBox_Mood.Text != "")
                    mood = textBox_Mood.Text;

                dataGridView1.DataSource = functions.Search_User_Track(author, artist, title, genre, mood);
                dataGridView1.Columns.RemoveAt(13); //удаление лишних полей
                dataGridView1.Columns.RemoveAt(12);
            }
        }
    }
}
