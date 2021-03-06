﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrukInterface1
{
    class Program
    {
        static void Main(string[] args)
        {
            IDbFunktioner[] array = new IDbFunktioner[4];
            array[0] = new Hund();
            array[1] = new Ubåd();
            array[2] = new Hund();
            array[3] = new Ubåd();
            foreach (var item in array)
            {
                item.Gem();
            }
            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }

        }
    }
    interface IDbFunktioner
    {
        void Gem();
    }

    class Hund : IDbFunktioner
    {
        public string Navn { get; set; }
        public void Gem()
        {
            Console.WriteLine("Gemmer Hund...");
        }
    }

    class Ubåd : IDbFunktioner
    {
        public int Nummer { get; set; }
        public double Tubine { get; set; }
        public void Gem()
        {
            Console.WriteLine("Gemmer Ubåd...");
        }
    }
}

