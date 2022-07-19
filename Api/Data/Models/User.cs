using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;
using System.Linq;
using SharpScape.Shared.Dto;
using System.ComponentModel.DataAnnotations.Schema;

namespace SharpScape.Api.Models;

public class User
{
    [Key]
    public int Id { get; set; }

    public string Username { get; set; }

    public string Email { get; set; }
    private string _role = UserRole.User;
    public string Role
    {
        get=>_role;
        set =>_role = typeof(UserRole).GetFields()
            .Any(f => (string)f.GetRawConstantValue() == value)
                ? value
                : throw new Exception("Invalid user role assigned");
    }

    public GameAvatar GameAvatar { get; set; }

    public byte[] PasswordHash { get; set; }

    public byte[] PasswordHmacKey { get; set; }

    public string PasswordSalt { get; set; }

    [Editable(false)]
    [DisplayFormat(DataFormatString = "{0:D}")]
    public DateTime Created { get; set; } = DateTime.Now.ToUniversalTime();

    public string ProfilePicDataUrl {get;set;} = "";
    public User() { }

    public User(string username, string email, string password)
    {
        Username = username;
        Email = email;
        
        PasswordSalt = Convert.ToBase64String(RandomNumberGenerator.GetBytes(32));
        
        CreatePasswordHash(password, PasswordSalt, out byte[] passwordHash, out byte[] passwordHmacKey);
        PasswordHash = passwordHash;
        PasswordHmacKey = passwordHmacKey;
    }
    public User(string username, string email, string password, string role) : this (username,email,password)
    {
        this.Role = role;
    }
    
    private static void CreatePasswordHash(string password, string salt, out byte[] passwordHash, out byte[] passwordSalt)
    {
        using (var hmac = new HMACSHA512())
        {
            passwordSalt = hmac.Key;
            passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password+salt));
        }
    }
}

public static class UserDtoExtensions
{
    public static UserInfoDto FromUser(this UserInfoDto dto, User user)
    {
        dto.Id = user.Id;
        dto.Username = user.Username;
        dto.Email = user.Email;
        dto.Role = user.Role;
        dto.Created = user.Created;
        return dto;
    }
}