using CodeSnippetTool.Controllers;
using CodeSnippetTool.Data;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;

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

            SnippetForm snippetForm = new SnippetForm();
            snippetForm.SnippetSaved += SnippetForm_SnippetSaved;
        }

        private void LoadSnippets()
        {

            try
            {
                using (var context = new AppDbContext())
                {
                    // Perform a LINQ join between Snippets and Languages based on LanguageId
                    var snippetsWithLanguage = (from snippet in context.Snippets
                                                join language in context.Languages
                                                on snippet.LanguageId equals language.Id
                                                select new
                                                {
                                                    snippet.Id,
                                                    snippet.SnippetName,
                                                    LanguageName = language.LanguageName,
                                                    snippet.SnippetDescription,
                                                }).ToList();

                    // Set the DataGridView's data source to the result of the join
                    dataGridViewSnippets.DataSource = snippetsWithLanguage;
                    dataGridViewSnippets.Columns["SnippetDescription"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
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
            snippetForm.SnippetSaved += SnippetForm_SnippetSaved;
            snippetForm.Show();
        }

        private void SnippetForm_SnippetSaved(object sender, EventArgs e)
        {
            RefreshSnippetDataGridView();
        }


        private void RefreshSnippetDataGridView()
        {
            using (var context = new AppDbContext())
            {
                var snippetsWithLanguage = (from snippet in context.Snippets
                                            join language in context.Languages
                                            on snippet.LanguageId equals language.Id
                                            select new
                                            {
                                                snippet.Id,
                                                snippet.SnippetName,
                                                LanguageName = language.LanguageName,
                                                snippet.SnippetDescription,
                                            }).ToList();
                dataGridViewSnippets.DataSource = snippetsWithLanguage;
            }
        }

        private void LoadSnippet_Click(object sender, EventArgs e)
        {
            if (dataGridViewSnippets.SelectedRows.Count > 0)
            {

                int snippetId = Convert.ToInt32(dataGridViewSnippets.SelectedRows[0].Cells["Id"].Value);


                SnippetForm snippetForm = new SnippetForm();
                snippetForm.LoadSnippet(snippetId);
                snippetForm.SnippetSaved += SnippetForm_SnippetSaved;
                snippetForm.Show();
            }
            else
            {
                MessageBox.Show("Please select a snippet to view.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DeleteSnippet_Click(object sender, EventArgs e)
        {
            if (dataGridViewSnippets.SelectedRows.Count > 0)
            {

                var result = MessageBox.Show("Are you sure you want to delete this snippet?", "Delete Snippet", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        int snippetId = Convert.ToInt32(dataGridViewSnippets.SelectedRows[0].Cells["Id"].Value);

                        // Call DeleteSnippet method from SnippetController
                        snippetController.DeleteSnippet(snippetId);

                        // Refresh the DataGridView after deletion
                        RefreshSnippetDataGridView();

                        MessageBox.Show("Snippet deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred while deleting the snippet: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a snippet to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {            
            RefreshSnippetDataGridView();            
        }
    }
}
