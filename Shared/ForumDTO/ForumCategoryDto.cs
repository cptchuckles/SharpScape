using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpScape.Shared.Dto
{
    public class ForumCategoryDto
    {
       
        public int Id { get; set; }

        public string ForumCategoryAuthor { get; set; }
        
        public string ForumCategoryName{ get; set; }
        public string ForumCategoryDescription { get; set; }

        public  List<Thread> Threads;
    }
}
