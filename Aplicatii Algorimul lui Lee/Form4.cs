using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicatii_Algorimul_lui_Lee
{
    public partial class Form4 : Form
    {
        public string User, Pass;
        public Form4()
        {
            InitializeComponent();
            button2.Hide();
        }
        public int eAdmin = 0;
        private void Form4_Load(object sender, EventArgs e)
        {
            System.Threading.Thread thrd = new System.Threading.Thread(new System.Threading.ThreadStart(LoadBackgroundImage));
            thrd.Start();
        }
        private void LoadBackgroundImage()
        {
            Image img = Image.FromFile("ack.jpg");
            this.BackgroundImage = img;
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown1.Maximum = numericUpDown3.Value;
            numericUpDown5.Maximum = numericUpDown3.Value;
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown2.Maximum = numericUpDown4.Value;
            numericUpDown6.Maximum = numericUpDown4.Value;
        }
        int n, m;
        int[,] A;

        Panel[,] P;//matricea de imagini
        Label[,] Lab;
        private void button1_Click(object sender, EventArgs e)
        {
            n = (int)numericUpDown3.Value;
            m = (int)numericUpDown4.Value;
            panel1.BackColor = Color.Cyan;
            creare();
            button2.Show();
        }
        
        public void creare()
        {

            panel1.Width = 635;
            panel1.Height = 489;
            int L = panel1.Width;//latimea panoului
            int H = panel1.Height;//inaltimea panoului       
            panel1.Controls.Clear();
            //creez matricea de imagini
            P = new Panel[n + 2, m + 2];
            //calculez latura imagii a.i. sa incapa
                int w = Math.Min(L / m, H / n) - 3;

            for (int i = 1; i <= n; i++)
                for (int j = 1; j <= m; j++)
                {
                    P[i, j] = new Panel();
                    
                    //setez latura
                    P[i, j].Width = w;
                    P[i, j].Height = w;
                    //setez pozitia
                    P[i, j].Top = (w + 2) * (i - 1);
                    P[i, j].Left = (w + 2) * (j - 1);
                   
                    //culoarea
                    if (i == (int)numericUpDown1.Value && j == (int)numericUpDown2.Value) P[i, j].BackColor = Color.Green;
                    else if (i == (int)numericUpDown5.Value && j == (int)numericUpDown6.Value) 
                        P[i, j].BackColor = Color.RoyalBlue;
                    else
                        P[i, j].BackColor = Color.Black;
                    //plasez in panou
                    panel1.Controls.Add(P[i, j]);
                }
            panel1.Width = (w + 2)* m;
            panel1.Height = (w + 2) * n;
        }
        public struct coordonate
        {
            public int x, y;
        }

        int[] di = { 0, 0, 1, -1 };
        int[] dj = { 1, -1, 0, 0 };

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Pass = Pass;
            f3.User = User;
            f3.eAdmin = eAdmin;
            this.Hide();
            f3.ShowDialog();
        }

        bool inside(int i, int j)
        {
            return i >= 1 && j >= 1 && i <= n && j <= m;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int istart = (int)numericUpDown1.Value;
            int jstart = (int)numericUpDown2.Value;
            Lee(istart, jstart);
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        void Lee(int i, int j)
        {
            int ok = 0;
            int L = panel1.Width;//latimea panoului
            int H = panel1.Height;//inaltimea panoului 
            //creez matricea de imagini
            Lab = new Label[n + 2, m + 2];
            //calculez latura imagii a.i. sa incapa
            int w = Math.Min(L / m, H / n) - 3;


            Queue<coordonate> Q = new Queue<coordonate>();
            coordonate c = new coordonate();
            c.x = i; c.y = j;
            Q.Enqueue(c);
            A = new int[n + 1, m + 2];
            A[i, j] = 1;


            Lab[i, j] = new Label();
            P[i, j].Controls.Add(Lab[i, j]);
            string t = "S";
            Lab[i, j].Text = t;

            Lab[i, j].ForeColor = Color.Cyan;

            int size = 20;
            Lab[i, j].Top = w / 3;
            Lab[i, j].Left = w / 3;
            if (w < 70)
            {
                Lab[i, j].Top = 0;
                Lab[i, j].Left = 0;
                size = 14;
            }
            if (w < 30)
            {
                size = 10;
            }
            Lab[i, j].Font = new Font("Arial", size, FontStyle.Bold);
            Lab[i, j].Refresh();

            while (Q.Count > 0)
            {
                c = Q.Peek();
                i = c.x;
                j = c.y;
                Q.Dequeue();

                for(int d = 0; d < 4;  d++)
                {
                    int inou = c.x + di[d];
                    int jnou = c.y + dj[d];

                    if(inside(inou,jnou) && A[inou,jnou] == 0)
                    {
                        A[inou, jnou] = A[i, j] + 1;
                        coordonate cc = new coordonate();
                        cc.x = inou; cc.y = jnou;
                        Lab[inou, jnou] = new Label();

                        Q.Enqueue(cc);

                        P[inou, jnou].Controls.Add(Lab[inou, jnou]);
                        t = "" + A[i, j]; ;
                        Lab[inou, jnou].Text = t;

                        Lab[inou, jnou].ForeColor = Color.Cyan;

                        size = 20;             
                        Lab[inou, jnou].Top = w /3 ;
                        Lab[inou, jnou].Left = w / 3 ;
                        if(w < 70)
                        {
                            Lab[inou, jnou].Top = 0;
                            Lab[inou, jnou].Left = 0;
                            size = 14;
                        }
                        if(w < 30)
                        {
                            size = 10;
                        }
                        Lab[inou, jnou].Font = new Font("Arial", size, FontStyle.Bold);
                        Lab[inou, jnou].Refresh();
                        Thread.Sleep(300);

                        if(inou == numericUpDown5.Value && jnou == numericUpDown6.Value)
                        {
                            ok = 1;
                            break;
                        }
                    }
                }
                if(ok == 1)
                {
                    MessageBox.Show("You need to take " + Lab[(int)numericUpDown5.Value, (int)numericUpDown6.Value].Text + " steps to arrive at the destination.");
                    break;
                }
            }
        }
    }
}
