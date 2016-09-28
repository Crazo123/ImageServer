using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApplication3
{
    public partial class AdminPage : Form
    {
        SqlConnection con = new SqlConnection("Data Source=CRAZO-PC;Initial Catalog=CSI3304 Assignment 2;Integrated Security=True");
        public AdminPage()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Display();
        }

        private void AdminPage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cSI3304_Assignment_2DataSet1.Consumer' table. You can move, or remove it, as needed.
            this.consumerTableAdapter1.Fill(this.cSI3304_Assignment_2DataSet1.Consumer);

           

        }


        void Display()
        {
            
            SqlDataAdapter sda = new SqlDataAdapter("Select * from Consumer", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = item[0].ToString();
                dataGridView1.Rows[n].Cells[1].Value = item[1].ToString();
                dataGridView1.Rows[n].Cells[2].Value = item[2].ToString();
                dataGridView1.Rows[n].Cells[3].Value = item[3].ToString();
                dataGridView1.Rows[n].Cells[4].Value = item[4].ToString();
                dataGridView1.Rows[n].Cells[5].Value = item[5].ToString();
            }

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(@"INSERT INTO Consumer
                (Username, Password, Email_Address, Secret_Question, Secret_Answer)
                VALUES               ('" + textBox1.Text + " ','" + textBox2.Text + " ','" + textBox3.Text + " ','" + SecretQuestion.Text + " ','" + textBox4.Text + " ')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Registration Successful!");
            
        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
