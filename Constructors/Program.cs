using System;

namespace Constructors
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.FistName = "Veysel";
            customer1.LastName = "Yılmaz";
            customer1.Id = 45455;
            customer1.City = "Isparta";


            Customer customer3 = new Customer() { FistName = "Ayşe", LastName = "Yılmaz", Id = 454, City = "Eskişehir" };



            Customer customer2 = new Customer( 23, "Ali", "Yılmaz ","İstanbul");

            Console.WriteLine(customer2.City);
            Console.WriteLine(customer1.FistName);
            Console.WriteLine(customer3.Id);

        }
    }
}
