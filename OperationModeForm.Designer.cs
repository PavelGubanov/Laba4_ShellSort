namespace Laba4_ShellSort
{
    partial class OperationModeForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chartForShellSort = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.comboBoxCountNumbers = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonPlotGraph = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartForShellSort)).BeginInit();
            this.SuspendLayout();
            // 
            // chartForShellSort
            // 
            chartArea4.Name = "ChartAreaShellSort";
            this.chartForShellSort.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartForShellSort.Legends.Add(legend4);
            this.chartForShellSort.Location = new System.Drawing.Point(24, 25);
            this.chartForShellSort.Name = "chartForShellSort";
            this.chartForShellSort.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series7.BorderWidth = 3;
            series7.ChartArea = "ChartAreaShellSort";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series7.Legend = "Legend1";
            series7.Name = "Перестановки";
            series8.BorderWidth = 3;
            series8.ChartArea = "ChartAreaShellSort";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            series8.Legend = "Legend1";
            series8.Name = "Сравнения";
            this.chartForShellSort.Series.Add(series7);
            this.chartForShellSort.Series.Add(series8);
            this.chartForShellSort.Size = new System.Drawing.Size(750, 358);
            this.chartForShellSort.TabIndex = 0;
            title4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title4.Name = "Title1";
            title4.Text = "Shell Sort";
            this.chartForShellSort.Titles.Add(title4);
            // 
            // comboBoxCountNumbers
            // 
            this.comboBoxCountNumbers.AutoCompleteCustomSource.AddRange(new string[] {
            "100",
            "500",
            "1000",
            "2000",
            "5000",
            "10000"});
            this.comboBoxCountNumbers.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCountNumbers.FormattingEnabled = true;
            this.comboBoxCountNumbers.Items.AddRange(new object[] {
            "100",
            "1000",
            "10000"});
            this.comboBoxCountNumbers.Location = new System.Drawing.Point(171, 402);
            this.comboBoxCountNumbers.Name = "comboBoxCountNumbers";
            this.comboBoxCountNumbers.Size = new System.Drawing.Size(121, 33);
            this.comboBoxCountNumbers.TabIndex = 1;
            this.comboBoxCountNumbers.SelectedIndexChanged += new System.EventHandler(this.comboBoxCountNumbers_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(19, 402);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Count numbers:";
            // 
            // buttonPlotGraph
            // 
            this.buttonPlotGraph.BackColor = System.Drawing.Color.Chartreuse;
            this.buttonPlotGraph.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPlotGraph.Location = new System.Drawing.Point(629, 402);
            this.buttonPlotGraph.Name = "buttonPlotGraph";
            this.buttonPlotGraph.Size = new System.Drawing.Size(145, 37);
            this.buttonPlotGraph.TabIndex = 3;
            this.buttonPlotGraph.Text = "Plot graph";
            this.buttonPlotGraph.UseVisualStyleBackColor = false;
            this.buttonPlotGraph.Click += new System.EventHandler(this.buttonPlotGraph_Click);
            // 
            // OperationModeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonPlotGraph);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxCountNumbers);
            this.Controls.Add(this.chartForShellSort);
            this.Name = "OperationModeForm";
            this.Text = "Operation Mode";
            ((System.ComponentModel.ISupportInitialize)(this.chartForShellSort)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartForShellSort;
        private System.Windows.Forms.ComboBox comboBoxCountNumbers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonPlotGraph;
    }
}