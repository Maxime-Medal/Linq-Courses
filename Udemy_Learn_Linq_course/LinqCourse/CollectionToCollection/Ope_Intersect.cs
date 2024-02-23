using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqCourse.CollectionToCollection
{
    public class Ope_Intersect
    {
        public void Methode()
        {
            var entiers1 = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            var entiers2 = new int[] { 6, 7, 8, 9, 10 };

            var entiersCommuns = entiers1.Intersect(entiers2);

            foreach (var item in entiersCommuns)
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

            var articlesCommun = articles.IntersectBy(articles2.Select(a => a.Nom), a => a.Nom);
            foreach (var item in articlesCommun)
            {
                Console.WriteLine(item.Nom);
            }
        }
    }
}
