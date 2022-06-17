using System.ComponentModel.DataAnnotations;

namespace SharpScape.Shared.Dto;

public class ThreadDto 
{
    [Required]
    public Guid Id { get; set; }

}
