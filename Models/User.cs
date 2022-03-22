namespace ecommerce.Models;

public class User : IEntity
{
    public string Username { get; set; } = string.Empty;
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Mail { get; set; } = string.Empty;
    public string Tel { get; set; } = string.Empty;
    
    public byte[] PasswordHash { get; set; }
    public byte[] PasswordSalt { get; set; }

    public Role role { get; set; }
}