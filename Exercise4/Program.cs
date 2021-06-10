using System;
using System.Collections.Generic;

namespace Exercise4
{
    public class Spiral
    {
        public List<int> Display(int[,] array)
        {
            int cols = array.GetLength(1) ;
            int rows = array.GetLength(0);
            int t = 0, r = cols - 1, b = rows - 1, l = 0;
            int row = 0, col = 0, dir = 0;
            List<int> result = new List<int>();
            while (t <= b &&  l <= r)
            {
                if (dir % 4 == 0)
                {
                    for (col = l; col <= r; col++) result.Add(array[row, col]);
                    t += 1; col -= 1;
                }
                else if (dir % 4 == 1)
                {
                    for (row = t; row <= b; row++) result.Add(array[row, col]);
                    r -= 1; row -= 1;
                }
                else if (dir % 4 == 2)
                {
                    for (col = r; col >= l; col--) result.Add(array[row, col]);
                    b -= 1; col += 1;
                }
                else
                {
                    for (row = b; row >= t; row--) result.Add(array[row, col]);
                    l += 1; row += 1;
                }
                dir++;

            }
            return result;
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Spiral s = new Spiral();
            int[,] matrix = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            s.Display(matrix).ForEach(x => Console.Write(x + " "));

        }
    }
}
