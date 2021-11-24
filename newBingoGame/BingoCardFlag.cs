using System;
namespace newBingoGame
{
    internal class BingoCardFlag
    {
        public int[,] bingoCardFlag(int[,] card, int ball, int[,] flag)
        {
            int mid = (card.GetLength(0) - 1) / 2;      //ﾋﾞﾝｺﾞｶｰﾄﾞの中央値を取得
            flag[mid,mid] = 1;
            for (int y = 0; y < card.GetLength(0); y++)
            {
                for (int x = 0; x < card.GetLength(0); x++)
                {
                    if (card[x, y] == ball)
                    {
                        flag[x, y] = 1;
                    }
                }
            }
            return flag;
        }
    }
}
