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
using System.Data.Sql;
using System.Data.SqlTypes;
using System.Data.Common;
namespace MarATHON
{
    public partial class Sponsor : Form
    {
        public class urobor
        {
            public static string pay1;
            public static string pay2;
            public static string pay3;
        };
        public Sponsor()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'g464_GolubtsovDataSet2.View_2' table. You can move, or remove it, as needed.
            this.view_2TableAdapter1.Fill(this.g464_GolubtsovDataSet2.View_2);
            // TODO: This line of code loads data into the 'g464_GolubtsovDataSet1.View_2' table. You can move, or remove it, as needed.
            this.view_2TableAdapter.Fill(this.g464_GolubtsovDataSet1.View_2);
            // TODO: This line of code loads data into the 'g464_GolubtsovDataSet.staff' table. You can move, or remove it, as needed.
            this.staffTableAdapter.Fill(this.g464_GolubtsovDataSet.staff);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "Ваше имя" || textBox3.Text == "Имя владельца" || maskedTextBox2.Text == "123")
            {
                MessageBox.Show("Пляне заполненые");
            }
            else
            {
                int n = 0;
                for (int i = 0; i < maskedTextBox1.Text.Length - 1; i++)
                    if (maskedTextBox1.Text[i] == ' ') n++;
                // MessageBox.Show(maskedTextBox1.Text.Length.ToString() + ", " + n.ToString());
                if (n > 3)
                {
                    MessageBox.Show("Нвереный крырты ");
                }
                else
                {
                    if (god.Text != null && Convert.ToInt32(god.Text) > 1900 && Convert.ToInt32(god.Text) < 2200)
                    {
                        if (maskedTextBox3.Text == null && Convert.ToInt32(maskedTextBox3.Text) > 13 && Convert.ToInt32(maskedTextBox3.Text) < 1) { MessageBox.Show("Год не торт"); }
                        else
                        {
                            string s = maskedTextBox1.Text;
                            s = s.Replace(" ", "");
                            s = s.Replace(" ", "");
                            s = s.Replace(" ", "");
                            MessageBox.Show(s);

                            string conn = "Data Source=127.0.0.1;Initial Catalog=g464_Golubtsov;User ID=student;Password=student";
                            string str = "INSERT INTO [Sponsorship] ([SponsorName],[RegistrationId],[Amount]) VALUES ('" + textBox2.Text + "'," + comboBox1.SelectedValue + "," + textBox1.Text + ")";
                            SqlConnection con = new SqlConnection(conn);
                            con.Open();
                            SqlCommand cmd = new SqlCommand(str, con);
                            cmd.ExecuteNonQuery();
                            con.Close();
                            urobor.pay1 = comboBox1.Text + " (" + comboBox1.SelectedValue + ")";
                            urobor.pay2 = textBox1.Text;
                            urobor.pay3 = label9.Text;

                            this.Hide();
                            formpay frm = new formpay();
                            frm.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Год не торт");
                    }
                }
            }
        }
      

        private void button2_Click(object sender, EventArgs e)
        {
            if ( Convert.ToInt32(textBox1.Text) > 10 & textBox1.Text != null)
            {
                int v = int.Parse(textBox1.Text);
                textBox1.Text = (v - 10).ToString();
                sum.Text = textBox1.Text + " $";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int v = int.Parse(textBox1.Text);
            textBox1.Text = (v + 10).ToString();
            sum.Text = textBox1.Text + " $";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan t = Program.start - DateTime.Now;
            DATA6.Text = t.Days.ToString() + " days, " +
                t.Hours.ToString() + " hours, " +
                t.Minutes.ToString() + " minutes";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Mains open = new Mains();
            open.Show();
            this.Close();
        }

        private void Sponsor_Enter(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            textBox2.Text = "Ваше имя";
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            textBox3.Text = "";
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            textBox3.Text = "Имя владельца";
        }

        private void maskedTextBox1_Leave(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text == "")
            maskedTextBox1.Text = "1234 1234 1234 1234";
        }

        private void maskedTextBox1_Enter(object sender, EventArgs e)
        {
            maskedTextBox1.Text = "";
        }

        private void maskedTextBox3_Enter(object sender, EventArgs e)
        {
            maskedTextBox3.Text = "";
        }

        private void maskedTextBox3_Leave(object sender, EventArgs e)
        {
            if (maskedTextBox3.Text == "")
            maskedTextBox3.Text = "01";
        }

        private void god_Enter(object sender, EventArgs e)
        {
           god.Text = "";
        }

        private void god_Leave(object sender, EventArgs e)
        {
            if (god.Text == "")
            god.Text = "2019";
        }

        private void maskedTextBox2_Enter(object sender, EventArgs e)
        {
            maskedTextBox2.Text = "";
        }

        private void maskedTextBox2_Leave(object sender, EventArgs e)
        {
            if (maskedTextBox2.Text == "")
            maskedTextBox2.Text = "123";
        }

        private void button4_Click(object sender, EventArgs e)
        {
           info open = new info();
            open.Show();
        }

        private void Sponsor_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        }
}
    

