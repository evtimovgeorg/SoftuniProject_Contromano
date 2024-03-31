using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftuniProject_Contromano.Core.Models.Article
{
    public class ArticleIndexViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; } = String.Empty;
        public string Content { get; set; } = String.Empty;
        public string ImageUrl { get; set; } = String.Empty;
        public string Author { get; set; } = String.Empty;
        public DateTime CreatedOn { get; set; }


    }
}
