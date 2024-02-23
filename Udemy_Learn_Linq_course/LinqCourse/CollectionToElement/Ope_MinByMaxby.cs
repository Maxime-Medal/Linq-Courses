using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqCourse.CollectionToElement
{
    public class Ope_MinByMaxby
    {
        public void Methode()
        {
            string[] chaines = new[] { "un", "deux", "trois", "quatre", "cinq" };

            var plusPetiteChaine = chaines.MinBy(c => c.Length);
            var plusGrandeChaine = chaines.MaxBy(c => c.Length);
            Console.WriteLine(plusPetiteChaine);
            Console.WriteLine(plusGrandeChaine);

            string[] chaines2 = new string[0];
            var test = chaines2.MinBy(c => c.Length);

            int[] entiers = new int[0];
            //var test2 = entiers.MinBy(i => i);
        }
    }
}
