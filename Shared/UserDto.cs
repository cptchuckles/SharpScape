using System.ComponentModel.DataAnnotations;

namespace SharpScape.Shared.Dto;

public record class UserInfoDto
{
    public Guid Id { get; }

    public string Username { get; }

    public string Email { get; }

    public DateTime Created { get; }
}

public class UserRegisterDto
{
    [Required]
    public string Username { get; set; }

    [Required]
    [EmailAddress]
    public string Email { get; set; }

    [Required]
    [MinLength(8)]
    public string Password { get; set; }
}

public class UserLoginDto
{
    [Required]
    public string Username { get; set; }

    [Required]
    public string Password { get; set; }
}