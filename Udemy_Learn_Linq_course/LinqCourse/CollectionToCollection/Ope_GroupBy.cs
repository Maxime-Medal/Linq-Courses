using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqCourse.CollectionToCollection
{

    public class ArticleGroup
    {
        public int Id { get; set; }
        public string Titre { get; set; }
        public int Categorie { get; set; }
    }

    public class Ope_GroupBy
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

            var articlesGroupesParCategorie
                = articles.GroupBy(article => article.Categorie);

            foreach (var item in articlesGroupesParCategorie)
            {
                Console.WriteLine("Catégorie n°" + item.Key);
                foreach (var article in item)
                {
                    Console.WriteLine(article.Titre);
                }
            }

            var titreArticlesGroupesParCategorie
                = articles.GroupBy(a => a.Categorie, a => a.Id);

            foreach (var item in titreArticlesGroupesParCategorie)
            {
                Console.WriteLine("Catégorie n°" + item.Key);
                foreach (var article in item)
                {
                    Console.WriteLine(article);
                }
            }

        }
    }
}
