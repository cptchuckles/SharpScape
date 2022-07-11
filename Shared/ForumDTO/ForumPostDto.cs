using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpScape.Shared.Dto
{
    public class ForumPostDto
    {
        public int Id { get; set; }
        public int ThreadId { get; set; }

        public int AuthorId { get; set; }
        public string Body { get; set; }
        public DateTime Created { get; set; }
    }
    public class ForumPostEditDto
    {
        public string Body { get; set; }
        public DateTime Created { get; set; }
    }
}