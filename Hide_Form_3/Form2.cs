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
   
    public partial class Form2 : Form
    {
        public static string t;
        public Form2()
        {
            InitializeComponent();
            label1.Text = Form1.n;
            t = label1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           /* this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
            this.Close();*/
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();

           /* Form2 f2 = new Form2();
            f2.ShowDialog();
            Form2.t = Form3.m;*/
           
        }
    }
}
