using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace SharpScape.Api.Models
{
    public class ThreadLike 
    {
        [Key]
        public int Id { get; set; } 

        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public  User? User { get; set; }

        public int ThreadId { get; set; }
        [ForeignKey("ThreadId")]
        public ForumThread ForumThread { get; set; }

    }
}
