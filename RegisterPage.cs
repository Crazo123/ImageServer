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
    public partial class RegisterPage : Form
    {

        SqlConnection con = new SqlConnection("Data Source=CRAZO-PC;Initial Catalog=CSI3304 Assignment 2;Integrated Security=True");
        public RegisterPage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Password_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("Username Is Required!");
            }
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            if (textBox2.Text == string.Empty)
            {
                MessageBox.Show("Password Is Required!");
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            if (textBox3.Text == string.Empty)
            {
                MessageBox.Show("Email Address Is Required!");
            }
        }

        private void SecretQuestion_Validating(object sender, CancelEventArgs e)
        {
            if (SecretQuestion.Text == string.Empty)
            {
                MessageBox.Show("Secret Question Is Required!");
            }

        }

        private void textBox4_Validating(object sender, CancelEventArgs e)
        {
            if (textBox4.Text == string.Empty)
            {
                MessageBox.Show("Secret Answer Is Required!");
            }
        }

        private void CodeOfConduct_Validating(object sender, CancelEventArgs e)
        {
            if (CodeOfConduct.Checked =false)
            {
                MessageBox.Show("You Have Not agreed To The Terms And Conditions");
            }
        }

        private void Submit_Validating(object sender, CancelEventArgs e)
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

        private void SecretQuestion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
