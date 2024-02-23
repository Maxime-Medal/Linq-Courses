using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExercise
{
    public static class Extensions
    {
        public static int CountOfOdd(this int[] list)
        {
            int count = 0;
            foreach (var item in list) { 
            if (item % 2 == 0) { 
                count ++;
                }
            }
            return count;
        }
    }
}
