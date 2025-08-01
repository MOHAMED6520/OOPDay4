using OOPDay4.Acstraction;
using OOPDay4.Operator_Overloading;
using System.Numerics;

namespace OOPDay4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Abstraction
            /////*Abstraction*/

            ////Shape shape = new Shape(); //Invalid
            //Rectangle r = new Rectangle() { Dim01 = 5, Dim02 = 3 };
            //Console.WriteLine(r.perimeter);
            //Console.WriteLine(r.GetArea());

            //Square square = new Square() { Dim01 = 2, Dim02 = 5 };

            //Console.WriteLine(square.perimeter);
            //Console.WriteLine(square.GetArea()); 
            #endregion

            #region Operator Overloading
            // //Operator Overloading

            // //int x = 3+4 ;
            // //string y = "Hello " + "World";

            //complex C01 =new complex() { Real =5 , Imag =2 };
            //complex C02 =new complex() { Real =3 , Imag =4 };

            // Console.WriteLine(C01);
            // Console.WriteLine(C02);

            // complex C03 =C01+C02 ;
            // Console.WriteLine(C03);

            //  C03 = C01 - C02;
            // Console.WriteLine(C03); 
            #endregion

            #region Unary Operator
            ////Unary Operator 
            //complex C01 =new complex() { Real =5 , Imag =2 };
            ////Console.WriteLine(C01++);
            //Console.WriteLine(C01--); 
            #endregion

            #region Comparison Operator

            // Comparison Operator
            ////complex C01 = new complex() { Real = 5, Imag = 2 };
            ////complex C02 = new complex() { Real = 3, Imag = 4 };

            ////if (C01>=C02)
            ////{
            ////    Console.WriteLine("C01 Grater Than C02");
            ////}
            ////else
            ////{
            ////    Console.WriteLine("C01 Is Not Grater Than C02");
            ////} 
            #endregion


            #region Casting Operator
            //Casting Operator
            //complex c01 = new complex() { Real = 1  , Imag = 2};

            //string s = (string) c01;
            //Console.WriteLine(s);

            //int x =(int) c01;
            //Console.WriteLine(x);
            //int x = new complex() { Real = 1 ,Imag = 2}; 
            #endregion
        }
    }
}
