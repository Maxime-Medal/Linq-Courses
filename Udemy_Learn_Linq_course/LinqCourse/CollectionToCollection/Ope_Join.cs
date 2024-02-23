using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqCourse.CollectionToCollection
{
    public class ArticleJoin
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int CategoryId { get; set; }
    }
    public class Category
    {
        public int Id { get; set; }
        public string Title { get; set; }
    }
    public class Ope_Join
    {
        public void Methode()
        {
            var articles = new ArticleJoin[3]
            {
                new() { Id = 1, Title = "Marteau", CategoryId = 1},
                new() { Id = 2, Title = "Tournevis", CategoryId = 1},
                new() { Id = 3, Title = "Manteau", CategoryId = 2},
            };
            var categories = new Category[1]
            {
                new() { Id = 1, Title = "Outils"},
                //new() { Id= 2, Title = "Vêtements"}
            };

            var articleEtCategories =
                articles.Join(categories, a => a.CategoryId, c => c.Id, (article, categorie) =>
                new { article, categorie});

            foreach (var item in articleEtCategories)
            {
                Console.WriteLine($"Article {item.article.Title} dans la catégorie {item.categorie.Title}");
            }
        }
    }
}
