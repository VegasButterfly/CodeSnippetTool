using CodeSnippetTool.Controllers;
using Microsoft.Data.Sqlite;

namespace CodeSnippetTool
{
    public partial class MainForm : Form
    {
        private readonly UserController userController;
        private readonly SnippetController snippetController;

        public MainForm()
        {
            InitializeComponent();
            userController = new UserController();
            snippetController = new SnippetController();
            LoadUsers();
            LoadSnippets();
        }

        private void LoadSnippets()
        {
            try
            {
                var snippets = snippetController.GetAllSnippets();
                dataGridViewSnippets.DataSource = snippets;
            }
            catch (Exception ex) 
            {
                MessageBox.Show($"Failed to load snippets: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadUsers()
        {
            try
            {
                var users = userController.GetAllUsers();
                dataGridViewUsers.DataSource = users;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load users: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SnippetForm snippetForm = new SnippetForm();
            snippetForm.Show();
        }

        private void dataGridViewUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dataGridViewSnippets_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
