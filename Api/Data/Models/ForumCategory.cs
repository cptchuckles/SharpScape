using System.ComponentModel.DataAnnotations;

namespace SharpScape.Api.Models
{
    public class ForumCategory 
    {
        [Key]
        public int Id { get; set; } 

        [Required(ErrorMessage = " x ")]
        public string Name { get; set; } = "";
        [Required(ErrorMessage = " x ")]
        public string Description { get; set; } = "";
        [Required(ErrorMessage = " x ")]
        
        public List<ForumThread> Threads { get; set; }= new List<ForumThread>();

    }
}
