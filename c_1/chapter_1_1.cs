using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_1
{
    public class chapter_1_1
    {
        /// <summary>
        /// Bubble
        /// </summary>
        /// <param name="unSortedArray"></param>
        /// <returns></returns>
        public int[] Bubble(int[] unSortedArray)
        {
            int[] sortedArray = {};
            if (unSortedArray != null && unSortedArray.Length > 0)
            {
                var length = unSortedArray.Length;
                for (int i = 0; i < length; i++)
                {
                    for (int j = i + 1; j < length; j++)
                    {
                        if (unSortedArray[j] < unSortedArray[i])
                        {
                            int temp = unSortedArray[j];
                            unSortedArray[j] = unSortedArray[i];
                            unSortedArray[i] = temp;
                        }
                    }
                }
                sortedArray = unSortedArray;
            }

            return sortedArray;
        }

        /// <summary>
        /// InsertSort
        /// </summary>
        /// <param name="unSortedArray"></param>
        /// <returns></returns>
        public List<int> InsertSort(List<int> unSortedArray)
        {
            var sortedArray = new List<int> {};
            if (unSortedArray != null && unSortedArray.Count > 0)
            {
                var length = unSortedArray.Count;
                for (var i = 0; i < length; i++)
                {
                    if (sortedArray.Count == 0)
                    {
                        sortedArray.Add(unSortedArray[i]);
                    }
                    else
                    {
                        for (var j = sortedArray.Count - 1; j >= 0; j--)
                        {
                            if (unSortedArray[i] > sortedArray[j])
                            {
                                if (j == sortedArray.Count - 1)
                                    sortedArray.Add(unSortedArray[i]);
                                else
                                    sortedArray.Insert(j + 1, unSortedArray[i]);
                                break;
                            }
                            if (j == 0)
                            {
                                sortedArray.Insert(j, unSortedArray[i]);
                                break;
                            }
                        }
                    }
                }
            }

            return sortedArray;
        }

        /// <summary>
        /// InsertSort
        /// <remarks>插入排序</remarks>
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public int[] InsertSort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int temp = array[i];
                for (int j = i - 1; j >= 0; j--)
                {
                    if (array[j] > temp)
                    {
                        array[j + 1] = array[j];
                        array[j] = temp;
                    }
                    else
                        break;
                }
            }
            return array;
        }
    }
}
