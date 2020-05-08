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
            this.buttonDemoMode = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
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
            // buttonDemoMode
            // 
            this.buttonDemoMode.BackColor = System.Drawing.Color.LawnGreen;
            this.buttonDemoMode.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDemoMode.Location = new System.Drawing.Point(120, 356);
            this.buttonDemoMode.Name = "buttonDemoMode";
            this.buttonDemoMode.Size = new System.Drawing.Size(178, 38);
            this.buttonDemoMode.TabIndex = 1;
            this.buttonDemoMode.Text = "Sort";
            this.buttonDemoMode.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Cyan;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(313, 356);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 38);
            this.button1.TabIndex = 2;
            this.button1.Text = "Fill random numbers";
            this.button1.UseVisualStyleBackColor = false;
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
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonDemoMode);
            this.Controls.Add(this.listBoxForNums);
            this.Name = "DemoModeForm";
            this.Text = "Demo Mode";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxForNums;
        private System.Windows.Forms.Button buttonDemoMode;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBoxForSelectedNums;
        private System.Windows.Forms.ListBox listBoxForSwapNums;
    }
}