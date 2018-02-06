﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgenskaberVare
{
    public class Vare
    {
        public Vare()
        {
        }
        public Vare(string navn, double pris)
        {
            this.Pris = pris;
            this.Navn = navn;
        }

        private string navn;

        public string Navn
        {
            get {
                Console.WriteLine("Nu aflæses navn");
                return navn;
            }
            set {
                Console.WriteLine("Nu tildeles navn");
                navn = value;
            }
        }

        public string VisNavn()
        {
            return this.navn;
        }

        private double pris;

        public double Pris
        {
            get {
                Console.WriteLine("Nu aflæses pris");
                return pris;
            }
            set {
                Console.WriteLine("Nu tildeles pris");
                pris = value;
            }
        }

        public double PrisMedMoms()
        {
            return this.pris * 1.25;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Vare v = new Vare();
            v.Navn = "Vare #1";
            Console.WriteLine(v.VisNavn());
            v.Pris = 100;
            Console.WriteLine(v.PrisMedMoms());
            Vare v2 = new Vare();
            v2.Navn = "Vare #2";
            Console.WriteLine(v2.VisNavn());
            v2.Pris = 200;
            Console.WriteLine(v2.PrisMedMoms());



            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }
    }
}
