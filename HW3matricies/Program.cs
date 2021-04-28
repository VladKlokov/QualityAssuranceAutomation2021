using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3matricies
{
    class Program
    {
        static void Main(string[] args)
        {
            #region creating random matrix
            Random rnd = new Random();
            double[] newMatrix = new double[25];
            for (int i = 0; i < newMatrix.Length; i++)
            {
                newMatrix[i] = rnd.NextDouble();
            }
            #endregion
            SquareMatricies squareMatrix = new SquareMatricies(newMatrix);
            #region Square matrix check
            squareMatrix.DisplayMatrix();
            Console.WriteLine();
            displayOneDimensionalArray(squareMatrix.GetRow(2));
            displayOneDimensionalArray(squareMatrix.GetColumn(2));
            Console.WriteLine();
            #endregion
            DiagonalMatrix diagonalMatrix = new DiagonalMatrix(squareMatrix.GetColumn(1));
            #region Diagonal matrix check
            diagonalMatrix.DisplayMatrix();
            Console.WriteLine();
            displayOneDimensionalArray(diagonalMatrix.GetRow(2));
            displayOneDimensionalArray(diagonalMatrix.GetColumn(2));
            displayOneDimensionalArray(diagonalMatrix.GetDiagonal());
            #endregion
        }
        public static void displayOneDimensionalArray(double[] oneDimensionalArray)
        {
            foreach (double element in oneDimensionalArray)
            {
                Console.Write(element);
                Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
}
