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
        int id;
        string name;
        string surname;
        string login;
        string command;
        int list_id;
        List<User_Track> user_Tracks = new List<User_Track>();
        Intensiv2018Entities context = new Intensiv2018Entities();
        DatabaseFunctions functions = new DatabaseFunctions();
        public Edit_MyPlaylist(string command, List<User_Track> list, int list_id, int id,string login, string name, string surname)
        {
            this.id = id;
            this.name = name;
            this.surname = surname;
            this.login = login;
            user_Tracks = list;
            this.command = command;
            this.list_id = list_id;
            InitializeComponent();
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
                    functions.PlaylistEdit(command, -1, user_Tracks, id, surname, name, textBox_Title_Playlist.Text, full_duration);
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
            Intensiv2018Entities context = new Intensiv2018Entities();

            int CurrentRow = dataGridView1.SelectedCells[0].RowIndex;
            //    //получить значение id выбранной строки
            int current_position = Convert.ToInt32(dataGridView1[3, CurrentRow].Value);
            int previous_position = Convert.ToInt32(dataGridView1[3, CurrentRow-1].Value);

            int previous_track_id = Convert.ToInt32(dataGridView1[2, CurrentRow - 1].Value);
            int current_track_id = Convert.ToInt32(dataGridView1[2, CurrentRow].Value);

            functions.User_Track_Playlist_Edit("Редактировать",list_id,previous_track_id, current_position);
            functions.User_Track_Playlist_Edit("Редактировать", list_id, current_track_id, previous_position);

        }
    }
}
