using System;
using System.Windows.Forms;

namespace Laba4_ShellSort
{
    public partial class OperationModeForm : Form
    {
        ShellSorter sorter = new ShellSorter(); // объект для управления сортировкой Шелла

        public OperationModeForm()
        {
            InitializeComponent();
            comboBoxCountNumbers.SelectedIndex = 0;
        }

        private void comboBoxCountNumbers_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonPlotGraph_Click(sender, e);
        }

        //Очистка графиков
        private void ClearChart()
        {
            chartForShellSort.Series[0].Points.Clear();
            chartForShellSort.Series[1].Points.Clear();
        }
        //Постройка графиков
        private void buttonPlotGraph_Click(object sender, EventArgs e)
        {
            ClearChart();

            int maxCountNumbers = Convert.ToInt32((string)comboBoxCountNumbers.SelectedItem);
            int step = maxCountNumbers / 10;
            int countNumbers = step;
            chartForShellSort.ChartAreas[0].AxisX.Minimum = countNumbers;
            chartForShellSort.ChartAreas[0].AxisX.Maximum = maxCountNumbers;
            while (countNumbers <= maxCountNumbers)
            {
                int[] array = new int[countNumbers];
                Random random = new Random();
                for (int i = 0; i < countNumbers; ++i)
                {
                    array[i] = random.Next();
                }
                sorter.SortForGraphics(array);
                chartForShellSort.Series[0].Points.AddXY(countNumbers, sorter.NumberOfSwaps);
                chartForShellSort.Series[1].Points.AddXY(countNumbers, sorter.NumberOfCompares);
                countNumbers += step;
            }
        }
    }
}
