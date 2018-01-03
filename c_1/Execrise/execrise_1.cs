using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace c_1.Execrise
{
    /// <summary>
    /// 编写一个程序解决选择问题。令 k = N / 2。画出表格显示你的程序对于N为不同值的运行时间。
    /// <remarks>
    /// 选出第 N/2 个最大者
    /// </remarks>
    /// </summary>
    public class execrise_1
    {
        public static int Selection(int[] data)
        {
            int result = 0;

            if (data != null && data.Length > 0)
            {
                int N = data.Length;
                int k = N/2;

                for (int i = 0; i < N; i++)
                {
                    int k2 = 0;
                    for (int j = 0; j < N; j++)
                    {
                        if (data[i] > data[j])
                            k2++;
                    }

                    if (k2 == k-1)
                    {
                        result = data[i];
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// 画出表格显示你的程序对于N为不同值的运行时间
        /// </summary>
        /// <param name="steps">步数</param>
        /// <param name="step">步长</param>
        public static void EffectTestAndDraw(int steps, int step = 50000)
        {
            int[] randomArray = { };
            //var effect = new Dictionary<int, string>();
            object[,] effect = new object[steps, 4];
            int selected;
            for (int i = 1; i <= steps; i++)
            {
                int N = step*i/2;
                randomArray = GetRandomArray(step*i);
                var c1 = new chapter_1_1();
                DateTime start = DateTime.Now;
                selected = Selection(randomArray);
                DateTime end = DateTime.Now;
                var s1 = c1.InsertSort(randomArray.ToList());
                DateTime end2 = DateTime.Now;
                var s2 = c1.InsertSort(randomArray);
                DateTime end3 = DateTime.Now;
                effect[i - 1, 0] = N;
                effect[i - 1, 1] = ExecDateDiff(start, end);
                effect[i - 1, 2] = ExecDateDiff(end, end2);
                effect[i - 1, 3] = ExecDateDiff(end2, end3);
            }

            Console.WriteLine("N\tMilliseconds-1\tMilliseconds-2\tMilliseconds-3");
            for (int i = 0; i < steps; i++)
            {
                Console.WriteLine($"{effect[i, 0]}\t{effect[i, 1]}\t{effect[i, 2]}\t{effect[i, 3]}");
            }
        }

        private static int[] GetRandomArray(int length)
        {
            int[] result = new int[length];

            for (int i = 0; i < length; i++)
                result[i] = i;

            var random = new Random();
            for (int j = 0; j < length/2; j++)
            {
                var randomIndex = random.Next(1, length - 1);
                int temp = result[j];
                result[j] = result[randomIndex];
                result[randomIndex] = temp;
            }

            return result;
        }


        /// <summary>
        /// 程序执行时间测试
        /// </summary>
        /// <param name="dateBegin">开始时间</param>
        /// <param name="dateEnd">结束时间</param>
        /// <returns>返回(秒)单位，比如: 0.00239秒</returns>
        public static string ExecDateDiff(DateTime dateBegin, DateTime dateEnd)
        {
            TimeSpan ts1 = new TimeSpan(dateBegin.Ticks);
            TimeSpan ts2 = new TimeSpan(dateEnd.Ticks);
            TimeSpan ts3 = ts1.Subtract(ts2).Duration();
            //你想转的格式
            return ts3.TotalMilliseconds.ToString();
        }
    }
}
