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
        }

        private void SnippetSaveButton_Click(object sender, EventArgs e)
        {
            var snippet = new Snippet
            {
                Id = loadedSnippetId,
                SnippetName = SnippetName.Text,
                SnippetDescription = SnippetDescription.Text,
                CodeSnippetText = CodeSnippetText.Text,
                AnalysisText = AnalysisText.Text,
                LanguageId = (int?)SnippetLanguageDropdown.SelectedValue,
                CreatedDate = DateTime.Now // Ensure CreatedDate is set
            };

            _controller.SaveSnippet(snippet);

            MessageBox.Show("Snippet saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close(); // Close the form after saving
        }

        public void LoadSnippet(int snippetId)
        {
            using (var context = new AppDbContext())
            {
                var snippet = context.Snippets
                    .Include(s => s.Language) // Include related language
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
