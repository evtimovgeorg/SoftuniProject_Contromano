using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SoftuniProject_Contromano.Infrastucture.Data.Common;

namespace SoftuniProject_Contromano.Controllers.Article
{
    public class ArticleController : Controller
    {
        



        // GET: ArticleController
        public ActionResult Index()
        {
            var articles = repository.All();
            return View(articles);
        }

        // GET: ArticleController/Details/5
        public ActionResult Details(int id)
        {
            var article = repository.GetArticleById(id);
            if (article == null)
            {
                return NotFound();
            }
            return View(article);
        }

        // GET: ArticleController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ArticleController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Article article)
        {
            if (!ModelState.IsValid)
            {
                return View(article);
            }
            await repository.Save(article);
            return RedirectToAction(nameof(Index));
        }

        // GET: ArticleController/Edit/5
        public ActionResult Edit(int id)
        {
            var article = repository.GetArticleById(id);
            if (article == null)
            {
                return NotFound();
            }
            return View(article);
        }

        // POST: ArticleController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id, Article article)
        {
            if (!ModelState.IsValid)
            {
                return View(article);
            }
            await repository.Edit(article);
            return RedirectToAction(nameof(Index));
        }

        // GET: ArticleController/Delete/5
        public ActionResult Delete(int id)
        {
            var article = repository.GetArticleById(id);
            if (article == null)
            {
                return NotFound();
            }
            return View(article);
        }

        // POST: ArticleController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(int id, IFormCollection collection)
        {
            var article = repository.GetArticleById(id);
            if (article == null)
            {
                return NotFound();
            }
            await repository.Delete(article);
            return RedirectToAction(nameof(Index));
        }
    }
}
