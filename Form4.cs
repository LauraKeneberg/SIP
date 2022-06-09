using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIP
{
    public partial class Form4 : Form
    {
        DataSet ds = new DataSet();
       
        public Form4()
        {
            InitializeComponent();
        }

        private void bt_scl1_Click(object sender, EventArgs e)
        {
            bt_scl1.ForeColor = System.Drawing.Color.Blue;
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("select * from sclad1", db.GetConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            db.openConnection();
            System.Data.DataTable table = new System.Data.DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            db.closeConnection();
            bt_scl2.ForeColor = System.Drawing.Color.Black;
            bt_scl3.ForeColor = System.Drawing.Color.Black;
        }

        private void bt_scl2_Click(object sender, EventArgs e)
        {
            bt_scl2.ForeColor = System.Drawing.Color.Blue;
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("select * from sclad2", db.GetConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            db.openConnection();
            System.Data.DataTable table = new System.Data.DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            db.closeConnection();
            bt_scl1.ForeColor = System.Drawing.Color.Black;
            bt_scl3.ForeColor = System.Drawing.Color.Black;
        }

        private void bt_scl3_Click(object sender, EventArgs e)
        {
            bt_scl3.ForeColor = System.Drawing.Color.Blue;
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("select * from sclad3", db.GetConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            db.openConnection();
            System.Data.DataTable table = new System.Data.DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            db.closeConnection();
            bt_scl1.ForeColor = System.Drawing.Color.Black;
            bt_scl2.ForeColor = System.Drawing.Color.Black;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            /*Form5 f5 = new Form5();
            f5.Show();
            this.Hide();*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            if (bt_scl1.ForeColor == System.Drawing.Color.Blue)
            { MySqlCommand command = new MySqlCommand("INSERT INTO sclad1 (Name, Count, Tara) VALUES (@name, @count, @tara)", db.GetConnection());
                command.Parameters.Add("@name", MySqlDbType.VarChar).Value = tB_Name.Text;
                command.Parameters.Add("@count", MySqlDbType.VarChar).Value = tB_Count.Text;
                command.Parameters.Add("@tara", MySqlDbType.VarChar).Value = tB_Tara.Text;

                adapter.SelectCommand = command;
                adapter.Fill(table);

                db.openConnection();


                db.closeConnection();
            }
            else if (bt_scl2.ForeColor == System.Drawing.Color.Blue)
            {
                MySqlCommand command = new MySqlCommand("INSERT INTO sclad2 (Name, Count, Tara) VALUES (@name, @count, @tara)", db.GetConnection());
                command.Parameters.Add("@name", MySqlDbType.VarChar).Value = tB_Name.Text;
                command.Parameters.Add("@count", MySqlDbType.VarChar).Value = tB_Count.Text;
                command.Parameters.Add("@tara", MySqlDbType.VarChar).Value = tB_Tara.Text;

                adapter.SelectCommand = command;
                adapter.Fill(table);

                db.openConnection();


                db.closeConnection();
            }
            else if (bt_scl3.ForeColor == System.Drawing.Color.Blue)
            {
                MySqlCommand command = new MySqlCommand("INSERT INTO sclad3 (Name, Count, Tara) VALUES (@name, @count, @tara)", db.GetConnection());
                command.Parameters.Add("@name", MySqlDbType.VarChar).Value = tB_Name.Text;
                command.Parameters.Add("@count", MySqlDbType.VarChar).Value = tB_Count.Text;
                command.Parameters.Add("@tara", MySqlDbType.VarChar).Value = tB_Tara.Text;

                adapter.SelectCommand = command;
                adapter.Fill(table);

                db.openConnection();


                db.closeConnection();
            }

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("delete from sclad1 where (Id, Name, Count, Tara) VALUES (@id, @name, @count, @tara)", db.GetConnection());

            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = tB_Id.Text;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = tB_Name.Text;
            command.Parameters.Add("@count", MySqlDbType.VarChar).Value = tB_Count.Text;
            command.Parameters.Add("@tara", MySqlDbType.VarChar).Value = tB_Tara.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            db.openConnection();


            db.closeConnection();
        }
    }
}
