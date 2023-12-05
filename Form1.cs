using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userName = textBox1.Text.Trim();
            string userPassword = textBox2.Text.Trim();

            string sql = "SELECT `pass` FROM `users` WHERE `name`=@par1";
            MySqlCommand cmd = new MySqlCommand(sql,DBConn.Connect());
            cmd.Parameters.AddWithValue("@par1",userName);
            cmd.ExecuteNonQuery();
            MySqlDataReader reader = cmd.ExecuteReader();
            if(reader.HasRows)
            {
                label3.Text = "такой пользователь есть";
            } else
            {
                label3.Text = "такого пользователя нет";
            }


        }
    }
}
