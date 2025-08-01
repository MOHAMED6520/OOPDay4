using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDay4.Operator_Overloading
{
    internal class complex
    {
        public int Real { get; set; }
        public int Imag { get; set; }

        public override string ToString()
        {
            return $"{Real} + {Imag}i";
        }

        public static complex operator +(complex a, complex b)
        {
            return new complex()
            {
                Real = (a?.Real ?? 0) + (b?.Real ?? 0),
                Imag = (a?.Imag ?? 0) + (b?.Imag ?? 0)
            };
        }

        public static complex operator -(complex a, complex b)
        {
            return new complex()
            {
                Real = (a?.Real ?? 0) - (b?.Real ?? 0),
                Imag = (a?.Imag ?? 0) - (b?.Imag ?? 0)
            };

        }

        public static complex operator ++(complex c)
        { 
           c.Real++;
            return c;
        }

        public static complex operator --(complex c)
        {
            c.Real--;
            return c;
        }

    }
}
