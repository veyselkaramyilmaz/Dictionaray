using Generics;
using System;
using System.Collections.Generic;

namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Sehirler = new List<string>();
            Sehirler.Add("Ankara");
            Console.WriteLine(Sehirler.Count);
            

            MyList<string> Sehirler2 = new MyList<string>();
            Sehirler2.Add(" Ankara");
            Console.WriteLine(Sehirler2.Count);

            




        }
    }
}
