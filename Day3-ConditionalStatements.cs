using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_30DaysOfCode
{
   public class Day3_ConditionalStatements
    {
        public static void Solution() 
        {
            int n = 18;            
            string result = "";
            if (n % 2 == 1)
                result = "Weird";
            else if (n % 2 == 0 && (n >= 2 && n <= 5))
                result = "Not Weird";
            else if (n % 2 == 0 && (n >= 6 && n <= 20))
                result = "Weird";
            else if (n % 2 == 0 && (n > 20))
                result = "Not Weird";

            Console.WriteLine(result);
        }
    }
}
