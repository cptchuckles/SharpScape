using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpScape.Shared.Dto
{
    public class ForumThreadDto
    {
        public int Id { get; set; }

        public int AuthorId { get; set; }

        public int CategoryId { get; set; }
        public string Title { get; set; }
        public string Body{ get; set; }
        public int Votes { get; set; }
        public int Replies { get; set; }
        public int Views { get; set; }
        public DateTime Created { get; set; }
    }
}
