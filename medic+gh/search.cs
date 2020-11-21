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

namespace medic_gh
{
    public partial class search : Form
    {

        MySqlConnection connection = new MySqlConnection("Server=localhost;port=3306;Database=medic+gh;username=root;password=1234;");
        MySqlCommand command;
        MySqlDataAdapter adapter;
        DataTable table;

        public search()
        {
            InitializeComponent();
        }

        private void search_Load(object sender, EventArgs e)
        {
            searchdata("");
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string Search = textBox1.Text.ToString();
            searchdata(Search);
        }

        public void searchdata(string Search)
        {
            string query = "SELECT * FROM patient WHERE (patient_id) like '%" + Search + "%'";
            connection.Open();
            command = new MySqlCommand(query, connection);
            adapter = new MySqlDataAdapter(command);
            table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            connection.Close();
        }

    }
}
