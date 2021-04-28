using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3matricies
{
    class SquareMatricies
    {
        protected double[] Contents { get; set; }
        //goes from rows to columns, starting with 1
        protected int size;
        public SquareMatricies(double[] contents)
        {
            size = (int)Math.Floor( Math.Sqrt(contents.Length));
            Contents = new double[contents.Length];
            //Contents = contents;
            Array.Copy(contents, 0, Contents, 0, contents.Length);
        }
        public double[] GetRow(int rowNumber)
        {
            double[] row = new double[size];
            //Contents.CopyTo(row, rowNumber * size);
            Array.Copy(Contents, (rowNumber-1) * size, row, 0, size);
            return row;
        }
        public double[] GetColumn(int columnNumber)
        {
            double[] column = new double[size];
            for (int i=0; i<size;i++)
            {
                column[i] = GetElementAt(i+1, columnNumber);
            }
            return column;
        }
        public double GetElementAt(int rowNumber, int columnNumber)
        {
            return Contents[size * (rowNumber - 1) + columnNumber - 1];
        }
        public void DisplayMatrix()
        {
            for (int i = 0; i < size; i++)
            {
                double[] column = GetRow(i+1);
                for (int j = 0; j < size; j++)
                {
                    Console.Write(column[j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            
        }
    }
}
