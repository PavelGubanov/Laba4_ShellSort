using System;
using System.Threading;
using System.Windows.Forms;

namespace Laba4_ShellSort
{  
    //Класс, описывающий сортировку Шелла
    class ShellSorter
    {
        public int NumberOfCompares { get; private set; } //количество сравнений
        public int NumberOfSwaps { get; private set; } //количество перестановок
        public static string selectedNumber = "--> "; //показывает, что элемент отобран
                                                      //на текущем шаге для сортировки вставками 

        //Возвращает массив с шагами для заданного количества чисел в массиве по формуле из задания
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

        //Отображает числа в отдельном ListBox с заданным шагом
        private void ShowNumsWithStep(ListBox listBoxForNums, ListBox listBoxForSelectedNums, int[]array, int startIndex, int step)
        {
            for (int i = startIndex; i < array.Length; i += step)
            {
                listBoxForSelectedNums.Items[i] = array[i];                          
                listBoxForNums.Items[i] = selectedNumber;
            }
            listBoxForNums.Refresh();
            listBoxForSelectedNums.Refresh();
            Thread.Sleep(1000);
        }

        //Обновляет отсортированные числа в ListBox с выбранными числами
        private void ShowSortedNumsWithStep(ListBox listBoxForSelectedNums, ListBox listBoxForSwapNums, int[] array, int startIndex, int step, int predNum, int currentNum)
        {            
            if (predNum != currentNum)
            {
                for (int i = startIndex; i < array.Length; i += step)
                {
                    if (i == currentNum)
                    {
                        listBoxForSelectedNums.Items[i] = "";
                    }
                    else
                    {
                        listBoxForSelectedNums.Items[i] = array[i];
                    }
                }
                listBoxForSwapNums.Items[currentNum] = listBoxForSwapNums.Items[predNum];
                listBoxForSwapNums.Items[predNum] = "";
                listBoxForSwapNums.Refresh();
                listBoxForSelectedNums.Refresh();
                Thread.Sleep(1000);
            }            
        }

        //Возвращает все числа обратно в общий ListBox
        private void ReturnAllNumsFromSelectedNums(ListBox listBoxForNums, ListBox listBoxForSelectedNums, int length, int startIndex, int step)
        {
            for (int i = startIndex; i < length; i += step)
            {                
                listBoxForNums.Items[i] = listBoxForSelectedNums.Items[i];
                listBoxForSelectedNums.Items[i] = "";
            }
            listBoxForNums.Refresh();
            listBoxForSelectedNums.Refresh();
            Thread.Sleep(1000);
        }

        //Показывает заданное число в отдельном ListBox
        private void ShowNumber(ListBox listBoxForSelectedNums, ListBox listBoxForSwapNums, int i)
        {
            listBoxForSwapNums.Items[i] = listBoxForSelectedNums.Items[i];
            listBoxForSelectedNums.Items[i] = "";
            listBoxForSwapNums.Refresh();
            listBoxForSelectedNums.Refresh();
            Thread.Sleep(1000);
        }

        //Возвращает заданное число обратно в список отобранных чисел с заданным шагом
        private void ReturnNumber(ListBox listBoxForSelectedNums, ListBox listBoxForSwapNums, int i)
        {
            listBoxForSelectedNums.Items[i] = listBoxForSwapNums.Items[i];
            listBoxForSwapNums.Items[i] = "";
            listBoxForSwapNums.Refresh();
            listBoxForSelectedNums.Refresh();
            Thread.Sleep(1000);
        }

        //Сортировка Шелла с отображением в ListBox-ах
        public void SortForCartoon (int[] array, ListBox listBoxForNums, ListBox listBoxForSelectedNums, ListBox listBoxForSwapNums)
        {
            NumberOfCompares = 0;
            NumberOfSwaps = 0;
            int[] stepSeries = GetStepSeries(array.Length); // вычисляем последовательность шагов для заданной размерности массива
            int countSteps = stepSeries.Length; // вычисляем количество шагов
            for (int j = 0; j < countSteps; j++)
            {
                int step = stepSeries[j];
                for (int p = 0; p < step; p++) // применяем сортировку вставками для всех групп
                {
                    ShowNumsWithStep(listBoxForNums, listBoxForSelectedNums, array, p, step);
                    int i = step + p;
                    while (i < array.Length)
                    {
                        int elem = array[i];
                        ShowNumber(listBoxForSelectedNums, listBoxForSwapNums, i);
                        int l = i - step;
                        while ((l >= 0) && CompareNumbers(elem, array[l]))
                        {
                            ++NumberOfSwaps;
                            array[l + step] = array[l];
                            l -= step;                                                        
                        }
                        ShowSortedNumsWithStep(listBoxForSelectedNums, listBoxForSwapNums, array, p, step, i, l + step);
                        ReturnNumber(listBoxForSelectedNums, listBoxForSwapNums, l + step);
                        array[l + step] = elem;
                        ++NumberOfSwaps;
                        i += step;
                    } // while
                    ReturnAllNumsFromSelectedNums(listBoxForNums, listBoxForSelectedNums, array.Length, p, step);
                } // for
            } // for
        }

        private bool CompareNumbers(int a, int b)
        {
            ++NumberOfCompares;
            return a < b;
        }

        //Сортировка Шелла для вычисления количества перестановок и количество сравнений для заданного массива чисел
        public void SortForGraphics(int[] array)
        {
            NumberOfCompares = 0;
            NumberOfSwaps = 0;
            int[] stepSeries = GetStepSeries(array.Length); // вычисляем последовательность шагов для заданной размерности массива
            int countSteps = stepSeries.Length; // вычисляем количество шагов
            for (int j = 0; j < countSteps; j++)
            {
                int step = stepSeries[j];
                for (int p = 0; p < step; p++) // применяем сортировку вставками для всех групп
                {
                    int i = step + p;
                    while (i < array.Length)
                    {
                        int elem = array[i];
                        int l = i - step;
                        while ((l >= 0) && CompareNumbers(elem, array[l]))
                        {
                            ++NumberOfSwaps;
                            array[l + step] = array[l];
                            l -= step;
                        }
                        array[l + step] = elem;
                        ++NumberOfSwaps;
                        i += step;
                    } // while
                } // for
            } // for
        }
    }
}
