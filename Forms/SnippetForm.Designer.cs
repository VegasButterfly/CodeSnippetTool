namespace CodeSnippetTool
{
    partial class SnippetForm
    {
        private System.ComponentModel.IContainer components = null;

        private TabControl tabControl2;
        private TabPage tabPage4;
        private Button TranslateDeleteButton;
        private Button TranslateSaveButton;
        private Button TranslateReviewButton;
        private Button TranslateButton;
        private RichTextBox TranslationText;
        private ComboBox TranslationLanguageDropdown;
        private TabPage tabPage5;
        private RichTextBox AnalysisText;
        private Button AnalyzeButton;
        private Panel panel1;
        private RichTextBox SnippetDescription;
        private TextBox SnippetName;
        private Label label3;
        private Label label2;
        private Label label1;
        private RichTextBox CodeSnippetText;
        private Label label4;
        private Button SnippetSaveButton;
        private ComboBox SnippetLanguageDropdown;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            tabControl2 = new TabControl();
            tabPage4 = new TabPage();
            TranslateDeleteButton = new Button();
            TranslateSaveButton = new Button();
            TranslateReviewButton = new Button();
            TranslateButton = new Button();
            TranslationText = new RichTextBox();
            TranslationLanguageDropdown = new ComboBox();
            tabPage5 = new TabPage();
            AnalysisText = new RichTextBox();
            AnalyzeButton = new Button();
            panel1 = new Panel();
            SnippetDescription = new RichTextBox();
            SnippetName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            CodeSnippetText = new RichTextBox();
            label4 = new Label();
            SnippetSaveButton = new Button();
            SnippetLanguageDropdown = new ComboBox();

            tabControl2.SuspendLayout();
            tabPage4.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // SnippetSaveButton
            // 
            SnippetSaveButton.Location = new Point(1173, 550);
            SnippetSaveButton.Name = "SnippetSaveButton";
            SnippetSaveButton.Size = new Size(142, 33);
            SnippetSaveButton.TabIndex = 17;
            SnippetSaveButton.Text = "SAVE";
            SnippetSaveButton.UseVisualStyleBackColor = true;
            SnippetSaveButton.Click += SnippetSaveButton_Click;
            // 
            // other control setups...
            // 
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
