using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_1.Execrise
{
    /// <summary>
    /// 字谜游戏
    /// </summary>
    public class execrise_2
    {
        private string[] Dictionary { get; set; }

        private string[,] CheckBoard { get; set; }

        public static int[] WordLength = {3, 4, 5};

        public void InitDiction(string[] dict)
        {
            this.Dictionary = dict;
        }

        public void InitCheckBoard(string[,] cb)
        {
            this.CheckBoard = cb;
        }

        public List<string> FindLetterCombination()
        {
            List<string> result = new List<string>();
            int cloumnCount = this.CheckBoard.GetLength(0);
            int rowCount = this.CheckBoard.GetLength(1);
            int directionCount = 6; // 寻词方向 6个

            for (int i = 0; i < cloumnCount; i++)
            {
                for (int j = 0; j < rowCount; j++)
                {
                    for (int k = 0; k < directionCount; k++)
                    {
                        for (int l = 0; l < WordLength.Length; l++)
                        {
                            int wordLengthLimit = WordLength[l];

                            switch (k)
                            {
                                case (int)DirectionEnum.Up:
                                    if (j >= wordLengthLimit - 1)
                                    {
                                        string word = "";
                                        for (int m = 0; m < wordLengthLimit; m++)
                                        {
                                            word += CheckBoard[i, j - m];
                                        }
                                        result.Add(word);
                                    }
                                    break;
                                case (int)DirectionEnum.Down:
                                    if ((rowCount - j) >= wordLengthLimit)
                                    {
                                        string word = "";
                                        for (int m = 0; m < wordLengthLimit; m++)
                                        {
                                            word += CheckBoard[i, j + m];
                                        }
                                        result.Add(word);
                                    }
                                    break;
                                case (int)DirectionEnum.Left:
                                    if (i >= wordLengthLimit - 1)
                                    {
                                        string word = "";
                                        for (int m = 0; m < wordLengthLimit; m++)
                                        {
                                            word += CheckBoard[i - m, j];
                                        }
                                        result.Add(word);
                                    }
                                    break;
                                case (int)DirectionEnum.Right:
                                    if ((cloumnCount - i) >= wordLengthLimit)
                                    {
                                        string word = "";
                                        for (int m = 0; m < wordLengthLimit; m++)
                                        {
                                            word += CheckBoard[i + m, j];
                                        }
                                        result.Add(word);
                                    }
                                    break;
                                case (int)DirectionEnum.LeftDown:
                                    break;
                                case (int)DirectionEnum.RightDown:
                                    break;
                                case (int)DirectionEnum.LeftUp:
                                    break;
                                case (int)DirectionEnum.RightUp:
                                    break;
                                default:
                                    break;
                            }
                        }
                    }
                }
            }
            

            return result;
        }

        //private string[] FindLetterCombination
    }

    /// <summary>
    /// 寻词方向
    /// </summary>

    public enum DirectionEnum : int
    {
        Up = 0,
        Down = 1,
        Left = 2,
        Right = 3,
        LeftDown = 4,
        RightDown = 5,
        LeftUp = 6,
        RightUp = 7,
    }
}
