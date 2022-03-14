using System.Security.Cryptography;

namespace ecommerce.Utils;

interface IPasswordCryptionService
{
    bool ValidatePassword(string password, byte[] passwordSalt, byte[] passwordHash);
    void GeneratePassword(string password, out byte[] passwordSalt, out byte[] passwordHash);
}

class PasswordCryptionService : IPasswordCryptionService
{
    public void GeneratePassword(string password, out byte[] passwordSalt, out byte[] passwordHash)
    {
        using (var hmac = new HMACSHA512())
        {
            passwordSalt = hmac.Key;
            passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
        }
    }

    public bool ValidatePassword(string password, byte[] passwordSalt, byte[] passwordHash)
    {
        using (var hmac = new HMACSHA512(passwordSalt))
        {
            var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));

            return computedHash.SequenceEqual(passwordHash);
        }
    }
}