using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> Kredi = new Dictionary<int, string>();

            Kredi.Add(1, "TuketiciKredisi");
            Kredi.Add(2, "Taşıt Kredisi");
            Kredi.Add(3, "Otomobil Kredisi");
            Kredi.Add(4, " Tatil Kredisi");

            Console.WriteLine("1-4 arasında Bir Rakam Giriniz");
            int No = int.Parse(Console.ReadLine());

            try
            {
                Console.WriteLine(Kredi[No]);
            }
            catch 
            {

                Console.WriteLine("Kredi Bulunamadı");
                Console.WriteLine("Yanlış Bir Numara Girdiniz");
            }

            Dictionary<int, string> Renkler = new Dictionary<int, string>();

            Renkler.Add(1, "red");
            Renkler.Add(2, "pink");
            Renkler.Add(3, "orange");
            Renkler.Add(4, "blue");

            

            Console.WriteLine("1-4 Arasında Bir Sayı Giriniz");
            int No1 = int.Parse(Console.ReadLine());

            try
            {
                Console.WriteLine(Renkler [No1]);
            }
            catch (Exception)
            {

                Console.WriteLine( "Aradığınız Renk Bulunamadı");
                Console.WriteLine(  " yanlış bir sayı girdiniz");
            }


            Dictionary<string, int> Alphabet = new Dictionary<string, int>();

            Alphabet.Add("a", 1);
            Alphabet.Add("b", 2);
            Alphabet.Add("c", 3);
            Alphabet.Add("ç", 4);
            Alphabet.Add("d", 5);

            Console.WriteLine("a-d arasında bir harf giriniz");
            string harf = Console.ReadLine();

            try
            {
                Console.WriteLine("alfabenin" + " "  + Alphabet[harf] + "." + " " + "harfini girdiniz");
            }
            catch 
            {

                Console.WriteLine("aradığınız harf bulunamadı");
                Console.WriteLine("yanlış bir harf girdiniz" );
            }








        }
    }
}
