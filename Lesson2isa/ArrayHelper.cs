using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2isa
{
    internal class ArrayHelper
    {
        internal static double SearchAverage(int[] array) => array.Sum() / array.Length;  // метод поиска среднего арифметического элементов массива

        internal static int SecondMax(int[] array)
        {
            var list = array.ToList();
            list.Remove(list.Max());
            return list.Max();  
        }

        internal static void Reverse(int[] array)
        {
            
        }

    }
}
