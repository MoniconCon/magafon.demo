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
            this.Close();
            Mains open = new Mains();
            open.Show();
           
        }
        //Регистрация
        public void button2_Click(object sender, EventArgs e)
        {
            string pattern = @"^[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,4}$";
            string pattern1 = @"^(?=.*[0-9])(?=.*[!@#$%^&*])(?=.*[a-z])(?=.*[A-Z])[0-9a-zA-Z!@#$%^&*]{6,}$";

            Regex r = new Regex(pattern, RegexOptions.IgnoreCase);
            Regex t = new Regex(pattern1, RegexOptions.IgnoreCase);


            if (textBox1.Text == "" || comboBox2.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "" || textBox8.Text == "" || comboBox1.Text == "" || dateTimePicker1.Text == "") MessageBox.Show("Есть пустые поля");
            bool matched = r.Match(textBox1.Text).Success;
            bool matched1 = t.Match(textBox8.Text).Success;

            if (matched != true) MessageBox.Show("Мыло то не торот");
            else if (matched1 != true) MessageBox.Show("Павроль то не торот, пароль должен содержать как минимум 6 символов, рсреди них должен быть специальный символ");
            else if (textBox8.Text == textBox7.Text)
            {
    
                DateTime data = Convert.ToDateTime(dateTimePicker1.Value.ToString("yyyy-MM-dd hh:mm:ss.hs"));

                PEREMEN.data = data;
                PEREMEN.textBox1 = textBox1.Text;
                PEREMEN.textBox7 = textBox7.Text;
                PEREMEN.textBox6 = textBox6.Text;
                PEREMEN.textBox5 = textBox5.Text;
                PEREMEN.comboBox1 = comboBox1.Text;
                PEREMEN.comboBox2 = comboBox2.Text;
                PEREMEN.Pictures = textBox4.Text;
                this.Close();
                newrunerr3 yyy5 = new newrunerr3();
                yyy5.Show();
            }
        }

        private void newrunner1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "g464_GolubtsovDataSet20.Country". При необходимости она может быть перемещена или удалена.
            this.countryTableAdapter3.Fill(this.g464_GolubtsovDataSet20.Country);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "g464_GolubtsovDataSet6.Country". При необходимости она может быть перемещена или удалена.
            //this.countryTableAdapter2.Fill(this.g464_GolubtsovDataSet6.Country);
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
                textBox4.Text=System.IO.Path.GetFileName(openDialog.FileName);
                image = Image.FromFile(openDialog.FileName);
            }
            catch (OutOfMemoryException ex)
            {
                MessageBox.Show("Ошибка чтения картинки");
                return;
            }
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox2.Image = image;
        }

    }
}
    
 
        