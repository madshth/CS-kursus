using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerningApp1
{
    public class Terning
    {

        public int Værdi;
        private static Random rnd = new Random();


        // Default
        public Terning()
        {
            //this.Værdi = 1;
            this.Ryst(); //tilfældig væerdi
        }

        // Custom
        public Terning(int værdi)
        {
            this.Værdi = værdi;
            // this.Ryst(); //tilfældig væerdi
        }

        public void Skriv()
        {
            Console.WriteLine("[" + this.Værdi + "]");

        }
        public void Ryst()
        {
            this.Værdi = rnd.Next(1, 7);
        }

        public void Ryst(bool snyd)
        {
            if (snyd)
            {
                this.Værdi = 6;
            }
            else
            {
                Ryst();
            }

        }
    }
    public class Bæger
    {
        private Terning[] terninger = new Terning[5];

        public Bæger()
        {
            for (int i = 0; i < 5; i++)
            {
                terninger[i] = new Terning();
            }

  


        }
        public void Skriv()
        {
            Console.WriteLine("Bæger ----");
            for (int i = 0; i < 5; i++)
            {
                terninger[i].Skriv();
               
            }
        }

    }







}
