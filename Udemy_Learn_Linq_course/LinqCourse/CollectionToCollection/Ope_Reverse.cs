using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqCourse.CollectionToCollection
{
    public class Ope_Reverse
    {
        public void Methode()
        {
            int[] entiers = new int[8] { 1, 2, 3, 4, 5, 1, 2, 7 };

            var entiersReverse = entiers.Reverse();

            foreach (var item in entiersReverse)
            {
                Console.WriteLine(item);
            }
        }
    }
}
