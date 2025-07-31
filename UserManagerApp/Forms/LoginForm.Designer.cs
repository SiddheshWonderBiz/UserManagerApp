namespace UserManagerApp
{
    public partial class LoginForm : Form
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
            label1 = new Label();
            label3 = new Label();
            txtEmail = new TextBox();
            label4 = new Label();
            txtPassword = new TextBox();
            btnLogin = new Button();
            lblMessage = new Label();
            linkSignup = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = Color.FromArgb(61, 205, 88);
            label1.FlatStyle = FlatStyle.System;
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, -2);
            label1.Name = "label1";
            label1.Size = new Size(965, 38);
            label1.TabIndex = 1;
            label1.Text = "Login";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(61, 205, 88);
            label3.Location = new Point(239, 121);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 4;
            label3.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtEmail.BackColor = SystemColors.Window;
            txtEmail.CausesValidation = false;
            txtEmail.Location = new Point(326, 114);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(319, 27);
            txtEmail.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(61, 205, 88);
            label4.Location = new Point(224, 169);
            label4.Name = "label4";
            label4.Size = new Size(79, 20);
            label4.TabIndex = 6;
            label4.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPassword.BackColor = SystemColors.Window;
            txtPassword.CausesValidation = false;
            txtPassword.Location = new Point(326, 162);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(319, 27);
            txtPassword.TabIndex = 7;
            txtPassword.TextChanged += textBox1_TextChanged;
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.Top;
            btnLogin.BackColor = Color.FromArgb(61, 205, 88);
            btnLogin.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(444, 226);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(90, 40);
            btnLogin.TabIndex = 10;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnSignUp_Click;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Location = new Point(368, 279);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(166, 20);
            lblMessage.TabIndex = 11;
            lblMessage.Text = "Dont have an Account ?";
            // 
            // linkSignup
            // 
            linkSignup.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            linkSignup.AutoSize = true;
            linkSignup.LinkColor = Color.FromArgb(61, 205, 88);
            linkSignup.Location = new Point(540, 279);
            linkSignup.Name = "linkSignup";
            linkSignup.Size = new Size(55, 20);
            linkSignup.TabIndex = 12;
            linkSignup.TabStop = true;
            linkSignup.Text = "Signup";
            linkSignup.LinkClicked += linkLogin_LinkClicked;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(964, 442);
            Controls.Add(linkSignup);
            Controls.Add(lblMessage);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(label4);
            Controls.Add(txtEmail);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "LoginForm";
            Text = "Form1";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private TextBox txtEmail;
        private Label label4;
        private TextBox txtPassword;
        private Button btnLogin;
        private Label lblMessage;
        private LinkLabel linkSignup;
    }
}
