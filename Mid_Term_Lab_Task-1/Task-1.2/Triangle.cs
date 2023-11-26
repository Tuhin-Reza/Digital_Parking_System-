﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1._2
{
    class Triangle
    {
        int x;
        int y;
        int z;
        public void setx(int newx)
        {
            x = newx;
        }
        public void sety(int newy)
        {
            y = newy;
        }
        public void setz(int newdz)
        {
            z = newdz;
        }
        public int getx()
        {
            return x;
        }
        public int gety()
        {
            return y;
        }
        public int getz()
        {
            return z;
        }
        public int TestTriangle()
        {
            if (x == y || y == z || z == x)
            {
                return 1;
            }
            else if (x == y && y == z)
            {
                return 2;
            }
            else
            {
                return 3;
            }
        }
        public void ShowInfo()
        {
            Console.WriteLine("\n---------Triangle Information---------");
            if (1 == TestTriangle())
            {
                Console.WriteLine("\n Triangle is Equilateral");
            }
            else if (2 == TestTriangle())
            {
                Console.WriteLine("\n Triangle is Isosceles ");
            }
            else
            {
                Console.WriteLine("\n Triangle is scalene ");
            }
        }
    }
}
