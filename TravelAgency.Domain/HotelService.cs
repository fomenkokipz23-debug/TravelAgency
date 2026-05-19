namespace TravelAgency.Domain
{
    public class HotelService : TravelService
    {
        public int Nights { get; private set; }

        public HotelService(string name, decimal pricePerNight, int nights) 
            : base(name, pricePerNight)
        {
            Nights = nights;
        }

        public override decimal CalculateCost()
        {
            return BasePrice * Nights;
        }
    }
}