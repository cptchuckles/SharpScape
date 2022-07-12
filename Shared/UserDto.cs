using System.ComponentModel.DataAnnotations;

namespace SharpScape.Shared.Dto;

public static class UserRole
{
    public const string Admin = "Admin";
    public const string User = "User";
}

public class UserInfoDto
{
    public int Id { get; set; } 

    public string Username { get; set; }

    public string Email { get; set; }

    public string Role { get; set; }

    public DateTime Created { get; set; }
    public string ProfilePicDataUrl {get;set;}
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
public class UserEditDto
{
    public string Username { get; set; }

    public string Email { get; set; }

    public string Password { get; set; }
    public string NewPassword { get; set; }
    public string ProfilePicDataUrl { get; set; }
}
public class UserRoleDto
{
    public string Role { get; set; }
}
public class UserLoginDto
{
    [Required]
    public string Username { get; set; }

    [Required]
    public string Password { get; set; }
}
public class UserLoginResponseDto
{
    public int Id { get; set; }

    public string Username { get; set; }
    public string accessToken {get;set;}
}