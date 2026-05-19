using System;

namespace TravelAgency.Domain
{
    // Додали спадкування від інтерфейсу IPurchasable
    public abstract class TravelService : IPurchasable
    {
        public string Name { get; protected set; }
        public decimal BasePrice { get; protected set; }

        protected TravelService(string name, decimal basePrice)
        {
            Name = name;
            BasePrice = basePrice;
        }

        public virtual decimal CalculateCost()
        {
            return BasePrice;
        }

        public string GetServiceTypeInfo()
        {
            return $"[Базовий тип] Це загальна туристична послуга: {Name}";
        }

        // --- РЕАЛІЗАЦІЯ ІНТЕРФЕЙСУ IPurchasable ---
        public string GetDescription()
        {
            return $"[Послуга] {Name}";
        }

        public decimal GetPrice()
        {
            return CalculateCost(); // Викличеться правильний (overridden) метод нащадка
        }
    }
}