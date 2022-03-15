namespace ecommerce.Models;

public class File : IEntity
{
    public int Id { get; set; }
    public string Path { get; set; }
    public DateTime Generated { get; set; }
    public DateTime Modified { get; set; }

    public Product Product { get; set; }
}
