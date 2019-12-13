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
    public partial class formpay : Form
    {
        public formpay()
        {
            InitializeComponent();
        }

        private void formpay_Load(object sender, EventArgs e)
        {
            label3.Text = Sponsor.urobor.pay2 + " $";
            label4.Text = Sponsor.urobor.pay1;
            label5.Text = Sponsor.urobor.pay3;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mains open = new Mains();
            open.Show();
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan t = Program.start - DateTime.Now;
            DATA6.Text = t.Days.ToString() + " days, " +
            t.Hours.ToString() + " hours, " +
            t.Minutes.ToString() + " minutes";
        }

        
    }
}
