using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SharpScape.Shared.Dto
{
    public class ThreadLikeDto
    {
        public int Id { get; set; }

        public int ThreadId { get; set; }
        public int UserId { get; set; }
    }
}
