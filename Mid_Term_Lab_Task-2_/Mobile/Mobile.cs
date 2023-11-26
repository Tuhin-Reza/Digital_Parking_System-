using System;
using System.Collections.Generic;
using System.Text;

namespace Mobiles
{
    class Mobile
    {
        String mobileOwnerName;
        String mobileNumber; // SIM number
        int mobileBalance;
        String mobileOSName;
        bool islock;

        public Mobile()
        {

        }
        public Mobile(String mobileOwnerName, String mobileNumber, int mobileBalance, String mobileOSName)
        {
            this.mobileOwnerName = mobileOwnerName;
            this.mobileNumber = mobileNumber;
            this.mobileBalance = mobileBalance;
            this.mobileOSName = mobileOSName;
        }
        public string Name
        {
            get { return mobileOwnerName; }
            set { mobileOwnerName = value; }
        }
        public string Mobile_Number
        {
            get { return mobileNumber; }
            set { mobileNumber = value; }
        }
        public int Balance
        {
            get { return mobileBalance; }
            set { mobileBalance = value; }
        }
        public string OS_Name
        {
            get { return mobileOSName; }
            set { mobileOSName = value; }
        }
      
        public void ShowInfo()
        {
            Console.WriteLine("\nMobile Owner Name     : " + mobileOwnerName);
            Console.WriteLine("Mobile Number         : " + mobileNumber);
            Console.WriteLine("Mobile Balance        : " + mobileBalance);
            Console.WriteLine("Mobile OS Name        : " + mobileOSName+"\n");         
        }
        public void Recharge(int amount)
        {
            if (amount > 10)
            {
                mobileBalance += amount;
                Console.WriteLine("--Recharge Suessfull--\n");
                Console.WriteLine("Now Balance is        : " + mobileBalance);
            }
            else
            {
                Console.WriteLine("--Recharge Fail--\n");
            }
           
        }
        public void  CallSomeone(int timeDuration) // per minute cost=1 taka
        {
           
                if (mobileBalance > 2)
                {
                    int cost = timeDuration * 1;
                    Console.WriteLine("Time Duration : " + timeDuration + " Total Cost : " + cost + "\n");
                }
                else
                {
                    Console.WriteLine("Insufficent Balance");

                }
        }
    }
}
