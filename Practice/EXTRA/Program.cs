using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXTRA
{
    class Program
    {
        static void Main(string[] args)
        {
            person[] p = new person[3];
            p[0] = new person
            {
                Name = "Ahmed",
                Gender = 1
            };
            p[1] = new person
            {
                Name = "Ahmeda",
                Gender = 2
            };
            p[2] = new person
            {
                Name = "Pppas",
                Gender = 3
            };
            foreach (person per in p)
            {
                //Console.WriteLine("Name = {0} && Gender = {1}", per.Name, per.Gender);
                Console.WriteLine("Name = {0} && Gender = {1}", per.Name, getGender(per.Gender));
            }
        }
        public static string getGender(int gender)
        {
            switch (gender)
            {
                case 1:
                    return "Male";

                case 2:
                    return "Female";

                case 3:
                    return "None";

                default:
                    return "Invalid Input";
            }

        }

        }

    
    /*
     1=Male
     2=Female
     3=None
     */
    public class person
    {
        public string Name { get; set; }
        public int Gender { get; set; }
    }
}
