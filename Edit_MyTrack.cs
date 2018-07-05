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
    public partial class Edit_MyTrack : Form
    {
        string path = "";
        User_Track new_track = new User_Track();

        public Edit_MyTrack(User_Track track)
        {
            InitializeComponent();
            textBox_Author.Text = track.artist;
            textBox_Title.Text = track.title;
            textBox_Genre.Text = track.genre;
            textBox_Mood.Text = track.mood;
            textBox_Path.Text = track.path;
            new_track = track;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string start_directory = "D:\\";
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.InitialDirectory = start_directory;

            if (dialog.ShowDialog() == DialogResult.OK)        //если в диал.окне выбран файл    
                path = dialog.FileName;//берём имя файла
            textBox_Path.Text = path;
        }

        private void Edit_MyTrack_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DatabaseFunctions functions = new DatabaseFunctions();
            functions.User_Track_Edit("Редактировать", new_track.id, new_track.author, textBox_Author.Text, textBox_Title.Text, textBox_Genre.Text, textBox_Mood.Text,new_track.bitrate,new_track.source,path,new_track.duration);
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
