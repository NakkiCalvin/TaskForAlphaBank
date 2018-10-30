using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstTask
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 3;
            int[] array = new int[] { 2, 4, 1, 3 };


            var arrSorted = (from item in array
                            orderby item descending
                            select item).ToArray();


            int result = Bsearch(arrSorted, x);
            
            Console.WriteLine(result);
        }

        public static int Bsearch(int[] array, int X)
        {
            for (int index = 0; index < array.Length; index++)
            {
                if (array[index] < X)
                {
                    return index;
                }
                else
                {
                    continue;
                }
            }
            return 0;
        }
    }
}
