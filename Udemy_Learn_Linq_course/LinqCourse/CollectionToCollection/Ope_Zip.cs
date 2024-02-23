using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqCourse.CollectionToCollection
{
    public class Ope_Zip
    {
        public void Methode()
        {
            var entiers1 = new int[5] { 1, 2, 3, 4, 5 };
            var chaines1 = new string[4] { "Un", "Deux", "Trois", "Quatre" };
            var entiers2 = new int[5] { 6, 7, 8, 9, 10 };
            var entiers3 = new int[5] { 11, 12, 13, 14, 15 };

            var entiersZipes =
                entiers1.Zip(chaines1, (i, c) => $"{i} = {c}");

            foreach (var item in entiersZipes)
            {
                Console.WriteLine($"{item}");
            }
        }
    }
}
