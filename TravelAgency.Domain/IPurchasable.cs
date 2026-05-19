namespace TravelAgency.Domain
{
    public interface IPurchasable
    {
        string GetDescription();
        decimal GetPrice();
    }
}