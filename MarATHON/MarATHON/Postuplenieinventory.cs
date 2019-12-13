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
    public partial class Postuplenieinventory : Form
    {
        public Postuplenieinventory()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Inventory open = new Inventory();
            open.Show();
        }

        private void Postuplenieinventory_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "g464_GolubtsovDataSet13.Инвентарь". При необходимости она может быть перемещена или удалена.
            //this.инвентарьTableAdapter.Fill(this.g464_GolubtsovDataSet13.Инвентарь);

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string conn = "Data Source=DESKTOP-AKC6G8I;Initial Catalog=g464_Golubtsov;Integrated Security=True";
            SqlConnection con = new SqlConnection(conn);
            con.Open();
            string str="UPDATE[Инвентарь] SET [Номер бегуна] = [Номер бегуна] + '"+textBox1.Text + "',[RFID браслет]=[RFID браслет]+ '" + textBox2.Text + "',[Бейсболка]=[Бейсболка]+ '" + textBox3.Text + "',[Бутылка воды]=[Бутылка воды]+ '" + textBox4.Text + "',[Футболка]=[Футболка]+ '" + textBox5.Text + "',[Сувенирный буклет]=[Сувенирный буклет]+ '" + textBox6.Text + "' WHERE([Инвентарь]= 'Ostatok')";
            SqlCommand cmd2 = new SqlCommand(str, con);
            cmd2.ExecuteNonQuery();
            con.Close();
            this.Close();
            Inventory open = new Inventory();
            open.Show();
        }
    }
}
