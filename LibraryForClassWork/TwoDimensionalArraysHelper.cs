using System;

namespace LibraryForClassWork
{
    public class TwoDimensionalArraysHelper
    {
        public static (int, int) MinI(int[,] array)
        {
            (int iMin, int jMin) = (0, 0);
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if(array[i, j] < array[iMin, jMin])
                    {
                        (iMin, jMin) = (i, j);
                    }
                }
            }

            return (iMin, jMin);
        }
    }
}
