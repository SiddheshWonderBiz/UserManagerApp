using System;
using System.Windows.Forms;
using UserManagerApp.Models;
using UserManagerApp.Services;

namespace UserManagerApp.Forms
{
    public partial class Dashboard : Form
    {
        private User _currentUser;

        public Dashboard(User user)
        {
            InitializeComponent();
            _currentUser = user;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            try
            {
                lblWelcome.Text = $"Welcome, {_currentUser.Name}!";
                lblEmail.Text = $"Email: {_currentUser.Email}";

                var users = FileService.LoadUsers();
                dataGridView1.DataSource = users;
            }
            catch (Exception ex) {
            MessageBox.Show("Failed to load dashbaord data" + ex.Message,  "Error", MessageBoxButtons.OK , MessageBoxIcon.Error );
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                LoginForm login = new LoginForm();
                login.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while logging out" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCalculator_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                CalculatorForm calc = new CalculatorForm(_currentUser);
                calc.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can't open Calculator " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }
    }
}
