using System;
using System.Collections.Generic;

namespace TravelAgency.Domain
{
    // Додали спадкування від інтерфейсу IPurchasable
    public class Tour : IPurchasable
    {
        private string _title;
        private decimal _basePrice;
        private List<Excursion> _excursions = new List<Excursion>();

        public string Id { get; private set; }

        public string Title
        {
            get => _title;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Назва туру не може бути порожньою.");
                _title = value;
            }
        }

        public decimal BasePrice
        {
            get => _basePrice;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Базова ціна туру не може бути від'ємною.");
                _basePrice = value;
            }
        }

        public decimal TotalPrice
        {
            get
            {
                decimal total = BasePrice;
                foreach (var exc in _excursions)
                {
                    total += exc.Price;
                }
                return total;
            }
        }

        public Tour(string title, decimal basePrice)
        {
            Id = Guid.NewGuid().ToString().Substring(0, 8); 
            Title = title;
            BasePrice = basePrice;
        }

        public Excursion this[int index]
        {
            get
            {
                if (index < 0 || index >= _excursions.Count)
                    throw new IndexOutOfRangeException("Ескурсії за таким індексом не існує.");
                return _excursions[index];
            }
        }

        public int ExcursionsCount => _excursions.Count;

        public static Tour operator + (Tour tour, Excursion excursion)
        {
            if (tour == null) throw new ArgumentNullException(nameof(tour));
            if (excursion == null) throw new ArgumentNullException(nameof(excursion));

            tour._excursions.Add(excursion);
            Console.WriteLine($"[Operator +] До туру '{tour.Title}' додано екскурсію: {excursion.Title} (+{excursion.Price} грн)");
            return tour;
        }

        public static bool operator == (Tour left, Tour right)
        {
            if (ReferenceEquals(left, right)) return true;
            if (left is null || right is null) return false;
            return left.TotalPrice == right.TotalPrice;
        }

        public static bool operator != (Tour left, Tour right)
        {
            return !(left == right);
        }

        public override bool Equals(object obj)
        {
            if (obj is Tour otherTour)
            {
                return this == otherTour;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return TotalPrice.GetHashCode();
        }

        // --- РЕАЛІЗАЦІЯ ІНТЕРФЕЙСУ IPurchasable ---
        public string GetDescription()
        {
            return $"[Тур] '{Title}' (Включено екскурсій: {ExcursionsCount})";
        }

        public decimal GetPrice()
        {
            return TotalPrice;
        }
    }
}