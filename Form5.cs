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

namespace dbs
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = " Data Source = LAPTOP - 5975IE7S;User ID = system";
            string query = "SELECT * FROM NGO ORDER BY Sector";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter dataadpater = new SqlDataAdapter(query, connection);
            DataSet ds = new DataSet();
            connection.Open();
            dataadpater.Fill(ds);
            connection.Close();
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();   
            form.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();   
                form.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
