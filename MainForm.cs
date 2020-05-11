using System;
using System.Windows.Forms;

//Губанов Павел Романович - 2 курс, 9 группа
//Лаба на внутренние сортировки - номер 9а (Сортировка Шелла с вычислением шага по заданной формуле в пункте а)

namespace Laba4_ShellSort
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonDemoMode_Click(object sender, EventArgs e)
        {
            DemoModeForm demoMode = new DemoModeForm();
            demoMode.ShowDialog(this);
        }

        private void buttonOperationMode_Click(object sender, EventArgs e)
        {
            OperationModeForm operationMode = new OperationModeForm();
            operationMode.ShowDialog(this);
        }
    }
}
