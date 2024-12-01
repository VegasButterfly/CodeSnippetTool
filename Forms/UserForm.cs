using CodeSnippetTool.Controllers;
using CodeSnippetTool.Data;
using CodeSnippetTool.Models;
using CodeSnippetTool.Services.Authentication;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CodeSnippetTool.Forms
{
    public partial class UserForm : Form
    {
        private UserController userController;
        private int loadedUserId = 0;
        private bool isEditMode = false;        

        public UserForm()
        {
            InitializeComponent();
            this.Icon = new System.Drawing.Icon("CodeSnippetTool.ico");
            LoadRoles();
        }

        public event EventHandler UserSaved;

        // Load RoleDropdown.
        private void LoadRoles()
        {
            using (var context = new AppDbContext())
            {
                var roles = context.Roles.ToList();
                roles.Insert(0, new Role { Id = 0, RoleName = "Select a role" });
                RoleDropdown.DataSource = roles;
                RoleDropdown.DisplayMember = "RoleName";
                RoleDropdown.ValueMember = "Id";
            }
        }

        public void LoadUser(int UserId)
        {
            using (var context = new AppDbContext())
            {
                var user = context.Users.FirstOrDefault(u => u.Id == UserId);

                if (user != null)
                {
                    loadedUserId = user.Id;
                    UsernameText.Text = user.Username;
                    EmailText.Text = user.Email;
                    RoleDropdown.SelectedValue = user.RoleId;
                }
                else
                {
                    MessageBox.Show("User not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UserSaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                string password = PasswordText.Text;
                if (string.IsNullOrWhiteSpace(password))
                {
                    MessageBox.Show("Password is required. Please enter a password before saving.",
                                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Stop 
                }
                string salt = SaltIt.GenerateSalt();
                string passwordHash = SaltIt.HashPassword(password, salt);

                var selectedRoleId = (int)RoleDropdown.SelectedValue;

                if (selectedRoleId == 0)
                {
                    MessageBox.Show("Please select a role before saving.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;  // Stop 
                }

                using (var context = new AppDbContext())
                {
                    bool roleExists = context.Roles.Any(r => r.Id == selectedRoleId);
                    if (!roleExists)
                    {
                        MessageBox.Show("The selected role does not exist. Please select a valid language.", "Invalid Language", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // check if new or update
                    User user;

                    if (loadedUserId == 0)
                    {
                        user = new User
                        {
                            Id = loadedUserId,
                            Username = UsernameText.Text,
                            Email = EmailText.Text,
                            RoleId = selectedRoleId,
                            PasswordHash = passwordHash,
                            Salt = salt
                        };
                    }
                    else
                    {
                        user = context.Users.FirstOrDefault(s => s.Id == loadedUserId);
                        if (user != null)
                        {
                            user.Id = loadedUserId;
                            user.Username = UsernameText.Text;
                            user.Email = EmailText.Text;
                            user.RoleId = selectedRoleId;
                            user.PasswordHash = passwordHash;
                        }
                        else
                        {
                            MessageBox.Show("User not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    context.Entry(user).State = loadedUserId == 0 ? EntityState.Added : EntityState.Modified;
                    context.SaveChanges();

                    MessageBox.Show("User saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    UserSaved?.Invoke(this, EventArgs.Empty);
                    this.Close();
                }
            }
            catch (DbUpdateException dbEx)
            {
                MessageBox.Show($"An error occurred while saving the snippet: {dbEx.Message}\n\n{dbEx.InnerException?.Message}",
                       "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }              
                       
    }
}
