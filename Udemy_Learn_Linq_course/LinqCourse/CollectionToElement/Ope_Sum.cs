using LinqCourse.CollectionToCollection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqCourse.CollectionToElement
{
    public class ArticlePrix
    {
        public string Nom { get; set; }
        public decimal Prix { get; set; }
    }
    public class Ope_Sum
    {
        public void Methode()
        {
            var entiers = new[] { 1, 2, 3, 4, 5 };
            var decimals = new[] { 1.0m, 2.0m, 3.0m, 4.0m, 5.0m };

            var somme = entiers.Sum();
            var somme2 = decimals.Sum();

            Console.WriteLine(somme);

            var articles = new ArticlePrix[]
            {
                new ArticlePrix{ Nom = "Marteau", Prix = 20.5m },
                new ArticlePrix{ Nom = "Tournevis", Prix = 12m},
                new ArticlePrix{ Nom = "Scie", Prix = 7.5m},
            };

            var prixArticles = articles.Sum(a => a.Prix);
            Console.WriteLine(prixArticles);
        }
    }
}
