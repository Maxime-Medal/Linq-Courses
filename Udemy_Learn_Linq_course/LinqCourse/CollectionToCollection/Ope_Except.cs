using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqCourse.CollectionToCollection
{
    public class Ope_Except
    {
        public void Methode()
        {
            var entiers1 = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            var entiers2 = new int[] { 6, 7, 8, 9, 10 };

            var entiers1NonDansEntiers2 = entiers1.Except(entiers2);
            var entiers2NonDansEntiers1 = entiers2.Except(entiers1);

            foreach (var item in entiers1NonDansEntiers2)
            {
                Console.WriteLine(item);
            }
            foreach (var item in entiers2NonDansEntiers1)
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

            //var articles1NonDansArticles2 = articles.ExceptBy(articles2.Select(a => a.Nom), a => a.Nom);
            var articles1NonDansArticles2 = articles2.ExceptBy(articles.Select(a => a.Nom), a => a.Nom);
            foreach (var item in articles1NonDansArticles2)
            {
                Console.WriteLine(item.Nom);
            }

        }
    }
}
