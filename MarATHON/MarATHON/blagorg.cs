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
    public partial class blagorg : Form
    {
        public blagorg()
        {
            InitializeComponent();
        }

        private void blagorg_Load(object sender, EventArgs e)
        {
            string conn = "Data Source=DESKTOP-AKC6G8I;Initial Catalog=g464_Golubtsov;Integrated Security=True";
  
                    int n = 14;
                    string name;
                    string disc;
                    string img;
                    string fall;
            for (int i = 0; i < n; i++)
            {
                string str = "SELECT  [CharityName],[CharityDescription],[CharityLogo]FROM [g464_Golubtsov].[dbo].[Charity] WHERE [CharityId] = " + (i+1);
                SqlConnection con = new SqlConnection(conn);
                con.Open();
                SqlCommand cmd = new SqlCommand(str, con);
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read() == true)
                {
                     name = rdr.GetString(0);
                     disc = rdr.GetString(1);
                     img = rdr.GetString(2);

                     fall = "C:/Users/Лулу/Downloads/log hor/СДАЮююююююююююююююююююю/MarATHON/MarATHON/IMG/" + img;
                     Image x = Image.FromFile(fall);
                     UserCont ctl = new UserCont();
                     ctl.setup(x, name, disc);
                     flowLayoutPanel1.Controls.Add(ctl);
                }
                con.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            dopform wqwe = new dopform();
            wqwe.Show();
        }
    }
}
