using System;

namespace newBingoGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BingoBall bingoBall = new BingoBall();
            BingoCard bingoCard = new BingoCard();
            BingoCardFlag bingoFlag = new BingoCardFlag();
            int[,] bCard = bingoCard.bingoCard();
            int[] bBall = bingoBall.bingoBall();
            int[,] bCardFlag = new int[bCard.GetLength(0),bCard.GetLength(0)];
            bCardFlag[(bCard.GetLength(0)-1)/2, (bCard.GetLength(0) - 1) / 2] = 1;
            for (int i = 0; i < bBall.Length; i++)
            {
                int flagNaname1 = 0;
                int flagNaname2 = 0;
                int reach = 0;
                int bingo = 0;
                Console.WriteLine("ball[" + (i+1) + "]:" + bBall[i]);
                for (int y = 0; y < bCard.GetLength(0); y++)
                {
                    int flagX = 0;
                    int flagY = 0;
                    for (int x = 0; x < bCard.GetLength(0); x++)
                    {

                        bCardFlag = bingoFlag.bingoCardFlag(bCard,bBall[i], bCardFlag);
                        if (x == (bCard.GetLength(0) - 1) / 2 && y == (bCard.GetLength(0) - 1) / 2)
                        {
                            Console.Write("FREE");
                        }
                        else if (bCardFlag[x, y] == 0)
                        {
                            Console.Write(bCard[x, y].ToString(" 00 "));
                        }
                        else if (bCardFlag[x, y] == 1)
                        {
                            Console.Write(bCard[x, y].ToString("(00)"));
                        }

                        if (bCardFlag[x, y] == 1)
                        {
                            flagX++;
                            if (flagX == bCard.GetLength(0) - 1)
                            {
                                reach++;
                            }
                            if (flagX == bCard.GetLength(0))
                            {
                                bingo++;
                            }
                        }
                        if (bCardFlag[y, x] == 1)
                        {
                            flagY++;
                            if (flagY == bCard.GetLength(0) - 1)
                            {
                                reach++;
                            }
                            if (flagY == bCard.GetLength(0))
                            {
                                bingo++;
                            }
                        }
                    }

                    if (bCardFlag[y, y] == 1)
                    {
                        flagNaname1++;
                        if(flagNaname1 == bCard.GetLength(0) - 1)
                        {
                            reach++;
                        }
                        if(flagNaname1 == bCard.GetLength(0))
                        {
                            bingo++;
                        }
                    }
                    if (bCardFlag[bCard.GetLength(0) - 1-y, y] == 1)
                    {
                        flagNaname2++;
                        if (flagNaname2 == bCard.GetLength(0) - 1)
                        {
                            reach++;
                        }
                        if (flagNaname2 == bCard.GetLength(0))
                        {
                            bingo++;
                        }
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                Console.WriteLine("REACH:" + (reach - bingo));
                Console.WriteLine("BINGO:" + bingo);
                Console.WriteLine("--------------------");
            }
        }
    }
}
