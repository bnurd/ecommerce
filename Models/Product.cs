namespace ecommerce.Models;

public class Product : IEntity
{

    public int Id { get; set; }
    public String Title { get; set; }

    public double Price { get; set; }
    public Currency Currency { get; set; }

    public int CategoryId { get; set; }
    public Category Category { get; set; }

    public List<Order> Orders { get; set; } // many to many

}