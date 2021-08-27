using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank_30DaysOfCode
{
   public class Day2_Operators_Result
    {
        public static void Solve(double meal_cost, int tip_percent, int tax_percent)
        {
            double TotalCost = Math.Round(meal_cost + (meal_cost / 100 * tip_percent) + (meal_cost / 100 * tax_percent));
            Console.WriteLine(TotalCost);
        }
    }
    public class Day2_Operators_Solution 
    {
        public static void Input() 
        {
            double meal_cost = 12.00;

            int tip_percent = 20;

            int tax_percent = 8;

            Day2_Operators_Result.Solve(meal_cost, tip_percent, tax_percent);
        }

    }
}
