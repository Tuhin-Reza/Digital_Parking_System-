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
    public partial class Form5 : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs1"].ConnectionString;
        private Image originalImage;
        public Form5()
        {
            InitializeComponent();
            BindGridView();
        }
        private void Form5_Load(object sender, EventArgs e)
        {
            int numRows = dataGridView1.Rows.Count;
            label11.Text = (numRows - 1).ToString();
            originalImage = pictureBox1.Image;

            dataGridView1.DefaultCellStyle.Font = new Font("Calibri", 10.25f, FontStyle.Regular);
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Calibri", 11, FontStyle.Regular);
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.BurlyWood;
            dataGridView1.EnableHeadersVisualStyles = false;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select Image";
            ofd.Filter = "Image File (All files) *.* | *.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(ofd.FileName);
            }

        }
        private byte[] SavePhoto()
        {
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            return ms.GetBuffer();
        }
        private Image GetPhoto(byte[] photo)
        {
            MemoryStream ms = new MemoryStream(photo);
            return Image.FromStream(ms);
        }
        void BindGridView()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "SELECT * FROM ATTENDANT_INFO";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;
            DataGridViewImageColumn dgv = new DataGridViewImageColumn();
            dgv = (DataGridViewImageColumn)dataGridView1.Columns[7];
            dgv.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.RowTemplate.Height = 70;
        }
        void ResetContro()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            numericUpDown1.Value = 0;
            pictureBox1.Image = originalImage;

            // pictureBox1.Image = Properties.Resources.no_image_avaiable;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            int count=0;
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox3.Text != "" && textBox3.Text != "" && numericUpDown1.Value != 0)
            {
                if (radioButton1.Checked == true || radioButton2.Checked == true)
                {
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        for (int j = 0; j < dataGridView1.Columns.Count; j++)
                        {
                            if (dataGridView1.Rows[i].Cells[j].Value != null && textBox4.Text == dataGridView1.Rows[i].Cells[j].Value.ToString())
                            {
                                count++;
                                break;
                            }
                        }
                    }
                    if(count==0)
                    {
                        SqlConnection con = new SqlConnection(cs);
                        string query = "INSERT INTO ATTENDANT_INFO VALUES (@NAME,@AGE,@GENDER,@ADDRESS,@CONTACT_NO,@PASSWOARD,@PICTURE)";
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
                        cmd.Parameters.AddWithValue("@PASSWOARD", textBox4.Text);

                        cmd.Parameters.AddWithValue("@PICTURE", SavePhoto());
                        con.Open();
                        int a = cmd.ExecuteNonQuery();
                        if (a > 0)
                        {
                            MessageBox.Show("Attendant Successfully Added");
                            BindGridView();
                            ResetContro();
                        }
                        else
                        {
                            MessageBox.Show("Attendant Not Added");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Enter Unique Passwoard");
                        count--;
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

        private void button3_Click(object sender, EventArgs e)
        {
            int count = 0;
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox3.Text != "" && textBox3.Text != "" && numericUpDown1.Value != 0)
            {
                MessageBox.Show("If You Change Passwoard Remember It Please ");
                if (radioButton1.Checked == true || radioButton2.Checked == true)
                {
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        for (int j = 0; j < dataGridView1.Columns.Count; j++)
                        {
                            if (dataGridView1.Rows[i].Cells[j].Value != null && textBox4.Text == dataGridView1.Rows[i].Cells[j].Value.ToString())
                            {
                                count++;
                                break;
                            }
                        }
                    }
                    if (count==0)
                    {
                        SqlConnection con = new SqlConnection(cs);
                        string query = "UPDATE ATTENDANT_INFO SET NAME=@NAME,AGE=@AGE,GENDER=@GENDER,ADDRESS=@ADDRESS,CONTACT_NO=@CONTACT_NO,PASSWOARD=@PASSWOARD,PICTURE=@PICTURE WHERE NAME=@NAME";
                        SqlCommand cmd = new SqlCommand(query, con);
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
                        cmd.Parameters.AddWithValue("@PASSWOARD", textBox4.Text);
                        cmd.Parameters.AddWithValue("@PICTURE", SavePhoto());
                        con.Open();
                        int a = cmd.ExecuteNonQuery();
                        if (a > 0)
                        {
                            MessageBox.Show("Attendant Successfully Modified");
                            BindGridView();
                            ResetContro();
                        }
                        else
                        {
                            MessageBox.Show("Attendant Not Modified");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Enter Unique Passwoard");
                        count--;
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
   
        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are You Sure Delete Attendant","Delete Permision", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox3.Text != "" && textBox3.Text != "" && numericUpDown1.Value != 0)
                {
                        SqlConnection con = new SqlConnection(cs);
                        string query = "DELETE FROM ATTENDANT_INFO WHERE PASSWOARD=@PASSWOARD";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@PASSWOARD", textBox4.Text);
                        con.Open();
                        int a = cmd.ExecuteNonQuery();
                        if (a > 0)
                        {
                            MessageBox.Show("Attendant Successfully DELETED");
                            BindGridView();
                            ResetContro();
                        }
                        else
                        {
                            MessageBox.Show("Attendant Not DELETED");
                        }
                }
                else
                {
                    MessageBox.Show("Fill All Form ");
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Try Agin Letter");
            }        
        }
        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            numericUpDown1.Value = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[2].Value);
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            textBox4.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            pictureBox1.Image = GetPhoto((byte[])dataGridView1.SelectedRows[0].Cells[7].Value);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ResetContro();
            textBox6.Clear();
            int numRows = dataGridView1.Rows.Count;
            label11.Text = (numRows - 1).ToString();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (textBox6.Text != "")
            {
                int type = int.Parse(textBox6.Text);
                SqlConnection con = new SqlConnection(cs);
                string query = "SELECT * FROM ATTENDANT_INFO WHERE  ID like '%" + type + "%'";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable data = new DataTable();
                sda.Fill(data);
                dataGridView1.DataSource = data;

                if (dataGridView1.CurrentRow == null)
                {
                    textBox4.Clear();
                    MessageBox.Show("Sorry Attendant Not Available Your Paking Lot");
                }
            }
            else
            {
                textBox4.Clear();
                BindGridView();
            }
        }
        private void button5_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
            this.Close();
        }
    }
}
