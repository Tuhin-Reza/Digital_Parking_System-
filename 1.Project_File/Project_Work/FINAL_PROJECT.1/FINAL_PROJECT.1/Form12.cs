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
    public partial class Form12 : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs1"].ConnectionString;
        public static string door2;
        public static string date2;
        public static string exit;
        public Form12()
        {
            InitializeComponent();
        }

        private void Form12_Load(object sender, EventArgs e)
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
            dateTimePicker2.Visible = false;
            //label28.Text= dateTimePicker2.Value.ToString("hh:mm tt");
           // exit = label28.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (label9.Text.Equals("Open"))
            {
               if(label20.Text.Equals("Close"))
                {
                    string door = "";
                    string door1 = "";
                    SqlConnection con = new SqlConnection(cs);
                    string query = "UPDATE TICKET_INFOR SET ENTRY_DOOR=@ENTRY_DOOR,EXIST_DOOR=@EXIST_DOOR WHERE RECIPT_N like '%" + Form8.recipt + "%'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@ENTRY_DOOR", door);
                    cmd.Parameters.AddWithValue("@EXIST_DOOR", door1);
                    con.Open();
                    int a = cmd.ExecuteNonQuery();
                    if (a > 0)
                    {
                        MessageBox.Show("Thank You See You Again ");
                        this.Hide();
                        Form8 f8 = new Form8();
                        f8.ShowDialog();
                        this.Close();
                        /*Form10 f10 = new Form10();
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
                        // info();*/
                    }
                    else
                    {
                        MessageBox.Show("SomteThing wrong Please Try Again");
                    }
               }
                else
                {
                    MessageBox.Show("Dear Sir You are already Exit");
                }

            }
            else
            {
                MessageBox.Show("Assign Ur Vehicle First");
                   
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 f8 = new Form8();
            f8.ShowDialog();
            this.Close();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
