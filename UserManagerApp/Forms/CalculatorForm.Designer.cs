namespace UserManagerApp.Forms
{
    partial class CalculatorForm
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
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            button16 = new Button();
            button17 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.BackColor = SystemColors.ButtonHighlight;
            textBox1.Location = new Point(12, 49);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(293, 27);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(12, 97);
            button1.Name = "button1";
            button1.Size = new Size(74, 41);
            button1.TabIndex = 1;
            button1.Text = "7";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnNumber_Click;
            button1.ChangeUICues += button10_ChangeUICues;
            // 
            // button2
            // 
            button2.Location = new Point(92, 97);
            button2.Name = "button2";
            button2.Size = new Size(74, 41);
            button2.TabIndex = 2;
            button2.Text = "8";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnNumber_Click;
            button2.ChangeUICues += button10_ChangeUICues;
            // 
            // button3
            // 
            button3.Location = new Point(172, 97);
            button3.Name = "button3";
            button3.Size = new Size(74, 41);
            button3.TabIndex = 3;
            button3.Text = "9";
            button3.UseVisualStyleBackColor = true;
            button3.Click += btnNumber_Click;
            button3.ChangeUICues += button10_ChangeUICues;
            // 
            // button4
            // 
            button4.Location = new Point(12, 144);
            button4.Name = "button4";
            button4.Size = new Size(74, 41);
            button4.TabIndex = 4;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += btnNumber_Click;
            button4.ChangeUICues += button10_ChangeUICues;
            // 
            // button5
            // 
            button5.Location = new Point(92, 144);
            button5.Name = "button5";
            button5.Size = new Size(74, 41);
            button5.TabIndex = 5;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += btnNumber_Click;
            button5.ChangeUICues += button10_ChangeUICues;
            // 
            // button6
            // 
            button6.Location = new Point(172, 144);
            button6.Name = "button6";
            button6.Size = new Size(74, 41);
            button6.TabIndex = 6;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += btnNumber_Click;
            button6.ChangeUICues += button10_ChangeUICues;
            // 
            // button7
            // 
            button7.Location = new Point(12, 191);
            button7.Name = "button7";
            button7.Size = new Size(74, 41);
            button7.TabIndex = 7;
            button7.Text = "1";
            button7.UseVisualStyleBackColor = true;
            button7.Click += btnNumber_Click;
            button7.ChangeUICues += button10_ChangeUICues;
            // 
            // button8
            // 
            button8.Location = new Point(92, 191);
            button8.Name = "button8";
            button8.Size = new Size(74, 41);
            button8.TabIndex = 8;
            button8.Text = "2";
            button8.UseVisualStyleBackColor = true;
            button8.Click += btnNumber_Click;
            button8.ChangeUICues += button10_ChangeUICues;
            // 
            // button9
            // 
            button9.Location = new Point(172, 191);
            button9.Name = "button9";
            button9.Size = new Size(74, 41);
            button9.TabIndex = 9;
            button9.Text = "3";
            button9.UseVisualStyleBackColor = true;
            button9.Click += btnNumber_Click;
            button9.ChangeUICues += button10_ChangeUICues;
            // 
            // button10
            // 
            button10.Location = new Point(12, 238);
            button10.Name = "button10";
            button10.Size = new Size(74, 41);
            button10.TabIndex = 10;
            button10.Text = "0";
            button10.UseVisualStyleBackColor = true;
            button10.Click += btnNumber_Click;
            button10.ChangeUICues += button10_ChangeUICues;
            // 
            // button11
            // 
            button11.Location = new Point(92, 238);
            button11.Name = "button11";
            button11.Size = new Size(74, 41);
            button11.TabIndex = 11;
            button11.Text = "C";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // button12
            // 
            button12.BackColor = Color.Crimson;
            button12.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button12.ForeColor = Color.White;
            button12.Location = new Point(172, 238);
            button12.Name = "button12";
            button12.Size = new Size(74, 41);
            button12.TabIndex = 12;
            button12.Text = "=";
            button12.UseVisualStyleBackColor = false;
            button12.Click += btnEqual_Click;
            // 
            // button13
            // 
            button13.BackColor = Color.FromArgb(61, 205, 88);
            button13.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button13.ForeColor = Color.White;
            button13.Location = new Point(252, 97);
            button13.Name = "button13";
            button13.Size = new Size(53, 41);
            button13.TabIndex = 13;
            button13.Text = "+";
            button13.UseVisualStyleBackColor = false;
            button13.Click += btnOperator_Click;
            // 
            // button14
            // 
            button14.BackColor = Color.FromArgb(61, 205, 88);
            button14.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button14.ForeColor = Color.White;
            button14.Location = new Point(252, 144);
            button14.Name = "button14";
            button14.Size = new Size(53, 41);
            button14.TabIndex = 14;
            button14.Text = "-";
            button14.UseVisualStyleBackColor = false;
            button14.Click += btnOperator_Click;
            // 
            // button15
            // 
            button15.BackColor = Color.FromArgb(61, 205, 88);
            button15.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button15.ForeColor = Color.White;
            button15.Location = new Point(252, 191);
            button15.Name = "button15";
            button15.Size = new Size(53, 41);
            button15.TabIndex = 15;
            button15.Text = "*";
            button15.UseVisualStyleBackColor = false;
            button15.Click += btnOperator_Click;
            // 
            // button16
            // 
            button16.BackColor = Color.FromArgb(61, 205, 88);
            button16.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button16.ForeColor = Color.White;
            button16.Location = new Point(252, 238);
            button16.Name = "button16";
            button16.Size = new Size(53, 41);
            button16.TabIndex = 16;
            button16.Text = "/";
            button16.UseVisualStyleBackColor = false;
            button16.Click += btnOperator_Click;
            // 
            // button17
            // 
            button17.BackColor = Color.RoyalBlue;
            button17.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button17.ForeColor = Color.White;
            button17.Location = new Point(12, 1);
            button17.Name = "button17";
            button17.Size = new Size(38, 31);
            button17.TabIndex = 17;
            button17.Text = "<";
            button17.UseVisualStyleBackColor = false;
            button17.Click += button17_Click;
            // 
            // CalculatorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(317, 300);
            Controls.Add(button17);
            Controls.Add(button16);
            Controls.Add(button15);
            Controls.Add(button14);
            Controls.Add(button13);
            Controls.Add(button12);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Name = "CalculatorForm";
            Text = "Calculator";
            Load += CalculatorForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button16;
        private Button button17;
    }
}