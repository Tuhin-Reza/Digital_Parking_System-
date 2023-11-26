using System;
using System.Collections.Generic;
using System.Text;

namespace Task_B
{
    class Company
    {
        SalesPerson []listofsalesperson = new SalesPerson[100];
        int totalsalesperson= 0;
       
        public void ShowInfo() // show library info and all book info as well
        {
            Console.WriteLine("\n----------Sales Person Information----------\n");
            for (int i = 0; i < totalsalesperson; i++)
            {
                Console.WriteLine("\nSales Person  Name          : " + listofsalesperson[i].Name);
                Console.WriteLine("Sales Person Gross Sale     : " + listofsalesperson[i].Sale);
                Console.WriteLine("Sales Person Earning        : " + listofsalesperson[i].Balance);
            }

        }
        public void AddNewPerson(SalesPerson person)
        {

            if (totalsalesperson < 1000)
            {
                listofsalesperson[totalsalesperson] = person;
                Console.WriteLine("\n--->Added New Person:" + listofsalesperson[totalsalesperson].Name);
                totalsalesperson++;
            }
            else
            {
                Console.WriteLine("--->Can Not Added New Book\n");
            }
        }
        public void AddGros_Sale(SalesPerson person,double amont)
        {
            bool added = false;
            for (int i = 0; i < totalsalesperson; i++)
            {
                if (person == listofsalesperson[i])
                {
                    double a = 0.09 * amont;
                    listofsalesperson[i].Sale = a ;
                    listofsalesperson[i].Balance = listofsalesperson[i].Balance +a+200;
                    // totalBook += copy;
                    Console.WriteLine("\n--->Added Gross Sale : " + listofsalesperson[i].Name);
                    added = true;
                }

            }
            if (!added)
            {
                Console.WriteLine("--->Contact Not Found ");
            }

        }

        

    }
}
