using System;
using TravelAgency.Domain;

namespace TravelAgency.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("=== Тестування СР №2: Інкапсуляція та Оператори ===\n");

            Tour tour1 = new Tour("Вікенд у Карпатах", 3000);
            Tour tour2 = new Tour("Релакс у Закарпатті", 4500);

            Excursion climb = new Excursion("Сходження на Говерлу", 1000);
            Excursion thermal = new Excursion("Термальні басейни Косино", 500);

            tour1 = tour1 + climb;   
            tour1 = tour1 + thermal; 

            Console.WriteLine($"\nПовна вартість {tour1.Title}: {tour1.TotalPrice} грн");
            Console.WriteLine($"Повна вартість {tour2.Title}: {tour2.TotalPrice} грн");

            Console.WriteLine($"\nПерша екскурсія в {tour1.Title}: {tour1[0].Title}");

            Console.WriteLine("\n--- Перевірка рівності цін турів ---");
            if (tour1 == tour2)
            {
                Console.WriteLine("Тури коштують однаково!");
            }
            else
            {
                Console.WriteLine("Ціни турів відрізняються.");
            }
        }
    }
}