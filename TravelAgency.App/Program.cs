using System;
using TravelAgency.Domain;

namespace TravelAgency.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("=== Старт програми ===\n");

            using (Customer customer1 = new Customer("Катерина", "kateryna@example.com"))
            {
                Customer customerClone = new Customer(customer1);
                Console.WriteLine($"Оригінал: {customer1.Name}, Клон: {customerClone.Name}");
            } 

            Console.WriteLine("\n=== Кінець програми ===");
        }
    }
}