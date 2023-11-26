using System;
using System.Collections.Generic;
using System.Text;

namespace Task_B
{
    class SalesPerson
    {
        string name;
        double gross_sale;
        double balance;

        public SalesPerson(string name)
        {
            this.name = name;
            //this.gross_sale = gross_sale;
           // this.balance = balance;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double Sale
        {
            get { return gross_sale; }
            set { gross_sale = value; }
        }  
        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }
    }
}
