using UserManagerApp.Forms;
using UserManagerApp.Models;
using UserManagerApp.Services;

namespace UserManagerApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            txtPassword.UseSystemPasswordChar = true;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            try
            {
                string Email = txtEmail.Text;
                string Password = txtPassword.Text;
                if (string.IsNullOrWhiteSpace(Email) || string.IsNullOrWhiteSpace(Password))
                {
                    lblMessage.Text = "Enter both email and password correctly ";
                    lblMessage.ForeColor = Color.Red;
                    return;
                }
                User Founduser = null;
                List<User> allusers = FileService.LoadUsers();
                foreach (User user in allusers)
                {
                    if (user.Email == Email && user.Password == Password)
                    {
                        Founduser = user;
                        break;
                    }
                }
                if (Founduser != null)
                {
                    lblMessage.Text = "Login successful!";
                    lblMessage.ForeColor = Color.Green;
                    MessageBox.Show($"Welcome, {Founduser.Name}!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Hide();
                    Dashboard dashboard = new Dashboard(Founduser);
                    dashboard.Show();
                }
                else
                {
                    lblMessage.Text = "Invalid email or password.";
                    lblMessage.ForeColor = Color.Red;
                }
            }
            catch (IOException ie)
            {
                MessageBox.Show("Error accessing user data file: " + ie.Message, "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex) {
                MessageBox.Show("Something went wrong" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Signup signup = new Signup();
            signup.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
