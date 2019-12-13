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
using System.IO;
namespace MarATHON
{
    public partial class zagruzkavolonters : Form
    {
        public zagruzkavolonters()
        {
            InitializeComponent();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "Файлы|*.csv";
            if (openDialog.ShowDialog() != DialogResult.OK)
                return;

            try
            {
                textBox1.Text = System.IO.Path.GetFileName(openDialog.FileName);
            }
            catch (OutOfMemoryException ex)
            {
                MessageBox.Show("Ошибка чтения файла csv");
                return;
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            string line = "";
            string con_str = "Data Source=DESKTOP-AKC6G8I;Initial Catalog=g464_Golubtsov;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(con_str))
            {
                connection.Open();
                using (StreamReader file = new StreamReader(new BufferedStream(File.OpenRead(textBox1.Text), 10 * 1024 * 1024)))
                {


                    while ((line = file.ReadLine()) != null)
                    {

                        string[] values = line.Split(',');
                        SqlCommand cmd = new SqlCommand("INSERT INTO [Volunteer] ([FirstName],[LastName],[CountryCode],[Gender]) VALUES (@fn, @ln, @code, @gen)", connection);


                        cmd.Parameters.AddWithValue("@fn", values[1].ToString());
                        cmd.Parameters.AddWithValue("@ln", values[2].ToString());
                        cmd.Parameters.AddWithValue("@code", values[3].ToString());
                        cmd.Parameters.AddWithValue("@gen", values[4].ToString());
                        cmd.ExecuteNonQuery();

                    }
                }
                connection.Close();

                this.Close();
                Volonters yyy = new Volonters();
                yyy.Show();
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Volonters yyy = new Volonters();
            yyy.Show();
        }
    }
}
    

