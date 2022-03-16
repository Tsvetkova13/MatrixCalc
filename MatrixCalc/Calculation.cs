using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics.LinearAlgebra;
//using MathNet.Numerics.LinearAlgebra.Complex;
//using MathNet.Numerics.LinearAlgebra.Double;



namespace MatrixCalc
{
    
    public class Calculation:IMatrix
    {
        public double[] MultiplyMatrix(int m, int n)

        {


            Matrix<double> A = Matrix<double>.Build.Dense(m, n, (i, j) => 5.2 * (i - j));//создали матрицу А
            Vector<double> B = Vector<double>.Build.Dense(n, i => (i + 4) * 2);//создали вектор В
            Vector<double> Res = Vector<double>.Build.Dense(n);//создали результирующий вектор

            Res = A.Multiply(B);

            return Res.ToArray();
          
        }

        public double[] MultiplyMatrixSparse(int m, int n)

        {


            Matrix<double> A = Matrix<double>.Build.Sparse(m, n, (i, j) => 5.2 * (i - j));//создали матрицу А
            Vector<double> B = Vector<double>.Build.Sparse(n, i => (i + 4) * 2);//создали вектор В
            Vector<double> Res = Vector<double>.Build.Sparse(n);//создали результирующий вектор

            Res = A.Multiply(B);

            return Res.ToArray();

        }

        public double[] MultiplyMatrix0(int m, int n)

        {



            Matrix<double> A = Matrix<double>.Build.DenseDiagonal(m,n,5);//создали матрицу А
            Vector<double> B = Vector<double>.Build.Dense(n, i => (i + 4) * 2);//создали вектор В
            Vector<double> Res = Vector<double>.Build.Dense(n);//создали результирующий вектор

            
            Res = A.Multiply(B);

            return Res.ToArray();

        }

        public double[] MultiplyMatrixSparse0(int m, int n)

        {


            Matrix<double> A = Matrix<double>.Build.SparseDiagonal(m,n, 5);//создали матрицу А
            Vector<double> B = Vector<double>.Build.Sparse(n, i => (i + 4) * 2);//создали вектор В
            Vector<double> Res = Vector<double>.Build.Sparse(n);//создали результирующий вектор

            Res = A.Multiply(B);

            return Res.ToArray();

        }

    }
}
