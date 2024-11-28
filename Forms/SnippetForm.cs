using CodeSnippetTool.Data;
using CodeSnippetTool.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeSnippetTool
{
    public partial class SnippetForm : Form
    {
        private int? loadedSnippetId;

        public SnippetForm(int? snippetId = null)
        {
            InitializeComponent();
            loadedSnippetId = snippetId;  // Store the snippetId if provided
        }

        private async void SnippetForm_Load(object sender, EventArgs e)
        {
            await LoadLanguagesAsync();

            // If there is a loadedSnippetId, load the snippet for editing
            if (loadedSnippetId.HasValue)
            {
                await LoadSnippet(loadedSnippetId.Value);
            }
        }

        public async Task LoadLanguagesAsync()
        {
            using (var context = new AppDbContext())
            {
                var languages = await context.Languages.ToListAsync();
                SnippetLanguageDropdown.DataSource = languages;
                SnippetLanguageDropdown.DisplayMember = "Name";
                SnippetLanguageDropdown.ValueMember = "Id";
            }
        }

        private async Task LoadSnippet(int snippetId)
        {
            using (var context = new AppDbContext())
            {
                var snippet = await context.Snippets
                    .Include(s => s.Language)  // Include the related language to avoid lazy loading issues
                    .FirstOrDefaultAsync(s => s.Id == snippetId);

                if (snippet != null)
                {
                    // Set the loaded snippet ID
                    loadedSnippetId = snippet.Id;

                    // Populate the form fields with the snippet details
                    SnippetName.Text = snippet.SnippetName;
                    SnippetDescription.Text = snippet.SnippetDescription;
                    CodeSnippetText.Text = snippet.CodeSnippetText;
                    AnalysisText.Text = snippet.AnalysisText;

                    // Set the selected language in the dropdown
                    SnippetLanguageDropdown.SelectedValue = snippet.LanguageId;
                }
                else
                {
                    MessageBox.Show("Snippet not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        // Save or update the snippet
        private async void SnippetSaveButton_Click(object sender, EventArgs e)
        {
            if (UserSession.CurrentUserId == null)
            {
                MessageBox.Show("No user is logged in. Please log in first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var context = new AppDbContext())
            {
                Snippet snippet;

                if (loadedSnippetId != null) // Check if an existing snippet is loaded
                {
                    snippet = await context.Snippets
                        .FirstOrDefaultAsync(s => s.Id == loadedSnippetId.Value);

                    if (snippet == null)
                    {
                        MessageBox.Show("Snippet not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    // Create a new snippet
                    snippet = new Snippet
                    {
                        CreatedDate = DateTime.UtcNow,
                        CreatedById = UserSession.CurrentUserId.Value,
                        SnippetName = "Untitled Snippet"
                    };
                    context.Snippets.Add(snippet);
                }

                // Update snippet properties from the form
                snippet.SnippetName = SnippetName.Text;
                snippet.SnippetDescription = SnippetDescription.Text;
                snippet.CodeSnippetText = CodeSnippetText.Text;
                snippet.AnalysisText = AnalysisText.Text;
                snippet.LanguageId = (int?)SnippetLanguageDropdown.SelectedValue; // Set the language ID from the dropdown

                try
                {
                    // Save changes to the database
                    await context.SaveChangesAsync();
                    MessageBox.Show("Snippet saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (DbUpdateException ex)
                {
                    MessageBox.Show($"An error occurred while saving the snippet: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
        }                
    }
}
