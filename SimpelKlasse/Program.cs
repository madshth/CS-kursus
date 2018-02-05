using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpelKlasse
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.Efternavn = "cronberg";
            p1.Fornavn = "mikkel";
            p1.Fødselsår = 2003;
            Console.WriteLine(p1.FuldtNavn());
            Console.WriteLine(p1.EstimeretAlder());


            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }

        class Person
        {
            public string Fornavn;
            public string Efternavn;
            public int Fødselsår;

            public string FuldtNavn()
            {
                return $"{Fornavn} {Efternavn}";   
            }

            public int EstimeretAlder()
            {
                int år = DateTime.Now.Year;
                return år - this.Fødselsår;
            }

            public Person()
            {
                this.Fornavn = "";
                this.Efternavn = "";
            }

            public Person(string fornavn, string efternavn, int fødselsår)
            {
                this.Fødselsår = fødselsår;
                this.Fornavn = fornavn.ToUpper();
                this.Efternavn = efternavn.ToUpper();
            }

        }
    }
}
