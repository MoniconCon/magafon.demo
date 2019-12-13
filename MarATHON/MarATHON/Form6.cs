using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarATHON
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan t = Program.start - DateTime.Now;
            label4.Text = t.Days.ToString() + " days, " +
                t.Hours.ToString() + " hours, " +
                t.Minutes.ToString() + " minutes";
        }
        //назад
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            dopform yyy = new dopform();
            yyy.Show();
        }

   
        //Интерактивая карта
        private void Label5_Click_1(object sender, EventArgs e)
        {
            this.Close();
            interaktmap2 yyy = new interaktmap2();
            yyy.Show();
        }
    }
}
