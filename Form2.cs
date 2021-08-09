using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace payroll
{
    public partial class Form2 : Form
    {
        public static int id;
        public Form2()
        {
            InitializeComponent();
            display();
        }

        public static string connectionString = @"Data Source=.;Initial Catalog=EmployeeForm;Integrated Security=True";
        SqlConnection connection = new SqlConnection(connectionString);
        DataTable dt;
        SqlDataAdapter adp;
        public static string  Department, Gender, Salary, Date, pic;
        SqlCommand command;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());

           
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            Name = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            pic = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            Gender = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            Department = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            Form1 f1 = new Form1();
            f1.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
           

           
            
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure to Delete ?", "Delete record", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
               // id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                connection.Open();
                command = new SqlCommand("DELETE FROM dbo.Form WHERE PersonID='" + id + "'", connection);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Record Deleted From Data");
                display();
            }
        }


        public void display()
        {
            try
            {
                dt = new DataTable();
                connection.Open();
                adp = new SqlDataAdapter("SELECT Form.PersonID, Form.Name,Form.ProfilePic,Form.Gender,Form.Department,Form.Salary,Form.Date from Form", connection);
                adp.Fill(dt);
                dataGridView1.DataSource = dt;
                connection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }
    }
}
