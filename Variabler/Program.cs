using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variabler
{
    class Program
    {
        static void Main(string[] args)
        {

            int heltal = 10;
            heltal++;
            heltal--;
            heltal += 20;
            Console.WriteLine(heltal);

            double kommatal = 12.5;
            kommatal *= 2;
            Console.WriteLine(kommatal);

            Filtyper ft = Filtyper.csv;
            Console.WriteLine(ft);
            Console.WriteLine((int)ft);

            if (true)
            {
                 
                //beskjed 1 = Filtyper.csv;
                Console.WriteLine("Filtypen er ok = CSV");
            }
            else
            {
                //ft = Filtyper.pdf;
                Console.WriteLine("Filtypen er IKKE ok");
            }


            DateTime dato = DateTime.Now;
            Console.WriteLine(dato.ToString("ddMMyyyy"));
            Console.WriteLine(dato.ToString("d-M-y"));
            Console.WriteLine(dato.ToLongDateString());

            Person p;
            p.id = 1;
            p.navn = "Mikkel";
            Console.WriteLine(p.navn);

            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }

        }
    }
public struct Person
    {
        public int id;
        public string navn;

    }
public enum Filtyper
    {
        pdf,
        txt,
        csv
    }
}
