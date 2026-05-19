using System;

namespace TravelAgency.Domain
{
    public class BookingService : IBookingService
    {
        public void Book(Customer customer, IPurchasable item)
        {
            if (customer == null) throw new ArgumentNullException(nameof(customer));
            if (item == null) throw new ArgumentNullException(nameof(item));

            Console.WriteLine($"[Booking] Оформлення для клієнта: {customer.Name}");
            Console.WriteLine($"Опис товару: {item.GetDescription()}");
            Console.WriteLine($"Кінцева ціна: {item.GetPrice()} грн.");
            Console.WriteLine($"[Статус] Бронювання успішно зафіксовано!\n");
        }
    }
}