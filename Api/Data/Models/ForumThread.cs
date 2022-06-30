using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SharpScape.Api.Models
{
    public class ForumThread
    {
        [Key]
        public int Id { get; set; }

        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public  User? Author { get; set; }

        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public ForumCategory ForumCategory { get; set; }

        public string? Title { get; set; }
        public string Body { get; set; } = "";
        public int Votes { get; set; }= 0;
        public int Replies { get; set; } = 0;
        public int Views { get; set; } = 0;

        [Editable(false)]
        [DisplayFormat(DataFormatString = "{0:D}")]
        public DateTime Created { get; set; } = DateTime.Now.ToUniversalTime();
    }
}
