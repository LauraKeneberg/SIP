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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            button1.ForeColor = System.Drawing.Color.Blue;
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("SELECT sotrudniky.name as Имя, sotrudniky.surname as Фамилия, sotrudniky.otchestvo as Отчество, ceh.name as Цех FROM sip.sotrudniky cross join sip.ceh on sotrudniky.Ceh_Id = Ceh.Id;", db.GetConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            db.openConnection();
            System.Data.DataTable table = new System.Data.DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            db.closeConnection();
            button2.ForeColor = System.Drawing.Color.Black;
            button3.ForeColor = System.Drawing.Color.Black;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 fo1 = new Form1();
            fo1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 fo1 = new Form1();
            fo1.Show();
        }
    }
}
