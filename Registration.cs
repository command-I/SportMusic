using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity.Validation;

namespace SportMusic
{
    public partial class Registration : Form
    {
        public Registration()
        {
            
            InitializeComponent();
            textBox_Pass.UseSystemPasswordChar = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox_Login.Text != "" && textBox_Pass.Text != "" && textBox_Surname.Text != "" && textBox_Name.Text != "" && textBox_Email.Text != "" && textBox_Phone.Text != "")
            {
                DatabaseFunctions functions = new DatabaseFunctions();
                string role = "Тренер";
                string login = textBox_Login.Text;
                string pass = textBox_Pass.Text;
                string name = textBox_Name.Text;
                string surname = textBox_Surname.Text;
                string email = textBox_Email.Text;
                int phone = Convert.ToInt32(textBox_Phone.Text);
                string path = "path"; // заглушка

                try
                {
                    functions.UserEdit("Добавить", -1, role, login, pass, name, surname, email, phone, path);
                }
                catch (DbEntityValidationException ex)
                {
                    foreach (var eve in ex.EntityValidationErrors)
                    {
                        MessageBox.Show(String.Format("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                            eve.Entry.Entity.GetType().Name, eve.Entry.State));
                        foreach (var ve in eve.ValidationErrors)
                        {
                            MessageBox.Show(String.Format("- Property: \"{0}\", Error: \"{1}\"",
                                ve.PropertyName, ve.ErrorMessage));
                        }
                    }
                    throw;
                }
            }
            else
            {
                MessageBox.Show("Заполните все поля");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form ifm = new Authorization();
            ifm.Show();
            this.Hide;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox_Pass.UseSystemPasswordChar = false;
            }
            else
                textBox_Pass.UseSystemPasswordChar = true;

        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }
    }
}
