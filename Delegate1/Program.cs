using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int res = Beregner(1, 4, Plus);
            //res = Beregner(1, 2, Minus);
            //res = Beregner(2, 8, Gange);
            int res2 = Beregner(10, 2, Gange);
            //res2 = Beregner(20, 2, Divider);
            Console.WriteLine(res+res2);


            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }


        }

        public static int Beregner(int a, int b, Func<int,int,int> funktion)
        {
            return funktion(a, b);
        }
        public static int Plus(int a, int b)
        {
            return a + b;
        }
        public static int Minus(int a, int b)
        {
            return a - b;
        }
        public static int Divider(int a, int b)
        {
            return a / b;
        }
        public static int Gange(int a, int b)
        {
            return a * b;
        }

    }
}
