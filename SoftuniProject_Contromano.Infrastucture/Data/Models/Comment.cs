using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftuniProject_Contromano.Infrastucture.Data.Models
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }


        public IdentityUser Creator { get; set; } = null!;

        public string Content { get; set; } = string.Empty;

        public DateTime CreatedOn { get; set; }

        public int ArticleId { get; set; } = default!;

        [ForeignKey(nameof(ArticleId))]
        public Article Article { get; set; } = null!;

        public bool IsDeleted { get; set; } = false;
    }
}
