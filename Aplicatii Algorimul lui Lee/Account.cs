using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicatii_Algorimul_lui_Lee
{
    public partial class Account : Form
    {
        public string Pass, User;
        public Account()
        {
            InitializeComponent();
        }
        public int eAdmin;
        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.eAdmin = eAdmin;
            f3.User = User;         
            f3.Pass = Pass;
            this.Hide();
            f3.ShowDialog();
        }

        private void Account_Load(object sender, EventArgs e)
        {
            System.Threading.Thread thrd = new System.Threading.Thread(new System.Threading.ThreadStart(LoadBackgroundImage));
            thrd.Start();
            panel1.BringToFront();
            label3.Text = User;

            string crypted = "";

            for (int i = 0; i < Pass.Length; ++i)
                crypted += "*";


            label4.Text = crypted;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.BringToFront();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel2.BringToFront();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != Pass)
            {
                MessageBox.Show("Incorect Password");
            }
            else
                if (textBox3.Text != textBox2.Text)
                {
                MessageBox.Show("Passwords not matching");
            }
            else 
                if (textBox3.Text == textBox2.Text && textBox1.Text == Pass)
                {
                    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\Register.mdf;Integrated Security=True;Connect Timeout=30");

                    con.Open();
                    SqlCommand command = new SqlCommand("UPDATE RegisterTbl set password = @password where username = @user", con);
               
                    command.Parameters.AddWithValue("@password", textBox2.Text);
                    command.Parameters.AddWithValue("@user", User);
                    command.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Password Succesfully changed");
                    Pass = textBox2.Text;

                    string crypted = "";

                    for (int i = 0; i < Pass.Length; ++i)
                        crypted += "*";


                    label4.Text = crypted;

                panel1.BringToFront();
                }
        }

        private void LoadBackgroundImage()
        {
            Image img = Image.FromFile("ack.jpg");
            this.BackgroundImage = img;
        }
    }
}
