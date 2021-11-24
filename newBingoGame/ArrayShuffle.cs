using System;

namespace newBingoGame
{
    internal class ArrayShuffle
    {
        Random random = new Random();
        public void arrayShuffle(int[] a)
        {
            for (int i = 0; i <a.Length; i++)
            {
                int j = random.Next(a.Length);
                int tmp = a[i];
                a[i] = a[j];
                a[j] = tmp;
            }
        }
    }
}
