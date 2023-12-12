using SortAlgorithmComparison.Algorithms;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace SortAlgorithmComparison
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            PrepareComboBoxes();
            ButtonSort_Click(null, null);
        }

        private void PrepareComboBoxes()
        {
            AlgorithmComboBox.Items.AddRange(new string[]
            {
                "Bubble Sort",
                "Quick Sort",
                "Merge Sort",
                "Insertion Sort",
                "Selection Sort"
            });
            AlgorithmComboBox.SelectedIndex = 0;

            ArrayTypeComboBox.Items.AddRange(new string[] 
            {
                "Losowy",
                "Rosnący",
                "Malejący"
            });
            ArrayTypeComboBox.SelectedIndex = 0;
        }

        private void ButtonSort_Click(object sender, EventArgs e)
        {
            GC.Collect();
            var chartArea = chart.ChartAreas[0];
            chartArea.AxisX.Title = "Ilość elementów";
            chartArea.AxisX.CustomLabels.Clear();
            chartArea.AxisY.Title = "Czas trwania";
            chartArea.AxisY.LabelStyle.Format = "0ms";
            chart.Series.Clear();

            var dataSource = new BindingSource();
            var n = (int)numericUpDownStart.Value;
            var arrayType = (ArrayType)ArrayTypeComboBox.SelectedIndex;
            var series = new Series { ChartType = SeriesChartType.Line, Name = "Czas trwania" };
            var i = 1;
            for (var j = 0; j < (int)numericUpDownIloscSerii.Value; j++)
            {
                SortAlgorithm algorithm = null;
                switch ((SortAlgorithmType)AlgorithmComboBox.SelectedIndex)
                {
                    case SortAlgorithmType.BubbleSort:
                        algorithm = new BubbleSort(n, arrayType);
                        break;
                    case SortAlgorithmType.QuickSort:
                        algorithm = new QuickSort(n, arrayType);
                        break;
                    case SortAlgorithmType.MergeSort:
                        algorithm = new MergeSort(n, arrayType);
                        break;
                    case SortAlgorithmType.InsertionSort:
                        algorithm = new InsertionSort(n, arrayType);
                        break;
                    case SortAlgorithmType.SelectionSort:
                        algorithm = new SelectionSort(n, arrayType);
                        break;
                }
                algorithm.Sort();
                var d = new DataPoint(i, algorithm.Duration)
                {
                    Label = algorithm.Duration.ToString(),
                    MarkerStyle = MarkerStyle.Circle,
                    MarkerSize = 10,
                    MarkerColor = Color.Red
                };
                series.Points.Add(d);
                chartArea.AxisX.CustomLabels.Add(i - 0.5, i + 0.5, n.ToString());
                dataSource.Add(new { Elementy = n.ToString(), Czas = algorithm.Duration });
                i++;
                n *= (int)numericUpDownMnoznik.Value;
                if (algorithm.Duration > 1000) break;
            }

            chart.Series.Add(series);
            chartArea.RecalculateAxesScale();

            ResultDataTable.DataSource = dataSource;
            ResultDataTable.Columns[0].DataPropertyName = "Elementy";
            ResultDataTable.Columns[1].DataPropertyName = "Czas";
        }
    }
}
