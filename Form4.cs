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
    public partial class Form4 : Form
    {
        Form ifrm = new Form3();
        public Form4()
        {
            
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Кнопка не работает, но вы там держитесь");
            //Form3 regf = new Form3();
            //string user = textBox1.Text;
            //string pass = textBox2.Text;
            //if (regf.Register(user, pass))
            //{
            //    MessageBox.Show($"Пользователь {user} был создан");
            //    ifrm.Show();
            //    this.Hide();
            //}
            //else
            //{
            //    MessageBox.Show($"Пользователь {user} не был создан");
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ifrm.Show();
            this.Hide();
        }
    }
}
