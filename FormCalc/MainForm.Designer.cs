namespace FormCalc
{
    partial class MainForm
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
            this.Number1 = new System.Windows.Forms.Button();
            this.Number2 = new System.Windows.Forms.Button();
            this.Number3 = new System.Windows.Forms.Button();
            this.Number4 = new System.Windows.Forms.Button();
            this.Number5 = new System.Windows.Forms.Button();
            this.Number6 = new System.Windows.Forms.Button();
            this.Number7 = new System.Windows.Forms.Button();
            this.Number8 = new System.Windows.Forms.Button();
            this.Number9 = new System.Windows.Forms.Button();
            this.Number0 = new System.Windows.Forms.Button();
            this.Backspace = new System.Windows.Forms.Button();
            this.Dot = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.Plus = new System.Windows.Forms.Button();
            this.Minus = new System.Windows.Forms.Button();
            this.Multiply = new System.Windows.Forms.Button();
            this.Enter = new System.Windows.Forms.Button();
            this.Divide = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Number1
            // 
            this.Number1.Location = new System.Drawing.Point(53, 30);
            this.Number1.Name = "Number1";
            this.Number1.Size = new System.Drawing.Size(125, 36);
            this.Number1.TabIndex = 0;
            this.Number1.Text = "1";
            this.Number1.UseVisualStyleBackColor = true;
            this.Number1.Click += new System.EventHandler(this.Number_Click);
            // 
            // Number2
            // 
            this.Number2.Location = new System.Drawing.Point(207, 30);
            this.Number2.Name = "Number2";
            this.Number2.Size = new System.Drawing.Size(125, 36);
            this.Number2.TabIndex = 1;
            this.Number2.Text = "2";
            this.Number2.UseVisualStyleBackColor = true;
            this.Number2.Click += new System.EventHandler(this.Number_Click);
            // 
            // Number3
            // 
            this.Number3.Location = new System.Drawing.Point(354, 30);
            this.Number3.Name = "Number3";
            this.Number3.Size = new System.Drawing.Size(125, 36);
            this.Number3.TabIndex = 2;
            this.Number3.Text = "3";
            this.Number3.UseVisualStyleBackColor = true;
            this.Number3.Click += new System.EventHandler(this.Number_Click);
            // 
            // Number4
            // 
            this.Number4.Location = new System.Drawing.Point(53, 89);
            this.Number4.Name = "Number4";
            this.Number4.Size = new System.Drawing.Size(125, 36);
            this.Number4.TabIndex = 3;
            this.Number4.Text = "4";
            this.Number4.UseVisualStyleBackColor = true;
            this.Number4.Click += new System.EventHandler(this.Number_Click);
            // 
            // Number5
            // 
            this.Number5.Location = new System.Drawing.Point(207, 89);
            this.Number5.Name = "Number5";
            this.Number5.Size = new System.Drawing.Size(125, 36);
            this.Number5.TabIndex = 4;
            this.Number5.Text = "5";
            this.Number5.UseVisualStyleBackColor = true;
            this.Number5.Click += new System.EventHandler(this.Number_Click);
            // 
            // Number6
            // 
            this.Number6.Location = new System.Drawing.Point(354, 89);
            this.Number6.Name = "Number6";
            this.Number6.Size = new System.Drawing.Size(125, 36);
            this.Number6.TabIndex = 5;
            this.Number6.Text = "6";
            this.Number6.UseVisualStyleBackColor = true;
            this.Number6.Click += new System.EventHandler(this.Number_Click);
            // 
            // Number7
            // 
            this.Number7.Location = new System.Drawing.Point(53, 146);
            this.Number7.Name = "Number7";
            this.Number7.Size = new System.Drawing.Size(125, 36);
            this.Number7.TabIndex = 6;
            this.Number7.Text = "7";
            this.Number7.UseVisualStyleBackColor = true;
            this.Number7.Click += new System.EventHandler(this.Number_Click);
            // 
            // Number8
            // 
            this.Number8.Location = new System.Drawing.Point(207, 146);
            this.Number8.Name = "Number8";
            this.Number8.Size = new System.Drawing.Size(125, 36);
            this.Number8.TabIndex = 7;
            this.Number8.Text = "8";
            this.Number8.UseVisualStyleBackColor = true;
            this.Number8.Click += new System.EventHandler(this.Number_Click);
            // 
            // Number9
            // 
            this.Number9.Location = new System.Drawing.Point(354, 146);
            this.Number9.Name = "Number9";
            this.Number9.Size = new System.Drawing.Size(125, 36);
            this.Number9.TabIndex = 8;
            this.Number9.Text = "9";
            this.Number9.UseVisualStyleBackColor = true;
            this.Number9.Click += new System.EventHandler(this.Number_Click);
            // 
            // Number0
            // 
            this.Number0.Location = new System.Drawing.Point(207, 201);
            this.Number0.Name = "Number0";
            this.Number0.Size = new System.Drawing.Size(125, 36);
            this.Number0.TabIndex = 9;
            this.Number0.Text = "0";
            this.Number0.UseVisualStyleBackColor = true;
            this.Number0.Click += new System.EventHandler(this.Number_Click);
            // 
            // Backspace
            // 
            this.Backspace.Location = new System.Drawing.Point(354, 201);
            this.Backspace.Name = "Backspace";
            this.Backspace.Size = new System.Drawing.Size(125, 36);
            this.Backspace.TabIndex = 10;
            this.Backspace.Text = "<--";
            this.Backspace.UseVisualStyleBackColor = true;
            this.Backspace.Click += new System.EventHandler(this.Backspace_Click);
            // 
            // Dot
            // 
            this.Dot.Location = new System.Drawing.Point(53, 201);
            this.Dot.Name = "Dot";
            this.Dot.Size = new System.Drawing.Size(125, 36);
            this.Dot.TabIndex = 11;
            this.Dot.Text = ",";
            this.Dot.UseVisualStyleBackColor = true;
            this.Dot.Click += new System.EventHandler(this.Dot_Click);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(53, 270);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(426, 20);
            this.textBox.TabIndex = 12;
            // 
            // Plus
            // 
            this.Plus.Location = new System.Drawing.Point(560, 30);
            this.Plus.Name = "Plus";
            this.Plus.Size = new System.Drawing.Size(116, 36);
            this.Plus.TabIndex = 13;
            this.Plus.Text = "+";
            this.Plus.UseVisualStyleBackColor = true;
            this.Plus.Click += new System.EventHandler(this.Plus_Click);
            // 
            // Minus
            // 
            this.Minus.Location = new System.Drawing.Point(560, 89);
            this.Minus.Name = "Minus";
            this.Minus.Size = new System.Drawing.Size(116, 36);
            this.Minus.TabIndex = 14;
            this.Minus.Text = "-";
            this.Minus.UseVisualStyleBackColor = true;
            this.Minus.Click += new System.EventHandler(this.Minus_Click);
            // 
            // Multiply
            // 
            this.Multiply.Location = new System.Drawing.Point(560, 146);
            this.Multiply.Name = "Multiply";
            this.Multiply.Size = new System.Drawing.Size(116, 36);
            this.Multiply.TabIndex = 15;
            this.Multiply.Text = "*";
            this.Multiply.UseVisualStyleBackColor = true;
            this.Multiply.Click += new System.EventHandler(this.Multiply_Click);
            // 
            // Enter
            // 
            this.Enter.Location = new System.Drawing.Point(560, 261);
            this.Enter.Name = "Enter";
            this.Enter.Size = new System.Drawing.Size(116, 36);
            this.Enter.TabIndex = 16;
            this.Enter.Text = "=";
            this.Enter.UseVisualStyleBackColor = true;
            this.Enter.Click += new System.EventHandler(this.Enter_Click);
            // 
            // Divide
            // 
            this.Divide.Location = new System.Drawing.Point(560, 201);
            this.Divide.Name = "Divide";
            this.Divide.Size = new System.Drawing.Size(116, 36);
            this.Divide.TabIndex = 17;
            this.Divide.Text = "/";
            this.Divide.UseVisualStyleBackColor = true;
            this.Divide.Click += new System.EventHandler(this.Divide_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 439);
            this.Controls.Add(this.Divide);
            this.Controls.Add(this.Enter);
            this.Controls.Add(this.Multiply);
            this.Controls.Add(this.Minus);
            this.Controls.Add(this.Plus);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.Dot);
            this.Controls.Add(this.Backspace);
            this.Controls.Add(this.Number0);
            this.Controls.Add(this.Number9);
            this.Controls.Add(this.Number8);
            this.Controls.Add(this.Number7);
            this.Controls.Add(this.Number6);
            this.Controls.Add(this.Number5);
            this.Controls.Add(this.Number4);
            this.Controls.Add(this.Number3);
            this.Controls.Add(this.Number2);
            this.Controls.Add(this.Number1);
            this.Name = "MainForm";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Number1;
        private System.Windows.Forms.Button Number2;
        private System.Windows.Forms.Button Number3;
        private System.Windows.Forms.Button Number4;
        private System.Windows.Forms.Button Number5;
        private System.Windows.Forms.Button Number6;
        private System.Windows.Forms.Button Number7;
        private System.Windows.Forms.Button Number8;
        private System.Windows.Forms.Button Number9;
        private System.Windows.Forms.Button Number0;
        private System.Windows.Forms.Button Backspace;
        private System.Windows.Forms.Button Dot;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button Plus;
        private System.Windows.Forms.Button Minus;
        private System.Windows.Forms.Button Multiply;
        private System.Windows.Forms.Button Enter;
        private System.Windows.Forms.Button Divide;
    }
}

