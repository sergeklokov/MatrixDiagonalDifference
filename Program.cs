using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixDiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            List<List<int>> arr = new List<List<int>>()
            {   new List<int>(){ 11, 2, 4},
                new List<int>(){ 4, 5, 6 },
                new List<int>(){ 10, 8, -12 },
            };

            var r = diagonalDifference(arr);
            Console.WriteLine(r);

            Console.WriteLine("Press any key..");
            Console.ReadKey();
        }

        public static int diagonalDifference(List<List<int>> arr)
        {
            var len = arr.Count();
            long s1 = 0;
            long s2 = 0;

            for (int i = 0; i < len; i++)
            {

                for (int j = 0; j < len; j++)
                {
                    if (i == j)
                    {
                        s1 += arr[i][j];

                        s2 += arr[i][len - j - 1];
                    }
                }

            }

            Console.WriteLine("s1 = {0}; s2 = {1}", s1, s2);

            return (int)Math.Abs(s1 - s2);
        }
    }
}
