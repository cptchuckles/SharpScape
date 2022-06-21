using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SharpScape.Api.Models
{
    public class ForumThread
    {
      
            [Key]
            public Guid Id { get; set; }= Guid.NewGuid();
            
            public Guid UserId { get; set; }
        [ForeignKey("UserId")]
        public  User Author { get; set; }

        
        public Guid CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public ForumCategory ForumCategory { get; set; }
        public string Title { get; set; } = "-";
            public string Body { get; set; }="-";
        public int Votes { get; set; } = 0;
        public int Replies { get; set; } 
            public int Views { get; set; }
            [Editable(false)]
            [DisplayFormat(DataFormatString = "{0:D}")]
            public DateTime Created { get; set; } = DateTime.Now.ToUniversalTime();
        
    }
}
