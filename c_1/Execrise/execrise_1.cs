using System;
using System.Collections.Generic;
using System.Data;
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

        public static void EffectTestAndPrint()
        {

        }


        private static int[] GetRandomArray(int length)
        {
            int[] result = new int[length];

            int[] index = new int[length];
            for (int i = 0; i < length; i++)
                index[i] = i;

            var r = new Random();
            int id;
            for (int j = 0; j < length / 2; j++)
            {
                id = r.Next(1, length - 1);
                //在随机位置取出一个数，保存到结果数组 
                result[j] = index[id];
                //最后一个数复制到当前位置 
                index[id] = index[length - 1];
                //位置的上限减少一 
                length--;
            }

            return index;
        }
    }
}
