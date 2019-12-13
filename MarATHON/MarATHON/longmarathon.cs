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
    public partial class longmarathon : Form
    {
        public longmarathon()
        {
            InitializeComponent();
        }

        private void PictureBox11_Click(object sender, EventArgs e)
        {
                pictureBox3.Image = pictureBox11.Image;
            label11.Text="Этот самолет пролетает со скоростью 100 км ";
        }

        private void PictureBox10_Click(object sender, EventArgs e)
        {
            pictureBox3.Image = pictureBox10.Image;
            label11.Text = "Эти тапки пролетают со скоростью 25км ";
        }

        private void PictureBox9_Click(object sender, EventArgs e)
        {
            pictureBox3.Image = pictureBox9.Image;
            label11.Text = "Это поле пролетает со скоростью 36км ";
        }

        private void PictureBox8_Click(object sender, EventArgs e)
        {
            pictureBox3.Image = pictureBox8.Image;
            label11.Text = "Этот Рональдиньо пролетает со скоростью 45км ";
        }

        private void PictureBox7_Click(object sender, EventArgs e)
        {
            pictureBox3.Image = pictureBox7.Image;
            label11.Text = "Этот автобус пролетает со скоростью 56км ";
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox3.Image = pictureBox1.Image;
            label11.Text = "Эта формула пролетает со скоростью 190км ";
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox3.Image = pictureBox2.Image;
            label11.Text = "Этот червяк пролетает со скоростью 1км ";
        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox3.Image = pictureBox4.Image;
            label11.Text = "Этот Ленивец пролетает со скоростью 2км ";
        }

        private void PictureBox5_Click(object sender, EventArgs e)
        {
            pictureBox3.Image = pictureBox5.Image;
            label11.Text = "Эта капибара пролетает со скоростью 22км ";
        }

        private void PictureBox6_Click(object sender, EventArgs e)
        {
            pictureBox3.Image = pictureBox6.Image;
            label11.Text = "Этот ягуар пролетает со скоростью 87км ";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
            dopform frm = new dopform();
            frm.Show();
        }
    }
}
 
    
    

