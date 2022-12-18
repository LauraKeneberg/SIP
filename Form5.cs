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
    public partial class Form5 : Form
    {
        DataSet ds = new DataSet();
        MySqlDataAdapter adapter = new MySqlDataAdapter();
        public Form5()
        {
            InitializeComponent();
            DB db = new DB();
            db.openConnection();
            MySqlCommand command = new MySqlCommand("SELECT * FROM users", db.GetConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);

            ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns["Id"].ReadOnly = true;
            
        }
        private BindingSource bindingSource = new BindingSource();
        private MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
        private DataSet dataSet = new DataSet();
        string currentTableName;
        private BindingSource loadData(string query, string tableName)
        {
            DB db = new DB();

            db.openConnection();

            MySqlCommand command = new MySqlCommand(query, db.GetConnection());

            dataAdapter.SelectCommand = command;
            currentTableName = tableName;

            MySqlCommandBuilder builder = new MySqlCommandBuilder(dataAdapter);

            dataAdapter.Fill(dataSet, tableName);
            dataAdapter.UpdateCommand = builder.GetUpdateCommand();
            bindingSource.DataSource = dataSet.Tables[currentTableName];

            db.closeConnection();

            return bindingSource;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            string connetionString = null;
            MySqlConnection cnn;
            connetionString = "server=localhost;port=3306;username=root;password=20052003mama;database=sip";
            cnn = new MySqlConnection(connetionString);
            try
            {
                cnn.Open();
                MessageBox.Show("Connection Open ! ");
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
            }
        }



        private void button5_Click(object sender, EventArgs e)
        {
            {
                int a = dataGridView1.CurrentRow.Index;
                dataGridView1.Rows.Add(dataGridView1.Rows[a]);
                MessageBox.Show("Успешно удалено");
                dataAdapter.Update(dataSet, currentTableName);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("SELECT name FROM v", db.GetConnection());
            MySqlDataAdapter riverSourcesAdapter = new MySqlDataAdapter(command);
            DataSet riverDataSet = new DataSet();
            riverSourcesAdapter.Fill(riverDataSet);

            comboBox1.DataSource = riverDataSet.Tables[0];
            comboBox1.DisplayMember = "<Name>";
            comboBox1.ValueMember = "<Name>";
        }
    }
}
