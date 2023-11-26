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
    public partial class Form3 : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs1"].ConnectionString;
        public Form3()
        {
            InitializeComponent();
            string name = Form1.name;
            this.Text = name;
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            BindGridView();
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
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
            this.Close();
        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select Image";
            ofd.Filter = "Image File (All files) *.* | *.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(ofd.FileName);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "UPDATE ADMIN_INFOR SET NAME=@NAME,AGE=@AGE,ADDRESS=@ADDRESS,CONTACT_NO=@CONTACT_NO,PASSWOARD=@PASSWOARD,PICTURE=@PICTURE WHERE @NAME=NAME";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@NAME", textBox1.Text);
            cmd.Parameters.AddWithValue("@AGE", numericUpDown1.Value);
            cmd.Parameters.AddWithValue("@ADDRESS", textBox2.Text);
            cmd.Parameters.AddWithValue("@CONTACT_NO", textBox3.Text);
            cmd.Parameters.AddWithValue("@PASSWOARD", textBox5.Text);
            cmd.Parameters.AddWithValue("@PICTURE", SavePhoto());

            con.Open();
            int a = cmd.ExecuteNonQuery();//0 1
            if (a > 0)
            {
                MessageBox.Show("Information Updated Successfully ! ");
                BindGridView();
            }
            else
            {
                MessageBox.Show(" Information Not Updated ! ");
            }
        }
        void BindGridView()
        {
          
            SqlConnection con = new SqlConnection(cs);
            string query = "SELECT * FROM  ADMIN_INFOR";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                textBox1.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
                textBox2.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
                numericUpDown1.Value = Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value);
                string gen = dataGridView1.Rows[i].Cells[2].Value.ToString();
                string gen2 = "MALE";
                if (gen.Equals(gen2))
                {
                    radioButton1.Checked = true;
                }
                else
                {
                    radioButton2.Checked = true;
                }
                textBox3.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
                textBox5.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
                //Image admin = GetPhoto((byte[])dataGridView1.Rows[i].Cells[6].Value);
                pictureBox1.Image = GetPhoto((byte[])dataGridView1.Rows[i].Cells[6].Value);
               
              


                dataGridView1.Visible = false;
            }
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
    

