using System;
using System.Collections.Generic;
using TravelAgency.Domain;

namespace TravelAgency.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("=== Тестування СР №5: Generics та Делегати ===\n");

            // Створюємо репозиторій суто для Турів
            Repository<Tour> tourRepository = new Repository<Tour>();

            // Додаємо кілька турів
            Tour t1 = new Tour("Бюджетний Львів", 1500);
            Tour t2 = new Tour("Елітний Вікенд в Одесі", 6000);
            Tour t3 = new Tour("Гірський відпочинок", 4000);

            tourRepository.Add(t1);
            tourRepository.Add(t2);
            tourRepository.Add(t3);

            // 1. Тестуємо ForEach з делегатом Action<T> (виводимо початкові ціни)
            Console.WriteLine("--- Список усіх турів (через ForEach): ---");
            tourRepository.ForEach(tour => Console.WriteLine($"Тур: {tour.Title}, Ціна: {tour.TotalPrice} грн"));

            // 2. Тестуємо Filter з делегатом Func<T, bool> (шукаємо тури дорожчі за 3000 грн)
            Console.WriteLine("\n--- Фільтрація турів (Ціна > 3000 грн): ---");
            List<Tour> expensiveTours = tourRepository.Filter(tour => tour.TotalPrice > 3000);

            foreach (var tour in expensiveTours)
            {
                Console.WriteLine($"[Знайдено] {tour.Title} — {tour.TotalPrice} грн.");
            }
        }
    }
}