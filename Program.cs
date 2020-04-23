using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
       

    class Program
    {


        class Class1
        {
            public void About1()
            {
                Console.WriteLine("Class 1");
            }
        }

        class Class2
        {
            public void About2()
            {

                Console.WriteLine("Class 2");
            }
        }




        delegate void SampleDelegate(string m);
        delegate void SDelegate();
        delegate void PrintMas(int[,] mas);

        static void f1(string mes)
        {
            Console.WriteLine("f1 + " + mes);
        }

        static void f2(string mes)
        {
            Console.WriteLine("f2 + " + mes );
        }


        static void Main(string[] args)
        {
            //  f1("Hello");
            //  f2("Привет");

            //SampleDelegate d;

            //d = f1;
            //d += f2;
            //d += f1;
            //d += f2;
            //d("Hello");

            //d -= f2;
            //d("Привет");


            //Class1 c1 = new Class1();
            //Class2 c2 = new Class2();
            //SDelegate d;

            //d = c1.About1;
            //d += c2.About2;
            //d();


            int[,] a = { { 1, 2 }, { 2, 4 }, { 5, 6 }, { 2, 4 }, { 2, 5 } };

   
            int[,] b = { { 1, 2, 3 }, { 2, 4, 2 }, { 5, 6, 6 } };
                       

            PrintMas PrMas = delegate (int[,] mas)
            {
                for (int i = 0; i < mas.GetLength(0); i++)
                {
                    for (int j = 0; j < mas.GetLength(1); j++)
                        Console.Write(mas[i, j] + " ");
                    Console.WriteLine();
                }
                Console.WriteLine();
            };
            PrMas(a);
            PrMas(b);


        }
    }
}