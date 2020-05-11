using System;
using System.Windows.Forms;

namespace Laba4_ShellSort
{
    //Форма для отображения процесса сортировки Шелла для целых чисел
    public partial class DemoModeForm : Form
    {
        int[] array = new int[10]; //массив для хранения сортируемых чисел
        ShellSorter sorter = new ShellSorter();//объект для управления сортировкой Шелла

        public DemoModeForm()
        {
            InitializeComponent();
        }
        //Рандомное заполнение массива из 10 чисел
        private void buttonFillArrayWithRandomNumbers_Click(object sender, EventArgs e)
        {
            listBoxForNums.Items.Clear();
            Random random = new Random();
            for (int i = 0; i < 10; ++i)
            {
                array[i] = random.Next(101);
                listBoxForNums.Items.Add(array[i]);
            }

            if (!buttonSortArray.Enabled)
            {
                buttonSortArray.Enabled = true;
            }
        }

        private void DemoModeForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; ++i)
            {
                listBoxForSelectedNums.Items.Add("");
                listBoxForSwapNums.Items.Add("");
            }
        }
        //Начать показ сортировки
        private void buttonSortArray_Click(object sender, EventArgs e)
        {
            sorter.SortForCartoon(array, listBoxForNums, listBoxForSelectedNums, listBoxForSwapNums);
            string text = "Сортировка окончена!\nЧисло перестановок: " + sorter.NumberOfSwaps + "\nЧисло сравнений: " + sorter.NumberOfCompares;
            MessageBox.Show(this, text, "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
