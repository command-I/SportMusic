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
    public partial class Edit_MyPlaylist : Form
    {
        int author;
        string name;
        string surname;
        string login;
        string command;
        int list_id;
        List<User_Track> user_Tracks = new List<User_Track>();
        Intensiv2018Entities context = new Intensiv2018Entities();
        DatabaseFunctions functions = new DatabaseFunctions();
        public Edit_MyPlaylist(string command, List<User_Track> list, int list_id, int author, string login, string name, string surname)
        {
            this.author = author;
            this.name = name;
            this.surname = surname;
            this.login = login;
            user_Tracks = list;
            this.command = command;
            this.list_id = list_id;
            InitializeComponent();
            this.Width = 816;
            this.Height = 489;
            label_Login.Text = login;
            label_Name.Text = surname + " " + name;
            if (list_id > 0)
            {
                textBox_Title_Playlist.Text = context.Playlist.Find(list_id).title;
            }
        }

        private void Edit_MyPlaylist_Load(object sender, EventArgs e)
        {
            if (user_Tracks != null)
            {
                dataGridView1.DataSource = user_Tracks;
            }
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            if (textBox_Title_Playlist.Text != "")
            {
                if (dataGridView1.DataSource != null)
                {
                    TimeSpan full_duration = new TimeSpan(); //заглушка
                    DatabaseFunctions functions = new DatabaseFunctions();
                    functions.PlaylistEdit(command,list_id, user_Tracks, author, surname, name, textBox_Title_Playlist.Text, full_duration);
                }
                else
                {
                    MessageBox.Show("В данном плейлисте отсутствуют композиции");
                }
            }
            else
            {
                MessageBox.Show("Введите название плейлиста");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            int CurrentRow = dataGridView1.SelectedCells[0].RowIndex;
            if (CurrentRow != 0)
            {
                //получить значение id выбранной строки
                int current_id = Convert.ToInt32(dataGridView1[0, CurrentRow].Value);
                int previous_id = Convert.ToInt32(dataGridView1[0, CurrentRow - 1].Value);

                var current_track = user_Tracks.FindIndex(a => a.id == current_id);
                var previous_track = user_Tracks.FindIndex(a => a.id == previous_id);

                var temp = user_Tracks[CurrentRow];
                user_Tracks[CurrentRow] = user_Tracks[previous_track];
                user_Tracks[CurrentRow-1] = temp;

                dataGridView1.DataSource = null;

                dataGridView1.DataSource = user_Tracks;
                
                dataGridView1.Refresh();

                dataGridView1.Rows[CurrentRow-1].Selected = true;
                dataGridView1.CurrentCell = dataGridView1[0, CurrentRow-1];
            }
        }

        private void buttonDown_Click(object sender, EventArgs e)
        {
            int CurrentRow = dataGridView1.SelectedCells[0].RowIndex;
            if (CurrentRow < dataGridView1.RowCount-1)
            {
                //получить значение id выбранной строки
                int current_id = Convert.ToInt32(dataGridView1[0, CurrentRow].Value);
                int next_id = Convert.ToInt32(dataGridView1[0, CurrentRow + 1].Value);

                var current_track = user_Tracks.FindIndex(a => a.id == current_id);
                var next_track = user_Tracks.FindIndex(a => a.id == next_id);

                var temp = user_Tracks[CurrentRow];
                user_Tracks[CurrentRow] = user_Tracks[next_track];
                user_Tracks[CurrentRow+1] = temp;

                dataGridView1.DataSource = null;

                dataGridView1.DataSource = user_Tracks;
                
                dataGridView1.Refresh();

                dataGridView1.Rows[CurrentRow+1].Selected = true;
                dataGridView1.CurrentCell = dataGridView1[0, CurrentRow+1];
                //dataGridView1.CurrentCell = dataGridView1.Rows[next_id].Cells[0];
            }
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            this.Width = 1323;
            this.Height = 489;
            List<User_Track> tracks = functions.Get_User_Track(author);
            dataGridView2.DataSource = tracks;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView2.SelectedRows)
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
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = user_Tracks;
            
            dataGridView1.Refresh();
            this.Width = 816;
            this.Height = 489;
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            int CurrentRow = dataGridView1.SelectedCells[0].RowIndex;
            user_Tracks.RemoveAt(CurrentRow);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = user_Tracks;
            
            dataGridView1.Refresh();
        }
    }
}
