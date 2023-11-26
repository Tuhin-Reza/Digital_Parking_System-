using System;
namespace Contacts
{
    class Program
    {
        static void Main(string[] args)
        {

            Contact cont = new Contact("Oge","18-1",22,"017xxxxxxxx",'M');
            cont.ShowPersonInfo();
            cont.DetectMobileOperator();

            Contact cont2 = new Contact("Bear", "18-2", 30, "018xxxxxxxx", 'M');
            cont2.ShowPersonInfo();
            cont2.DetectMobileOperator();

            Contact cont3 = new Contact();
            cont3.Name = "Masha";
            cont3.Id = "18-3";
            cont3.Age = 10;
            cont3.Mobile_Number = "01565847962";
            cont3.Gender = 'F';
            cont3.ShowPersonInfo();
            cont3.DetectMobileOperator();          


            
            AddressBook ab1 = new AddressBook("AAAA"," ");
            ab1.ShowAllContactInfo();
            ab1.AddContact(cont);
            ab1.AddContact(cont2);
            ab1.AddContact(cont3);

            ab1.ShowAllContactInfo();

            ab1.DeleteContact(cont2);
            ab1.ShowAllContactInfo();
            ab1.DeleteContact(cont2);
            ab1.ShowAllContactInfo();


            /* AddressBook ab = new AddressBook();
             ab.Name = "LKJHG";
             ab.AddContact(cont3);
             ab.ShowAllContactInfo();*/


            Console.Read();

        }
    }
}
