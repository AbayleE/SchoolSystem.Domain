namespace SchoolSystem.Domain.ValueObjects;
public class Address
{
    public string? Region { get; set; }
    public string? City { get; set; }
    public string? SubCity { get; set; }
    public string? Woreda { get; set; }
    public string? HouseNumber { get; set; }
    
    private Address() { }

    public Address(string region, string city, string subCity, string woreda, string houseNumber)
    {
        this.Region = region;   
        this.City = city;
        this.SubCity = subCity;
        this.Woreda = woreda;
        this.HouseNumber = houseNumber;
    }
}