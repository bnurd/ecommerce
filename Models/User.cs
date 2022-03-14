namespace ecommerce.Models;

public class User : IEntity
{
    public string Username { get; set; } = string.Empty;
    public byte[] PasswordHash { get; set; }
    public byte[] PasswordSalt { get; set; }

    public Role role { get; set; }
}