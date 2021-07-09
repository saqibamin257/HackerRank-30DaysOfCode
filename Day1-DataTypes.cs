using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_30DaysOfCode
{
    class Day1_DataTypes
    {
        public static void Solution() 
        {
            int i = 4;
            double d = 4.0;
            string s = "HackerRank ";

            int i2;
            double d2;
            string s2;

            i2 = int.Parse(Console.ReadLine());
            d2 = double.Parse(Console.ReadLine());
            s2 = Console.ReadLine();

            Console.WriteLine(i + i2);
            Console.WriteLine(String.Format("{0:0.0}", d + d2));
            Console.WriteLine(s + s2);
        } 

    }
}
