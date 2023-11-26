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
using System.Globalization;


namespace FINAL_PROJECT._1
{
    public partial class Form11 : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs1"].ConnectionString;
        public static string door1;
        public static string date2;
       // string dt3;
        string dt2;
        string date;
        string dt1;

        public Form11()
        {
            InitializeComponent();
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            Form10 f10 = new Form10();          
            label24.Text=Form10.date;
            label13.Text=Form10.id;
            label14.Text= Form10.name;
            label15.Text=Form10.f_name;
            label16.Text=Form10.s_name;
            label17.Text=Form10.type;
            label8.Text=Form10.parking_time;
            label21.Text=Form10.total_time;
            label19.Text=Form10.bill;
            label22.Text = Form10.bill;
            label9.Text=Form10.entry;
            label20.Text = Form10.exist;
            label25.Text=Form10.recipt;

            dateTimePicker3.Visible = false;
            dateTimePicker1.Visible = false;

            string time = label8.Text.Substring(0, 4);
            DateTime dt = DateTime.Parse(time, CultureInfo.InvariantCulture);
            dateTimePicker3.Value = dt;
            dt1= dateTimePicker3.Value.ToString("hh tt");
            //MessageBox.Show(""+dt1);


           /* string time2 = label8.Text.Substring(6);
            DateTime dt4 = DateTime.Parse(time2, CultureInfo.InvariantCulture);
            dateTimePicker3.Value = dt4;

            string dt4 = dateTimePicker2.Value.ToString("hh tt");*/

            date = dateTimePicker1.Value.ToString("dd/MM/yyyy");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            dt2 = dateTimePicker2.Value.ToString("hh tt");
            //MessageBox.Show("" + dt2);
            //MessageBox.Show("" + dt1);
            //MessageBox.Show("" + date);

            if (dt2.Equals(dt1) && date.Equals(label24.Text))
            {
                if (label9.Text.Equals("Close"))
                {
                    string door = "Open";
                    SqlConnection con = new SqlConnection(cs);
                    string query = "UPDATE TICKET_INFOR SET ENTRY_DOOR=@ENTRY_DOOR WHERE RECIPT_N like '%" + Form8.recipt + "%'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@ENTRY_DOOR", door);
                    con.Open();
                    int a = cmd.ExecuteNonQuery();
                    if (a > 0)
                    {
                        MessageBox.Show("Now You Can Assign Your Vehicle ");
                        Form10 f10 = new Form10();
                        label24.Text = Form10.date;
                        label13.Text = Form10.id;
                        label14.Text = Form10.name;
                        label15.Text = Form10.f_name;
                        label16.Text = Form10.s_name;
                        label17.Text = Form10.type;
                        label8.Text = Form10.parking_time;
                        label21.Text = Form10.total_time;
                        label19.Text = Form10.bill;
                        label22.Text = Form10.bill;
                        label9.Text = Form10.entry;
                        label20.Text = Form10.exist;
                        label25.Text = Form10.recipt;

                    }
                    else
                    {
                        MessageBox.Show("SomteThing wring Please Try Again");
                    }
                }
                else
                {
                    MessageBox.Show("Your Vehicle Already Assign ");
                }                     
            }
            else
            {
                MessageBox.Show("Time and Date not matche ");
            }

        }
        void info()
        {
            Form10 f10 = new Form10();
            label24.Text = Form10.date;
            label13.Text = Form10.id;
            label14.Text = Form10.name;
            label15.Text = Form10.f_name;
            label16.Text = Form10.s_name;
            label17.Text = Form10.type;
            label8.Text = Form10.parking_time;
            label21.Text = Form10.total_time;
            label19.Text = Form10.bill;
            label22.Text = Form10.bill;
            label9.Text = Form10.entry;
            label20.Text = Form10.exist;
            label25.Text = Form10.recipt;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 f8 = new Form8();
            f8.ShowDialog();
            this.Close();
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }
    }
    
}
