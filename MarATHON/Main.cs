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
    public partial class Mains : Form
    {
        public Mains()
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

        private void button1_Click(object sender, EventArgs e)
        {
              this.Hide();
              Sponsor frm = new Sponsor();
              frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            run yyy = new run();
            yyy.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            dopform yyy = new dopform();
            yyy.Show();  
        }
        }
    }

