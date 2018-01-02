using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_1
{
    public class chapter_1_3
    {
        /// <summary>
        /// RecursiveFun1 
        /// <remarks>递归</remarks>
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static int RecursiveFun1(int x)
        {
            // base case
            if (x == 0)
                return x;
            // making progress
            else
                return 2*RecursiveFun1(x - 1) + x*x;
        }

        /// <summary>
        /// recursive print
        /// </summary>
        /// <param name="N"></param>
        public static void PrintOut(int N)
        {
            if (N >= 10)
                PrintOut(N / 10);
            //PrintDigit(N % 10);

            // avoid mod
            PrintDigit(N - (N/10)*10); 
        }

        /// <summary>
        /// print digits
        /// <remarks>打印个位数</remarks>
        /// </summary>
        /// <param name="x"></param>
        private static void PrintDigit(int x)
        {
            Console.Write(x);
        }
    }
}
