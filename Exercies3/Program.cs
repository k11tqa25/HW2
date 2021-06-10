using System;
using System.Collections.Generic;

namespace Exercies3
{
    public class Solution
    {
        public IEnumerable<int> solution(int A, int B)
        {
            for (int i = A; i <= B; i++) if (Math.Sqrt(i) % 1 == 0) yield return i; 
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers:");
            Console.Write("From: ");
            int from = Convert.ToInt32(Console.ReadLine());
            Console.Write("To: ");
            int to = Convert.ToInt32(Console.ReadLine());
            Solution s = new Solution();
            Console.WriteLine($"All perfect square numbers:");
            foreach (var item in s.solution(from, to)) Console.Write(item + " ");
        }
    }
}
