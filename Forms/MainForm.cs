using CodeSnippetTool.Controllers;
using CodeSnippetTool.Data;
using CodeSnippetTool.Forms;
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
            userController = new UserController();
            snippetController = new SnippetController();
            LoadUsers();
            LoadSnippets();

            UserForm userForm = new UserForm();
            userForm.UserSaved += UserForm_UserSaved;
            SnippetForm snippetForm = new SnippetForm();
            snippetForm.SnippetSaved += SnippetForm_SnippetSaved;
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
            if (dataGridViewUsers.SelectedRows.Count > 0)
            {
                this.Hide();
                int userId = Convert.ToInt32(dataGridViewUsers.SelectedRows[0].Cells["Id"].Value);

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
            if (dataGridViewUsers.SelectedRows.Count > 0)
            {
                var result = MessageBox.Show("Are you sure you want to delete this snippet?", "Delete Snippet", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        int userId = Convert.ToInt32(dataGridViewUsers.SelectedRows[0].Cells["Id"].Value);
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
                                     }).ToList();
                dataGridViewUsers.DataSource = usersWithRole;
            }
        }

        private void LoadSnippet_Click(object sender, EventArgs e)
        {
            if (dataGridViewSnippets.SelectedRows.Count > 0)
            {
                this.Hide();
                int snippetId = Convert.ToInt32(dataGridViewSnippets.SelectedRows[0].Cells["Id"].Value);


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

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string searchQuery = searchTextBox.Text.Trim();
            LoadSnippets(searchQuery);
        }

        private void RefreshUserList_Click(object sender, EventArgs e)
        {
            RefreshUserDataGridView();
        }
    }

}
