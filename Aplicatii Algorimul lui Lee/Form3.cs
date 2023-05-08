using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicatii_Algorimul_lui_Lee
{
    public partial class Form3 : Form
    {
        public string Pass, User;
        public Form3()
        {
            InitializeComponent();
        }
        public int eAdmin = 0;
        private void Form3_Load(object sender, EventArgs e)
        {
            System.Threading.Thread thrd = new System.Threading.Thread(new System.Threading.ThreadStart(LoadBackgroundImage));
            thrd.Start();
        }
        private void LoadBackgroundImage()
        {
            Image img = Image.FromFile("ack.jpg");
            this.BackgroundImage = img;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Pass = Pass;
            f4.User = User;
            f4.eAdmin = eAdmin;
            this.Hide();
            f4.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Pass = Pass;
            f5.User = User;
            f5.eAdmin = eAdmin;
            this.Hide();
            f5.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Pbinfo f5 = new Pbinfo();
            f5.Pass = Pass;
            f5.User = User;
            f5.eAdmin = eAdmin;
            this.Hide();
            f5.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            video f5 = new video();
            f5.Pass = Pass;
            f5.User = User;
            f5.eAdmin = eAdmin;
            this.Hide();
            f5.ShowDialog();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Account f = new Account();
            f.eAdmin = eAdmin;
            f.Pass = Pass;
            f.User = User;
            this.Hide();
            f.ShowDialog();
            
        }
    }
}
