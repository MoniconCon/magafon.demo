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
           
            if (textBox1.Text == "" && textBox2.Text == "") MessageBox.Show("Пустые поля");
             else{
             string conn = "Data Source=127.0.0.1;Initial Catalog=g464_Golubtsov;User ID=student;Password=student";
             string str = "select [Email],[Password],[RoleId] FROM [User] WHERE [Email]='"+textBox1.Text+"' AND [Password]='"+textBox2.Text+"'";
             SqlConnection con = new SqlConnection(conn);
             con.Open();
             SqlCommand cmd = new SqlCommand(str, con);
             SqlDataReader rdr = cmd.ExecuteReader();
             if (rdr.Read() == true)
             {
                 login = rdr.GetString(0);
                 pass = rdr.GetString(1);
                 role = rdr.GetString(2);

                 switch (role)
                 {
                     case "A":
                         menuadmin open = new menuadmin();
                         open.Show();
                         this.Close();
                         break;
                     case "C":
                         menukoor open2 = new menukoor();
                         open2.Show();
                         this.Close();
                         break;
                     case "R":
                         menurun open3 = new menurun();
                         open3.Show();
                         this.Close();
                         break;
                 }
                // MessageBox.Show("Вы успешно вышли в систему как "+role);
             }
             else MessageBox.Show("Неверный логин или пароль"); 
          
             con.Close();
             }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mains open = new Mains();
            open.Show();
            this.Close();
        }
    }
}
