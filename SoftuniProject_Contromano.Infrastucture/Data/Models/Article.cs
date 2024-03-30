using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using static SoftuniProject_Contromano.Infrastucture.Constants.ArticleConstants;
namespace SoftuniProject_Contromano.Infrastucture.Data.Models
{
    public class Article
    {
        [Key]
        [Comment("Unique identifier for the article.")]
        public int Id { get; set; }

        public string? CreatorId { get; set; } = null!;
        [ForeignKey(nameof(CreatorId))]
        public IdentityUser Creator { get; set; } = null!;

        [Required]
        [MaxLength(ArticleContentMaxLenght)]
        [Comment("Title of the Article")]
        public string Title { get; set; } = string.Empty;

        [Required]
        [MaxLength(ArticleContentMaxLenght)]
        [Comment("Content of the article")]
        public string Content { get; set; } = string.Empty;

        [Required]
        [Comment("Creation data of the Article")]
        public DateTime CreatedOn { get; set; }

        [Comment("Date and time when the article is scheduled to be published.")]
        public DateTime? ScheduledTime { get; set; }

        public int CategoryId { get; set; } = default!;

        [ForeignKey(nameof(CategoryId))]
        [Comment("Categories associated with the article.")]
        public Category Category { get; set; } = null!;

        [Comment("Comments associated with the article.")]
        public ICollection<Comment> Comments { get; set; } = null!;

        [Comment("Is article is deleted")]
        public bool IsDeleted { get; set; } = false;
        [Comment("Is article is modified")]
        public bool IsModified { get; set; } = false;
        [Comment("Is article is published")]
        public bool IsPublic { get; set; } = true;
        [Comment("Indicates whether comments are allowed for this article.")]
        public bool NoComment { get; set; } = CommentDisabled;
    }
}
