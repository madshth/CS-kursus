using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionKort
{
    class Program
    {
        static void Main(string[] args)
        {
            Bunke b = new Bunke();
            b.TilføjKort(new Kort() { Kulør = "Spar", Værdi = 2 });
            b.TilføjKort(new Kort() { Kulør = "Hjerter", Værdi = 14 });
            b.TilføjKort(new Kort() { Kulør = "Ruder", Værdi = 3 });
            b.TilføjKort(new Kort() { Kulør = "Kløver", Værdi = 10 });



            var k = b.FjernKort();
            Console.WriteLine();
            Console.WriteLine(k);
            Console.WriteLine();



            b.Vis();


            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }
    }
    public class Kort
    {
        public string Kulør { get; set; }
        public int Værdi { get; set; }
        public override string ToString()
        {
            return this.Kulør + " " + this.Værdi;
        }
    }
    public class Bunke
    {
        private Stack<Kort> bunke = new Stack<Kort>();

        public void TilføjKort(Kort k)
        {
            bunke.Push(k);
        }


        public Kort FjernKort()
        {
            if (bunke.Count > 5)
                return bunke.Pop();
            return null;
        }
        
        public void Vis()
        {
            foreach (var item in bunke)
            {
                Console.WriteLine(item);
            }

        }
    }


}

