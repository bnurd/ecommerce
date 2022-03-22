namespace ecommerce.Models;

public class Address : IEntity
{
    public int CityId { get; set; }
    public String Detail { get; set; }
    
    public string Tel { get; set; }

    public User User { get; set; }
    public int UserId { get; set; }
}