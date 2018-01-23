using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] månedsløn = { 10000, 20000, 15000, 20000, 30000, 45000 };
            double sum = 0;
            double sumbonus = 0;

            for (int i = 0; i < månedsløn.Length; i++)
            {
                sum += månedsløn[i];
            }
            double gns = sum / månedsløn.Length;

            for (int i = 0; i < månedsløn.Length; i++)
            {
                Console.WriteLine(månedsløn[i]);
            }
            Console.WriteLine("Gennemsnit løn " + gns.ToString("N2"));

            int[] bonus = { 500, 1000, 1500, 2000 };
            for (int i = 0; i < bonus.Length; i++)
            {
                sumbonus += bonus[i]+månedsløn[i];
            }
            double gnsbonus = sumbonus / bonus.Length;

            for (int i = 0; i < bonus.Length; i++)
            {
                Console.WriteLine(bonus[i]);
            }
            Console.WriteLine("Gennemsnit bonus " + gnsbonus.ToString("N2"));

            double forskat = gns + gnsbonus;
            double sumutbetalt = forskat * 0.80;


            
            Console.WriteLine("Udbetalt " + sumutbetalt.ToString("N2"));






            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }



        }
    }
}
