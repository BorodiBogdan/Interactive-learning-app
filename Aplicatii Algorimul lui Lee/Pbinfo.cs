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
    public partial class Pbinfo : Form
    {
        public string Pass, User;
        public int eAdmin;
        public Pbinfo()
        {
            InitializeComponent();
        }
        List<Panel> listPanel = new List<Panel>();
        int index = 0;
        private void Pbinfo_Load(object sender, EventArgs e)
        {
            System.Threading.Thread thrd = new System.Threading.Thread(new System.Threading.ThreadStart(LoadBackgroundImage));
            thrd.Start();
           
            listPanel.Add(addArticle);
            listPanel.Add(panel1);
            listPanel.Add(panel2);
            addArticle.BringToFront();
            LessonText.BringToFront();
            richTextBox2.BringToFront();
            richTextBox4.BringToFront();
        }
        private void LoadBackgroundImage()
        {
            Image img = Image.FromFile("ack.jpg");
            this.BackgroundImage = img;
        }

        private void addArticle_Paint(object sender, PaintEventArgs e)
        {

        }
        int check = 1, check1 = 1, check2 = 1;
        private void button2_Click(object sender, EventArgs e)
        {
            if (check == 1)
            {
                Solution.BringToFront();
                check = 0;
                button2.Text = "SHOW PROBLEM";
            }
            else
            {
                LessonText.BringToFront();
                button2.Text = "SHOW SOLUTION";
                check = 1;
            }
         
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (index > 0)
            {
                listPanel[--index].BringToFront();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(index < listPanel.Count - 1)
            {
                listPanel[++index].BringToFront();
            }
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

        private void button6_Click(object sender, EventArgs e)
        {
            if (check2 == 1)
            {
                richTextBox3.BringToFront();
                check2 = 0;
                button6.Text = "SHOW PROBLEM";
            }
            else
            {
                richTextBox4.BringToFront();
                button6.Text = "SHOW SOLUTION";
                check2 = 1;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (check1 == 1)
            {
                richTextBox2.BringToFront();
                check1 = 0;
                button5.Text = "SHOW SOLUTION";
            }
            else
            {
                button5.Text = "SHOW PROBLEM";
                richTextBox1.BringToFront();
                check1 = 1;
            }
        }

        private void button1_Click(object sender, EventArgs e) { 
            Form3 f3 = new Form3();
            f3.Pass = Pass;
            f3.User = User;
            f3.eAdmin = eAdmin;
            this.Hide();
            f3.ShowDialog();
        }
}
}
