using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SharpScape.Api.Models;

public class GameAvatar
{
    [Key]
    public int Id { get; set; }
    [JsonIgnore]
    public User User { get; set; }
    [ForeignKey("User")]
    public int UserId { get; set; }
    public string SpriteName { get; set; } = "default";
    public float GlobalPositionX { get; set; } = 0f;
    public float GlobalPositionY { get; set; } = 0f;
}