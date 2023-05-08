using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicatii_Algorimul_lui_Lee
{
    public partial class Form5 : Form
    {
        public string Pass, User;
        public Form5()
        {
            InitializeComponent();
        }

        public int eAdmin = 0, id;
        List<Panel> listPanel = new List<Panel>();
        int index;
        Form1 f1 = new Form1();
        int []ID = new int[1001];
        private void Form5_Load(object sender, EventArgs e)
        {
            System.Threading.Thread thrd = new System.Threading.Thread(new System.Threading.ThreadStart(LoadBackgroundImage));
            thrd.Start();
         
            button5.Hide();
            button6.Hide();


            if (eAdmin == 0)
            {
                button4.Hide();
                button7.Hide();
            }
            else
            {
                button7.Show();
                button4.Show();
            }
            AddItemsToList();

            listPanel[0].BringToFront();
        }
        public void AddItemsToList()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\Register.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlCommand command = new SqlCommand("Select * from LessonsTbl", con);

            SqlDataReader oReader = command.ExecuteReader();


            if (oReader.HasRows) 
            {


                while (oReader.Read())
                {
                    id++;
                
                    string unu = oReader["Title"].ToString();
                    string doi = oReader["Text"].ToString();
                    int w = (int)oReader["Id"];
                    ID[id] = w;
                    Panel p1 = new Panel();
                    Label l1 = new Label();
                    RichTextBox t1 = new RichTextBox();

                    //TITLE BOX

                    Point pointl = new Point();
                    pointl.X = 299; pointl.Y = 40;
                    l1.Location = pointl;
                    l1.Width = 245;
                    l1.Height = 43;
                    l1.AutoSize = true;
                    l1.Font = new Font("Impact", 22);
                    l1.Text = unu;
                    l1.ForeColor = Color.Cyan;

                    //TEXT BOX
                  
                    p1.Controls.Add(t1);
                    Point pointt = new Point();
                    pointt.X = 57; pointt.Y = 114;
                    t1.Height = 354;
                    t1.Width = 774;
                    t1.Text = doi;
                    t1.Location = pointt;
                    t1.Font = new Font("Microsoft YaHei UI", 10, FontStyle.Bold);
                    t1.BackColor = Color.Black;
                    t1.BorderStyle = BorderStyle.None;                
                    t1.ForeColor = Color.White;

                    //ADD PANEL
                    Point point = new Point();
                    point.X = 113; point.Y = 57;
                    p1.Location = point;
                    p1.Controls.Add(l1);
                    p1.Height = 486;
                    p1.Width = 876;
                    p1.BackColor = Color.Black;
                    this.Controls.Add(p1);
                    listPanel.Add(p1);
                    Console.WriteLine(unu);
                   
                }


            }
            con.Close();
        }
        private void LoadBackgroundImage()
        {
            Image img = Image.FromFile("ack.jpg");
            this.BackgroundImage = img;
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            if(index < listPanel.Count - 1)
            {
                listPanel[++index].BringToFront();
            }
            if(eAdmin == 1)
            {
                button7.Show();
            }
            else
            {
                button7.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(index > 0)
            {
                listPanel[--index].BringToFront();
            }
            if (eAdmin == 1)
            {
                button7.Show();
            }
            else
            {
                button7.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Pass = Pass;
            f3.User = User;
            f3.eAdmin = eAdmin;
            this.Hide();
            f3.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button5.Show();
            button6.Show();
            button7.Hide();
            addArticle.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            index = 0;
            button5.Hide();
            button6.Hide();
            
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\Register.mdf;Integrated Security=True;Connect Timeout=30");

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Account f = new Account();
            f.eAdmin = eAdmin;
            f.Pass = Pass;
            f.User = User;
            this.Hide();
            f.ShowDialog();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (id > 0)
            {
                con.Open();
                SqlCommand command = new SqlCommand("Delete LessonsTbl where Id = @Id", con);
                command.Parameters.AddWithValue("@Id", ID[index + 1]);
                command.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Lesson succesfully deleted");
                listPanel.RemoveAt(index--);
                listPanel[index].BringToFront();
                id--;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand command = new SqlCommand("insert into LessonsTbl values(@Id, @Title, @Text)", con);
            command.Parameters.AddWithValue("@Id", ++id);
            command.Parameters.AddWithValue("@Title", LessonTitle.Text);
            command.Parameters.AddWithValue("@Text", LessonText.Text);
            command.ExecuteNonQuery();
            con.Close();
            listPanel.Clear();
            id = 0; index = 0;
            AddItemsToList();
            
            listPanel[listPanel.Count - 1].BringToFront();
            
            if (eAdmin == 1)
                button7.Show();

            index = listPanel.Count - 1;
            MessageBox.Show("Lesson was added!");
            LessonTitle.Text = "TITLE";
            LessonText.Text = "";
        }
    }
}
