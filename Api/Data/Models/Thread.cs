using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SharpScape.Api.Models;
// cant use Thread as classname cause its already used in namespace. So I name it ThreadModel
public class ThreadModel
{
    [Key]
    public Guid Id{get;set;}
    [ForeignKey("User")]
    public Guid UserId {get;set;}
    public User User{get;set;}
    public string Title { get; set; }
    public string Body {get;set;}
    public string Votes { get; set; }
    public string Relies { get; set; }
    public string Views { get; set; }
    [Editable(false)]
    [DisplayFormat(DataFormatString = "{0:D}")]
    public DateTime Created { get; set; } = DateTime.Now.ToUniversalTime();
}