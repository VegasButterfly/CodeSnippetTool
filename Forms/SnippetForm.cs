using CodeSnippetTool.Controllers;
using CodeSnippetTool.Data;
using CodeSnippetTool.Models;
using System;
using Microsoft.EntityFrameworkCore;
using System.Windows.Forms;

namespace CodeSnippetTool
{
    public partial class SnippetForm : Form
    {
        private SnippetController _controller = new SnippetController();
        private int loadedSnippetId = 0;

        public SnippetForm()
        {
            InitializeComponent();
            LoadLanguages();
        }

        public event EventHandler SnippetSaved;

        private void SnippetSaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedLanguageId = (int)SnippetLanguageDropdown.SelectedValue;

                // Check if a language has been selected
                if (selectedLanguageId == 0)
                {
                    MessageBox.Show("Please select a language before saving.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;  // Stop further execution if no language is selected
                }

                using (var context = new AppDbContext())
                {
                    bool languageExists = context.Languages.Any(l => l.Id == selectedLanguageId);
                    if (!languageExists)
                    {
                        MessageBox.Show("The selected language does not exist. Please select a valid language.", "Invalid Language", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }


                    var snippet = new Snippet
                    {
                        Id = loadedSnippetId,
                        SnippetName = SnippetName.Text,
                        SnippetDescription = SnippetDescription.Text,
                        CodeSnippetText = CodeSnippetText.Text,
                        AnalysisText = AnalysisText.Text,
                        LanguageId = (int)SnippetLanguageDropdown.SelectedValue,
                        CreatedDate = DateTime.Now // Ensure CreatedDate is set
                    };

                    _controller.SaveSnippet(snippet);

                    MessageBox.Show("Snippet saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SnippetSaved?.Invoke(this, EventArgs.Empty);
                    this.Close(); // Close the form after saving
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


        private void LoadLanguages()
        {
            using (var context = new AppDbContext())
            {
                // Get the list of languages from the database
                var languages = context.Languages.ToList();
                languages.Insert(0, new Language { Id = 0, LanguageName = "Select a language" });

                // Bind the languages to the ComboBox
                SnippetLanguageDropdown.DataSource = languages;
                SnippetLanguageDropdown.DisplayMember = "LanguageName";  // The property to display
                SnippetLanguageDropdown.ValueMember = "Id";             // The value to use for data binding
            }
        }

        public void LoadSnippet(int snippetId)
        {
            using (var context = new AppDbContext())
            {
                var snippet = context.Snippets
                    .Include(s => s.LanguageId) // Include related language
                    .FirstOrDefault(s => s.Id == snippetId);

                if (snippet != null)
                {
                    loadedSnippetId = snippet.Id;

                    SnippetName.Text = snippet.SnippetName;
                    SnippetDescription.Text = snippet.SnippetDescription;
                    CodeSnippetText.Text = snippet.CodeSnippetText;
                    AnalysisText.Text = snippet.AnalysisText;
                    SnippetLanguageDropdown.SelectedValue = snippet.LanguageId;
                }
                else
                {
                    MessageBox.Show("Snippet not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
