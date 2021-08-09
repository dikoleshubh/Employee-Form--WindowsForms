using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Windows.Forms;

namespace payroll
{
    public partial class Form1 : Form
    {
        public static string connectionString = @"Data Source=.;Initial Catalog=EmployeeForm;Integrated Security=True";
        SqlConnection connection = new SqlConnection(connectionString);
        public Form1()
        {
          
            InitializeComponent();
        }
        public string ProfilePic;
        public string Gender;
        public string Department;
        int IDS;

       
        private void button1_Click(object sender, EventArgs e)
        {

            Clear();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            Department = "Finance";
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

            //if (textBox2.Text == "remarks")
            //{
            //    textBox2.Text = "";

            //    textBox2.ForeColor = Color.Black;
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[Form]
           ([Name]
           ,[ProfilePic]
           ,[Gender]
           ,[Department]
           ,[Salary]
           ,[Date]
           ,[Remarks])
     VALUES('" + textBox1.Text + "','" + ProfilePic + "','" + Gender + "','" + Department + "','" + label9.Text + "','" + dateTimePicker1.Text + "','" + textBox2.Text + "')", connection);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Employee Registration successful");
            Form2 form2 = new Form2();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //if (textBox1.Text == "Your Name ....")
            //{
            //    textBox1.Text = "";

            //    textBox1.ForeColor = Color.Black;
            //}
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            ProfilePic = "Pic1";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            ProfilePic = "Pic2";
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            ProfilePic = "Pic3";
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            ProfilePic = "Pic4";
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            Gender = "Female";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Male";
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            Department = "HR";
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            Department = "Engineer";
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            Department = "Others";
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        public void Clear()
        {
            textBox1.Clear();
            textBox2.Clear();
            dateTimePicker1.Text = null;
         
            checkBox6.Checked = false;
            checkBox5.Checked = false;
            trackBar1.IsAccessible=false;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label9.Text = trackBar1.Value.ToString();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            IDS = Form2.id;
            connection.Open();
             SqlCommand cmd = new SqlCommand("UPDATE [dbo].[Form] set [Name] ='" + textBox1.Text + "',[ProfilePic]='" + ProfilePic + "',[Gender]='" + Gender + "',[Department]='" + Department + "',[Salary]='" + label9.Text + "',[Date]='" + dateTimePicker1.Text + "',[Remarks]='" + textBox2.Text + "' where PersonID='" + IDS + "'", connection);
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Record Update Successful");
            //  up.Show();
            Close();
            Form2 form2 = new Form2();
            form2.display();
            MessageBox.Show("Updated ");
        }


       
    }
}
