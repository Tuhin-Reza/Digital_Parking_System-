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
    public partial class Form16 : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs1"].ConnectionString;
        public static string id;
        public Form16()
        {
            InitializeComponent();
            BindGridView();
        }

        private void Form16_Load(object sender, EventArgs e)
        {
            string name = Form1.name;
            label9.Text = name;

        }
        void BindGridView()
        {
            string name = Form1.name;
            this.Text = name;
            string type = name;
            SqlConnection con = new SqlConnection(cs);
            string query = "SELECT * FROM  ATTENDANT_INFO WHERE NAME like '%" + type + "%'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                textBox1.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
                id = textBox1.Text;
                textBox2.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
                numericUpDown1.Value = Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value);
                string gen = dataGridView1.Rows[i].Cells[3].Value.ToString();
                string gen2 = "MALE";
                if (gen.Equals(gen2))
                {
                    radioButton1.Checked = true;
                }
                else
                {
                    radioButton2.Checked = true;
                }
                textBox4.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
                textBox3.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
                textBox5.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
                pictureBox1.Image = GetPhoto((byte[])dataGridView1.Rows[i].Cells[7].Value);
            }
            dataGridView1.Visible = false;
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
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select Image";
            ofd.Filter = "Image File (All files) *.* | *.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(ofd.FileName);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {                   
                SqlConnection con = new SqlConnection(cs);
                string query = "UPDATE ATTENDANT_INFO SET NAME=@NAME,AGE=@AGE,ADDRESS=@ADDRESS,CONTACT_NO=@CONTACT_NO,PASSWOARD=@PASSWOARD,PICTURE=@PICTURE WHERE ID=@ID";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@ID", textBox1.Text);
                cmd.Parameters.AddWithValue("@NAME", textBox2.Text);
                cmd.Parameters.AddWithValue("@AGE", numericUpDown1.Value);
                cmd.Parameters.AddWithValue("@ADDRESS", textBox4.Text);
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form13 f13 = new Form13();
            f13.ShowDialog();
            this.Close();
        }
    }
}
