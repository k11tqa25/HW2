using System;
using System.Collections.Generic;

namespace Exercise2
{
    public class Solution
    { 
        public int solution(int[] A)
        {
            Dictionary<int, int> freq = new Dictionary<int, int>();
            int max = 0;
            int result = A[0];
            for (int i = 0; i < A.Length; i++)
            {
                if (freq.ContainsKey(A[i])) freq[A[i]] += 1;
                else freq[A[i]] = 1;
                if(freq[A[i]] > max)
                {
                    max = freq[A[i]];
                    result = A[i];
                }
            }
            return result;
        }
    }
        class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the array:");
            int size = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the elements of the array.");
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Solution s = new Solution();
            Console.WriteLine($"Most freqent number: {s.solution(array)}");
        }
    }
}
