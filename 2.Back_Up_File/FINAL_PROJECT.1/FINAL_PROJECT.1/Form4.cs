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

namespace FINAL_PROJECT._1
{
    public partial class Form4 : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs1"].ConnectionString;
        public Form4()
        {
            InitializeComponent();
            BindGridView();
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            dataGridView1.DefaultCellStyle.Font = new Font("Calibri", 10.25f, FontStyle.Regular);
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Calibri", 11, FontStyle.Regular);
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.BurlyWood;
            dataGridView1.EnableHeadersVisualStyles = false;
            int numRows = dataGridView1.Rows.Count;
            label10.Text = (numRows-1).ToString();

        }
        void BindGridView()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "SELECT *FROM FLOOR_INFOR";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable data = new DataTable();
            sda.Fill(data);
           
            dataGridView1.DataSource = data;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);
            dataGridView1.Sort(dataGridView1.Columns[1], ListSortDirection.Ascending);
        }
        void ResetContro()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            comboBox1.Text = "";
            comboBox2.Text = "";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && comboBox1.Text != "" &&comboBox2.Text != "")
            {
                SqlConnection con = new SqlConnection(cs);
                string query = "INSERT INTO FLOOR_INFOR VALUES (@FLOOR_NAME,@SPOT_NAME,@PARKING_TYPE,@PARKING_STATUS,@PARKING_RATE)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@FLOOR_NAME", textBox1.Text);
                cmd.Parameters.AddWithValue("@SPOT_NAME", textBox2.Text);
                cmd.Parameters.AddWithValue("@PARKING_TYPE", comboBox1.Text);
                cmd.Parameters.AddWithValue("@PARKING_STATUS", comboBox2.Text);
                cmd.Parameters.AddWithValue("@PARKING_RATE", textBox3.Text);

                con.Open();
                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Floor Created Successfully ! ");
                    BindGridView();
                    ResetContro();
                }
                else
                {
                    MessageBox.Show("Floor Not Created ! ");
                }
            }
            else
            {
                MessageBox.Show("Fill All Form ");
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && comboBox1.Text != "" && comboBox2.Text != "")
            {
                SqlConnection con = new SqlConnection(cs);
                string query = "UPDATE FLOOR_INFOR SET FLOOR_NAME=@FLOOR_NAME,PARKING_TYPE=@PARKING_TYPE,PARKING_STATUS=@PARKING_STATUS,RATE=@PARKING_RATE WHERE SPOT_NAME=@SPOT_NAME";//PARKING_STATUS='Empty
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@FLOOR_NAME", textBox1.Text);
                cmd.Parameters.AddWithValue("@SPOT_NAME", textBox2.Text);
                cmd.Parameters.AddWithValue("@PARKING_TYPE", comboBox1.Text);
                cmd.Parameters.AddWithValue("@PARKING_STATUS", comboBox2.Text);
                cmd.Parameters.AddWithValue("@PARKING_RATE", textBox3.Text);
                con.Open();
                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Floor Update Successfully ! ");
                    BindGridView();
                    ResetContro();
                }
                else
                {
                    MessageBox.Show("Floor Not Updated! ");
                }
            }
            else
            {
                MessageBox.Show("Fill All Form ");
            }
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            comboBox1.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            comboBox2.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();        
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && comboBox1.Text != "" && comboBox2.Text != "")
            {
                SqlConnection con = new SqlConnection(cs);
                string query = "DELETE FROM FLOOR_INFOR WHERE SPOT_NAME=@SPOT_NAME";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@SPOT_NAME", textBox2.Text);
                con.Open();
                int a = cmd.ExecuteNonQuery();
                if (a >= 0)
                {
                    MessageBox.Show("Floor Canselation  Successfully ! ");
                    BindGridView();
                    ResetContro();
                }
                else
                {
                    MessageBox.Show("Floor Not Cansel ! ");
                }
            }
            else
            {
                MessageBox.Show("Double Click Your Selected Row ");
            }

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text != "")
            {
                string type = textBox4.Text;
                SqlConnection con = new SqlConnection(cs);
                string query = "SELECT * FROM FLOOR_INFOR WHERE  PARKING_TYPE like '%" + type + "%'";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable data = new DataTable();
                sda.Fill(data);
                dataGridView1.DataSource = data;

                if (dataGridView1.CurrentRow == null)
                {
                    textBox4.Clear();
                    MessageBox.Show("Sorry This Type Vehicle Not Available This Time");
                }
            }
            else
            {
                textBox4.Clear();
                BindGridView();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BindGridView();
            textBox4.Clear();
            int numRows = dataGridView1.Rows.Count;

            label10.Text = (numRows - 1).ToString();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
            this.Close();
        }
    }
}
