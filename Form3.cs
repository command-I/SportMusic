using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SportMusic
{
    public partial class Form3 : Form
    {
        private MySqlConnection conn;
        private string server;
        private string database;
        private string uid;
        private string password;
        private int port;
        public Form3()
        {
            server = "localhost";
            database = "accounts_music";
            uid = "enmaboya";
            password = "tau40000wh";
            port = 3306;

            string connString;
            connString = $"SERVER={server}; PORT ={port}; DATABASE ={database};UID={uid};PASSWORD={password};";

            conn = new MySqlConnection(connString);
            InitializeComponent();
        }

  

        private void button1_Click(object sender, EventArgs e)
        {
            Form ifrm = new Form4();
            ifrm.Show(); // отображаем Form4
            this.Hide(); // скрываем Form3 
        }

        public bool Register(string user, string pass)
        {
            string query = $"INSERT INTO accounts_music (id, username, password) VALUES ('', '{user}', '{pass}');";
            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    try
                    {
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        return false;
                    }
                }
                else
                {
                    conn.Close();
                    return false;
                }
            }
            catch (Exception ex)
            {
                conn.Close();
                return false;
            }
        }

        public bool IsLogin(string user, string pass)
        {
            string query = $"SELECT * FROM accounts_music WHERE username = '{user}' AND password = '{pass}';";

            try
            {
                if (OpenConnection())
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        reader.Close();
                        conn.Close();
                        return true;
                    }
                    else
                    {
                        reader.Close();
                        conn.Close();
                        return false;
                    }
                }
                else
                {
                    conn.Close();
                    return false;
                }
            }
            catch (Exception ex) { }
            {
                conn.Close();
                return false;
            }
        }

        private bool OpenConnection()
        {
            try
            {
                conn.Open();
                return true;
            }
            catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message);
                //switch (ex.Number)
                //{
                //    case 0:
                //        MessageBox.Show("Ошибка соединения с сервером");
                //        break;
                //    case 1045:
                //        MessageBox.Show("Логин или пароль введены неверно");
                //        break;
                //}
                return false;
            }
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
            Form ifrm = new Form1();
            ifrm.Show(); // отображаем Form1
            this.Hide(); // скрываем Form3
            
            //string user = textBox1.Text;
            //string pass = textBox2.Text;
            //if (IsLogin(user, pass))
            //{
            //    MessageBox.Show($"Пользователь {user} в системе.");
            //}
            //else
            //{
            //    MessageBox.Show($"{user} пароль или логин введены неправильно.");
            //}
        }
    }
}
