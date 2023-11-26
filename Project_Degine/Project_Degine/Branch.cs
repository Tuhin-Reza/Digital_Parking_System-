using System;
using System.Collections.Generic;
using System.Text;

namespace Project_Degine
{
    class Branch :Head_Branch
    {
        string branch_name;
        string  reg_no;
        public Branch() { }
        public Branch(string branch_name,string reg_no)
        {
            this.branch_name = branch_name;
            this.reg_no = reg_no;
        }
        public string Branch_name
        {
            get { return branch_name; }
            set { branch_name= value; }
        }
        public string Registration_NO
        {
            get { return reg_no; }
            set { reg_no = value; }
        }
        public void show_Branch_details()
        {

        }
    }
}
