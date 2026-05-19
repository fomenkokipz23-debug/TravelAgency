namespace TravelAgency.Domain
{
    public class FlightService : TravelService
    {
        public bool IsRoundTrip { get; private set; }

        public FlightService(string name, decimal ticketPrice, bool isRoundTrip) 
            : base(name, ticketPrice)
        {
            IsRoundTrip = isRoundTrip;
        }

        public override decimal CalculateCost()
        {
            return IsRoundTrip ? BasePrice * 2 : BasePrice;
        }

        public new string GetServiceTypeInfo()
        {
            return $"[Прихований тип з 'new'] Це авіапереліт: {Name} (Туди-назад: {IsRoundTrip})";
        }
    }
}