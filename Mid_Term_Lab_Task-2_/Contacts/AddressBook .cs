using System;
using System.Collections.Generic;
using System.Text;

namespace Contacts
{
    class AddressBook
    {
        String ownerName;
        String info;//can not understood what does mean this field
        Contact[] listOfContact;
        int count = 0;
        public AddressBook() { }
        public AddressBook(String ownerName, String info)
        {
            this.ownerName = ownerName;
            this.info = info;
            listOfContact = new Contact[1000];
        }
        public string Name
        {
            get { return ownerName; }
            set { this.ownerName= value; }
        }
        public string Info
        {
            get { return info; }
            set { info = value; }
        }
        public void ShowAllContactInfo()
        {
            if (count != 0)
            {
                Console.WriteLine("\n----------Address Book  Information----------\n");
                Console.WriteLine("\nOwner Name           : " + Name);
                //Console.WriteLine("Owner Informatio       : " + info);

                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine("\n\nPerson Name          : " + listOfContact[i].Name);
                    Console.WriteLine("Person Id            : " + listOfContact[i].Id);
                    Console.WriteLine("Person Age           : " + listOfContact[i].Age);
                    Console.WriteLine("Person Mobile_Number : " + listOfContact[i].Mobile_Number);
                    Console.WriteLine("Person Gender        : " + listOfContact[i].Gender + "\n");

                }

            }
            else
            {
                Console.WriteLine("\n--->Contact Info is not Available This Time ");
            }
        }
        public  void AddContact(Contact con)
        {
            if (count < 1000)
            {
                listOfContact[count] = con;
                Console.WriteLine("\n--->Added New Contact ID :" + listOfContact[count].Id);
                count++;
            }
            else
            {
                Console.WriteLine("Can Not Added New Contact");
            }
        }
        public void DeleteContact(Contact con)
        {
            bool deleted = false;
            for (int i = 0; i < count; i++)
            {
                if (con == listOfContact[i])
                {
                    Console.WriteLine("\n---> Deleted Contact Id : " + listOfContact[i].Id);
                    listOfContact[i] = listOfContact[--count];                  
                    deleted = true;
                }
            }
            if (!deleted)
            {
                Console.WriteLine("--->Contact Not Found ");
            }         

        }
    }
}
