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
    public partial class newrunner : Form
    {
        public newrunner()
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
            string login;
            string pass;
            string role;
           // xyoi
            //loginDEafs2018' AND [Пароль]='Wiw0VR
             string conn = "Data Source=127.0.0.1;Initial Catalog=g464_Golubtsov;User ID=student;Password=student";
             string str = "select [Email],[Password],[RoleId] FROM [User] WHERE [Email]='"+textBox1.Text+"' AND [Password]='"+textBox2.Text+"'";
             SqlConnection con = new SqlConnection(conn);
             con.Open();
             SqlCommand cmd = new SqlCommand(str, con);
             SqlDataReader rdr = cmd.ExecuteReader();
             while (rdr.Read() == true)
             {
                 login = rdr.GetString(0);
                 pass = rdr.GetString(1);
                 role = rdr.GetString(2);
                 if (login == textBox1.Text && pass == textBox2.Text )
                 {
                     MessageBox.Show("ПРИВЕТ АНДРЕЙ");
                     
                 }
                 else { MessageBox.Show("АЛЛО ТЫКТО УХАДИи"); };
             }
             con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mains open = new Mains();
            open.Show();
            this.Close();
        }
    }
}
