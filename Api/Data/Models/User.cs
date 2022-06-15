using System.ComponentModel.DataAnnotations;

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
    public DateTime Created { get; set; } = DateTime.Now;
}