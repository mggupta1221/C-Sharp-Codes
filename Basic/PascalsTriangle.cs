using System;

namespace Pascals_Triangle
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("enter integer:");
            int number = Convert.ToInt32(Console.ReadLine());
            int[,] pascalsTriangle = new int[number, number];

            int rows = number - 1;
            if (number == 0)
                Console.WriteLine(1);
            else
            {
                for (int rowCount = 0; rowCount <= rows; rowCount++)
                {
                    for (int columnCount = 0; columnCount <= rowCount; columnCount++)
                    {
                    if (columnCount == 0 || rowCount == columnCount)
                    {
                        
                            pascalsTriangle[rowCount,columnCount] = 1;
                    }
                    else
                    {
                            pascalsTriangle[rowCount, columnCount] = pascalsTriangle[rowCount-1, columnCount-1] + pascalsTriangle[rowCount - 1, columnCount];
                    }
                }
                }

                for (int rowCount = 0; rowCount <= rows; rowCount++)
                {
                    for (int columnCount = 0; columnCount <= rowCount; columnCount++)
                    {
                        Console.Write(pascalsTriangle[rowCount,columnCount]+" ");
                    }
                Console.WriteLine();
                }

            }
        }
    }
}