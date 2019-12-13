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
    

    public partial class newrunerr3 : Form
    {
        public newrunerr3()
        {

            InitializeComponent();
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }
        //регистрация
        public void button1_Click(object sender, EventArgs e)
        {
            int id=0;

            //string conn = "Data Source=127.0.0.1;Initial Catalog=g464_Golubtsov;User ID=student;Password=student";
            string conn = "Data Source=DESKTOP-AKC6G8I;Initial Catalog=g464_Golubtsov;Integrated Security=True";
            SqlConnection con = new SqlConnection(conn);

            con.Open();
            string str = "INSERT INTO [user] ([Email],[Password],[FirstName],[LastName],[RoleId], [Pictures]) VALUES ('" + PEREMEN.textBox1 + "','" + PEREMEN.textBox7+ "','" + PEREMEN.textBox6 + "','" + PEREMEN.textBox5 + "','R' , '"+ PEREMEN.Pictures +"')";
            string str2 = "INSERT INTO [Runner] ([Email],[Gender],[DateOfBirth],[CountryCode]) VALUES ('" + PEREMEN.textBox1 + "','" + PEREMEN.comboBox1 + "','" + PEREMEN.data + "','" + PEREMEN.comboBox2 + "')";
            SqlCommand cmd2 = new SqlCommand(str, con);
            cmd2.ExecuteNonQuery();
            SqlCommand cmd3 = new SqlCommand(str2, con);
            cmd3.ExecuteNonQuery();

            string str4 = "SELECT [RunnerID] FROM [dbo].[Runner] WHERE [Email]='" + PEREMEN.textBox1 + "'";
            SqlCommand cmd = new SqlCommand(str4, con);
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read() == true)
            {
                id = rdr.GetInt32(0);
            }
            rdr.Close();

            string str3 = "INSERT INTO [Registration] ([RunnerId],[RegistrationDateTime],[RaceKitOptionId],[RegistrationStatusId],[Cost],[CharityId],[SponsorshipTarget]) VALUES ('" + id + "','" + DateTime.Today + "','" + PEREMEN.Kit1 + "','" + "1" + "','" + label9.Text + "','" + comboBox2.SelectedValue + "','" + textBox1.Text + "')";
            SqlCommand cmd4 = new SqlCommand(str3, con);
            cmd4.ExecuteNonQuery();


            SqlCommand cmd201= new SqlCommand(PEREMEN.KitA,con);
            cmd201.ExecuteNonQuery();

            SqlCommand cmd202 = new SqlCommand(PEREMEN.KitAA, con);
            cmd202.ExecuteNonQuery();

            con.Close();
            PEREMEN.Login = PEREMEN.textBox1;
            this.Close();
            zavershenieregi open = new zavershenieregi();
            open.Show();

        }


        private void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {
          
            if (checkBox3.Checked == true)
            {
                label9.Text = Convert.ToString(Convert.ToInt32(label9.Text) + 5);
            }
            else
                label9.Text = Convert.ToString(Convert.ToInt32(label9.Text) - 5);

        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
          
            if (radioButton3.Checked == true)
            {
                label9.Text = Convert.ToString(Convert.ToInt32(label9.Text) + 45);
                PEREMEN.Kit1 = "C";
                PEREMEN.KitA = "UPDATE [Инвентарь]  SET [Номер бегуна]=[Номер бегуна]+1,[RFID браслет]=[RFID браслет]+1,[Бейсболка]=[Бейсболка]+1,[Бутылка воды]=[Бутылка воды]+1,[Футболка]=[Футболка]+1,[Сувенирный буклет]=[Сувенирный буклет]+1 WHERE([Инвентарь]='Neobhodimo')";
                PEREMEN.KitAA ="UPDATE[Инвентарь]  SET[Номер бегуна] =[Номер бегуна] - 1,[RFID браслет]=[RFID браслет]-1,[Бейсболка]=[Бейсболка]-1,[Бутылка воды]=[Бутылка воды]-1,[Футболка]=[Футболка]-1,[Сувенирный буклет]=[Сувенирный буклет]-1 WHERE([Инвентарь]= 'Ostatok')";
                PEREMEN.SostavC = " UPDATE[Sostav] SET  C = C + 1 WHERE[Состав] = 'Номер бегуна'";
                PEREMEN.SostavCC = "UPDATE[Sostav] SET  C = C + 1 WHERE[Состав] = 'Браслет'";
                PEREMEN.SostavCCC = "UPDATE[Sostav] SET C = C + 1 WHERE[Состав] = 'Бейсболка'";
                PEREMEN.SostavCCCC = "UPDATE[Sostav] SET C = C + 1 WHERE[Состав] = 'Вода'";
                PEREMEN.SostavССССС = "UPDATE[Sostav] SET C = C + 1 WHERE[Состав] = 'Футболка'";
                PEREMEN.SostavСССССС = "UPDATE[Sostav] SET C = C + 1 WHERE[Состав] = 'Буклет'";


            }
            else
                label9.Text = Convert.ToString(Convert.ToInt32(label9.Text) - 45);
        }

       

        private void Button5_Click(object sender, EventArgs e)
        {
            this.Close();
            info open = new info();
            open.Show();
        }

        public void Newrunerr3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "g464_GolubtsovDataSet21.Charity". При необходимости она может быть перемещена или удалена.
            this.charityTableAdapter2.Fill(this.g464_GolubtsovDataSet21.Charity);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "g464_GolubtsovDataSet9.Charity". При необходимости она может быть перемещена или удалена.
          //  this.charityTableAdapter1.Fill(this.g464_GolubtsovDataSet9.Charity);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "g464_GolubtsovDataSet8.Charity". При необходимости она может быть перемещена или удалена.
           // this.charityTableAdapter.Fill(this.g464_GolubtsovDataSet8.Charity);

            // TODO: данная строка кода позволяет загрузить данные в таблицу "g464_GolubtsovDataSet7.Sponsorship". При необходимости она может быть перемещена или удалена.
           // this.sponsorshipTableAdapter.Fill(this.g464_GolubtsovDataSet7.Sponsorship);

        }

 

       // private void TextBox1_TextChanged(object sender, EventArgs e)
       // {
       //
      //      label9.Text = Convert.ToString(Convert.ToInt32(label9.Text) + Convert.ToInt32(textBox1.Text));
      //  }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                label9.Text = Convert.ToString(Convert.ToInt32(label9.Text) + 75);
                
            }
            else
                label9.Text = Convert.ToString(Convert.ToInt32(label9.Text) - 75);
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                label9.Text = Convert.ToString(Convert.ToInt32(label9.Text) + 145);
            }
            else
            {
                label9.Text = Convert.ToString(Convert.ToInt32(label9.Text) - 145);

            }
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

            if (radioButton1.Checked == true)
            {
                label9.Text = Convert.ToString(Convert.ToInt32(label9.Text) + 0);
                PEREMEN.Kit1 = "A";
                PEREMEN.KitA = "UPDATE [Инвентарь]  SET [Номер бегуна]=[Номер бегуна]+1,[RFID браслет]=[RFID браслет]+1 WHERE([Инвентарь]='Neobhodimo')";
                PEREMEN.KitAA = "UPDATE[Инвентарь]  SET [Номер бегуна] =[Номер бегуна] - 1,[RFID браслет]=[RFID браслет]-1 WHERE([Инвентарь]= 'Ostatok')";
                PEREMEN.SostavA = "UPDATE [Sostav] SET A=A+1 WHERE  [Состав]='Браслет'";
                PEREMEN.SostavAA = "UPDATE [Sostav] SET A=A+1 WHERE  [Состав]='Номер бегуна'";


            }
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                label9.Text = Convert.ToString(Convert.ToInt32(label9.Text) + 20);
                PEREMEN.Kit1 = "B";
                PEREMEN.KitA = "UPDATE [Инвентарь]  SET [Номер бегуна]=[Номер бегуна]+1,[RFID браслет]=[RFID браслет]+1,[Бейсболка]=[Бейсболка]+1,[Бутылка воды]=[Бутылка воды]+1 WHERE([Инвентарь]='Neobhodimo')";
                PEREMEN.KitAA = "UPDATE[Инвентарь]  SET [Номер бегуна] =[Номер бегуна] - 1,[RFID браслет]=[RFID браслет]-1,[Бейсболка]=[Бейсболка]-1,[Бутылка воды]=[Бутылка воды]-1 WHERE([Инвентарь]= 'Ostatok')";
                PEREMEN.SostavB = " UPDATE[Sostav] SET  B = B + 1 WHERE[Состав] = 'Номер бегуна'";
                PEREMEN.SostavBB = "UPDATE[Sostav] SET  B = B + 1 WHERE[Состав] = 'Браслет'";
                PEREMEN.SostavBBB = "UPDATE[Sostav] SET B = B + 1 WHERE[Состав] = 'Бейсболка'";
                PEREMEN.SostavBBBB = "UPDATE[Sostav] SET B = B + 1 WHERE[Состав] = 'Вода'";
            }
            else
                label9.Text = Convert.ToString(Convert.ToInt32(label9.Text) - 20);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            newrunner1 qwe = new newrunner1();
            qwe.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Mains qwe = new Mains();
            qwe.Show();
        }
    }
}
