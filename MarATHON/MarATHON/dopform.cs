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
    public partial class dopform : Form
    {
        public dopform()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan t = Program.start - DateTime.Now;
            DATA6.Text = t.Days.ToString() + " days, " +
                t.Hours.ToString() + " hours, " +
                t.Minutes.ToString() + " minutes";
        }
        //Благотворительные оргонзации
        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            blagorg frm = new blagorg();
            frm.Show();
        }
        //marafon skils
        private void Marafon_Click(object sender, EventArgs e)
        {
            this.Close();
            Form6 frm = new Form6();
            frm.Show();
        }
        //Насколько длинный марафон
        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
            longmarathon frm = new longmarathon();
            frm.Show();
        }
        //Назад
        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
            Mains frm = new Mains();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //
        }
    }
    }

