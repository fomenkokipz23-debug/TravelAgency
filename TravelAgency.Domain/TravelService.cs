using System;

namespace TravelAgency.Domain
{
    public abstract class TravelService
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
    }
}