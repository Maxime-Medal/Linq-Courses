using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqCourse.CollectionToCollection
{
    public class Ope_Union
    {
        public void Methode()
        {
            var entiers1 = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            var entiers2 = new int[] { 6, 7, 8, 9, 10 };

            var chaines = new string[] { "a", "b", "c" };

            var entiers3 = entiers1.Union(entiers2);

            foreach (var item in entiers3)
            {
                Console.WriteLine(item);
            }

            var articles = new Article[]
            {
                new Article{ Nom = "Marteau"},
                new Article{ Nom = "Tournevis"},
                new Article{ Nom = "Scie"},
            };
            var articles2 = new Article[]
            {
                new Article{ Nom = "Marteau"},
                new Article{ Nom = "Perceuse"},
                new Article{ Nom = "Rabot"},
            };

            var tousLesArticles = articles.UnionBy(articles2, a => a.Nom);
            foreach (var article in tousLesArticles)
            {
                Console.WriteLine(article.Nom);
            }
        }
    }
}
