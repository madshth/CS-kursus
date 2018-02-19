using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> lst1 = new List<Person>();
            lst1.Add(new Person() { Id = 1, Navn = "M" });
            lst1.Add(new Person() { Id = 2, Navn = "T" });
            lst1.Add(new Person() { Id = 3, Navn = "P" });
            foreach (var item in lst1)
            {
                Console.WriteLine(item.Navn);
            }

            Dictionary<int, Person> lst2 = new Dictionary<int, Person>();
            lst2.Add(1, new Person() { Id = 1, Navn = "M" });
            lst2.Add(2, new Person() { Id = 2, Navn = "T" });
            lst2.Add(3, new Person() { Id = 3, Navn = "P" });
            var p = lst2[3];
            Console.WriteLine(p.Navn);

            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }
    }
    class Person
    {
        public int Id { get; set; }
        public string Navn { get; set; }
    }
}
