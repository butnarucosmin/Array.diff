using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array.diff
{
    public class Kata
    {
        public static int[] ArrayDiff(int[] a, int[] b)
        {
            var result = new List<int>();

            foreach(int value in a)
            {
                if (!b.Contains(value))
                {
                    result.Add(value);
                }
            }

            return result.ToArray();
        }
    }
}
