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
    public partial class boardForm : Form
    {

        bool buttonClicked = false;

        public boardForm()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            Main_Form childForm = new Main_Form();
            childForm.MdiParent = this;
            childForm.Show();
            childForm.WindowState = FormWindowState.Maximized;

            label1.Visible = true;
            bunifuCircleProgressbar1.Visible = true;
            buttonClicked = true;
        }

        private void timerLoad_Tick(object sender, EventArgs e)
        {
            if (buttonClicked == true)
            {
                if (bunifuCircleProgressbar1.Value < 100)
                {
                    bunifuCircleProgressbar1.Value++;
                }
                else
                {
                    label1.Visible = false;
                    bunifuCircleProgressbar1.Visible = false;
                    buttonClicked = false;
                    bunifuCircleProgressbar1.Value = 0;
                    panel2.Hide();
                }
            }
            else
            {
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
