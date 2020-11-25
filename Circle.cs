using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;

namespace csharp_intro
{
    class Circle
    {

        public double r { get; set; }
        public double enviroment()
        {
            double env;

            env = 2 * Math.PI * r;
            return env;
        }

        public double area()
        {
            double area;
            area = Math.PI * Math.Pow(r, 2);
            return area;
        }




    }
}
