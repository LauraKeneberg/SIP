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
    public partial class F_BD : Form
    {
        DataSet ds = new DataSet();
        MySqlDataAdapter adapter = new MySqlDataAdapter();
        public F_BD()
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

        private void bt_scl1_Click(object sender, EventArgs e)
        {
            bt_scl1.ForeColor = System.Drawing.Color.Blue;
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("select nomenclatura.name as Товар,nomenclatura.count as Количество,nomenclatura.date as Дата, sotrudniky.Name as Сотрудники, v.name as Объём from sip.nomenclatura cross join sip.sotrudniky on nomenclatura.Sotrudniky_Id = sotrudniky.Id cross join sip.v on nomenclatura.V_Id = v.Id where nomenclatura.Sclad_Id = 4; ", db.GetConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            db.openConnection();
            System.Data.DataTable table = new System.Data.DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            db.closeConnection();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
