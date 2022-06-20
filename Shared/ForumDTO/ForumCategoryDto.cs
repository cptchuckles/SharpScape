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
       
        public Guid Id { get; set; } = Guid.NewGuid();


        public string ForumCategoryName;
        public string ForumCategoryDescription;
        public string ForumCategoryAuthor;
        public  List<Thread> Threads;

    }
}
