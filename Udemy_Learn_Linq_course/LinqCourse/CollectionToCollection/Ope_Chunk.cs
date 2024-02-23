using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqCourse.CollectionToCollection
{
    public class Ope_Chunk
    {
        public void Methode()
        {
            var articles = new ArticleGroup[5]
            {
                new() { Id= 1, Titre = "Marteau", Categorie = 1},
                new() { Id= 4, Titre = "Manteau", Categorie = 2},
                new() { Id= 2, Titre = "Tournevis", Categorie = 1},
                new() { Id= 5, Titre = "Gants", Categorie = 2},
                new() { Id= 3, Titre = "Scie", Categorie = 1},
            };

            var paquetDArticles = articles.Chunk(2);

            foreach (var item in paquetDArticles)
            {
                Console.WriteLine($"Il y a {item.Length} article(s) dans le paquet");
                foreach (var article in item)
                {
                    Console.WriteLine(article.Titre);
                }
            }
        }
    }
}
