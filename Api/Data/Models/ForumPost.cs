using SharpScape.Api.Models;
using System.ComponentModel.DataAnnotations;

namespace SharpScape.Api.Data.Models
{
    public class ForumPost
    {

        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();


        public string ForumPostTitle { get; set; } = "-";

        public string ForumPostBody { get; set; } = "-";
       
        public Guid ForumThreadId { get; set; }
        
        
        public Guid ForumAuthorId { get; set; }







    }
}
