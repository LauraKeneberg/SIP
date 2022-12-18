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
    public partial class FAutoriz : Form
    {
        public FAutoriz()
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
            string LoginUser = textBox1.Text;
            string PassUser = textBox2.Text;

            DB db = new DB();
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("select * from Users where Login = @UL and Password = @UP", db.GetConnection());

            command.Parameters.Add("@UL", MySqlDbType.VarChar).Value = LoginUser;
            command.Parameters.Add("@UP", MySqlDbType.VarChar).Value = PassUser;

            adapter.SelectCommand = command;
            adapter.Fill(table);
           

            if (table.Rows.Count > 0)
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
