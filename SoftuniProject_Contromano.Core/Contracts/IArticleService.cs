using SoftuniProject_Contromano.Core.Models.Article;
using SoftuniProject_Contromano.Infrastucture.Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SoftuniProject_Contromano.Core.Contracts
{
    public interface IArticleService
    {
        Task<ArticleDetailsServiceModel> GetArticleById(int id);
        IEnumerable<Article> GetAllArticles();
        Task SaveArticle(Article article);
        Task EditArticle(Article article);
        Task DeleteArticle(int id);
    }
}
