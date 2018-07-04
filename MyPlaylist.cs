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
    public partial class MyPlaylist : Form
    {
        int author_id;
        string login;
        string name;
        string surname;
        private DatabaseFunctions functions = new DatabaseFunctions();

        public MyPlaylist(int id, string login, string name, string surname)
        {
            this.author_id = id;
            this.login = login;
            this.name = name;
            this.surname = surname;
            InitializeComponent();
            label_Login.Text = login;
            label_Name.Text = surname + " " + name;

        }

        private void MyPlaylist_Load(object sender, EventArgs e)
        {
            RefreshDGV();
        }

        private void button_Edit_Click(object sender, EventArgs e)
        {
            int CurrentRow = dataGridView1.SelectedCells[0].RowIndex;
            //    //получить значение id выбранной строки
            int valueId = Convert.ToInt32(dataGridView1[0, CurrentRow].Value);
            Intensiv2018Entities context = new Intensiv2018Entities();
            List<User_Track_Playlist> user_Track_Playlists = context.User_Track_Playlist.Where(a => a.playlist_id == valueId).ToList();

            List<Track> tracks = new List<Track>();
            foreach (User_Track_Playlist temp in user_Track_Playlists)
            {
                tracks.Add(context.Tracks1.Where(a => a.id == temp.track_id).FirstOrDefault());
            }

            List<User_Track> list = new List<User_Track>();
            //List<User_Track_for_Playlist> list = new List<User_Track_for_Playlist>();
            foreach (Track track in tracks)
            {
                User_Track user = context.User_Track.Where(a => a.track_id == track.id).FirstOrDefault();

                //User_Track_for_Playlist _For_Playlist = new User_Track_for_Playlist();
                //_For_Playlist.artist = user.artist;
                //_For_Playlist.author = user.author;
                //_For_Playlist.bitrate = user.bitrate;
                //_For_Playlist.date_add = user.date_add;
                //_For_Playlist.duration = user.duration;
                //_For_Playlist.genre = user.genre;
                //_For_Playlist.id = user.id;
                //_For_Playlist.mood = user.mood;
                //_For_Playlist.path = user.path;
                //_For_Playlist.source = user.source;
                //_For_Playlist.title = user.title;
                //_For_Playlist.track_id = user.track_id;
                //_For_Playlist.user_track_playlist_id = 0;
                //list.Add(_For_Playlist);

                list.Add(context.User_Track.Where(a => a.track_id == track.id).FirstOrDefault());

            }

            Edit_MyPlaylist f = new Edit_MyPlaylist("Редактировать", list, valueId, author_id, login, name, surname);
            f.ShowDialog();
        }


        private void button_Delete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                int CurrentRow = row.Index;
                //    //получить значение id выбранной строки
                int valueId = Convert.ToInt32(dataGridView1[0, CurrentRow].Value);

                //functions.PlaylistEdit("Удалить", valueId,);
            }
            RefreshDGV();
        }

        private void RefreshDGV()
        {
            dataGridView1.DataSource = functions.Get_Playlist(author_id);
            dataGridView1.Columns.RemoveAt(11); //удаление лишних полей
            dataGridView1.Columns.RemoveAt(10);
            dataGridView1.Columns.RemoveAt(9);
            dataGridView1.Columns.RemoveAt(8);

        }

        /// <summary>
        /// Функция для переноса выделенной строки вверх
        /// По задумке они должны меняться местами. Переназначать значения не выйдет, так как связь идёт с треками. 
        /// Значит надо менять именно последовательность.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonUp_Click(object sender, EventArgs e)
        {
            
        }
    }

    public partial class User_Track_for_Playlist
    {
        public int id { get; set; }
        public Nullable<int> author { get; set; }
        public int track_id { get; set; }
        public string artist { get; set; }
        public string title { get; set; }
        public string genre { get; set; }
        public string mood { get; set; }
        public Nullable<int> bitrate { get; set; }
        public string source { get; set; }
        public string path { get; set; }
        public System.TimeSpan duration { get; set; }
        public Nullable<System.DateTime> date_add { get; set; }
        public int user_track_playlist_id { get; set; }
    }
}
