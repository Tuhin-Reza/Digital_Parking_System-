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
    public partial class Form3 : Form
    {
        public static string m;
        public Form3()
        {
            InitializeComponent();
          
            // textBox1.Text = Form1.n;
            //m = textBox1.Text;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            textBox1.Text = Form2.t;
        }
    }
}



