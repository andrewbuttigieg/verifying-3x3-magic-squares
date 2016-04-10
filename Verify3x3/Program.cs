using System;
using System.Collections.Generic;

namespace Verify3x3
{
    public class Program
    {
        public static bool IsMagicSquare(List<int> square){
            int columns = Int32.Parse(Math.Sqrt(square.Count).ToString());
                
            int magicSum = 0;
            bool toReturn = true;
            
            int forwardDiagnal = 0; // => 0, 4, 8
            int backwardDiagnal = 0;// => 2, 4, 6
            
            for (int i = 0; i < columns; i++){
                int rowSum = 0;
                int columnSum = 0;
                for (int j = 0; j < columns; j++){
                    columnSum += square[(i * columns) + j];
                    rowSum += square[i + (j * columns)];
                }
                if (magicSum == 0)
                    magicSum = columnSum;
                if(columnSum != magicSum) 
                    toReturn = false;
                if (rowSum != magicSum)
                    toReturn = false;
                forwardDiagnal += square[i * columns + i];
                backwardDiagnal += square[(columns * (i + 1))- (i + 1)];
            }
            
            if (forwardDiagnal != magicSum)
                toReturn = false;
            if (backwardDiagnal != magicSum)
                toReturn = false;
                
            return toReturn;
        }
        
        public static void Main(string[] args)
        {
            Console.WriteLine(IsMagicSquare(new List<int>{8, 1, 6, 3, 5, 7, 4, 9, 2}));
            Console.WriteLine(IsMagicSquare(new List<int>{2, 7, 6, 9, 5, 1, 4, 3, 8}));
            Console.WriteLine(IsMagicSquare(new List<int>{3, 5, 7, 8, 1, 6, 4, 9, 2}));
            Console.WriteLine(IsMagicSquare(new List<int>{8, 1, 6, 7, 5, 3, 4, 9, 2}));
            Console.WriteLine(IsMagicSquare(new List<int>{4, 9, 2, 3, 5, 7, 8, 1, 6}));
            
            
            Console.Read();
        }
    }
}
