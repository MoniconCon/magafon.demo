using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarATHON
{
    public partial class UserCont : UserControl
    {
        public UserCont()
        {
            InitializeComponent();
        }
                public void setup(Image x, string t1, string t2)
        {
            pictureBox1.Image = x;
            label1.Text = t1;
            label2.Text = t2;
        }
    }
}
