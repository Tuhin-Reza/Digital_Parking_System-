using System;
using System.Collections.Generic;
using System.Text;

namespace Contacts
{
    class Contact
    {
        String personName;
        String personId;
        int age;
        String mobileNumber;
        Char gender;
        public Contact()
        { }
        public Contact(String personName,String personId,int age,String mobileNumber,Char gender)
        {
            this.personName = personName;
            this.personId = personId;
            this.age = age;
            this.mobileNumber = mobileNumber;
            this.gender = gender;
        }
        public string Name
        {
            get { return personName; }
            set { personName = value; }
        }
        public string Id
        {
            get { return personId; }
            set { personId = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public string Mobile_Number
        {        
            get { return mobileNumber; }
            set { mobileNumber = value; }
        }
        public char Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        public void ShowPersonInfo()
        {
            Console.WriteLine("\n----------Person Information----------\n");
            Console.WriteLine("Person Name               : " + personName);
            Console.WriteLine("Person Id                 : " + personId);
            Console.WriteLine("Person Age                : " + age);
            Console.WriteLine("Person Mobile Number      : " + mobileNumber);
            Console.WriteLine("Person Gender             : " + gender);

        }
        public void DetectMobileOperator()
        {
            if("017"==mobileNumber.Substring(0, 3)|| "013" == mobileNumber.Substring(0, 3))
            {

                Console.WriteLine("Mobile Operator           :GrameenPhone "+"\n");
            }
            else if ("018" == mobileNumber.Substring(0, 3))
            {

                Console.WriteLine("Mobile Operator           : Robi " + "\n");
            }
            else if ("016" == mobileNumber.Substring(0, 3))
            {

                Console.WriteLine("Mobile Operator           : Airtel " + "\n");
            }
            else if ("019" == mobileNumber.Substring(0, 3))
            {

                Console.WriteLine("Mobile Operator           : Banglalink " + "\n");
            }
            else if ("015" == mobileNumber.Substring(0, 3))
            {

                Console.WriteLine("Mobile Operator           : Teletalk " + "\n");
            }
            else if ("011" == mobileNumber.Substring(0, 3))
            {

                Console.WriteLine("Mobile Operator           : Citycell " + "\n");
            }
            else
            {
                Console.WriteLine("Cannot Find Your Operator" + "\n");
            }

        }

    }
}
