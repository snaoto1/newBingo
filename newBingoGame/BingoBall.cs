using System;
namespace newBingoGame
{
    internal class BingoBall
    {
        public int[] bingoBall()
        {
            ArrayShuffle arrayshuffle = new ArrayShuffle();
            int[] bingoBall = new int[75];
            for (int i = 0; i < bingoBall.Length; i++)
            {
                bingoBall[i] = i + 1;
            }
            arrayshuffle.arrayShuffle(bingoBall);
                
            return bingoBall;
        }
    }
}
