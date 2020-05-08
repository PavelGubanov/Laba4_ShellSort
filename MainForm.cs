using System;
using System.Windows.Forms;

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
            Hide();
            demoMode.ShowDialog();
        }
    }
}
