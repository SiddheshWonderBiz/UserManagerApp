using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserManagerApp.Services;
using UserManagerApp.Models;

namespace UserManagerApp
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
            txtPassword.UseSystemPasswordChar = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Signup_Load(object sender, EventArgs e)
        {

        }

        private void Signup_Load_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string Name = txtName.Text.Trim();
                string Email = txtEmail.Text.Trim();
                string Password = txtPassword.Text.Trim();

                if (string.IsNullOrWhiteSpace(Name) || !System.Text.RegularExpressions.Regex.IsMatch(Name, @"^[a-zA-Z\s]+$"))
                {
                    lblMessage.Text = "Name should conatin only letters";
                    lblMessage.ForeColor = Color.Red;
                    return;
                }
                if (string.IsNullOrWhiteSpace(Email) || !System.Text.RegularExpressions.Regex.IsMatch(Email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                {
                    lblMessage.Text = "please enter valid email address";
                    lblMessage.ForeColor = Color.Red;
                    return;
                }
                if (string.IsNullOrWhiteSpace(Password) || Password.Length < 10 || !Password.Any(char.IsDigit) || !Password.Any(ch => "!@#$%^&*()-_=+[{]}|;:',<.>/?".Contains(ch)))
                {
                    lblMessage.Text = "Password must be at least 10 characters long, with a number and special character";
                    lblMessage.ForeColor = Color.Red;
                    return;
                }

                if (string.IsNullOrWhiteSpace(Name) || string.IsNullOrWhiteSpace(Email) || string.IsNullOrWhiteSpace(Password))
                {
                    lblMessage.Text = "Please fill all fields correctly";
                    lblMessage.ForeColor = Color.Red;
                    return;
                }
                if (FileService.CheckEmai(Email))
                {
                    lblMessage.Text = "Email already exist";
                    lblMessage.ForeColor = Color.Red;
                    return;
                }
                User user = new User
                {
                    Id = FileService.NextId(),
                    Name = Name,
                    Email = Email,
                    Password = Password,
                };
                FileService.AddUser(user);
                lblMessage.Text = "User added sucessfully";
                lblMessage.ForeColor = Color.Green;
                MessageBox.Show("User registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
            }
            catch (FormatException fe)
            {
                MessageBox.Show("Input format error" + fe.Message , "Format error" , MessageBoxButtons.OK , MessageBoxIcon.Warning);
            }
            catch(IOException ie)
            {
                MessageBox.Show("File access error: " + ie.Message, "File Error",MessageBoxButtons.OK , MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
