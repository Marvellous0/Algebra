using System;

namespace Assingment
{
    public class Quiz1
    {
        public static void Quadratic()
        {
            double a;

            double b;

            double c;
            
            double disc;

            double deno;

            double x1;

            double x2;

            Console.WriteLine("Enter The value of A, B, C");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());

            if (a == 0)
            {
                x1 = -c / b;
                Console.WriteLine("Linear Roots: ", x1);
            }
            else
            {
                disc = (b * b) - (4 * a * c);
                deno = 2 * a;

                if (disc > 0)
                {
                    Console.WriteLine("The Roots Is Real");

                    x1 = ((-b / deno) + Math.Sqrt(disc) / deno);
                    x2 = ((-b / deno) + Math.Sqrt(disc) / deno);
                    Console.WriteLine("The Root Are ....." + x1 + "and " + x2);

                }
                else if (disc == 0)
                {
                    Console.WriteLine("Repeated Root");
                    x1 = -b / deno;
                    Console.WriteLine("The Root is...." + x1);

                }
                else
                {
                    Console.WriteLine("The Square Root");
                    x1 = -b / deno;
                    x2 = ((Math.Sqrt((4 * a * c) - (b * b))) / deno);
                    Console.WriteLine("Root1:" + x1 + " OR " + x2);
                    Console.WriteLine("Root2: " + x1 + " OR " + x2);
                    Console.WriteLine("Click Any Key To Return To Main Menu");
                }
                Console.ReadKey();
            }

        }
    }
}