namespace ecommerce.Models;

public class Option : IEntity
{
    public int Id { get; set; }
    public string Title { get; set; }
    public List<Value> Values { get; set; }
}

// PRODUCT OPTION VALUE COUNTS