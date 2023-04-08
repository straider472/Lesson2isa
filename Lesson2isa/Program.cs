using System;

namespace Lesson2isa
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new int[10] { 1, 5, 7, 8, 2, 9, 1, 3, 4, 4 };
            Console.WriteLine(ArrayHelper.SecondMax(array));
            Console.ReadKey();
        }
    }
}
