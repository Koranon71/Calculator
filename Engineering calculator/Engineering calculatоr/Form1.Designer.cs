namespace Engineering_calculatоr
{
    partial class Calculator
    {
        private System.ComponentModel.IContainer components = null;

        // Переменные элементов управления
        private System.Windows.Forms.TextBox textBox_Result;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.Button button_Equals;
        // Кнопки для цифр
        private System.Windows.Forms.Button button_0;
        private System.Windows.Forms.Button button_1;
        private System.Windows.Forms.Button button_2;
        private System.Windows.Forms.Button button_3;
        private System.Windows.Forms.Button button_4;
        private System.Windows.Forms.Button button_5;
        private System.Windows.Forms.Button button_6;
        private System.Windows.Forms.Button button_7;
        private System.Windows.Forms.Button button_8;
        private System.Windows.Forms.Button button_9;
        // Кнопки для операций
        private System.Windows.Forms.Button button_Plus;
        private System.Windows.Forms.Button button_Minus;
        private System.Windows.Forms.Button button_Multiply;
        private System.Windows.Forms.Button button_Divide;

        private void InitializeComponent()
        {
            this.textBox_Result = new System.Windows.Forms.TextBox();
            this.button_Clear = new System.Windows.Forms.Button();
            this.button_Equals = new System.Windows.Forms.Button();
            this.button_0 = new System.Windows.Forms.Button();
            this.button_1 = new System.Windows.Forms.Button();
            this.button_2 = new System.Windows.Forms.Button();
            this.button_3 = new System.Windows.Forms.Button();
            this.button_4 = new System.Windows.Forms.Button();
            this.button_5 = new System.Windows.Forms.Button();
            this.button_6 = new System.Windows.Forms.Button();
            this.button_7 = new System.Windows.Forms.Button();
            this.button_8 = new System.Windows.Forms.Button();
            this.button_9 = new System.Windows.Forms.Button();
            this.button_Plus = new System.Windows.Forms.Button();
            this.button_Minus = new System.Windows.Forms.Button();
            this.button_Multiply = new System.Windows.Forms.Button();
            this.button_Divide = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_Result
            // 
            this.textBox_Result.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.textBox_Result.Location = new System.Drawing.Point(12, 12);
            this.textBox_Result.Name = "textBox_Result";
            this.textBox_Result.ReadOnly = true;
            this.textBox_Result.Size = new System.Drawing.Size(260, 43);
            this.textBox_Result.TabIndex = 0;
            this.textBox_Result.Text = "0";
            this.textBox_Result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button_Clear
            // 
            this.button_Clear.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button_Clear.Location = new System.Drawing.Point(10, 238);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(65, 50);
            this.button_Clear.TabIndex = 1;
            this.button_Clear.Text = "C";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.ClearButtonClick);
            // 
            // button_Equals
            // 
            this.button_Equals.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button_Equals.Location = new System.Drawing.Point(152, 238);
            this.button_Equals.Name = "button_Equals";
            this.button_Equals.Size = new System.Drawing.Size(65, 50);
            this.button_Equals.TabIndex = 2;
            this.button_Equals.Text = "=";
            this.button_Equals.UseVisualStyleBackColor = true;
            this.button_Equals.Click += new System.EventHandler(this.EqualsButtonClick);
            // 
            // button_0
            // 
            this.button_0.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button_0.Location = new System.Drawing.Point(81, 238);
            this.button_0.Name = "button_0";
            this.button_0.Size = new System.Drawing.Size(65, 50);
            this.button_0.TabIndex = 3;
            this.button_0.Text = "0";
            this.button_0.UseVisualStyleBackColor = true;
            this.button_0.Click += new System.EventHandler(this.NumberButtonClick);
            // 
            // button_1
            // 
            this.button_1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button_1.Location = new System.Drawing.Point(10, 182);
            this.button_1.Name = "button_1";
            this.button_1.Size = new System.Drawing.Size(65, 50);
            this.button_1.TabIndex = 4;
            this.button_1.Text = "1";
            this.button_1.UseVisualStyleBackColor = true;
            this.button_1.Click += new System.EventHandler(this.NumberButtonClick);
            // 
            // button_2
            // 
            this.button_2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button_2.Location = new System.Drawing.Point(81, 182);
            this.button_2.Name = "button_2";
            this.button_2.Size = new System.Drawing.Size(65, 50);
            this.button_2.TabIndex = 5;
            this.button_2.Text = "2";
            this.button_2.UseVisualStyleBackColor = true;
            this.button_2.Click += new System.EventHandler(this.NumberButtonClick);
            // 
            // button_3
            // 
            this.button_3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button_3.Location = new System.Drawing.Point(152, 182);
            this.button_3.Name = "button_3";
            this.button_3.Size = new System.Drawing.Size(65, 50);
            this.button_3.TabIndex = 6;
            this.button_3.Text = "3";
            this.button_3.UseVisualStyleBackColor = true;
            this.button_3.Click += new System.EventHandler(this.NumberButtonClick);
            // 
            // button_4
            // 
            this.button_4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button_4.Location = new System.Drawing.Point(10, 126);
            this.button_4.Name = "button_4";
            this.button_4.Size = new System.Drawing.Size(65, 50);
            this.button_4.TabIndex = 7;
            this.button_4.Text = "4";
            this.button_4.UseVisualStyleBackColor = true;
            this.button_4.Click += new System.EventHandler(this.NumberButtonClick);
            // 
            // button_5
            // 
            this.button_5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button_5.Location = new System.Drawing.Point(81, 126);
            this.button_5.Name = "button_5";
            this.button_5.Size = new System.Drawing.Size(65, 50);
            this.button_5.TabIndex = 8;
            this.button_5.Text = "5";
            this.button_5.UseVisualStyleBackColor = true;
            this.button_5.Click += new System.EventHandler(this.NumberButtonClick);
            // 
            // button_6
            // 
            this.button_6.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button_6.Location = new System.Drawing.Point(152, 126);
            this.button_6.Name = "button_6";
            this.button_6.Size = new System.Drawing.Size(65, 50);
            this.button_6.TabIndex = 9;
            this.button_6.Text = "6";
            this.button_6.UseVisualStyleBackColor = true;
            this.button_6.Click += new System.EventHandler(this.NumberButtonClick);
            // 
            // button_7
            // 
            this.button_7.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button_7.Location = new System.Drawing.Point(10, 70);
            this.button_7.Name = "button_7";
            this.button_7.Size = new System.Drawing.Size(65, 50);
            this.button_7.TabIndex = 10;
            this.button_7.Text = "7";
            this.button_7.UseVisualStyleBackColor = true;
            this.button_7.Click += new System.EventHandler(this.NumberButtonClick);
            // 
            // button_8
            // 
            this.button_8.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button_8.Location = new System.Drawing.Point(81, 70);
            this.button_8.Name = "button_8";
            this.button_8.Size = new System.Drawing.Size(65, 50);
            this.button_8.TabIndex = 11;
            this.button_8.Text = "8";
            this.button_8.UseVisualStyleBackColor = true;
            this.button_8.Click += new System.EventHandler(this.NumberButtonClick);
            // 
            // button_9
            // 
            this.button_9.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button_9.Location = new System.Drawing.Point(152, 70);
            this.button_9.Name = "button_9";
            this.button_9.Size = new System.Drawing.Size(65, 50);
            this.button_9.TabIndex = 12;
            this.button_9.Text = "9";
            this.button_9.UseVisualStyleBackColor = true;
            this.button_9.Click += new System.EventHandler(this.NumberButtonClick);
            // 
            // button_Plus
            // 
            this.button_Plus.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button_Plus.Location = new System.Drawing.Point(223, 70);
            this.button_Plus.Name = "button_Plus";
            this.button_Plus.Size = new System.Drawing.Size(65, 50);
            this.button_Plus.TabIndex = 13;
            this.button_Plus.Text = "+";
            this.button_Plus.UseVisualStyleBackColor = true;
            this.button_Plus.Click += new System.EventHandler(this.OperationButtonClick);
            // 
            // button_Minus
            // 
            this.button_Minus.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button_Minus.Location = new System.Drawing.Point(223, 126);
            this.button_Minus.Name = "button_Minus";
            this.button_Minus.Size = new System.Drawing.Size(65, 50);
            this.button_Minus.TabIndex = 14;
            this.button_Minus.Text = "-";
            this.button_Minus.UseVisualStyleBackColor = true;
            this.button_Minus.Click += new System.EventHandler(this.OperationButtonClick);
            // 
            // button_Multiply
            // 
            this.button_Multiply.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button_Multiply.Location = new System.Drawing.Point(223, 182);
            this.button_Multiply.Name = "button_Multiply";
            this.button_Multiply.Size = new System.Drawing.Size(65, 50);
            this.button_Multiply.TabIndex = 15;
            this.button_Multiply.Text = "*";
            this.button_Multiply.UseVisualStyleBackColor = true;
            this.button_Multiply.Click += new System.EventHandler(this.OperationButtonClick);
            // 
            // button_Divide
            // 
            this.button_Divide.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button_Divide.Location = new System.Drawing.Point(223, 238);
            this.button_Divide.Name = "button_Divide";
            this.button_Divide.Size = new System.Drawing.Size(65, 50);
            this.button_Divide.TabIndex = 16;
            this.button_Divide.Text = "/";
            this.button_Divide.UseVisualStyleBackColor = true;
            this.button_Divide.Click += new System.EventHandler(this.OperationButtonClick);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 317);
            this.Controls.Add(this.button_Divide);
            this.Controls.Add(this.button_Multiply);
            this.Controls.Add(this.button_Minus);
            this.Controls.Add(this.button_Plus);
            this.Controls.Add(this.button_9);
            this.Controls.Add(this.button_8);
            this.Controls.Add(this.button_7);
            this.Controls.Add(this.button_6);
            this.Controls.Add(this.button_5);
            this.Controls.Add(this.button_4);
            this.Controls.Add(this.button_3);
            this.Controls.Add(this.button_2);
            this.Controls.Add(this.button_1);
            this.Controls.Add(this.button_0);
            this.Controls.Add(this.button_Equals);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.textBox_Result);
            this.Name = "Calculator";
            this.Text = "Калькулятор";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}