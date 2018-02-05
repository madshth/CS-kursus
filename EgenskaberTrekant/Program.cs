using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgenskaberTrekant
{
    class Program
    {
        public class TreKant
        {
            public int Grundlinje { get; private set; }
            public int Højde { get; private set; }

            public TreKant(int grundlinje, int højde)
            {
                this.Grundlinje = grundlinje;
                this.Højde = højde;
            }

            public double Areal
            {
                get
                {
                    return this.Grundlinje * this.Højde * 0.5;
                }
            }

        }
        static void Main(string[] args)
        {


            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }
    }
}
