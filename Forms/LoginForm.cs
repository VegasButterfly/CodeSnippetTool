using CodeSnippetTool.Data;
using CodeSnippetTool.Models;
using CodeSnippetTool.Services.Authentication;

namespace CodeSnippetTool
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            // enter key activates login just because it's driving me crazy!!!!!
            this.AcceptButton = LoginButton;
        }




        private void LoginButton_Click(object? sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both a Username and Password", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using var context = new AppDbContext();
            var user = context.Users.SingleOrDefault(u => u.Username == username);
            if (user == null)
            {
                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string hashedPassword = SaltIt.HashPassword(password, user.Salt);

            if (hashedPassword == user.PasswordHash)
            {
                UserSession.CurrentUserId = user.Id;
                UserSession.CurrentUsername = user.Username;
                UserSession.CurrentUser = user;

                MessageBox.Show($"Welcome, {username}!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Proceed to the main application
                // Hide or close this form, then open the main form.
                this.Hide();
                var mainForm = new MainForm(); // Assume MainForm exists
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
           
    }
}
