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
    public partial class Form8 : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs1"].ConnectionString;
        string name = Form1.name;
        public static string id;
        public static string nam;
        public static int age;
        public static string gender;
        public static string address;
        public static string contact_no;
        public static string passwoard;
        public static Image picture;

        public static string date;
        public static string r;
        public static string p;
        public static string f_name;
        public static string s_name;
        public static string type;
        public static string status;
        public static string in_time;
        public static string out_time;
        public static string total_time;
        public static string bill;
        public static string entry;
        public static string exist;
        public static string recipt;

        public static int  count1;
        public static int count2;

        public Form8()
        {
            InitializeComponent();         
            BindGridView();
        }
        private void Form8_Load(object sender, EventArgs e)
        {
           
            dateTimePicker1.Visible = false;
            string dt = dateTimePicker1.Value.ToString("dd/MM/yyyy hh mm tt");
            label5.Text = dt;

            dataGridView1.DefaultCellStyle.Font = new Font("Calibri", 10.25f, FontStyle.Regular);
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Calibri", 11, FontStyle.Regular);
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.BurlyWood;
            dataGridView1.EnableHeadersVisualStyles = false;
            BindGridView2();

            groupBox2.Visible = false;





        }
        void BindGridView2()
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Visible = true;
            SqlConnection con = new SqlConnection(cs);
            //string query = "SELECT FLR_NAME,SPT_NAME,PARKING_TYPE,PARKING_TIME,ENTRY_DOOR,EXIST_DOOR,RECIPT_N FROM TICKET_INFOR WHERE  CUS_ID  like '%" + label3.Text + "%' AND EXIST_DOOR='CLOSE'";
            string query = "SELECT FLR_NAME,SPT_NAME,PARKING_TYPE,PARKING_TIME,RECIPT_N,ENTRY_DOOR,EXIST_DOOR FROM TICKET_INFOR WHERE  CUS_ID  like '%" + label3.Text + "%'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;
        }

        void BindGridView()
        {
            string name = Form1.name;
            this.Text = name;
            string type = name;
            SqlConnection con = new SqlConnection(cs);
            string query = "SELECT * FROM  CUSTOMER_INFO WHERE NAME like '%" + type + "%'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                label3.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
                id = label3.Text;
                label4.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
                age = Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value);
                string gen = dataGridView1.Rows[i].Cells[3].Value.ToString();
                string gen2 = "MALE";
                if (gen.Equals(gen2))
                {
                    gender = "Male";
                }
                else
                {
                    gender = "Female";
                }
                address = dataGridView1.Rows[i].Cells[4].Value.ToString();
                contact_no = dataGridView1.Rows[i].Cells[5].Value.ToString();
                passwoard = dataGridView1.Rows[i].Cells[6].Value.ToString();
                picture = GetPhoto((byte[])dataGridView1.Rows[i].Cells[7].Value);
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
            //pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            return ms.GetBuffer();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form9 f9 = new Form9();
            f9.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form10 f10 = new Form10();
            f10.ShowDialog();
            this.Close();
        }
        private void button3_Click(object sender, EventArgs e)
        {           
            MessageBox.Show(" Double Click Your Bokking Time");
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Visible = true;
            SqlConnection con = new SqlConnection(cs);
            //string query = "SELECT FLR_NAME,SPT_NAME,PARKING_TYPE,PARKING_TIME,ENTRY_DOOR,EXIST_DOOR,RECIPT_N FROM TICKET_INFOR WHERE  CUS_ID  like '%" + label3.Text + "%' AND EXIST_DOOR='CLOSE'";
            string query = "SELECT FLR_NAME,SPT_NAME,PARKING_TYPE,PARKING_TIME,RECIPT_N,ENTRY_DOOR,EXIST_DOOR FROM TICKET_INFOR WHERE  CUS_ID  like '%" + label3.Text + "%' AND ENTRY_DOOR='Close'AND EXIST_DOOR='Close'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Visible = true;
            SqlConnection con = new SqlConnection(cs);
            //string query = "SELECT FLR_NAME,SPT_NAME,PARKING_TYPE,PARKING_TIME,ENTRY_DOOR,EXIST_DOOR,RECIPT_N FROM TICKET_INFOR WHERE  CUS_ID  like '%" + label3.Text + "%' AND EXIST_DOOR='CLOSE'";
            string query = "SELECT FLR_NAME,SPT_NAME,PARKING_TYPE,PARKING_TIME,RECIPT_N,ENTRY_DOOR,EXIST_DOOR FROM TICKET_INFOR WHERE  CUS_ID  like '%" + label3.Text + "%' AND ENTRY_DOOR='Open'AND EXIST_DOOR='Close'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;
            MessageBox.Show(" Double Click Your Bokking Time");
        }
        private void dataGridView1_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            recipt = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            string e_door = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            string ex_door = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            if (e_door.Equals("Open") && ex_door.Equals("Close"))
            {

                this.Hide();
                Form10 f10 = new Form10();
                Form12 f12 = new Form12();
                f12.ShowDialog();
                this.Close();
            }
            else if (e_door.Equals("Close") && ex_door.Equals("Close"))
            {
                this.Hide();
                Form10 f10 = new Form10();
                Form11 f11 = new Form11();
                f11.ShowDialog();
                this.Close();
            }
            else if (e_door.Equals("Close") && ex_door.Equals("Open"))
            {
                MessageBox.Show("This Time Already Used");
            }
            else
            {
                MessageBox.Show("Something Wrong Please Try again");
            }          
        }
        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            BindGridView2();
            groupBox2.Visible = false;
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != null)
            {             
                string re = textBox1.Text;
                SqlConnection con = new SqlConnection(cs);
                string query = "SELECT *FROM TICKET_INFOR WHERE RECIPT_N like '%" + textBox1.Text + "%' AND CUS_ID like '%" + label3.Text + "%'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable data = new DataTable();
                sda.Fill(data);
                dataGridView1.DataSource = data;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {

                    label24.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
                    label13.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
                    label14.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
                    label15.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
                    label16.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
                    label17.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
                    label8.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
                    label21.Text = dataGridView1.Rows[i].Cells[7].Value.ToString();
                    label19.Text = dataGridView1.Rows[i].Cells[8].Value.ToString();
                    label22.Text = dataGridView1.Rows[i].Cells[8].Value.ToString();
                    label9.Text = dataGridView1.Rows[i].Cells[9].Value.ToString();
                    label20.Text = dataGridView1.Rows[i].Cells[10].Value.ToString();
                    label25.Text = dataGridView1.Rows[i].Cells[11].Value.ToString();
                    if (label25.Text.Equals(textBox1.Text))
                    {
                        groupBox2.Visible = true;
                    }
                   
                    // label33.Text = Form12.exit;

                }
            }
            else
            {
                MessageBox.Show("Please Enter Rceipt Number ");
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            BindGridView2();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
            this.Close();
        }
    }
}
