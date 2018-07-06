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
    public partial class loadForm : Form
    {

        int id;
        string login;
        string name;
        string surname;

        public loadForm (int id, string login, string name, string surname)
        {
            this.id = id;
            this.login = login;
            this.name = name;
            this.surname = surname;
            InitializeComponent();
        }

        public loadForm()
        {
            InitializeComponent();
        }

        private void loader_Tick(object sender, EventArgs e)
        {
            if (bunifuCircleProgressbar1.Value < 100)
            {
                bunifuCircleProgressbar1.Value++;
            }
            else
            {
                label1.Visible = false;
                bunifuCircleProgressbar1.Visible = false;
                Form ifm = new Main_Form(id, login, name, surname);
                ifm.Show();
                loader.Enabled = false;
                this.Hide();
                

            }

        }
    }
}
