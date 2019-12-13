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
    public partial class Volonters : Form
    {
        public Volonters()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mains yyy = new Mains();
            yyy.Show();
        }

        private void Volonters_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "g464_GolubtsovDataSet26.Volunteer". При необходимости она может быть перемещена или удалена.
            this.volunteerTableAdapter1.Fill(this.g464_GolubtsovDataSet26.Volunteer);


            string con_str = "Data Source=DESKTOP-AKC6G8I;Initial Catalog=g464_Golubtsov;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(con_str))
            {
                SqlCommand command = new SqlCommand("select count(VolunteerId) as count from Volunteer", connection);
                connection.Open();
                label6.Text = command.ExecuteScalar().ToString();
                connection.Close();
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            zagruzkavolonters yyy = new zagruzkavolonters();
            yyy.Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            dataGridView1.Update();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns[comboBox1.Text], ListSortDirection.Ascending);
        }
    }
}
