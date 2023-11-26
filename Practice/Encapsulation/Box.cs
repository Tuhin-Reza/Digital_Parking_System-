using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Box
    {
        //public double length;
        //public double breadth;
        //public double height;

        private double length;
        private double breadth;
        private double height;

        public void setLength(double len)
        {
            length = len;
        }
        public void setBreadth(double bre)
        {
            breadth = bre;
        }
        public void setHeight(double hei)
        {
            height = hei;
        }

        public double getVolume()
        {
            return length * height * breadth;
        }

    }
}
