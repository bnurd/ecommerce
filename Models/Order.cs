namespace ecommerce.Models;
public class Order : IEntity
{
    public int Id { get; set; }
    public DateTime Date { get; set; }
    public OrderState State { get; set; }

    public string CustomerNote { get; set; }

    public int AddressId { get; set; }
    public Address Address { get; set; }

    public double Price { get; set; }
    
    public int UserId { get; set; }
    public User User { get; set; }


    public List<Product> Products { get; set; }
}