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
    public partial class Form6 : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs1"].ConnectionString;
        public Form6()
        {
            InitializeComponent();
            BindGridView();
        }
        void BindGridView()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "SELECT *FROM CUSTOMER_INFO";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable data = new DataTable();
            sda.Fill(data);

            dataGridView1.DataSource = data;

            DataGridViewImageColumn dgv = new DataGridViewImageColumn();
            dgv = (DataGridViewImageColumn)dataGridView1.Columns[7];
            dgv.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.RowTemplate.Height = 70;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);
            dataGridView1.Sort(dataGridView1.Columns[1], ListSortDirection.Ascending);
        }
        void ResetContro()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            numericUpDown1.Value = 0;

        }   
        private void button4_Click(object sender, EventArgs e)
        {            
                SqlConnection con = new SqlConnection(cs);
                string query = "DELETE FROM CUSTOMER_INFO WHERE ID=@ID";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@ID", textBox1.Text);
                con.Open();
                int a = cmd.ExecuteNonQuery();
                if (a >= 0)
                {
                    MessageBox.Show("Customer Delation Suceesful! ");
                    BindGridView();
                    ResetContro();
                }
                else
                {
                    MessageBox.Show("No delation");
                }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ResetContro();
            BindGridView();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (textBox6.Text != "")
            {
                string type = textBox6.Text;
                SqlConnection con = new SqlConnection(cs);
                string query = "SELECT * FROM CUSTOMER_INFO WHERE  PARKING_TYPE like '%" + type + "%'";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable data = new DataTable();
                sda.Fill(data);
                dataGridView1.DataSource = data;

                if (dataGridView1.CurrentRow == null)
                {
                    textBox6.Clear();
                    MessageBox.Show("Sorry This Type Vehicle Not Available This Time");
                }
            }
            else
            {
                textBox6.Clear();
                BindGridView();
            }
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            dataGridView1.DefaultCellStyle.Font = new Font("Calibri", 10.25f, FontStyle.Regular);
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Calibri", 11, FontStyle.Regular);
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.BurlyWood;
            dataGridView1.EnableHeadersVisualStyles = false;
            BindGridView();    
        }
        private byte[] SavePhoto()
        {
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            return ms.GetBuffer();
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
         
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            numericUpDown1.Value = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[2].Value.ToString());
            string gen = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            string gen2 = "MALE";
            if (gen.Equals(gen2))
            {
                radioButton1.Checked = true;
            }
            else
            {
                radioButton2.Checked = true;
            }
            textBox4.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            textBox5.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            pictureBox1.Image = GetPhoto((byte[])dataGridView1.SelectedRows[0].Cells[7].Value);
        }
        private Image GetPhoto(byte[] photo)
        {
            MemoryStream ms = new MemoryStream(photo);
            return Image.FromStream(ms);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
            this.Close();
        }

    }
}
