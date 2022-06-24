using SharpScape.Api.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace SharpScape.Api.Models
{
    public class ForumPost
    {

        [Key]
        public int Id { get; set; } 
        public int ThreadId { get; set; }
        [ForeignKey("ThreadId")]
        public ForumThread ForumThread { get; set; }
        public int AuthorId { get; set; }
        [ForeignKey("AuthorId")]
        public  User Author { get; set; }
        public string Body { get; set; }
        [Editable(false)]
        [DisplayFormat(DataFormatString = "{0:D}")]
        public DateTime Created { get; set; } = DateTime.Now.ToUniversalTime();
        public ForumPost(){}
        public ForumPost(int id,int threadId, int authorId,string body){
            Id = id;
            ThreadId = threadId;
            AuthorId = authorId;
            Body = body;
        }
    }
}
