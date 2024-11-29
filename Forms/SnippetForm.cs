using CodeSnippetTool.Controllers;
using CodeSnippetTool.Data;
using CodeSnippetTool.Models;
using System;
using Microsoft.EntityFrameworkCore;
using System.Windows.Forms;
using System.Diagnostics.Eventing.Reader;
using CodeSnippetTool.Services;

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
                    return;  // Stop 
                }

                using (var context = new AppDbContext())
                {
                    bool languageExists = context.Languages.Any(l => l.Id == selectedLanguageId);
                    if (!languageExists)
                    {
                        MessageBox.Show("The selected language does not exist. Please select a valid language.", "Invalid Language", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    //this checks if it's an update or a new one
                    Snippet snippet;

                    if (loadedSnippetId == 0)
                    {
                        snippet = new Snippet
                        {
                            Id = loadedSnippetId,
                            SnippetName = SnippetName.Text,
                            SnippetDescription = SnippetDescription.Text,
                            CodeSnippetText = CodeSnippetText.Text,
                            AnalysisText = AnalysisText.Text,
                            LanguageId = selectedLanguageId,
                            CreatedDate = DateTime.Now,
                            CreatedById = (int)UserSession.CurrentUserId
                        };
                    }
                    else
                    {
                        snippet = context.Snippets.FirstOrDefault(s => s.Id == loadedSnippetId);
                        if (snippet != null)
                        {
                            snippet.SnippetName = SnippetName.Text;
                            snippet.SnippetDescription = SnippetDescription.Text;
                            snippet.CodeSnippetText = CodeSnippetText.Text;
                            snippet.AnalysisText = AnalysisText.Text;
                            snippet.LanguageId = selectedLanguageId;
                        }
                        else
                        {
                            MessageBox.Show("Snippet not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    context.Entry(snippet).State = loadedSnippetId == 0 ? EntityState.Added : EntityState.Modified;
                    context.SaveChanges();

                    MessageBox.Show("Snippet saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    SnippetSaved?.Invoke(this, EventArgs.Empty);
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
                    .Include(s => s.CreatedBy)
                    .FirstOrDefault(s => s.Id == snippetId);

                if (snippet != null)
                {
                    loadedSnippetId = snippet.Id;

                    SnippetName.Text = snippet.SnippetName;
                    SnippetDescription.Text = snippet.SnippetDescription;
                    CodeSnippetText.Text = snippet.CodeSnippetText;
                    AnalysisText.Text = snippet.AnalysisText;
                    SnippetLanguageDropdown.SelectedValue = snippet.LanguageId;
                    CreatedByLabel.Text = $"Created By: {snippet.CreatedBy?.Username ?? "Not Saved"}";
                    CreatedOnLabel.Text = $"Created On: {snippet.CreatedDate:MM/dd/yyyy}";
                }
                else
                {
                    MessageBox.Show("Snippet not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private async void AnalyzeButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate required fields
                if (string.IsNullOrEmpty(CodeSnippetText.Text))
                {
                    MessageBox.Show("Code snippet text cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string languageName = SnippetLanguageDropdown.Text; // Works if DisplayMember is set properly
                if (string.IsNullOrEmpty(languageName))
                {
                    MessageBox.Show("Please select a language before analyzing.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Prepare the prompt for OpenAI analysis
                string prompt = $"Analyze my code for its purpose. It is written in {languageName}: {CodeSnippetText.Text}";

                // Call OpenAIHelper to get the analysis
                string analysisResult = await OpenAIHelper.GetAIAnalysisAsync(languageName, CodeSnippetText.Text); // Use CodeSnippetText.Text

                // Check if this is a new snippet or an existing snippet
                if (loadedSnippet == null)
                {
                    // If it's a new snippet, create a new one
                    loadedSnippet = new Snippet
                    {
                        SnippetName = "New Snippet",  // Set this to whatever is appropriate
                        SnippetDescription = "Description for new snippet",  // Set as needed
                        LanguageName = languageName,
                        CodeSnippetText = CodeSnippetText.Text,
                        AnalysisText = analysisResult,
                        IsAnalyzed = true
                    };

                    // Optionally, you can save this new snippet to the database
                    // SaveNewSnippetToDatabase(loadedSnippet); // Implement the saving logic here

                    // Notify the user of the new snippet creation and analysis
                    MessageBox.Show("New code snippet created and analyzed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // If it's an existing snippet, update the analysis
                    loadedSnippet.AnalysisText = analysisResult;
                    loadedSnippet.IsAnalyzed = true;

                    // Optionally, save the updated snippet
                    // SaveUpdatedSnippetToDatabase(loadedSnippet); // Implement the update logic here

                    // Notify the user of the successful analysis update
                    MessageBox.Show("Code analyzed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Show the analysis result in the AnalysisText box
                AnalysisText.Text = analysisResult;
            }
            catch (Exception ex)
            {
                // Handle any errors during the API call
                MessageBox.Show($"An error occurred while analyzing the code: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
 }

