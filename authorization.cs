using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace SportMusic
{
    public partial class Authorization : Form
    {

        public Authorization()
        {

            InitializeComponent();
        }

  

        private void button1_Click(object sender, EventArgs e)
        {
            Form ifrm = new Registration();
            ifrm.Show(); // отображаем Form4
            this.Hide(); // скрываем Form3 
        }


        public bool IsLogin(string user, string pass)
        {
            return true;
        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Intensiv2018Entities asd = new Intensiv2018Entities();

            string role = "temp";
            role = asd.SysUsers.Where(a => a.login == textBox1.Text && a.pass == textBox2.Text).Select(a => a.role).FirstOrDefault();
            if (role != "Тренер" && role != "Администратор")
            {
                MessageBox.Show("Такого пользователя в системе нет");
            }
            else
            {
                Form ifrm = new Main_Form();
                ifrm.Show(); // отображаем Form1
                this.Hide(); // скрываем Form3
            }
            
            
        }
    }
}
