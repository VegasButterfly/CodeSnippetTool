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
        private bool isLanguageProgrammaticChange = false;

        public SnippetForm()
        {
            InitializeComponent();
            this.Icon = new System.Drawing.Icon("CodeSnippetTool.ico");
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
                SnippetLanguageDropdown.SelectedIndexChanged -= SnippetLanguageDropdown_SelectedIndexChanged;

                // Get the list of languages from the database
                var languages = context.Languages.ToList();
                languages.Insert(0, new Language { Id = 0, LanguageName = "Select a language" });

                // Bind the languages to the ComboBox
                SnippetLanguageDropdown.DataSource = languages;
                SnippetLanguageDropdown.DisplayMember = "LanguageName";  // The property to display
                SnippetLanguageDropdown.ValueMember = "Id";             // The value to use for data binding


                ///TranslationLanguageDropdown.DataSource = languages;
                ///TranslationLanguageDropdown.DisplayMember = "LanguageName";  // The property to display
                ///TranslationLanguageDropdown.ValueMember = "Id";             // The value to use for data binding             
                
                SnippetLanguageDropdown.SelectedIndexChanged += SnippetLanguageDropdown_SelectedIndexChanged;

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
                    SnippetLanguageDropdown.SelectedIndexChanged -= SnippetLanguageDropdown_SelectedIndexChanged;

                    loadedSnippetId = snippet.Id;

                    SnippetName.Text = snippet.SnippetName;
                    SnippetDescription.Text = snippet.SnippetDescription;
                    CodeSnippetText.Text = snippet.CodeSnippetText;
                    AnalysisText.Text = snippet.AnalysisText;
                    SnippetLanguageDropdown.SelectedValue = snippet.LanguageId;
                    CreatedByLabel.Text = $"Created By: {snippet.CreatedBy?.Username ?? "Not Saved"}";
                    CreatedOnLabel.Text = $"Created On: {snippet.CreatedDate:MM/dd/yyyy}";

                    SnippetLanguageDropdown.SelectedIndexChanged += SnippetLanguageDropdown_SelectedIndexChanged;
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
                // Validate that the CodeSnippetText and Language dropdown have values
                if (string.IsNullOrEmpty(CodeSnippetText.Text))
                {
                    MessageBox.Show("Code snippet text cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string languageName = SnippetLanguageDropdown.Text; // Assuming the dropdown provides the language name
                if (string.IsNullOrEmpty(languageName))
                {
                    MessageBox.Show("Please select a language before analyzing.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                try
                {
                    // Call the OpenAI API to get the analysis
                    string analysisResult = await OpenAIHelper.GetAIAnalysisAsync(languageName, CodeSnippetText.Text);

                    // Populate the AnalysisText rich text box with the result
                    AnalysisText.Text = analysisResult;

                    MessageBox.Show("Analysis completed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    // Log or display the detailed error message
                    MessageBox.Show($"Error: {ex.Message}\n\nDetails: {ex.InnerException?.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while analyzing the code: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void TranslateReviewButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Assuming translationId is available from the UI context or selected translation
                int translationId = 1;  // Example translation Id
                int currentUserId = (int)UserSession.CurrentUserId;  // Get the current user ID from session

                // Call the method to mark the translation as reviewed
                await new TranslationController(new AppDbContext())
                    .ReviewTranslationAsync(translationId, currentUserId);

                MessageBox.Show("Translation reviewed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reviewing translation: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void TranslateSaveButton_Click(object sender, EventArgs e)
        {
            try
            {

                var translation = new Translation
                {
                    ///Language = TranslationLanguageDropdown.Text,
                    ///TranslationText = TranslationText.Text,
                    Reviewed = false,  // Default value if not reviewed
                    ReviewerId = null,  // No reviewer yet
                    ReviewDate = null  // No review date yet
                };

                bool isNew = translation.Id == 0; // Assuming translation has an Id property
                await new TranslationController(new AppDbContext())
                    .SaveTranslationAsync(translation, isNew);

                MessageBox.Show("Translation saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving translation: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SnippetLanguageDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (isLanguageProgrammaticChange) return;

                // Get the currently selected language ID
                int selectedLanguageId = (int)SnippetLanguageDropdown.SelectedValue;

                // If AnalysisText is not empty and a snippet is loaded, prompt the user
                if (!string.IsNullOrEmpty(AnalysisText.Text) && loadedSnippetId > 0)
                {
                    var result = MessageBox.Show(
                        "Translation feature is not enabled at this time. The analysis will be cleared, and a new AI analysis should be run before saving. Do you wish to continue changing the language?",
                        "Language Change Confirmation",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        // Allow language change and clear AnalysisText
                        this.AnalysisText.Clear();
                    }
                    else
                    {
                        isLanguageProgrammaticChange = true;
                        // Revert to the previously saved language
                        using (var context = new AppDbContext())
                        {
                            var snippet = context.Snippets.FirstOrDefault(s => s.Id == loadedSnippetId);
                            if (snippet != null)
                            {
                                SnippetLanguageDropdown.SelectedValue = snippet.LanguageId;
                            }
                        }
                        isLanguageProgrammaticChange = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while changing the language: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}

