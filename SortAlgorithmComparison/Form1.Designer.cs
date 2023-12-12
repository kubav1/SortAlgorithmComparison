namespace SortAlgorithmComparison
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.numericUpDownStart = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownIloscSerii = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownMnoznik = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AlgorithmComboBox = new System.Windows.Forms.ComboBox();
            this.ArrayTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ResultDataTable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIloscSerii)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMnoznik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultDataTable)).BeginInit();
            this.SuspendLayout();
            // 
            // chart
            // 
            chartArea2.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart.Legends.Add(legend2);
            this.chart.Location = new System.Drawing.Point(200, 0);
            this.chart.Name = "chart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Czas";
            this.chart.Series.Add(series2);
            this.chart.Size = new System.Drawing.Size(600, 450);
            this.chart.TabIndex = 0;
            this.chart.Text = "chart1";
            // 
            // numericUpDownStart
            // 
            this.numericUpDownStart.Location = new System.Drawing.Point(61, 50);
            this.numericUpDownStart.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownStart.Name = "numericUpDownStart";
            this.numericUpDownStart.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownStart.TabIndex = 1;
            this.numericUpDownStart.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // numericUpDownIloscSerii
            // 
            this.numericUpDownIloscSerii.Location = new System.Drawing.Point(61, 24);
            this.numericUpDownIloscSerii.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDownIloscSerii.Name = "numericUpDownIloscSerii";
            this.numericUpDownIloscSerii.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownIloscSerii.TabIndex = 2;
            this.numericUpDownIloscSerii.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.ArrayTypeComboBox);
            this.groupBox1.Controls.Add(this.AlgorithmComboBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.numericUpDownMnoznik);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numericUpDownIloscSerii);
            this.groupBox1.Controls.Add(this.numericUpDownStart);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(194, 190);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parametry";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(61, 157);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Sortuj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ButtonSort_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mnożnik";
            // 
            // numericUpDownMnoznik
            // 
            this.numericUpDownMnoznik.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownMnoznik.Location = new System.Drawing.Point(61, 76);
            this.numericUpDownMnoznik.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownMnoznik.Name = "numericUpDownMnoznik";
            this.numericUpDownMnoznik.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownMnoznik.TabIndex = 5;
            this.numericUpDownMnoznik.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Start";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ile serii";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Algorytm";
            // 
            // AlgorithmComboBox
            // 
            this.AlgorithmComboBox.FormattingEnabled = true;
            this.AlgorithmComboBox.Location = new System.Drawing.Point(60, 102);
            this.AlgorithmComboBox.Name = "AlgorithmComboBox";
            this.AlgorithmComboBox.Size = new System.Drawing.Size(121, 21);
            this.AlgorithmComboBox.TabIndex = 9;
            // 
            // ArrayTypeComboBox
            // 
            this.ArrayTypeComboBox.FormattingEnabled = true;
            this.ArrayTypeComboBox.Location = new System.Drawing.Point(61, 130);
            this.ArrayTypeComboBox.Name = "ArrayTypeComboBox";
            this.ArrayTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.ArrayTypeComboBox.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Ciąg";
            // 
            // ResultDataTable
            // 
            this.ResultDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResultDataTable.Location = new System.Drawing.Point(0, 196);
            this.ResultDataTable.Name = "ResultDataTable";
            this.ResultDataTable.Size = new System.Drawing.Size(194, 242);
            this.ResultDataTable.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ResultDataTable);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chart);
            this.Name = "Form1";
            this.Text = "Porównanie algorytmów sortujących";
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIloscSerii)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMnoznik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultDataTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.NumericUpDown numericUpDownStart;
        private System.Windows.Forms.NumericUpDown numericUpDownIloscSerii;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownMnoznik;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox AlgorithmComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ArrayTypeComboBox;
        private System.Windows.Forms.DataGridView ResultDataTable;
    }
}

