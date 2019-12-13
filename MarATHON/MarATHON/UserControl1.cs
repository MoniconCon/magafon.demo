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
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        public void setup2( string t1, string t2, string t3, string t4, string t5)
        {
            label1.Text = t1;
            label2.Text = t2;
            label3.Text = t3;
            label4.Text = t4;
            label5.Text = t5;
        }
    }
}
