using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace MarATHON
{
    public partial class newrunner1 : Form
    {
        public newrunner1()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Mains open = new Mains();
            open.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && textBox2.Text == "" && textBox3.Text == "" && textBox4.Text == "" && textBox5.Text == "" && textBox6.Text == "" && textBox7.Text == "" && textBox8.Text == "") MessageBox.Show("Есть пустые поля");
            else if(textBox8.Text == textBox7.Text)
            {
            string conn = "Data Source=127.0.0.1;Initial Catalog=g464_Golubtsov;User ID=student;Password=student";
            string str = "INSERT INTO [user] ([Email],[Password],[FirstName],[LastName],[RoleId]) VALUES ('" + textBox1.Text + "','" + textBox7.Text + "','" + textBox6.Text + "','" + textBox5.Text + "','R')";
            string str2 = "INSERT INTO [Runner] ([Email],[Gender],[DateOfBirth],[CountryCode]) VALUES ('" + textBox1.Text + "','" + textBox3.Text + "','" + dateTimePicker1.Text + "','" + textBox2.Text + "')";
            SqlConnection con = new SqlConnection(conn);
            con.Open();
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.ExecuteNonQuery();
            SqlCommand cmd2 = new SqlCommand(str2, con);
            cmd.ExecuteNonQuery();
            con.Close();
            }
        }
    }
}
