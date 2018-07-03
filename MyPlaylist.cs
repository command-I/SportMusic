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
            foreach (Track track in tracks)
            {
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

       

        
    }
}
