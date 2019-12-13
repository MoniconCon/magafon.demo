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
    public partial class menurun : Form
    {
        public menurun()
        {
            InitializeComponent();
        }
        //назад
        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
            redaktbegun yyy22 = new redaktbegun();
            yyy22.Show();
        }
        //Мои результаты
        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
            MyRezRun yyy2111 = new MyRezRun();
            yyy2111.Show();
        }
        //редактирование
        private void Button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mains frm = new Mains();
            frm.Show();
        }
    }
}
