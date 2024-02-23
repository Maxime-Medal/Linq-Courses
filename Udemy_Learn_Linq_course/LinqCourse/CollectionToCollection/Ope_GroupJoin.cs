using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqCourse.CollectionToCollection
{
    public class Ope_GroupJoin
    {
        public void Methode()
        {
            var articles = new ArticleJoin[4]
            {
                new() { Id = 1, Title = "Marteau", CategoryId = 1},
                new() { Id = 2, Title = "Tournevis", CategoryId = 1},
                new() { Id = 3, Title = "Manteau", CategoryId = 2},
                new() { Id = 4, Title = "Gants", CategoryId = 2},
            };
            var categories = new Category[2]
            {
                new() { Id = 1, Title = "Outils"},
                new() { Id= 2, Title = "Vêtements"}
            };

            var articlesParCategorie =
                categories.GroupJoin(articles,
                    categorie => categorie.Id,
                    article => article.CategoryId,
                    (categorie, articles) => new { categorie, articles});

            foreach (var item in articlesParCategorie)
            {
                Console.WriteLine($"Articles dans la catégorie {item.categorie.Title}");
                foreach (var article in item.articles)
                {
                    Console.WriteLine(article.Title);
                }
            }
        }
    }
}
