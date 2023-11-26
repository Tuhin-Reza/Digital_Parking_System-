using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FINAL_PROJECT._1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            string name = Form1.name;
            this.Text = name;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                this.Hide();
                Form4 f4= new Form4();
                f4.ShowDialog();
                this.Close();
            }
            else if (radioButton2.Checked == true)
            {
                this.Hide();
                Form5 f5 = new Form5();
                f5.ShowDialog();
                this.Close();
            }
            else if (radioButton3.Checked == true)
            {
                this.Hide();
                Form6 f6 = new Form6();
                f6.ShowDialog();
                this.Close();
            }
            else if (radioButton3.Checked == true)
            {
                this.Hide();
                Form15 f15 = new Form15();
                f15.ShowDialog();
                this.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
            this.Close();
        }
    }
}
