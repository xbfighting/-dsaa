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

        public string[] GetDictionary()
        {
            return Dictionary;
        }

        public void InitCheckBoard(string[,] cb)
        {
            this.CheckBoard = cb;
        }

        public Dictionary<string, string> FindLetter()
        {
            var letterCombinationDict = new Dictionary<string, string>();
            int cloumnCount = this.CheckBoard.GetLength(0);
            int rowCount = this.CheckBoard.GetLength(1);
            int directionCount = 8; // 寻词方向 6个

            for (int cloumnIndex = 0; cloumnIndex < cloumnCount; cloumnIndex++)
            {
                for (int rowIndex = 0; rowIndex < rowCount; rowIndex++)
                {
                    for (int direction = 0; direction < directionCount; direction++)
                    {
                        for (int wl = 0; wl < WordLength.Length; wl++)
                        {
                            int wordLengthLimit = WordLength[wl];
                            string word = "";
                            string indexStr = "";

                            switch (direction)
                            {
                                case (int) DirectionEnum.Up:
                                    if (rowIndex >= wordLengthLimit - 1)
                                    {
                                        for (int m = 0; m < wordLengthLimit; m++)
                                        {
                                            word += CheckBoard[cloumnIndex, rowIndex - m];
                                            indexStr += $"[{cloumnIndex},{rowIndex - m}]";
                                        }
                                    }
                                    break;
                                case (int) DirectionEnum.Down:
                                    if ((rowCount - rowIndex) >= wordLengthLimit)
                                    {
                                        for (int m = 0; m < wordLengthLimit; m++)
                                        {
                                            word += CheckBoard[cloumnIndex, rowIndex + m];
                                            indexStr += $"[{cloumnIndex},{rowIndex + m}]";
                                        }
                                    }
                                    break;
                                case (int) DirectionEnum.Left:
                                    if (cloumnIndex >= wordLengthLimit - 1)
                                    {
                                        for (int m = 0; m < wordLengthLimit; m++)
                                        {
                                            word += CheckBoard[cloumnIndex - m, rowIndex];
                                            indexStr += $"[{cloumnIndex - m},{rowIndex}]";
                                        }
                                    }
                                    break;
                                case (int) DirectionEnum.Right:
                                    if ((cloumnCount - cloumnIndex) >= wordLengthLimit)
                                    {
                                        for (int m = 0; m < wordLengthLimit; m++)
                                        {
                                            word += CheckBoard[cloumnIndex + m, rowIndex];
                                            indexStr += $"[{cloumnIndex + m},{rowIndex}]";
                                        }
                                    }
                                    break;
                                case (int) DirectionEnum.LeftDown:
                                    if ((cloumnIndex + 1 >= wordLengthLimit) && (rowCount - rowIndex) >= wordLengthLimit)
                                    {
                                        for (int m = 0; m < wordLengthLimit; m++)
                                        {
                                            word += CheckBoard[cloumnIndex - m, rowIndex + m];
                                            indexStr += $"[{cloumnIndex - m},{rowIndex + m}]";
                                        }
                                    }
                                    break;
                                case (int) DirectionEnum.RightDown:
                                    if ((cloumnCount - cloumnIndex) >= wordLengthLimit &&
                                        (rowCount - rowIndex >= wordLengthLimit))
                                    {
                                        for (int m = 0; m < wordLengthLimit; m++)
                                        {
                                            word += CheckBoard[cloumnIndex + m, rowIndex + m];
                                            indexStr += $"[{cloumnIndex + m},{rowIndex + m}]";
                                        }
                                    }
                                    break;
                                case (int) DirectionEnum.LeftUp:
                                    if ((cloumnIndex + 1 >= wordLengthLimit) && (rowIndex + 1 >= wordLengthLimit))
                                    {
                                        for (int m = 0; m < wordLengthLimit; m++)
                                        {
                                            word += CheckBoard[cloumnIndex - m, rowIndex - m];
                                            indexStr += $"[{cloumnIndex - m},{rowIndex - m}]";
                                        }
                                    }
                                    break;
                                case (int) DirectionEnum.RightUp:
                                    if ((cloumnCount - cloumnIndex) >= wordLengthLimit &&
                                        (rowIndex + 1) >= wordLengthLimit)
                                    {
                                        for (int m = 0; m < wordLengthLimit; m++)
                                        {
                                            word += CheckBoard[cloumnIndex + m, rowIndex - m];
                                            indexStr += $"[{cloumnIndex + m},{rowIndex - m}]";
                                        }
                                    }
                                    break;
                                default:
                                    break;
                            }

                            if (!string.IsNullOrWhiteSpace(word))
                            {
                                if (this.Dictionary.Contains(word))
                                {
                                    letterCombinationDict.Add(indexStr, word);
                                }
                            }
                        }
                    }
                }
            }
            

            return letterCombinationDict;
        }
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
