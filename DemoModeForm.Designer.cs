namespace Laba4_ShellSort
{
    partial class DemoModeForm
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
            this.listBoxForNums = new System.Windows.Forms.ListBox();
            this.buttonSortArray = new System.Windows.Forms.Button();
            this.buttonFillArrayWithRandomNumbers = new System.Windows.Forms.Button();
            this.listBoxForSelectedNums = new System.Windows.Forms.ListBox();
            this.listBoxForSwapNums = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBoxForNums
            // 
            this.listBoxForNums.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxForNums.FormattingEnabled = true;
            this.listBoxForNums.ItemHeight = 32;
            this.listBoxForNums.Location = new System.Drawing.Point(12, 12);
            this.listBoxForNums.Name = "listBoxForNums";
            this.listBoxForNums.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBoxForNums.Size = new System.Drawing.Size(178, 324);
            this.listBoxForNums.TabIndex = 0;
            // 
            // buttonSortArray
            // 
            this.buttonSortArray.BackColor = System.Drawing.Color.LawnGreen;
            this.buttonSortArray.Enabled = false;
            this.buttonSortArray.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSortArray.Location = new System.Drawing.Point(21, 356);
            this.buttonSortArray.Name = "buttonSortArray";
            this.buttonSortArray.Size = new System.Drawing.Size(267, 41);
            this.buttonSortArray.TabIndex = 1;
            this.buttonSortArray.Text = "Sort";
            this.buttonSortArray.UseVisualStyleBackColor = false;
            this.buttonSortArray.Click += new System.EventHandler(this.buttonSortArray_Click);
            // 
            // buttonFillArrayWithRandomNumbers
            // 
            this.buttonFillArrayWithRandomNumbers.BackColor = System.Drawing.Color.Cyan;
            this.buttonFillArrayWithRandomNumbers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFillArrayWithRandomNumbers.Location = new System.Drawing.Point(303, 356);
            this.buttonFillArrayWithRandomNumbers.Name = "buttonFillArrayWithRandomNumbers";
            this.buttonFillArrayWithRandomNumbers.Size = new System.Drawing.Size(266, 41);
            this.buttonFillArrayWithRandomNumbers.TabIndex = 2;
            this.buttonFillArrayWithRandomNumbers.Text = "Fill array with random numbers";
            this.buttonFillArrayWithRandomNumbers.UseVisualStyleBackColor = false;
            this.buttonFillArrayWithRandomNumbers.Click += new System.EventHandler(this.buttonFillArrayWithRandomNumbers_Click);
            // 
            // listBoxForSelectedNums
            // 
            this.listBoxForSelectedNums.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxForSelectedNums.FormattingEnabled = true;
            this.listBoxForSelectedNums.ItemHeight = 32;
            this.listBoxForSelectedNums.Location = new System.Drawing.Point(205, 12);
            this.listBoxForSelectedNums.Name = "listBoxForSelectedNums";
            this.listBoxForSelectedNums.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBoxForSelectedNums.Size = new System.Drawing.Size(178, 324);
            this.listBoxForSelectedNums.TabIndex = 3;
            // 
            // listBoxForSwapNums
            // 
            this.listBoxForSwapNums.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxForSwapNums.FormattingEnabled = true;
            this.listBoxForSwapNums.ItemHeight = 32;
            this.listBoxForSwapNums.Location = new System.Drawing.Point(399, 12);
            this.listBoxForSwapNums.Name = "listBoxForSwapNums";
            this.listBoxForSwapNums.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBoxForSwapNums.Size = new System.Drawing.Size(178, 324);
            this.listBoxForSwapNums.TabIndex = 4;
            // 
            // DemoModeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 409);
            this.Controls.Add(this.listBoxForSwapNums);
            this.Controls.Add(this.listBoxForSelectedNums);
            this.Controls.Add(this.buttonFillArrayWithRandomNumbers);
            this.Controls.Add(this.buttonSortArray);
            this.Controls.Add(this.listBoxForNums);
            this.Name = "DemoModeForm";
            this.Text = "Demo Mode";
            this.Load += new System.EventHandler(this.DemoModeForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxForNums;
        private System.Windows.Forms.Button buttonSortArray;
        private System.Windows.Forms.Button buttonFillArrayWithRandomNumbers;
        private System.Windows.Forms.ListBox listBoxForSelectedNums;
        private System.Windows.Forms.ListBox listBoxForSwapNums;
    }
}