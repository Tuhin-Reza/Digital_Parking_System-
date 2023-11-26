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
    public partial class Form1 : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["dbcs1"].ConnectionString;

        public static string name;
        public static string passwoard;
        public Form1()
        {
            InitializeComponent();
        }
        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                errorProvider1.SetError(this.textBox1, "Enter Your Name!");

            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                errorProvider2.SetError(this.textBox2, "Enter Your Passwoard !");
            }
            else
            {
                errorProvider2.Clear();
            }
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                name = textBox1.Text;
                passwoard = textBox2.Text;

                SqlConnection con = new SqlConnection(cs);
                con.Open();
                string query_a = "SELECT * FROM ADMIN_INFOR WHERE NAME =@NAME and  PASSWOARD =@PASSWOARD";
                SqlCommand cmd_a = new SqlCommand(query_a, con);
                cmd_a.Parameters.AddWithValue("@NAME", textBox1.Text);
                cmd_a.Parameters.AddWithValue("@PASSWOARD", textBox2.Text);
                SqlDataReader dr_a = cmd_a.ExecuteReader();
                if (dr_a.HasRows == true)
                {
                    this.Hide();
                    Form2 f2 = new Form2();
                    f2.ShowDialog();
                    this.Close();
                }
                else
                {
                    SqlConnection con2 = new SqlConnection(cs);
                    con2.Open();
                    string query_c = "SELECT * FROM CUSTOMER_INFO WHERE NAME=@NAME AND PASSWOARD=@PASSWOARD";
                    SqlCommand cmd_c = new SqlCommand(query_c, con2);
                    cmd_c.Parameters.AddWithValue("@NAME", textBox1.Text);
                    cmd_c.Parameters.AddWithValue("@PASSWOARD", textBox2.Text);
                    SqlDataReader dr_c = cmd_c.ExecuteReader();
                    if (dr_c.HasRows == true)
                    {
                        this.Hide();
                        Form8 f8 = new Form8();
                        f8.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        SqlConnection con3 = new SqlConnection(cs);
                        con3.Open();
                        string query_at = "SELECT * FROM ATTENDANT_INFO WHERE NAME=@NAME AND PASSWOARD=@PASSWOARD";
                        SqlCommand cmd_at = new SqlCommand(query_at, con3);
                        cmd_at.Parameters.AddWithValue("@NAME", textBox1.Text);
                        cmd_at.Parameters.AddWithValue("@PASSWOARD", textBox2.Text);
                        SqlDataReader dr_at = cmd_at.ExecuteReader();
                        if (dr_at.HasRows == true)
                        {
                            this.Hide();
                            Form13 f13 = new Form13();
                            f13.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Enter Correct Name and Passwoard!");
                        }
                    }
                }
            }             
            else
            {
                MessageBox.Show("Enter Name and Passwoard!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 f7 = new Form7();
            f7.ShowDialog();
            this.Close();

        }

    }
}
