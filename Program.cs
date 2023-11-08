using System.Diagnostics;
using System.Numerics;

namespace Dynamic_Programming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fibonacci Fb = new Fibonacci();
            var fibo = Fb.CalculateFibo_BottomUp(13);
            Print(fibo);

        }
        static void Print(int[] ints)
        {
            for (int i = 0; i < ints.Length; i++)
            {
                Console.WriteLine($"{i+1} => {ints[i]}");
            }
        }
    }
}