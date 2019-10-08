using System;
using System.Collections.Generic;
using System.Text;

namespace Homework3
{
    public class Array
    {
        //Дан класс содержащий внутри себя массив.
        //Реализовать перегрузку операторов < , > так,
        //чтобы если сумма элементов массива 1 класса больше,
        //возвращалось значение true и наоборот.
        public int [] numbers;
        public int size { get; set; }
        public static bool operator >(Array arr1, Array arr2)
        {
            int sum1, sum2 = 0;
            for (int i = 0; i < arr1.size - 1; i++)    {  sum1 += i;  }
            for (int i = 0; i < arr2.size - 1; i++)    {  sum2 += i;  }
            if (sum1 >sum2)
                return true;
            return false;
        }
        public static bool operator <(Array arr1, Array arr2)
        {
            int sum1, sum2 = 0;
            for (int i = 0; i < arr1.size - 1; i++) { sum1 += i; }
            for (int i = 0; i < arr2.size - 1; i++) { sum2 += i; }
            if (sum1 < sum2)
                return true;
            return false;
        }
    }
