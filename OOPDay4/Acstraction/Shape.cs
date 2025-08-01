using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDay4.Acstraction
{
    internal abstract class Shape
    {
        public double Dim01 { get; set; }
        public double Dim02 { get; set; }

        public abstract double GetArea();
        public abstract double perimeter { get; }

        public void Print ()
        {
            Console.WriteLine("Hello World");
        }


    }
}
