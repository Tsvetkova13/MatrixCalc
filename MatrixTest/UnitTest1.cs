using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MatrixCalc;

namespace MatrixTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMultiply()
        {
            //assert 
            int m = 3;
            int n = 3;
            int k = 1;
            double[,] resExpected = new double[k,n];
            resExpected[0,0] = -176.8;
            resExpected[0,1] = -20.8;
            resExpected[0,2] = 135.2;
            //act
            IMatrix math = new Calculation();
            double[] res=new double[n];
            res = math.MultiplyMatrix(m, n);
           
            Assert.AreEqual(resExpected, res);

        }

        [TestMethod]
        public void TestMultiplyS()
        {
            //assert 
            int m = 3;
            int n = 3;
            int k = 1;
            double[,] resExpected = new double[k, n];
            resExpected[0, 0] = -176.8;
            resExpected[0, 1] = -20.8;
            resExpected[0, 2] = 135.2;
            //act
            IMatrix math = new Calculation();
            double[] res = new double[n];
            res = math.MultiplyMatrixSparse(m, n);

            Assert.AreEqual(resExpected, res);

        }

        [TestMethod]
        public void TestMultiply0()
        {
            //assert 
            int m = 3;
            int n = 3;
            //int k = 1;
            double[] resExpected = new double[ n];
            resExpected[ 0] = 0;
            resExpected[ 1] = 0;
            resExpected[ 2] = 0;
            //act
            IMatrix math = new Calculation();
            double[] res = new double[n];
            res = math.MultiplyMatrix0(m, n);

            Assert.AreEqual(resExpected, res);

        }
    }
}
