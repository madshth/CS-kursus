using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            string fornavn = "Mikkel";
            string efternavn = "Cronberg";
            string samletNavn = fornavn + " " + efternavn;
            Console.WriteLine(samletNavn);
            string navnStort = samletNavn.ToUpper();
            Console.WriteLine(navnStort);
            string navnLille = samletNavn.ToLower();
            Console.WriteLine(navnLille);
            string del = samletNavn.Substring(7, 4);
            Console.WriteLine(del);
            string[] navne = samletNavn.Split(' ');
            for (int i = 0; i < navne.Length; i++)
            {
                Console.WriteLine(navne[i]);
            }

            Console.WriteLine(fornavn + "\r\n\t" + efternavn);
            //System.IO.File.WriteAllText("c:\\temp\\test\\.txt", samletNavn);
            //System.IO.File.
            //System.IO.File.o
            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }






        }
    }
}
