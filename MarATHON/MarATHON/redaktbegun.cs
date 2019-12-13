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
    public partial class redaktbegun : Form
    {
        
        public redaktbegun()
        {
           
            InitializeComponent();
        }

        private void Redaktbegun_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "g464_GolubtsovDataSet22.Country". При необходимости она может быть перемещена или удалена.
            this.countryTableAdapter1.Fill(this.g464_GolubtsovDataSet22.Country);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "g464_GolubtsovDataSet5.Country". При необходимости она может быть перемещена или удалена.
            //this.countryTableAdapter.Fill(this.g464_GolubtsovDataSet5.Country);
            label11.Text = PEREMEN.Login;


            //string conn = "Data Source=127.0.0.1;Initial Catalog=g464_Golubtsov;User ID=student;Password=student";
            string conn = "Data Source=DESKTOP-AKC6G8I;Initial Catalog=g464_Golubtsov;Integrated Security=True";
            // string str = "select [Email],[Password],[RoleId] FROM [User] WHERE [Email]='" + textBox1.Text + "' AND [Password]='" + textBox2.Text + "'";

            string str = "SELECT  [Gender],[DateOfBirth],[CountryCode] FROM [g464_Golubtsov].[dbo].[Runner] WHERE [Email] = '" + PEREMEN.Login+"'";
            string str2 = "SELECT  [FirstName],[LastName] FROM [g464_Golubtsov].[dbo].[User] WHERE [Email] = '" + PEREMEN.Login+"'";
            SqlConnection con = new SqlConnection(conn);
            con.Open();
            SqlCommand cmd = new SqlCommand(str, con);
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read() == true)
            {
                comboBox1.Text = rdr.GetString(0);
                dateTimePicker1.Value = rdr.GetDateTime(1);
                comboBox2.Text = rdr.GetString(2);
            }
            rdr.Close();

            SqlCommand cmd2 = new SqlCommand(str2, con);
            SqlDataReader rdr2 = cmd2.ExecuteReader();
            while (rdr2.Read() == true)
            {
                textBox2.Text = rdr2.GetString(0);
                textBox3.Text = rdr2.GetString(1);
            }
            rdr2.Close();
            con.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string pattern1 = @"^(?=.*[0-9])(?=.*[!@#$%^&*])(?=.*[a-z])(?=.*[A-Z])[0-9a-zA-Z!@#$%^&*]{6,}$";
            Regex t = new Regex(pattern1, RegexOptions.IgnoreCase);
            bool matched1 = t.Match(textBox8.Text).Success;
            if (textBox4.Text != textBox8.Text)MessageBox.Show("Пароли не совпадают");
            else if (matched1 != true) MessageBox.Show("Павроль то не торот, пароль должен содержать как минимум 6 символов, рсреди них должен быть специальный символ");
            else
            {
            string conn = "Data Source=DESKTOP-AKC6G8I;Initial Catalog=g464_Golubtsov;Integrated Security=True";
            string str = "UPDATE [User] SET Password = '" + textBox8.Text + "', FirstName = '" + textBox2.Text + "', LastName = '" + textBox3.Text + "', Pictures = '" + textBox7.Text + "'  WHERE Email = '" + PEREMEN.Login + "'  ";
            string str2 = "UPDATE [Runner] SET [Gender] ='" + comboBox1.Text+"',  [DateOfBirth] = '" + dateTimePicker1.Value+"', [CountryCode] ='"+comboBox2.Text+"'  WHERE [Email] = '" + PEREMEN.Login + "'";
            SqlConnection con = new SqlConnection(conn);
            con.Open();
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.ExecuteNonQuery();
            SqlCommand cmd1 = new SqlCommand(str2, con);
            cmd1.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Вы успешно изменили");
                this.Close();
                menurun yyy51 = new menurun();
            yyy51.Show();
            }



        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Image image;
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "Файлы изображений|*.bmp;*.png;*.jpg";
            if (openDialog.ShowDialog() != DialogResult.OK)
                return;

            try
            {
                textBox7.Text = System.IO.Path.GetFileName(openDialog.FileName);
                image = Image.FromFile(openDialog.FileName);
            }
            catch (OutOfMemoryException ex)
            {
                MessageBox.Show("Ошибка чтения картинки");
                return;
            }
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox1.Image = image;
        }
    }
}
