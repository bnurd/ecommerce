namespace ecommerce.Models;
public class MiniOrder : IEntity
{
    public int Id { get; set; }
    public double Price { get; set; }

    public Product Product { get; set; }
    public int Count { get; set; }
}