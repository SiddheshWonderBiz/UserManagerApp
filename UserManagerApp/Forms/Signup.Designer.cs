namespace UserManagerApp
{
    partial class Signup
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
            label1 = new Label();
            label2 = new Label();
            txtName = new TextBox();
            label3 = new Label();
            txtEmail = new TextBox();
            label4 = new Label();
            txtPassword = new TextBox();
            linkLogin = new LinkLabel();
            lblMessage = new Label();
            btnSignUp = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = Color.FromArgb(61, 205, 88);
            label1.FlatStyle = FlatStyle.System;
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(-1, -1);
            label1.Name = "label1";
            label1.Size = new Size(965, 38);
            label1.TabIndex = 0;
            label1.Text = "User Registration";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(61, 205, 88);
            label2.Location = new Point(286, 82);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtName.BackColor = SystemColors.Window;
            txtName.CausesValidation = false;
            txtName.Location = new Point(366, 75);
            txtName.Name = "txtName";
            txtName.Size = new Size(294, 27);
            txtName.TabIndex = 2;
            txtName.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(61, 205, 88);
            label3.Location = new Point(286, 127);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 3;
            label3.Text = "Email";
            label3.Click += label3_Click;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtEmail.BackColor = SystemColors.Window;
            txtEmail.CausesValidation = false;
            txtEmail.Location = new Point(366, 127);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(294, 27);
            txtEmail.TabIndex = 4;
            txtEmail.TextChanged += textBox2_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(61, 205, 88);
            label4.Location = new Point(273, 180);
            label4.Name = "label4";
            label4.Size = new Size(79, 20);
            label4.TabIndex = 5;
            label4.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPassword.BackColor = SystemColors.Window;
            txtPassword.CausesValidation = false;
            txtPassword.Location = new Point(366, 173);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(294, 27);
            txtPassword.TabIndex = 6;
            txtPassword.TextChanged += textBox3_TextChanged;
            // 
            // linkLogin
            // 
            linkLogin.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            linkLogin.AutoSize = true;
            linkLogin.LinkColor = Color.FromArgb(61, 205, 88);
            linkLogin.Location = new Point(560, 290);
            linkLogin.Name = "linkLogin";
            linkLogin.Size = new Size(46, 20);
            linkLogin.TabIndex = 7;
            linkLogin.TabStop = true;
            linkLogin.Text = "Login";
            linkLogin.LinkClicked += linkLabel1_LinkClicked;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Location = new Point(366, 290);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(188, 20);
            lblMessage.TabIndex = 8;
            lblMessage.Text = "Already have an Account ? ";
            lblMessage.Click += label5_Click;
            // 
            // btnSignUp
            // 
            btnSignUp.Anchor = AnchorStyles.Top;
            btnSignUp.BackColor = Color.FromArgb(61, 205, 88);
            btnSignUp.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnSignUp.ForeColor = Color.White;
            btnSignUp.Location = new Point(464, 236);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(90, 40);
            btnSignUp.TabIndex = 9;
            btnSignUp.Text = "Signup";
            btnSignUp.UseVisualStyleBackColor = false;
            btnSignUp.Click += button1_Click;
            // 
            // Signup
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            ClientSize = new Size(964, 442);
            Controls.Add(btnSignUp);
            Controls.Add(lblMessage);
            Controls.Add(linkLogin);
            Controls.Add(txtPassword);
            Controls.Add(label4);
            Controls.Add(txtEmail);
            Controls.Add(label3);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Signup";
            Text = "Signup";
            Load += Signup_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtName;
        private Label label3;
        private TextBox txtEmail;
        private Label label4;
        private TextBox txtPassword;
        private LinkLabel linkLogin;
        private Label lblMessage;
        private Button btnSignUp;
    }
}