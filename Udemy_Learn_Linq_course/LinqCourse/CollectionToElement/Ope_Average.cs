using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqCourse.CollectionToElement
{
    public class Ope_Average
    {
        public void Methode()
        {
            var entiers = new[] { 1, 2, 3, 4, 5, 6 };
            var decimals = new[] { 1.0m, 2.0m, 3.0m, 4.0m, 5.0m };

            var moyenneEntiers = entiers.Average();
            var moyennedecimals = decimals.Average();

            Console.WriteLine(moyenneEntiers);
            Console.WriteLine(moyennedecimals);

            var articles = new ArticlePrix[]
            {
                new ArticlePrix{ Nom = "Marteau", Prix = 20.5m },
                new ArticlePrix{ Nom = "Tournevis", Prix = 12m},
                new ArticlePrix{ Nom = "Scie", Prix = 7.5m},
            };

            var prixMoyen = articles.Average(a => a.Prix);
            Console.WriteLine(prixMoyen);
        }
    }
}
