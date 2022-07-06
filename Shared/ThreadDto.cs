using System.ComponentModel.DataAnnotations;

namespace SharpScape.Shared.Dto;

public class ThreadInfoDto 
{
    [Required]
    public int Id { get; set; }

    public int AuthorId { get; set; }

    public int CategoryId { get; set; }
    public string Title { get; set; }
    public int Votes { get; set; }
    public int Replies { get; set; }
    public int Views { get; set; }
}
