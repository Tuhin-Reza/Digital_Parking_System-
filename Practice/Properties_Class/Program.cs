using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties_Class
{
    class Student
    {
        
        private int stId;
        private string stName;

        public int ID///Property
        {
            set
            {
                if(value<=0)
                {
                    Console.WriteLine("Invalild ID");
                }
                else
                {
                    this.stId = value;
                }
                
            }
            get
            {
                return this.stId;
            }
        }
        public string NAME///Property
        {

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Please set/add your name.");
                }
                else
                {
                    this.stName = value;
                }
               
                this.stName = value;
            }
            get
            {
                return this.stName;
            }
        }
         
        
        /////AUTO IMPLEMENTED PROPERTY
        /// prop two tab
      /* public int ID { get; set; }
        public string NAME { get; set; }
       
       /* /////AUTO IMPLEMENTED PROPERTY UPDATED
        /// prop two tab
        public int ID { get; private set; }
        public string NAME { get; private set; }
        public Student(int i, string n)
        {
            ID = i;
            NAME = n;
        }*/

    }
    class Program
    {
        static void Main(string[] args)
        {
            //Student s = new Student();
            /*
             * s.ID=0;
            s.NAME="";
            //Console.WriteLine(s.ID);
            //Console.WriteLine(s.NAME);
             * */
            /*
            ///For auto implemented property
            Console.WriteLine(s.ID=101);
            Console.WriteLine(s.NAME = "Ahmed");
             * */
            Student s = new Student();
            
            s.ID = 1119;
            s.NAME = "NAN";
            s.ID += 1;

            //* Not possible as set is private 

            Console.WriteLine(s.ID);
            Console.WriteLine(s.NAME);
        }
    }
}
