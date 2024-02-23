using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqCourse.CollectionToElement
{
    public class Ope_Aggregate
    {
        public void Methode()
        {
            var entiers = new[] { 1, 2, 3, 4, 5 };

            var result = entiers.Aggregate((total, n) => total + n);
            Console.WriteLine(result);

            var result2 = entiers.Aggregate(-15,(total, n) => total + n);
            Console.WriteLine(result2);

            var articles = new ArticlePrix[]
            {
                new ArticlePrix{ Nom = "Marteau", Prix = 20.5m },
                new ArticlePrix{ Nom = "Tournevis", Prix = 12m},
                new ArticlePrix{ Nom = "Scie", Prix = 7.5m},
            };

            var result3 = articles.Aggregate(0m, (total, article) => total + article.Prix);
        }
    }
}
