namespace ecommerce.Models;

public class Category : IEntity
{

    public int Id { get; set; }
    public String Title { get; set; }

    public List<Product> Products { get; set; }

}