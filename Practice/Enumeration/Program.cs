using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumeration
{
    class Program
    {
      /*  enum WeekDays
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }*/
       /* enum WeekDays
        {
            Monday=5,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }*/
        enum WeekDays
        {
            Monday = 7,
            Tuesday=0,
            Wednesday=6,
            Thursday=7,
            Friday,
            Saturday,
            Sunday
        }
       /* enum WeekDays
        {
            Monday = 5,
            Tuesday=9,
            Wednesday=5,
            Thursday=1,
            Friday=2,
            Saturday=4,
            Sunday=3
        }*/
        enum Categories
        {
            Electronics = 1,
            Food = 5,
            Automotive = 6,
            Arts = 10,
            BeautyCare = 11,
            Fashion = 15,
            WomanFashion = 15
        }

        static void Main(string[] args)
        {
            
            Console.WriteLine(WeekDays.Monday); // Monday
            Console.WriteLine(WeekDays.Tuesday); // Tuesday
            Console.WriteLine(WeekDays.Wednesday); // Wednesday
            Console.WriteLine(WeekDays.Thursday); // Thursday
            Console.WriteLine(WeekDays.Friday); // Friday
            Console.WriteLine(WeekDays.Saturday); // Saturday
            Console.WriteLine(WeekDays.Sunday); // Sunday

            Console.WriteLine((int)WeekDays.Monday);
            Console.WriteLine((int)WeekDays.Tuesday);
            Console.WriteLine((int)WeekDays.Wednesday);
            Console.WriteLine((int)WeekDays.Thursday);
            Console.WriteLine((int)WeekDays.Friday);
            Console.WriteLine((int)WeekDays.Saturday);
            Console.WriteLine((int)WeekDays.Sunday);

            string[] values = Enum.GetNames(typeof(Categories));
            foreach (string s in values)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();
            int[] n = (int[])Enum.GetValues(typeof(Categories));
            foreach (int x in n)
            {
                Console.WriteLine(x);
            }    
        }
    }
}
