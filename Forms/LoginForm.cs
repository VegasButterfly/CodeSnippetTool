using CodeSnippetTool.Data;
using CodeSnippetTool.Models;
using CodeSnippetTool.Services.Authentication;
using System.Windows.Forms;

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

        private void linkLabel_GitHub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                linkLabel_GitHub.LinkVisited = true;
                OpenUrl("https://github.com/VegasButterfly/CodeSnippetTool");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open link that was clicked.");
            }

        }

        private void linkLabel_LinkedIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                LinkLabel_LinkedIn.LinkVisited = true;
                OpenUrl("https://www.linkedin.com/in/vegasbutterfly2024");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open link that was clicked.");
            }

        }

        private void OpenUrl(string url)
        {
            try
            {
                // Use ProcessStartInfo to open the URL in the default browser
                var psi = new System.Diagnostics.ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true // Ensures the system default browser is used
                };

                System.Diagnostics.Process.Start(psi);
            }
            catch (Exception ex)
            {
                // Show a message if the URL fails to open
                MessageBox.Show($"Failed to open URL: {ex.Message}");
            }
        }
    }
}
