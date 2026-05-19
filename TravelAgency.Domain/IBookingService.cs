namespace TravelAgency.Domain
{
    public interface IBookingService
    {
        void Book(Customer customer, IPurchasable item);
    }
}