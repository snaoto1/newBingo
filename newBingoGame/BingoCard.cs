using System;

namespace newBingoGame
{
    internal class BingoCard
    {
        private int[] randomNumber = new int[30];           //1列に何種類の数字が入るかを決める
        public int[,] bingoCard()
        {
            ArrayShuffle arrayShuffle = new ArrayShuffle();
            int[,] bingoCard = new int[7, 7];               //〇×〇のビンゴを作るか
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
        public int randomNumberLength()
        {
            int randomNumberLength = randomNumber.Length;
            return randomNumberLength;
        }
    }
}
