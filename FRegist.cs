using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIP
{
    public partial class FRegist : Form
    {
        public FRegist()
        {
            InitializeComponent();
        }

        private void lb_SIP_Click(object sender, EventArgs e)
        {
            FStart f1 = new FStart();
            f1.Show();
            this.Hide();
        }

        private void lb_SIP_MouseMove(object sender, MouseEventArgs e)
        {
            lb_SIP.ForeColor = Color.Orange;
        }

        private void lb_SIP_MouseLeave(object sender, EventArgs e)
        {
            lb_SIP.ForeColor = Color.Pink;
        }

        private void bt_vhod_Click(object sender, EventArgs e)
        {
            DB dB = new DB();
            DataTable table = new DataTable();
            MySqlCommand command = new MySqlCommand("INSERT INTO users(F_name, L_name, M_name, Login, Password) VALUES (@name, @surname, @otchestvo, @login, @pass)", dB.GetConnection());
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = textBox3.Text;
            command.Parameters.Add("@surname", MySqlDbType.VarChar).Value = textBox4.Text;
            command.Parameters.Add("@otchestvo", MySqlDbType.VarChar).Value = textBox5.Text;
            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = textBox1.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = textBox2.Text;

            dB.openConnection();
            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Аккаунт был создан");
            else
                MessageBox.Show("Аккаунт не был создан");
            dB.closeConnection();

            if (command.ExecuteNonQuery() > 0)
            {
                if (textBox1.Text == "Admin" && textBox2.Text == "Admin")
                {
                    MessageBox.Show("Добро пожаловать! ^_^");
                    this.Hide();
                    Adm_S f1 = new Adm_S();
                    f1.Show();

                }
                else if (table.Rows.Count > 0)
                {
                    Form5 f5 = new Form5();
                    f5.Show();
                    this.Hide();
                    MessageBox.Show("Добро пожаловать! ^_^");
                }
            }
            else
            {
                MessageBox.Show("Нет такого пользователя");
            }
        }
    }
}
