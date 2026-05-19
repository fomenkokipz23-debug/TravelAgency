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
            Console.WriteLine("=== Тестування СР №3: Поліморфізм (Override vs New) ===\n");

            List<TravelService> cart = new List<TravelService>
            {
                new HotelService("Готель 'Буковель Слоуп'", 1500, 3), 
                new FlightService("Київ - Варшава", 2000, true)     
            };

            foreach (var service in cart)
            {
                Console.WriteLine($"--- Обробка послуги: {service.Name} ---");
                
                Console.WriteLine($"Розрахована вартість: {service.CalculateCost()} грн.");

                Console.WriteLine(service.GetServiceTypeInfo());
                Console.WriteLine();
            }

            Console.WriteLine("--- Прямий виклик об'єкта FlightService без приведення до базового типу ---");
            FlightService directFlight = new FlightService("Київ - Варшава", 2000, true);
            Console.WriteLine(directFlight.GetServiceTypeInfo());
        }
    }
}