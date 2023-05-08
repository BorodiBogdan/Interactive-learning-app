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
    public partial class video : Form
    {
        public int eAdmin;
        public string Pass, User;
        public video()
        {
            InitializeComponent();
        }

        private void video_Load(object sender, EventArgs e)
        {
            System.Threading.Thread thrd = new System.Threading.Thread(new System.Threading.ThreadStart(LoadBackgroundImage));
            thrd.Start();
        }
        private void LoadBackgroundImage()
        {
            Image img = Image.FromFile("ack.jpg");
            this.BackgroundImage = img;
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

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.eAdmin = eAdmin;
            f3.User = User;
            f3.Pass = Pass;
            this.Hide();
            f3.ShowDialog();
        }
    }
}
