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
    public partial class Inventory : Form
    {
        public Inventory()
        {
            InitializeComponent();
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "g464_GolubtsovDataSet25.NEOLBHODIMO". При необходимости она может быть перемещена или удалена.
            this.nEOLBHODIMOTableAdapter1.Fill(this.g464_GolubtsovDataSet25.NEOLBHODIMO);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "g464_GolubtsovDataSet24.sum". При необходимости она может быть перемещена или удалена.
            this.sumTableAdapter1.Fill(this.g464_GolubtsovDataSet24.sum);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "g464_GolubtsovDataSet23.NOMER_A". При необходимости она может быть перемещена или удалена.
            this.nOMER_ATableAdapter1.Fill(this.g464_GolubtsovDataSet23.NOMER_A);


            string A;

            string conn = "Data Source=DESKTOP-AKC6G8I;Initial Catalog=g464_Golubtsov;Integrated Security=True";
            SqlConnection con = new SqlConnection(conn);

            con.Open();
            string str = "SELECT COUNT(*) AS Необходимо FROM dbo.Registration";
            
            SqlCommand cmd2 = new SqlCommand(str, con);
            SqlDataReader rdr = cmd2.ExecuteReader();
            while (rdr.Read() == true)
            {
                A = Convert.ToString(rdr.GetInt32(0));
               label52.Text = A;
            }
            rdr.Close();
            
            con.Close();


        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Postuplenieinventory open = new Postuplenieinventory();
            open.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Mains open = new Mains();
            open.Show();
        }
    }
}
