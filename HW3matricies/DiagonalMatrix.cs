using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3matricies
{
    class DiagonalMatrix : SquareMatricies
    {
        public DiagonalMatrix(double[] contents) : base(contents)
        {
            size = (contents.Length);
            Contents = new double[size * size];
            for (int i = 0; i<size; i++)
            {
                Contents[size * (i) + i] = contents[i];
            }
        }
        public double[] GetDiagonal()
        {
            double[] diag = new double[size];
            for (int i = 0; i < size; i++)
            {
                diag[i] = Contents[size * (i) + i];
            }
            return diag;
        }
    }
}
