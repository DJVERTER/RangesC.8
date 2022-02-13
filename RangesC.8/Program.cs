using System;
using System.Linq;

namespace RangesC._8
{
    class Program
    {
        static void Main(string[] args)
        {
            //for method
            var numbers = new int[] { 5, 1, 4, 2, 3, 7 };
            var result = new int[3];
            for (int i = 2; i <= 4; i++)
            {
                result[i - 2] = numbers[i];
            }
            Console.WriteLine(string.Join(" ", result));

            //List method
            var list = numbers.ToList();
            var resultList = list.GetRange(2, 3);
            var resultToArr = resultList.ToArray();
            Console.WriteLine(string.Join(" ", resultToArr));

            //LINQ method
            var temp = numbers.Skip(2).Take(3);
            var resultToArr2 = temp.ToArray();
            Console.WriteLine(string.Join(" ", resultToArr2));

            //Copy() Array method
            var resultCopy = new int[3];
            Array.Copy(numbers, 2, resultCopy, 0, 3);
            Console.WriteLine(string.Join(" ", resultCopy));

            //Range method
            var resultRange = numbers[2..5];
            Console.WriteLine(string.Join(" ", resultRange));
        }
    }
}
