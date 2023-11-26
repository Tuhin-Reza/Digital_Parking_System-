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
    public partial class Form14 : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs1"].ConnectionString;
        public Form14()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form13 f13 = new Form13();
            f13.ShowDialog();
            this.Close();
        }

        private void Form14_Load(object sender, EventArgs e)
        {
            BindGridView();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                string type = textBox1.Text;
                SqlConnection con = new SqlConnection(cs);
                string query = "SELECT * FROM  TICKET_INFOR WHERE  CUS_ID like '%" + type + "%'";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable data = new DataTable();
                sda.Fill(data);
                dataGridView1.DataSource = data;

                if (dataGridView1.CurrentRow == null)
                {
                    textBox1.Clear();
                    MessageBox.Show("Not Found");
                }
            }
            else
            {
                textBox1.Clear();
                BindGridView();
            }
           
        }
        void BindGridView()
        {
            dataGridView1.DefaultCellStyle.Font = new Font("Calibri", 10.25f, FontStyle.Regular);
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Calibri", 11, FontStyle.Regular);
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.BurlyWood;
            dataGridView1.EnableHeadersVisualStyles = false;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Visible = true;
            SqlConnection con = new SqlConnection(cs);
            //string query = "SELECT FLR_NAME,SPT_NAME,PARKING_TYPE,PARKING_TIME,ENTRY_DOOR,EXIST_DOOR,RECIPT_N FROM TICKET_INFOR WHERE  CUS_ID  like '%" + label3.Text + "%' AND EXIST_DOOR='CLOSE'";
            string query = "SELECT * FROM TICKET_INFOR";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;
        }

    }
}
