namespace Laba4_ShellSort
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonDemoMode = new System.Windows.Forms.Button();
            this.buttonOperationMode = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonDemoMode
            // 
            this.buttonDemoMode.BackColor = System.Drawing.Color.Tomato;
            this.buttonDemoMode.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDemoMode.Location = new System.Drawing.Point(26, 29);
            this.buttonDemoMode.Name = "buttonDemoMode";
            this.buttonDemoMode.Size = new System.Drawing.Size(194, 86);
            this.buttonDemoMode.TabIndex = 0;
            this.buttonDemoMode.Text = "Demo Mode";
            this.buttonDemoMode.UseVisualStyleBackColor = false;
            this.buttonDemoMode.Click += new System.EventHandler(this.buttonDemoMode_Click);
            // 
            // buttonOperationMode
            // 
            this.buttonOperationMode.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonOperationMode.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOperationMode.Location = new System.Drawing.Point(247, 29);
            this.buttonOperationMode.Name = "buttonOperationMode";
            this.buttonOperationMode.Size = new System.Drawing.Size(194, 86);
            this.buttonOperationMode.TabIndex = 1;
            this.buttonOperationMode.Text = "Operation Mode";
            this.buttonOperationMode.UseVisualStyleBackColor = false;
            this.buttonOperationMode.Click += new System.EventHandler(this.buttonOperationMode_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 146);
            this.Controls.Add(this.buttonOperationMode);
            this.Controls.Add(this.buttonDemoMode);
            this.Name = "MainForm";
            this.Text = "Сортировка Шелла";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDemoMode;
        private System.Windows.Forms.Button buttonOperationMode;
    }
}

