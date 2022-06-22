using SharpScape.Api.Models;
using System.ComponentModel.DataAnnotations;

namespace SharpScape.Api.Data.Models
{
    public class ForumPost
    {

        [Key]
        public int Id { get; set; } 

        public string ForumPostTitle { get; set; }

        public string ForumPostBody { get; set; }
       
        public int ForumThreadId { get; set; }
        
        public int ForumAuthorId { get; set; }
    }
}
