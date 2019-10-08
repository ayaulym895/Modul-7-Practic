using System;
using System.Collections.Generic;
using System.Text;

namespace Homework3
{
    public class Number
    {
        public int x { get; set; }
        public int y { get; set; }

        public Number(int num1 = 0, int num2 = 0, int num3 = 0)
        {
            this.x = x;
            this.y = y;
        }
        public static bool operator ==(Number num1, Number num2)
        {
            if ((num1.x == num2.x) && (num1.y == num2.y))
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Number num1, Number num2)
        {
            if ((num1.x != num2.x) || (num1.y != num2.y))
            {
                return true;
            }
            return false;
        }
    }
}
