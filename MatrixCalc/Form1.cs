using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace MatrixCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public double[] Multiply()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            Calculation c = new Calculation();

            int m=Convert.ToInt32(StringA.Text);//количество строк в матрице А
            int n = Convert.ToInt32(RowsA.Text);//количество столбцов в матрице А
            double[] res1 = new double[n];//результирующий массив
            res1 = c.MultiplyMatrix(m, n);

            dgvRes.ColumnCount = 1;
            for (int i = 0; i < res1.Length; i++)
            {
                
                dgvRes.Rows.Add();
                dgvRes[0, i].Value = res1[i];
            }

            stopwatch.Stop();

            textBox1.Text = (stopwatch.ElapsedMilliseconds).ToString();

            return res1;
        }

        public double[] MultiplyS()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            Calculation c = new Calculation();

            int m = Convert.ToInt32(StringA.Text);//количество строк в матрице А
            int n = Convert.ToInt32(RowsA.Text);//количество столбцов в матрице А
            double[] res2 = new double[n];//результирующий массив
            res2 = c.MultiplyMatrixSparse(m, n);

            
            dgvRes2.ColumnCount = 1;
            for (int i = 0; i < res2.Length; i++)
            {

                dgvRes2.Rows.Add();
                dgvRes2[0, i].Value = res2[i];
            }

            stopwatch.Stop();

            textBox2.Text = (stopwatch.ElapsedMilliseconds).ToString();


            return res2;
        }

        public double[] Multiply0()
        {
            
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start(); 

            Calculation c = new Calculation();

            int m = Convert.ToInt32(StringA.Text);//количество строк в матрице А
            int n = Convert.ToInt32(RowsA.Text);//количество столбцов в матрице А
            double[] res1 = new double[n];//результирующий массив
            res1 = c.MultiplyMatrix0(m, n);

            dgvRes01.ColumnCount = 1;
            for (int i = 0; i < res1.Length; i++)
            {

                dgvRes01.Rows.Add();
                dgvRes01[0, i].Value = res1[i];
            }

            stopwatch.Stop();

            Res.Text = (stopwatch.ElapsedMilliseconds).ToString();

            return res1;
        }

        public double[] MultiplyS0()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            Calculation c = new Calculation();

            int m = Convert.ToInt32(StringA.Text);//количество строк в матрице А
            int n = Convert.ToInt32(RowsA.Text);//количество столбцов в матрице А
            double[] res2 = new double[n];//результирующий массив
            res2 = c.MultiplyMatrixSparse0(m, n);


            dgvRes02.ColumnCount = 1;
            for (int i = 0; i < res2.Length; i++)
            {

                dgvRes02.Rows.Add();
                dgvRes02[0, i].Value = res2[i];
            }

            stopwatch.Stop();

            Res2.Text = (stopwatch.ElapsedMilliseconds).ToString();

            return res2;
        }



        private void btCalc_Click(object sender, EventArgs e)
        {
           
          
            Multiply();
            MultiplyS();
            Multiply0();
            MultiplyS0();


        }
    }
}
