using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixCalc
{
    public interface IMatrix
    {
        double[] MultiplyMatrix(int m, int n);
        double[] MultiplyMatrixSparse(int m, int n);
        double[] MultiplyMatrix0(int m, int n);
        double[] MultiplyMatrixSparse0(int m, int n);
    }
}
