using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqCourse.CollectionToElement
{
    public class Ope_Contains
    {
        public void Methode()
        {
            var entiers = new[] { 1, 2, 3, 4, 5 };

            var contientTrois = entiers.Contains(3);
            var contientSix = entiers.Contains(6);
            //var contientSix2 = entiers.Any(i => i == 6);

            Console.WriteLine(contientTrois);
            Console.WriteLine(contientSix);


            var marteau = new ArticlePrix
            {
                Nom = "Marteau",
                Prix = 20.5m
            };

            var articles = new ArticlePrix[]
            {
                marteau,
                new ArticlePrix{ Nom = "Tournevis", Prix = 12m},
                new ArticlePrix{ Nom = "Scie", Prix = 7.5m},
            };

            var contientUnMarteau = articles.Contains(marteau);
            Console.WriteLine(contientUnMarteau);
        }
    }
}
