using System.ComponentModel.DataAnnotations;

namespace SharpScape.Shared.Dto;

public class UserInfoDto
{
    public int Id { get; set; }

    public string Username { get; set; }

    public string Email { get; set; }

    public DateTime Created { get; set; }
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