namespace ecommerce.Models;
public class Card : IEntity
{
    public int Id { get; set; }

    public int ProductId { get; set; }
    public Product Product { get; set; }
}