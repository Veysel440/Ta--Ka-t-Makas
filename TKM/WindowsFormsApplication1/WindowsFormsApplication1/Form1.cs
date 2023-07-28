using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rnd = new Random();
        int secim = 0;
        int rno = 0;
        int Oskor=0, Bskor=0;
        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Size = new Size(60, 60);
            pictureBox2.Size = new Size(60, 60);
            pictureBox3.Size = new Size(60, 60);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            (sender as PictureBox).Size = new Size(150,150);
            secim = Convert.ToInt16((sender as PictureBox).Tag);
            kapat();
            
            rno = rnd.Next(1,4);

            if (rno == 1) { pictureBox4.ImageLocation = "tas.jpg"; }
            if (rno == 2) { pictureBox4.ImageLocation = "kagit.jpg"; }
            if (rno == 3) { pictureBox4.ImageLocation = "makas.jpg"; }

            kontrol();
            textBox1.Text = Oskor.ToString();
            textBox2.Text = Bskor.ToString();
            ac();
        }

        public void kontrol()
        {
            if (secim == rno) { MessageBox.Show("Berabere"); }
            else if (secim == 1)
            {
                if (rno == 2)
                {
                    Bskor++;
                }
                else
                {
                    Oskor++;
                }
            }
            else if (secim == 2)
            {
                if (rno == 1)
                {
                    Oskor++;
                }
                else
                {
                    Bskor++;
                }
            }
            else if (secim == 3)
            {
                if (rno == 1)
                {
                    Bskor++;
                }
                else
                {
                    Oskor++;
                }
            }
        }
        public void kapat()
        {
            pictureBox1.Enabled = false;
            pictureBox2.Enabled = false;
            pictureBox3.Enabled = false;
        }

        public void ac()
        {
            pictureBox1.Enabled = true;
            pictureBox2.Enabled = true;
            pictureBox3.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "tas.jpg";
            pictureBox2.ImageLocation = "kagit.jpg";
            pictureBox3.ImageLocation = "makas.jpg";
            pictureBox4.ImageLocation = "soru.jpg";

            textBox1.Text = "0";
            textBox2.Text = "0";
        }
    }
}
