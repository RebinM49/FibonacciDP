using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_Programming
{
    public class Fibonacci
    {
        /// <summary>
        /// Calculate Fibonacci sequence using Bottom-Up Dynamic Programming approch
        /// </summary>
        /// <param name="x">F(n)</param>
        /// <returns>the calculated sequence</returns>
        public int[] CalculateFibo_BottomUp(int x)
        {
            int[] fibo = new int[x];
            fibo[0] = 0;
            fibo[1] = 1;
            for (int i = 2; i < fibo.Length; i++)
            {
                fibo[i] = fibo[i - 1] + fibo[i - 2];
            }
            return fibo;
        }

        /// <summary>
        /// Calculate Fibonacci sequence using Bottom-Up Dynamic Programming approch
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public int CalculateFibo_TopDown(int x)
        {
            Dictionary<int, int> FiboCalculatedValues = new();
            var result = fiboCalculator(x);
            int fiboCalculator(int x)
            {
                if (x == 0 || x == 1)
                    return x;
                if (!FiboCalculatedValues.ContainsKey(x))
                    FiboCalculatedValues[x] = fiboCalculator(x - 1) + fiboCalculator(x - 2);
                return FiboCalculatedValues[x];
            }
            return result;
        }
    }
}
