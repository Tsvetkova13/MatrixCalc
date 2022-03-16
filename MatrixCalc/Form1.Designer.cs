namespace MatrixCalc
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btCalc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.StringA = new System.Windows.Forms.TextBox();
            this.RowsA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.StringB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvRes = new System.Windows.Forms.DataGridView();
            this.Res = new System.Windows.Forms.TextBox();
            this.dgvRes2 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvRes01 = new System.Windows.Forms.DataGridView();
            this.dgvRes02 = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Res2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRes2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRes01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRes02)).BeginInit();
            this.SuspendLayout();
            // 
            // btCalc
            // 
            this.btCalc.Location = new System.Drawing.Point(313, 137);
            this.btCalc.Name = "btCalc";
            this.btCalc.Size = new System.Drawing.Size(139, 65);
            this.btCalc.TabIndex = 0;
            this.btCalc.Text = "Перемножить A*B";
            this.btCalc.UseVisualStyleBackColor = true;
            this.btCalc.Click += new System.EventHandler(this.btCalc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите размерность матрицы А";
            // 
            // StringA
            // 
            this.StringA.Location = new System.Drawing.Point(173, 65);
            this.StringA.Name = "StringA";
            this.StringA.Size = new System.Drawing.Size(100, 22);
            this.StringA.TabIndex = 2;
            // 
            // RowsA
            // 
            this.RowsA.Location = new System.Drawing.Point(173, 134);
            this.RowsA.Name = "RowsA";
            this.RowsA.Size = new System.Drawing.Size(100, 22);
            this.RowsA.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Количество строк";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Количество столбцов";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(221, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Введите размерность вектора В";
            // 
            // StringB
            // 
            this.StringB.Location = new System.Drawing.Point(173, 299);
            this.StringB.Name = "StringB";
            this.StringB.Size = new System.Drawing.Size(100, 22);
            this.StringB.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Количество строк";
            // 
            // dgvRes
            // 
            this.dgvRes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRes.Location = new System.Drawing.Point(493, 65);
            this.dgvRes.Name = "dgvRes";
            this.dgvRes.RowHeadersWidth = 51;
            this.dgvRes.RowTemplate.Height = 24;
            this.dgvRes.Size = new System.Drawing.Size(240, 150);
            this.dgvRes.TabIndex = 9;
            // 
            // Res
            // 
            this.Res.Location = new System.Drawing.Point(973, 486);
            this.Res.Name = "Res";
            this.Res.Size = new System.Drawing.Size(172, 22);
            this.Res.TabIndex = 10;
            // 
            // dgvRes2
            // 
            this.dgvRes2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRes2.Location = new System.Drawing.Point(493, 280);
            this.dgvRes2.Name = "dgvRes2";
            this.dgvRes2.RowHeadersWidth = 51;
            this.dgvRes2.RowTemplate.Height = 24;
            this.dgvRes2.Size = new System.Drawing.Size(240, 150);
            this.dgvRes2.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(435, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(363, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Результат перемножения плотной матрицы и вектора";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(392, 236);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(397, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Результат перемножения разреженной матрицы и вектора";
            // 
            // dgvRes01
            // 
            this.dgvRes01.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRes01.Location = new System.Drawing.Point(944, 65);
            this.dgvRes01.Name = "dgvRes01";
            this.dgvRes01.RowHeadersWidth = 51;
            this.dgvRes01.RowTemplate.Height = 24;
            this.dgvRes01.Size = new System.Drawing.Size(240, 150);
            this.dgvRes01.TabIndex = 14;
            // 
            // dgvRes02
            // 
            this.dgvRes02.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRes02.Location = new System.Drawing.Point(944, 280);
            this.dgvRes02.Name = "dgvRes02";
            this.dgvRes02.RowHeadersWidth = 51;
            this.dgvRes02.RowTemplate.Height = 24;
            this.dgvRes02.Size = new System.Drawing.Size(240, 150);
            this.dgvRes02.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(847, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(464, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "Результат перемножения плотной матрицы с большим количеством 0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(813, 236);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(498, 16);
            this.label9.TabIndex = 17;
            this.label9.Text = "Результат перемножения разреженной матрицы с большим количеством 0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(847, 489);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 16);
            this.label10.TabIndex = 18;
            this.label10.Text = "TIME Dense";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(847, 533);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 16);
            this.label11.TabIndex = 19;
            this.label11.Text = "TIME Sparse";
            // 
            // Res2
            // 
            this.Res2.Location = new System.Drawing.Point(973, 533);
            this.Res2.Name = "Res2";
            this.Res2.Size = new System.Drawing.Size(172, 22);
            this.Res2.TabIndex = 20;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(493, 465);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 21;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(493, 514);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1323, 617);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Res2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgvRes02);
            this.Controls.Add(this.dgvRes01);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvRes2);
            this.Controls.Add(this.Res);
            this.Controls.Add(this.dgvRes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.StringB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RowsA);
            this.Controls.Add(this.StringA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btCalc);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRes2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRes01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRes02)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCalc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox StringA;
        private System.Windows.Forms.TextBox RowsA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox StringB;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.DataGridView dgvRes;
        private System.Windows.Forms.TextBox Res;
        public System.Windows.Forms.DataGridView dgvRes2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvRes01;
        private System.Windows.Forms.DataGridView dgvRes02;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Res2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

