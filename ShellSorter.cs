using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba4_ShellSort
{
    class ShellSorter
    {
        public static string selectedNumber = " --> ";
        
        private int[] GetStepSeries (int N)
        {
            int sizeSeries = (int)Math.Truncate(Math.Log(N, 3));
            if (sizeSeries == 0)
            {
                sizeSeries = 1; // тот случай, когда в массиве 1 или 2 элемента
            }
            int[] stepSeries = new int[sizeSeries];
            stepSeries[sizeSeries - 1] = 1;
            for (int i = sizeSeries - 2; i >= 0; --i)
            {
                stepSeries[i] = 3 * stepSeries[i + 1] + 1;
            }
            return stepSeries;
        }

        private void ShowNumsWithStep(ListBox listBoxForNums, ListBox listBoxForSelectedNums, int[]array, int startIndex, int step)
        {
            for (int i = startIndex; i < array.Length; i += step)
            {
                listBoxForSelectedNums.Items[i] = array[i];
                listBoxForNums.Items[i] = selectedNumber;
            }
            listBoxForNums.Refresh();
            listBoxForSelectedNums.Refresh();
            Thread.Sleep(500);
        }

        private void ShowCurrentNumberForComparison(ListBox listBoxForSelectedNums, ListBox listBoxForSwapNums, )

        public void Sort (int[] array, ListBox listBoxForNums, ListBox listBoxForSelectedNums, ListBox listBoxForSwapNums)
        {
            int[] stepSeries = GetStepSeries(array.Length); // вычисляем последовательность шагов для заданной размерности массива
            int countSteps = stepSeries.Length; // вычисляем количество шагов
            for (int j = 0; j < countSteps; j++)
            {
                int step = stepSeries[j];
                for (int p = 0; p < step; p++) // применяем сортировку вставками для всех групп
                {
                    ShowNumsWithStep(listBoxForNums, listBoxForSelectedNums, array, p, step);
                    int i = step + p;
                    while (i <= array.Length)
                    {
                        int elem = array[i];
                        int l = i - step;
                        bool needExchande = elem < array[l];
                        while ((l >= 0) && needExchande)
                        {
                            array[l + step] = array[l];
                            l -= step;
                        }
                        array[l + step] = elem;
                        i += step;
                    } // while
                } // for
            } // for
        }
    }
}
