using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hide_Form_3
{
    public partial class Form1 : Form
    {

        public static string n;
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            /* n = textBox1.Text; 
             this.Hide();
              Form2 f2 = new Form2();
              f2.ShowDialog();
              this.Close();*/
            /* DateTime startTime = Convert.ToDateTime("12.00AM");
              DateTime endtime = Convert.ToDateTime("12:00PM ");
              TimeSpan duration = endtime-startTime;
             label1.Text = duration.ToString();*/
            n = textBox1.Text;
            
            Form2 f2 = new Form2();
            Form3 f3 = new Form3();
            f3.ShowDialog();



            // TimeSpan result = this.dateTimePicker3.Value - this.dateTimePicker1.Value;
     
           

        }
        private void label1_Click(object sender, EventArgs e)
        {
           /* if (radioButton1.Checked == true)
            {
                label1.Text = radioButton1.Text;
            }   */       
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            /* dateTimePicker1.Format = DateTimePickerFormat.Custom;
             dateTimePicker1.CustomFormat = "hh:mm:ss tt";
             dateTimePicker1.ShowUpDown = true;
             string dt = dateTimePicker1.Value.ToString("hh:mm:ss tt");


             dateTimePicker3.Format = DateTimePickerFormat.Custom;
             dateTimePicker3.CustomFormat = "hh:mm:ss tt";
             dateTimePicker3.ShowUpDown = true;
             string dt3 = dateTimePicker2.Value.ToString("hh:mm:ss tt");

             .string t1 = dateTimePicker1.value;
             dateTimePicker4 = Convert.toDateTime(dt3);
             TimeSpan timediff = dt3 - dt;*/
            // dataGridView1.Columns.Insert(0, combo);
           

            //Form1.Opacity = .75;
            // Size the form to be 300 pixels in height and width.
            //  Form1.Size = new Size(300, 300);
            // Display the form in the center of the screen.
            // form2.StartPosition = FormStartPosition.CenterScreen;

          //  Utility.fitFormToScreen(this, 788, 1280);
            this.CenterToScreen();

        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
           
       
        }

        private void radioButton7_MouseClick(object sender, MouseEventArgs e)
        {
           
        /*    if (radioButton7.BackColor ==)
            {
                MessageBox.Show("u cannot chose this time");
                
            }
            else
            {
                label9.Text = radioButton7.Text;
                label9.Visible = true;
                int i = 0;
               // label[i].Text=  "";

            }*/
        }
        private void CreateMyOpaqueForm()
        {
            // Create a new form.
            Form form2 = new Form();
            // Set the text displayed in the caption.
            form2.Text = "My Form";
            // Set the opacity to 75%.
            form2.Opacity = .75;
            // Size the form to be 300 pixels in height and width.
            form2.Size = new Size(300, 300);
            // Display the form in the center of the screen.
            form2.StartPosition = FormStartPosition.CenterScreen;

            // Display the form as a modal dialog box.
            form2.ShowDialog();
        }
    }
}
