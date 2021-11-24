using System;

namespace newBingoGame
{
    internal class BingoCard
    {
        public int[,] bingoCard()
        {
            ArrayShuffle arrayShuffle = new ArrayShuffle();
            int[] randomNumber = new int[15];
            int[,] bingoCard = new int[5, 5];
            for (int y = 0; y < bingoCard.GetLength(0); y++)
            {
                for (int x = 0; x < randomNumber.Length; x++)
                {
                    randomNumber[x] = y * randomNumber.Length + x + 1;
                }
                arrayShuffle.arrayShuffle(randomNumber);
                for (int x = 0; x < bingoCard.GetLength(0); x++)
                {
                    bingoCard[y, x] = randomNumber[x];
                }
            }
            return bingoCard;
        }
    }
}
