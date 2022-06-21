using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;

namespace SharpScape.Api.Models;

public class User
{
    [Key]
    public Guid Id { get; set; } = Guid.NewGuid();

    public string Username { get; set; }

    public string Email { get; set; }

    public byte[] PasswordHash { get; set; }

    public byte[] PasswordSalt { get; set; }

    [Editable(false)]
    [DisplayFormat(DataFormatString = "{0:D}")]
    public DateTime Created { get; set; } = DateTime.Now.ToUniversalTime();

    public User() { }

    public User(string username, string email, string password)
    {
        Username = username;
        Email = email;

        CreatePasswordHash(password, out byte[] passwordHash, out byte[] passwordSalt);
        PasswordHash = passwordHash;
        PasswordSalt = passwordSalt;
    }

    private static void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
    {
        using (var hmac = new HMACSHA512())
        {
            passwordSalt = hmac.Key;
            passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
        }
    }
}