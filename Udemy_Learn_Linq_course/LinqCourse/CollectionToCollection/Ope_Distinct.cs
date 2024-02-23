using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqCourse.CollectionToCollection
{

    public class Article
    {
        public string Nom { get; set; }

        /*public override bool Equals(object? obj)
        {
            if(obj is Article article)
            {
                return article.Nom == Nom;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return Nom.GetHashCode();
        }*/
    }

    public class ArticleEqualityComparer : IEqualityComparer<Article>
    {
        public bool Equals(Article? x, Article? y)
        {
            return x?.Nom == y?.Nom;
        }

        public int GetHashCode([DisallowNull] Article obj)
        {
            return obj.Nom.GetHashCode();
        }
    }

    public class Ope_Distinct
    {
        public void Methode()
        {
            int[] entiers = new int[8] { 1, 2, 3, 4, 5, 1, 2, 7 };

            var entiersDistincts =
                entiers.Distinct();

            Console.WriteLine("Distinct");

            foreach (var item in entiersDistincts)
            {
                Console.WriteLine(item);
            }

            Article[] articles = new Article[3]
            {
                new Article{ Nom = "Marteau"},
                new Article{ Nom = "Tournevis"},
                new Article{ Nom = "Marteau"},
            };

            var articlesDistincts = articles.Distinct(new ArticleEqualityComparer());

            foreach (var item in articlesDistincts)
            {
                Console.WriteLine(item.Nom);
            }

            Console.WriteLine("DistinctBy");

            var articlesDistinctsBy =
                articles.DistinctBy(a => a.Nom);

            foreach (var item in articlesDistinctsBy)
            {
                Console.WriteLine(item.Nom);
            }
        }
    }
}
