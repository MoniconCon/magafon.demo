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
using System.Text.RegularExpressions;
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
            string pattern = @"^[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,4}$";
            string pattern1 = @"^(?=.*[0-9])(?=.*[!@#$%^&*])(?=.*[a-z])(?=.*[A-Z])[0-9a-zA-Z!@#$%^&*]{6,}$";
         
                Regex r = new Regex(pattern, RegexOptions.IgnoreCase);
                Regex t = new Regex(pattern1, RegexOptions.IgnoreCase);

                
              // DateTime U;
              // U = DateTimePicker1.Value;

                //string udate = dateTimePicker1.Text;
                //System.Convert.ToShortDateString(dateTimePicker1.Value);
               // dateTimePicker1.Value.ToShortDateString("yyyy-MM-dd");
                //string Dataa = dateTimePicker1.Value.Date.ToShortDateString();
               // Convert.ToDateTime(dateTimePicker1.Text).ToShortDateString("yyyy-MM-dd hh:mm:sss");
                
                if (textBox1.Text == "" || comboBox2.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "" || textBox8.Text == "" || comboBox1.Text == "" || dateTimePicker1.Text == "") MessageBox.Show("Есть пустые поля");
                bool matched = r.Match(textBox1.Text).Success;
                bool matched1 = t.Match(textBox8.Text).Success;

                if (matched != true) MessageBox.Show("Мыло то не торот");
                else if (matched1 != true) MessageBox.Show("Павроль то не торот, пароль должен содержать как минимум 6 символов, рсреди них должен быть специальный символ");
                else if (textBox8.Text == textBox7.Text)
                {
                    string data = dateTimePicker1.Value.ToString("yyyy-MM-dd hh:mm:ss.hs");
                    string conn = "Data Source=127.0.0.1;Initial Catalog=g464_Golubtsov;User ID=student;Password=student";
                    string str = "INSERT INTO [user] ([Email],[Password],[FirstName],[LastName],[RoleId]) VALUES ('" + textBox1.Text + "','" + textBox7.Text + "','" + textBox6.Text + "','" + textBox5.Text + "','R')";
                    string str2 = "INSERT INTO [Runner] ([Email],[Gender],[DateOfBirth],[CountryCode]) VALUES ('" + textBox1.Text + "','" + comboBox1.Text + "','" + data + "','" + comboBox2.Text + "')";
                    SqlConnection con = new SqlConnection(conn);
                    con.Open();
                    SqlCommand cmd = new SqlCommand(str, con);
                    cmd.ExecuteNonQuery();
                    SqlCommand cmd2 = new SqlCommand(str2, con);
                    cmd2.ExecuteNonQuery();
                    con.Close();
                }

    }

        private void newrunner1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'g464_GolubtsovDataSet4.Country' table. You can move, or remove it, as needed.
            this.countryTableAdapter1.Fill(this.g464_GolubtsovDataSet4.Country);
            // TODO: This line of code loads data into the 'g464_GolubtsovDataSet3.Country' table. You can move, or remove it, as needed.
            this.countryTableAdapter.Fill(this.g464_GolubtsovDataSet3.Country);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Image image;
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "Файлы изображений|*.bmp;*.png;*.jpg";
            if (openDialog.ShowDialog() != DialogResult.OK)
                return;

            try
            {
                image = Image.FromFile(openDialog.FileName);
            }
            catch (OutOfMemoryException ex)
            {
                MessageBox.Show("Ошибка чтения картинки");
                return;
            }

            panel1.AutoScroll = true;
            panel1.AutoScrollMinSize = image.Size;
            panel1.Invalidate();
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }
        }
}
