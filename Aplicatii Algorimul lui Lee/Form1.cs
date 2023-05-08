using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Aplicatii_Algorimul_lui_Lee
{
    public partial class Form1 : Form
    {
        public string User, Pass;
        public Form1()
        {
            InitializeComponent();
        }
        public int eAdmin = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            System.Threading.Thread thrd = new System.Threading.Thread(new System.Threading.ThreadStart(LoadBackgroundImage));
            thrd.Start();
     
        }
        private void LoadBackgroundImage()
        {
            Image img = Image.FromFile("ack.jpg");
            this.BackgroundImage = img;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            this.Hide();
            f2.ShowDialog();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\Register.mdf;Integrated Security=True;Connect Timeout=30");
        private void button1_Click(object sender, EventArgs e)
        {
            string query = "select count(*) from RegisterTbl where username='" + user_name.Text + "' and " + "password= '" + password.Text + "'";
            con.Open();
            SqlCommand command = new SqlCommand(query, con);
            int v = (int)command.ExecuteScalar();

            if (v != 0)
            {   
                Form3 f3 = new Form3();
                eAdmin = 0;

                if (user_name.Text == "admin" && password.Text == "admin")
                    eAdmin = 1;

                f3.eAdmin = eAdmin;
                MessageBox.Show("Succesfully connected.");
                
                User = user_name.Text;
                Pass = password.Text;
                f3.User = User;
                f3.Pass = Pass;
                this.Hide();
                f3.ShowDialog();
                this.Hide();
            }
            else MessageBox.Show("Account does not exist.");
            con.Close();
        }

        private void user_name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
