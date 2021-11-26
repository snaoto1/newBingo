using System;
namespace newBingoGame
{
    internal class BingoBall
    {
        public int[] bingoBall()
        {
            ArrayShuffle arrayshuffle = new ArrayShuffle();
            //bingoCard[,]配列の長さを取得する
            BingoCard bCard = new BingoCard();
            int[,] bingoCardLength = bCard.bingoCard();
            int[] bingoBall = new int[bCard.randomNumber.Length * bingoCardLength.GetLength(0)];
            for (int i = 0; i < bingoBall.Length; i++)
            {
                bingoBall[i] = i + 1;
            }
            arrayshuffle.arrayShuffle(bingoBall);
                
            return bingoBall;
        }
    }
}
