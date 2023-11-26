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
    public partial class Form10 : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs1"].ConnectionString;

        public static string date;
        public static string id;
        public static string name;
        public static string f_name;
        public static string s_name;
        public static string type;
        public static string status;
        public static string rate;
        public static string parking_time;
      
        public static string total_time;
        public static string bill;
        public static string entry;
        public static string exist;
        public static string recipt;
        public static int numRows;

        string time;
        public Form10()
        {
            InitializeComponent();
            label13.Text = Form8.id;
            label14.Text = Form1.name;
            SqlConnection con = new SqlConnection(cs);
            string query = "SELECT *FROM TICKET_INFOR WHERE RECIPT_N like '%" + Form8.recipt + "%'  AND EXIST_DOOR='CLOSE'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            numRows = dataGridView1.Rows.Count;
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    date = dataGridView1.Rows[i].Cells[0].Value.ToString();
                    id = dataGridView1.Rows[i].Cells[1].Value.ToString();
                    name = dataGridView1.Rows[i].Cells[2].Value.ToString();
                    f_name = dataGridView1.Rows[i].Cells[3].Value.ToString();
                    s_name = dataGridView1.Rows[i].Cells[4].Value.ToString();
                    type = dataGridView1.Rows[i].Cells[5].Value.ToString();
                    parking_time = dataGridView1.Rows[i].Cells[6].Value.ToString();
                    total_time = dataGridView1.Rows[i].Cells[7].Value.ToString();
                    bill = dataGridView1.Rows[i].Cells[8].Value.ToString();
                    entry = dataGridView1.Rows[i].Cells[9].Value.ToString();
                    exist = dataGridView1.Rows[i].Cells[10].Value.ToString();
                    recipt = dataGridView1.Rows[i].Cells[11].Value.ToString();
                }

        }    
        private void Form10_Load(object sender, EventArgs e)
        {

            dataGridView2.Visible = false;
            BindGridView();
            dateTimePicker1.Visible = false;
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            dateTimePicker1.ShowUpDown = true;
            string dt = dateTimePicker1.Value.ToString("dd/MM/yyyy");
            this.label24.Text = dt;

            dataGridView1.DefaultCellStyle.Font = new Font("Calibri", 10.25f, FontStyle.Regular);
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Calibri", 11, FontStyle.Regular);
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.BurlyWood;
            dataGridView1.EnableHeadersVisualStyles = false;
            //dataGridView1.RowHeadersVisible = false;
           
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
        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            label15.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            label16.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            label17.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            label19.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            label22.Text = label19.Text;
            refresh();
            BindGridView2();
        }
        void BindGridView2()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "SELECT * FROM TICKET_INFOR WHERE FLR_NAME like'%" + label15.Text + "%' and  SPT_NAME like '%" + label16.Text + "%' and EXIST_DOOR='CLOSE'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView2.DataSource = data;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
            {

                time = dataGridView2.Rows[i].Cells[6].Value.ToString();
                if (radioButton1.Text.Equals(time))
                {
                    radioButton1.Visible = false;
                }
                else if (radioButton2.Text.Equals(time))
                {
                    radioButton2.Visible = false;
                }
                else if (radioButton3.Text.Equals(time))
                {
                    radioButton3.Visible = false;
                }
                else if (radioButton4.Text.Equals(time))
                {
                    radioButton4.Visible = false;
                }
                else if (radioButton5.Text.Equals(time))
                {
                    radioButton5.Visible = false;
                }
                else if (radioButton6.Text.Equals(time))
                {
                    radioButton6.Visible = false;
                }
                else if (radioButton7.Text.Equals(time))
                {
                    radioButton7.Visible = false;
                }
                else if (radioButton8.Text.Equals(time))
                {
                    radioButton8.Visible = false;
                }
                else if (radioButton9.Text.Equals(time))
                {
                    radioButton9.Visible = false;
                }
                else if (radioButton10.Text.Equals(time))
                {
                    radioButton10.Visible = false;
                }
                else if (radioButton11.Text.Equals(time))
                {
                    radioButton11.Visible = false;
                }
                else if (radioButton5.Text.Equals(time))
                {
                    radioButton5.Visible = false;
                }
                else
                {

                }
            }
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            if (label13.Text != "" && label14.Text != "" && label15.Text != "" && label16.Text != "" && label17.Text != "" && label8.Text != "")// &&label20.Text != ""
            {
                int bill = Convert.ToInt32(label22.Text);
                if (numericUpDown1.Value == bill)
                {
                    SqlConnection con = new SqlConnection(cs);
                    string query = "INSERT INTO TICKET_INFOR VALUES (@ISSUE_DATE,@CUS_ID,@CUS_NAME,@FLR_NAME,@SPT_NAME,@PARKING_TYPE,@PARKING_TIME,@TOTAL_TIME,@CUS_BILL,@ENTRY_DOOR,@EXIST_DOOR)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@ISSUE_DATE", label24.Text);
                    cmd.Parameters.AddWithValue("@CUS_ID", label13.Text);
                    cmd.Parameters.AddWithValue("@CUS_NAME", label14.Text);
                    cmd.Parameters.AddWithValue("@FLR_NAME", label15.Text);
                    cmd.Parameters.AddWithValue("@SPT_NAME", label16.Text);
                    cmd.Parameters.AddWithValue("@PARKING_TYPE", label17.Text);
                    cmd.Parameters.AddWithValue("@PARKING_TIME", label8.Text);
                    cmd.Parameters.AddWithValue("@TOTAL_TIME", label21.Text);
                    cmd.Parameters.AddWithValue("@CUS_BILL", label22.Text);
                    cmd.Parameters.AddWithValue("@ENTRY_DOOR",label9.Text );
                    cmd.Parameters.AddWithValue("@EXIST_DOOR",label20.Text);

                    con.Open();
                    int a = cmd.ExecuteNonQuery();
                    if (a > 0)
                    {
                        MessageBox.Show("" + label14.Text + "  " + label17.Text + " Assign Successfull");
                        BindGridView();
                        refresh2();
                    }
                    else
                    {
                        MessageBox.Show("Assign Unsuccessful ! ");
                    }
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Payment Parking Fee First ! ");
                }
            }
            else
            {
                MessageBox.Show("Fill All Form ");
            }
        }
        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboBox1.Text != "")
            {
                string type = comboBox1.Text;
                SqlConnection con = new SqlConnection(cs);
                string query = "SELECT * FROM FLOOR_INFOR WHERE  PARKING_TYPE like '%" + type + "%'";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable data = new DataTable();
                sda.Fill(data);
                dataGridView1.DataSource = data;

                if (dataGridView1.CurrentRow == null)
                {
                    comboBox1.Text = "";
                    MessageBox.Show("Sorry This Type Vehicle Not Available This Time");
                }
            }
            else
            {
                comboBox1.Text = "";
                BindGridView();
            }
        }

        private void radioButton1_MouseClick(object sender, MouseEventArgs e)
        {
            label8.Text = radioButton1.Text;
        }

        private void radioButton2_MouseClick(object sender, MouseEventArgs e)
        {
            label8.Text = radioButton2.Text;
        }

        private void radioButton3_MouseClick(object sender, MouseEventArgs e)
        {
            label8.Text = radioButton3.Text;
        }

        private void radioButton4_MouseClick(object sender, MouseEventArgs e)
        {
            label8.Text = radioButton4.Text;
        }

        private void radioButton5_MouseClick(object sender, MouseEventArgs e)
        {
            label8.Text = radioButton5.Text;
        }

        private void radioButton6_MouseClick(object sender, MouseEventArgs e)
        {
            label8.Text = radioButton6.Text;
        }

        private void radioButton7_MouseClick(object sender, MouseEventArgs e)
        {
            label8.Text = radioButton7.Text;
        }

        private void radioButton8_MouseClick(object sender, MouseEventArgs e)
        {
            label8.Text = radioButton8.Text;
        }

        private void radioButton9_MouseClick(object sender, MouseEventArgs e)
        {
            label8.Text = radioButton9.Text;
        }

        private void radioButton10_MouseClick(object sender, MouseEventArgs e)
        {
            label8.Text = radioButton10.Text;
        }

        private void radioButton11_MouseClick(object sender, MouseEventArgs e)
        {
            label8.Text = radioButton11.Text;
        }

        private void radioButton12_MouseClick(object sender, MouseEventArgs e)
        {
            label8.Text = radioButton12.Text;
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            refresh();
            refresh2();
        }
        void refresh()
        {
            radioButton1.Visible = true;
            radioButton2.Visible = true;
            radioButton3.Visible = true;
            radioButton4.Visible = true;
            radioButton5.Visible = true;
            radioButton6.Visible = true;
            radioButton7.Visible = true;
            radioButton8.Visible = true;
            radioButton9.Visible = true;
            radioButton10.Visible = true;
            radioButton11.Visible = true;
            radioButton12.Visible = true;
        }
        void refresh2()
        {
            label15.Text = "";
            label16.Text = "";
            label17.Text = "";
            //label18.Text = "";
            label21.Text = "";
            label22.Text = "";
            label8.Text = "";
            label19.Text = "";
            comboBox1.Text = "Search Vehicle";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 f8 = new Form8();
            f8.ShowDialog();
            this.Close();
        }
    } 
}