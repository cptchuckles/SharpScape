using System.ComponentModel.DataAnnotations;

namespace SharpScape.Api.Models
{
    public class ForumCategory
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required(ErrorMessage = " x ")]
        public string ForumCategoryName { get; set; }
        [Required(ErrorMessage = " x ")]
        public string ForumCategoryDescription { get; set; }
        [Required(ErrorMessage = " x ")]
        public string ForumCategoryAuthor { get; set; }
        [Required(ErrorMessage = " x ")]
        public virtual List<ForumThread> Threads { get; set; }

    }
}
