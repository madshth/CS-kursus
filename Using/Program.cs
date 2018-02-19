using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Test_Using
{
    
    class Program
    {

    }
        

        // Oppgave Using fungeret ikke.
        using (StreamReader stream = System.IO.File.OpenText("dyrenavne.txt"))
        {
            while (stream.Peek() != -1)
            {
                var l = stream.ReadLine();
                Console.WriteLine(l.ToUpper());

            }
       
