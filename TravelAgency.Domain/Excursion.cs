using System;

namespace TravelAgency.Domain
{
    public class Excursion
    {
        public string Title { get; private set; }
        public decimal Price { get; private set; }

        public Excursion(string title, decimal price)
        {
            if (string.IsNullOrWhiteSpace(title)) 
                throw new ArgumentException("Назва екскурсії не може бути порожньою.");
            if (price < 0) 
                throw new ArgumentException("Ціна екскурсії не може бути меншою за 0.");

            Title = title;
            Price = price;
        }
    }
}