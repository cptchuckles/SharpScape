using System.ComponentModel.DataAnnotations;

namespace SharpScape.Api.Models
{
    public class ForumCategory
    {
        [Key]
        public int Id { get; set; } 

        [Required(ErrorMessage = " x ")]
        public string ForumCategoryName { get; set; } = "";
        [Required(ErrorMessage = " x ")]
        public string ForumCategoryDescription { get; set; } = "";
        [Required(ErrorMessage = " x ")]
        public string ForumCategoryAuthor { get; set; } = "";
        
        public List<ForumThread>? Threads { get; set; }

    }
}
