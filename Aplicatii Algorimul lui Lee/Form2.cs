using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace Aplicatii_Algorimul_lui_Lee
{
    public partial class Form2 : Form
    {        
        public Form2()
        {
            InitializeComponent();
        }
        public int eAdmin = 0;
        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Users' table. You can move, or remove it, as needed.

            System.Threading.Thread thrd = new System.Threading.Thread(new System.Threading.ThreadStart(LoadBackgroundImage));
            thrd.Start();
        }
        private void LoadBackgroundImage()
        {
            Image img = Image.FromFile("ack.jpg");
            this.BackgroundImage = img;
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\Register.mdf;Integrated Security=True;Connect Timeout=30");
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if(pass_word.Text != confirm_pass_word.Text)
                {
                    MessageBox.Show("Passwords not matching.");
                }
                else
                    if (user_name.Text == "" || pass_word.Text == "" || confirm_pass_word.Text == "")
                    {
                    MessageBox.Show("Fill in the blanks!");
                }
                else                
                    if(check_username(user_name.Text) == 1){
                        con.Open();
                        SqlCommand command = new SqlCommand("insert into RegisterTbl values(@username, @password)", con);
                        command.Parameters.AddWithValue("@username", user_name.Text);
                        command.Parameters.AddWithValue("@password", pass_word.Text);
                        command.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Registration was succesfull");
                        pass_word.Text = "";
                        user_name.Text = "";
                    confirm_pass_word.Text = "";
                   }
                else
                    MessageBox.Show("Username already used!");
            }
            catch
            {
                MessageBox.Show("Try Again");
            }
        }

        public int check_username(string user)
        {
            con.Open();
            string query = "select count(*) from RegisterTbl where username='" + user + "'";
            SqlCommand command = new SqlCommand(query, con);
            int v = (int)command.ExecuteScalar();
            con.Close();

            if (v == 0)
                return 1;
            return 0;
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.ShowDialog();
        }
    }
}
