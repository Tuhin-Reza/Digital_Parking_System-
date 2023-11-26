using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;

namespace FINAL_PROJECT._1
{
    
    public partial class Form7 : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs1"].ConnectionString;
       
        public Form7()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox5.Text != "" && numericUpDown1.Value !=0)
            {
                MessageBox.Show("Remember Your Passwoard");
                if (radioButton1.Checked==true || radioButton2.Checked==true)
                {
                    SqlConnection con = new SqlConnection(cs);
                    string query = "INSERT INTO CUSTOMER_INFO VALUES (@NAME,@AGE,@GENDER,@ADDRESS,@CONTACT_NO,@PASSWOARD,@PICTURE)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    //cmd.Parameters.AddWithValue("@ID", textBox1.Text);
                    cmd.Parameters.AddWithValue("@NAME", textBox1.Text);
                    cmd.Parameters.AddWithValue("@AGE", numericUpDown1.Value);
                    if (radioButton1.Checked == true)
                    {
                        cmd.Parameters.AddWithValue("@GENDER", radioButton1.Text);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@GENDER", radioButton2.Text);
                    }
                    cmd.Parameters.AddWithValue("@ADDRESS", textBox2.Text);
                    cmd.Parameters.AddWithValue("@CONTACT_NO", textBox3.Text);
                    cmd.Parameters.AddWithValue("@PASSWOARD", textBox5.Text);
                    cmd.Parameters.AddWithValue("@PICTURE", SavePhoto());

                    con.Open();
                    int a = cmd.ExecuteNonQuery();//0 1
                    if (a > 0)
                    {
                        this.Hide();
                        Form1 f1 = new Form1();
                        f1.ShowDialog();
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("Account Not Created ");
                    }

                }
                else
                {
                    MessageBox.Show("Select Your Gender");
                }
            }
            else
            {
                MessageBox.Show("Fill All Form ");
            }
        }
        private Image GetPhoto(byte[] photo)
        {
            MemoryStream ms = new MemoryStream(photo);
            return Image.FromStream(ms);
        }

        private byte[] SavePhoto()
        {
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            return ms.GetBuffer();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select Image";
            ;
            ofd.Filter = "Image File (All files) *.* | *.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(ofd.FileName);
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
            this.Close();
        }
    }
}
