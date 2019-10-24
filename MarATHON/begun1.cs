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
    public partial class run : Form
    {
        public run()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            newrunner yyy1 = new newrunner();
            yyy1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            newrunner1 yyy12 = new newrunner1();
            yyy12.Show();
        }
    }
}
