using System;

namespace Homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            Number number1 = new Number(x: 3, y: 8);
            Number number2 = new Number(x: 4, y: 9);

            if (number1 == number2)
            {
                Console.WriteLine("Одинаковы");
            }

            int[] arr1 = { 3,5,6,9,11};
            int[] arr2 = { 1,8,16,0,5 };
            Array array1 = new Array(arr1);
            Array array2 = new Array(arr2);

      
            Console.ReadLine();
        }
    }
}
