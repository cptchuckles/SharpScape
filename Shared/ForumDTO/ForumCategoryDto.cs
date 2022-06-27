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

        //[Parameter]
        //public string Route { get; set; } = "r";
        //[Parameter]
        //public string Status { get; set; } = "s";

        //[Parameter]
        //public string Icon { get; set; } = "i";

        //[Parameter]
        //public string Title { get; set; } = "t";
        //[Parameter]
        //public string SubTitle { get; set; } = "st";
        //[Parameter]
        //public string ViewsNumber { get; set; } = "vn";
        //[Parameter]
        //public string TopicsNumber { get; set; } = "tn";
        //[Parameter]
        //public string PostsNumber { get; set; } = "pn";

    }
}
