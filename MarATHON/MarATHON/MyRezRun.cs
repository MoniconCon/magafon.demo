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
    public partial class MyRezRun : Form
    {
        public MyRezRun()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
            menurun qqqw = new menurun();
            qqqw.Show();
          
        }

        private void MyRezRun_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "g464_GolubtsovDataSet14.Dlinniy". При необходимости она может быть перемещена или удалена.
            //this.dlinniyTableAdapter.Fill(this.g464_GolubtsovDataSet14.Dlinniy);
            DateTime GodRojd = DateTime.Today;


            string conn = "Data Source=DESKTOP-AKC6G8I;Initial Catalog=g464_Golubtsov;Integrated Security=True";
            // string str = "select [Email],[Password],[RoleId] FROM [User] WHERE [Email]='" + textBox1.Text + "' AND [Password]='" + textBox2.Text + "'";
            string str = "SELECT  [Gender],[DateOfBirth] FROM [g464_Golubtsov].[dbo].[Runner] WHERE [Email] = '" + PEREMEN.Login + "'";
            SqlConnection con = new SqlConnection(conn);
            con.Open();
            SqlCommand cmd = new SqlCommand(str, con);
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read() == true)
            {
                label3.Text = rdr.GetString(0);
                GodRojd = rdr.GetDateTime(1);
            }
            rdr.Close();
            DateTime now = DateTime.Today;
            try
            {
                int age = now.Year - GodRojd.Year;
                if (now < GodRojd.AddYears(age)) age--;
                label4.Text = Convert.ToString(age);
                if (age < 18) label6.Text = "до 18";
                else if (age >= 18 && age <= 29) label6.Text = "От 18 до 29";
                else if (age >= 30 && age <= 39) label6.Text = "От 30 до 39";
                else if (age >= 40 && age <= 55) label6.Text = "От 40 до 55";
                else if (age >= 56 && age <= 70) label6.Text = "От 56 до 70";
                else if (age > 70) label6.Text = "более 70";
            }
            catch
            {

            }


            int n = 1;
            string str3="SELECT Count(*) FROM dbo.RegistrationEvent INNER JOIN dbo.Registration ON dbo.RegistrationEvent.RegistrationId = dbo.Registration.RegistrationId INNER JOIN dbo.Runner ON dbo.Registration.RunnerId = dbo.Runner.RunnerId Where dbo.Runner.Email = 'larissa.delaney@gmail.com' Group By dbo.RegistrationEvent.RegistrationId";
            SqlCommand cmd3 = new SqlCommand(str3, con);
            SqlDataReader rdr3 = cmd3.ExecuteReader();
            while (rdr3.Read() == true)
            {
                n = rdr3.GetInt32(0);
            }
            rdr3.Close();




                
            int name;
            string disc;
            string img;
            int fall;
            string qq;
            
            //for (int i=0; i < n; i++)
            //{
                string str2 = "SELECT dbo.Marathon.YearHeld, dbo.Marathon.CityName, dbo.Event.EventName,STUFF(CONVERT(VARCHAR, DATEADD(SECOND, dbo.RegistrationEvent.RaceTime, 0), 8), 1, 2, dbo.RegistrationEvent.RaceTime / (60 * 60)) AS RaceTime,dbo.RegistrationEvent.BibNumber FROM dbo.Runner INNER JOIN dbo.Registration ON dbo.Runner.RunnerId = dbo.Registration.RunnerId INNER JOIN dbo.RegistrationEvent ON dbo.Registration.RegistrationId = dbo.RegistrationEvent.RegistrationId INNER JOIN dbo.Event INNER JOIN dbo.Marathon ON dbo.Event.MarathonId = dbo.Marathon.MarathonId ON dbo.RegistrationEvent.EventId = dbo.Event.EventId WHERE(dbo.Runner.Email = '"+PEREMEN.Login+"')";
                SqlCommand cmd2 = new SqlCommand(str2, con);
                SqlDataReader rdr2 = cmd2.ExecuteReader();
                while (rdr2.Read() == true)
                {
                    name = rdr2.GetInt16(0);
                    disc = rdr2.GetString(1);
                    img = rdr2.GetString(2);
                    try
                    {
                        qq = rdr2.GetString(3);
                    }
                    catch
                    {
                        qq = "Не добежал";
                    }
                    fall = rdr2.GetInt16(4);
                    

                    UserControl1 ctl = new UserControl1();
                    ctl.setup2(Convert.ToString(name), disc, img, Convert.ToString(qq), Convert.ToString(fall));
                    flowLayoutPanel1.Controls.Add(ctl);
                    
                }

                rdr2.Close();
           // }
            
            con.Close();
        }

        private void FillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.dlinniyTableAdapter.FillBy(this.g464_GolubtsovDataSet14.Dlinniy);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
