using CodeSnippetTool.Controllers;
using CodeSnippetTool.Data;
using CodeSnippetTool.Forms;
using CodeSnippetTool.Services;
using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace CodeSnippetTool
{
    public partial class MainForm : Form
    {
        private readonly UserController userController;
        private readonly SnippetController snippetController;

        public MainForm()
        {
            InitializeComponent();
            this.Icon = new System.Drawing.Icon("CodeSnippetTool.ico");
            this.FormClosing += MainForm_FormClosing;
            userController = new UserController();
            snippetController = new SnippetController();
            LoadUsers();
            LoadSnippets();

            UserForm userForm = new UserForm();
            userForm.UserSaved += UserForm_UserSaved;
            SnippetForm snippetForm = new SnippetForm();
            snippetForm.SnippetSaved += SnippetForm_SnippetSaved;

            dataGridViewSnippets.CellClick += DataGridViewSnippets_CellClick;
            dataGridViewUsers.CellClick += DataGridViewUsers_CellClick;
            OpenAIHelper.apiKey = txtAPIKey.Text;
        }

        private void LoadSnippets(string searchQuery = null)
        {

            try
            {
                using (var context = new AppDbContext())
                {
                    // Perform a LINQ join between Snippets and Languages based on LanguageId
                    var query = from snippet in context.Snippets
                                join language in context.Languages
                                on snippet.LanguageId equals language.Id
                                select new
                                {
                                    snippet.Id,
                                    snippet.SnippetName,
                                    LanguageName = language.LanguageName,
                                    snippet.SnippetDescription,
                                };

                    if (!string.IsNullOrEmpty(searchQuery))
                    {
                        query = query.Where(s =>
                        (s.SnippetName ?? "").ToLower().Contains(searchQuery.ToLower()) ||
                        (s.SnippetDescription ?? "").ToLower().Contains(searchQuery.ToLower()));
                    }

                    var snippetsWithLanguage = query.ToList();

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
                using (var context = new AppDbContext())
                {
                    //Perform a LINQ join between Users and Roles based on RoleId
                    var query = from user in context.Users
                                join role in context.Roles
                                on user.RoleId equals role.Id
                                select new
                                {
                                    user.Id,
                                    user.Username,
                                    RoleName = role.RoleName,
                                    user.Email,
                                };
                    var usersWithRole = query.ToList();

                    dataGridViewUsers.DataSource = usersWithRole;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load users: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserForm userForm = new UserForm();
            userForm.UserSaved += UserForm_UserSaved;
            userForm.FormClosed += (s, arg) => this.Show();
            userForm.Show();
        }

        private void LoadUser_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsers.SelectedCells.Count > 0)
            {
                this.Hide();
                int rowIndex = dataGridViewUsers.SelectedCells[0].RowIndex;
                var idValue = dataGridViewUsers.Rows[rowIndex].Cells["Id"].Value;

                int userId = Convert.ToInt32(idValue);
                UserForm userForm = new UserForm();
                userForm.LoadUser(userId);
                userForm.UserSaved += UserForm_UserSaved;
                userForm.FormClosed += (s, arg) => this.Show();
                userForm.Show();
            }
            else
            {
                MessageBox.Show("Please select a user to load.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteUser_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsers.SelectedCells.Count > 0)
            {
                var result = MessageBox.Show("Are you sure you want to delete this user?", "Delete User", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        int rowIndex = dataGridViewUsers.SelectedCells[0].RowIndex;
                        var idValue = dataGridViewUsers.Rows[rowIndex].Cells["Id"].Value;

                        int userId = Convert.ToInt32(idValue);

                        userController.DeleteUser(userId);
                        RefreshUserDataGridView();
                        MessageBox.Show("User deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred while deleting the user: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a user to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AddSnippet_Click(object sender, EventArgs e)
        {
            this.Hide();
            SnippetForm snippetForm = new SnippetForm();
            snippetForm.SnippetSaved += SnippetForm_SnippetSaved;
            snippetForm.FormClosed += (s, args) => this.Show();
            snippetForm.Show();
        }

        private void SnippetForm_SnippetSaved(object sender, EventArgs e)
        {
            RefreshSnippetDataGridView();
        }

        private void UserForm_UserSaved(object sender, EventArgs e)
        {
            RefreshUserDataGridView();
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

        private void RefreshUserDataGridView()
        {
            using (var context = new AppDbContext())
            {
                var usersWithRole = (from user in context.Users
                                     join role in context.Roles
                                     on user.RoleId equals role.Id
                                     select new
                                     {
                                         user.Id,
                                         user.Username,
                                         role.RoleName,
                                         user.Email,
                                     }).ToList();
                dataGridViewUsers.DataSource = usersWithRole;
            }
        }

        private void LoadSnippet_Click(object sender, EventArgs e)
        {
            if (dataGridViewSnippets.SelectedCells.Count > 0)
            {
                this.Hide();
                int rowIndex = dataGridViewSnippets.SelectedCells[0].RowIndex;
                var idValue = dataGridViewSnippets.Rows[rowIndex].Cells["Id"].Value;

                int snippetId = Convert.ToInt32(idValue);


                SnippetForm snippetForm = new SnippetForm();
                snippetForm.LoadSnippet(snippetId);
                snippetForm.SnippetSaved += SnippetForm_SnippetSaved;
                snippetForm.FormClosed += (s, args) => this.Show();
                snippetForm.Show();
            }
            else
            {
                MessageBox.Show("Please select a snippet to view.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DeleteSnippet_Click(object sender, EventArgs e)
        {
            if (dataGridViewSnippets.SelectedCells.Count > 0)
            {

                var result = MessageBox.Show("Are you sure you want to delete this snippet?", "Delete Snippet", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        int rowIndex = dataGridViewSnippets.SelectedCells[0].RowIndex;
                        var idValue = dataGridViewSnippets.Rows[rowIndex].Cells["Id"].Value;

                        int snippetId = Convert.ToInt32(idValue);


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

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string searchQuery = searchTextBox.Text.Trim();
            LoadSnippets(searchQuery);
        }

        private void RefreshUserList_Click(object sender, EventArgs e)
        {
            RefreshUserDataGridView();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void DataGridViewSnippets_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Get the row index of the clicked cell
                int rowIndex = e.RowIndex;

                // Get the cell value of the Id column (assuming "Id" is the column name)
                var idValue = dataGridViewSnippets.Rows[rowIndex].Cells["Id"].Value;

                if (idValue != null)
                {
                    int snippetId = Convert.ToInt32(idValue);
                }
            }
        }

        private void DataGridViewUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Get the row index of the clicked cell
                int rowIndex = e.RowIndex;

                // Get the cell value of the Id column (assuming "Id" is the column name)
                var idValue = dataGridViewUsers.Rows[rowIndex].Cells["Id"].Value;

                if (idValue != null)
                {
                    int userId = Convert.ToInt32(idValue);
                }
            }
        }

        private void SaveApiKey_Click(object sender, EventArgs e)
        {
            string apiKey = txtAPIKey.Text;
            OpenAIHelper.apiKey = apiKey;
            MessageBox.Show("API Key saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

}
