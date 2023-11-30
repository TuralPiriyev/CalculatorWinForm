namespace Kalkulyator
{
    partial class Calculator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            multiplication = new Button();
            Divide = new Button();
            Minus = new Button();
            Percent = new Button();
            Number1 = new TextBox();
            Number2 = new TextBox();
            Plus = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // multiplication
            // 
            multiplication.Location = new Point(32, 178);
            multiplication.Name = "multiplication";
            multiplication.Size = new Size(112, 70);
            multiplication.TabIndex = 0;
            multiplication.Text = "multiplication";
            multiplication.UseVisualStyleBackColor = true;
            multiplication.Click += multiplication_Click;
            // 
            // Divide
            // 
            Divide.Location = new Point(179, 178);
            Divide.Name = "Divide";
            Divide.Size = new Size(112, 70);
            Divide.TabIndex = 1;
            Divide.Text = "Divide";
            Divide.UseVisualStyleBackColor = true;
            Divide.Click += Divide_Click;
            // 
            // Minus
            // 
            Minus.Location = new Point(32, 292);
            Minus.Name = "Minus";
            Minus.Size = new Size(112, 70);
            Minus.TabIndex = 2;
            Minus.Text = "Minus";
            Minus.UseVisualStyleBackColor = true;
            Minus.Click += Minus_Click;
            // 
            // Percent
            // 
            Percent.Location = new Point(179, 292);
            Percent.Name = "Percent";
            Percent.Size = new Size(112, 70);
            Percent.TabIndex = 3;
            Percent.Text = "Percent";
            Percent.UseVisualStyleBackColor = true;
            Percent.Click += Percent_Click;
            // 
            // Number1
            // 
            Number1.Location = new Point(32, 49);
            Number1.Name = "Number1";
            Number1.Size = new Size(111, 27);
            Number1.TabIndex = 4;
            // 
            // Number2
            // 
            Number2.Location = new Point(171, 49);
            Number2.Name = "Number2";
            Number2.Size = new Size(120, 27);
            Number2.TabIndex = 5;
            // 
            // Plus
            // 
            Plus.Location = new Point(32, 387);
            Plus.Name = "Plus";
            Plus.Size = new Size(259, 60);
            Plus.TabIndex = 6;
            Plus.Text = "Plus";
            Plus.UseVisualStyleBackColor = true;
            Plus.Click += Plus_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(147, 111);
            label1.Name = "label1";
            label1.Size = new Size(17, 20);
            label1.TabIndex = 7;
            label1.Text = "0";
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(317, 459);
            Controls.Add(label1);
            Controls.Add(Plus);
            Controls.Add(Number2);
            Controls.Add(Number1);
            Controls.Add(Percent);
            Controls.Add(Minus);
            Controls.Add(Divide);
            Controls.Add(multiplication);
            Name = "Calculator";
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button multiplication;
        private Button Divide;
        private Button Minus;
        private Button Percent;
        private TextBox Number1;
        private TextBox Number2;
        private Button Plus;
        private Label label1;
    }
}