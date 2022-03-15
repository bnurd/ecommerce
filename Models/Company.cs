namespace ecommerce.Models;
public class Company : IEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Subtitle { get; set; }
    public string Detail { get; set; }
    public string Mail { get; set; }

    public string LogoPath { get; set; }

}