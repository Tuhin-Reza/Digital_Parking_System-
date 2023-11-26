using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your score? : ");
            int score = Convert.ToInt32(Console.ReadLine());

            if (score >= 0 && score <= 49)
            {
                Console.WriteLine("Student Grade F");
            }
            else if (score>=50 && score <=54)
            {
                Console.WriteLine("Student Grade D");
            }
            else if (score>=55 && score<=59)
            {
                Console.WriteLine("Student Grade D+");
            }
            else if (score>=60 && score <=64)
            {
                Console.WriteLine("Student Grade C");
            }
            else if (score >=65 && score <=69)
            {
                Console.WriteLine("Student Grade C+");
            }
            else if (score>=70 && score <=74)
            {
                Console.WriteLine("Student Grade C");
            }
            else if (score>=75 && score <=79)
            {
                Console.WriteLine("Student Grade B");
            }
            else if (score>=80 && score <=84)
            {
                Console.WriteLine("Student Grade B+ ");
            }
            else if (score>=85 && score<=89)
            {
                Console.WriteLine("Student Grade A");
            }
            else if (score>=90 && score <=100)
            {
                Console.WriteLine("Student Grade A+");
            }
            else
            {
                Console.WriteLine("Wrong Number");
            }
            Console.ReadKey();

        }
    }
}
