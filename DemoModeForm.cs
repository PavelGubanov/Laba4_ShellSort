using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba4_ShellSort
{
    public partial class DemoModeForm : Form
    {
        int[] array = new int[10];
        ShellSorter sorter = new ShellSorter();

        public DemoModeForm()
        {
            InitializeComponent();
        }

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

        private void buttonSortArray_Click(object sender, EventArgs e)
        {
            sorter.Sort(array, listBoxForNums, listBoxForSelectedNums, listBoxForSwapNums);
        }
    }
}
