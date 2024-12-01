namespace CodeSnippetTool
{
    partial class SnippetForm
    {
        private System.ComponentModel.IContainer components = null;
        private RichTextBox AnalysisText;
        private Button AnalyzeButton;
        private Panel panel1;
        private RichTextBox SnippetDescription;
        private TextBox SnippetName;
        private Label label3;
        private Label label2;
        private RichTextBox CodeSnippetText;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SnippetForm));
            AnalysisText = new RichTextBox();
            AnalyzeButton = new Button();
            panel1 = new Panel();
            CreatedOnLabel = new Label();
            CreatedByLabel = new Label();
            SnippetDescription = new RichTextBox();
            SnippetName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            CodeSnippetText = new RichTextBox();
            SnippetSaveButton = new Button();
            SnippetLanguageDropdown = new ComboBox();
            CloseButton = new Button();
            ExitButton = new Button();
            IconImage = new PictureBox();
            label8 = new Label();
            SourceLanguageLabel = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)IconImage).BeginInit();
            SuspendLayout();
            // 
            // AnalysisText
            // 
            AnalysisText.Location = new Point(889, 83);
            AnalysisText.Name = "AnalysisText";
            AnalysisText.Size = new Size(379, 327);
            AnalysisText.TabIndex = 13;
            AnalysisText.Text = "";
            // 
            // AnalyzeButton
            // 
            AnalyzeButton.Location = new Point(889, 50);
            AnalyzeButton.Name = "AnalyzeButton";
            AnalyzeButton.Size = new Size(159, 23);
            AnalyzeButton.TabIndex = 14;
            AnalyzeButton.Text = "AI Analyze";
            AnalyzeButton.UseVisualStyleBackColor = true;
            AnalyzeButton.Click += AnalyzeButton_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(CreatedOnLabel);
            panel1.Controls.Add(CreatedByLabel);
            panel1.Controls.Add(SnippetDescription);
            panel1.Controls.Add(SnippetName);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(29, 83);
            panel1.Name = "panel1";
            panel1.Size = new Size(357, 383);
            panel1.TabIndex = 10;
            // 
            // CreatedOnLabel
            // 
            CreatedOnLabel.AutoSize = true;
            CreatedOnLabel.Location = new Point(18, 336);
            CreatedOnLabel.Name = "CreatedOnLabel";
            CreatedOnLabel.Size = new Size(70, 15);
            CreatedOnLabel.TabIndex = 8;
            CreatedOnLabel.Text = "Created On:";
            // 
            // CreatedByLabel
            // 
            CreatedByLabel.AutoSize = true;
            CreatedByLabel.Location = new Point(17, 312);
            CreatedByLabel.Name = "CreatedByLabel";
            CreatedByLabel.Size = new Size(67, 15);
            CreatedByLabel.TabIndex = 7;
            CreatedByLabel.Text = "Created By:";
            // 
            // SnippetDescription
            // 
            SnippetDescription.Location = new Point(16, 65);
            SnippetDescription.Name = "SnippetDescription";
            SnippetDescription.Size = new Size(313, 229);
            SnippetDescription.TabIndex = 6;
            SnippetDescription.Text = "";
            // 
            // SnippetName
            // 
            SnippetName.Location = new Point(16, 21);
            SnippetName.Name = "SnippetName";
            SnippetName.Size = new Size(314, 23);
            SnippetName.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 47);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 4;
            label3.Text = "Description";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 3);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 3;
            label2.Text = "Name";
            // 
            // CodeSnippetText
            // 
            CodeSnippetText.Location = new Point(407, 83);
            CodeSnippetText.Name = "CodeSnippetText";
            CodeSnippetText.Size = new Size(462, 383);
            CodeSnippetText.TabIndex = 11;
            CodeSnippetText.Text = "";
            // 
            // SnippetSaveButton
            // 
            SnippetSaveButton.Location = new Point(924, 419);
            SnippetSaveButton.Name = "SnippetSaveButton";
            SnippetSaveButton.Size = new Size(142, 33);
            SnippetSaveButton.TabIndex = 17;
            SnippetSaveButton.Text = "Save Snippet";
            SnippetSaveButton.UseVisualStyleBackColor = true;
            SnippetSaveButton.Click += SnippetSaveButton_Click;
            // 
            // SnippetLanguageDropdown
            // 
            SnippetLanguageDropdown.FormattingEnabled = true;
            SnippetLanguageDropdown.Location = new Point(515, 50);
            SnippetLanguageDropdown.Name = "SnippetLanguageDropdown";
            SnippetLanguageDropdown.Size = new Size(121, 23);
            SnippetLanguageDropdown.TabIndex = 18;
            SnippetLanguageDropdown.Text = "Language";
            // 
            // CloseButton
            // 
            CloseButton.Location = new Point(1104, 419);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(138, 33);
            CloseButton.TabIndex = 19;
            CloseButton.Text = "Cancel";
            CloseButton.UseVisualStyleBackColor = true;
            CloseButton.Click += CloseButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(1188, 20);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(124, 35);
            ExitButton.TabIndex = 20;
            ExitButton.Text = "&Exit Program";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // IconImage
            // 
            IconImage.Image = (Image)resources.GetObject("IconImage.Image");
            IconImage.InitialImage = (Image)resources.GetObject("IconImage.InitialImage");
            IconImage.Location = new Point(21, 14);
            IconImage.Name = "IconImage";
            IconImage.Size = new Size(55, 42);
            IconImage.SizeMode = PictureBoxSizeMode.Zoom;
            IconImage.TabIndex = 22;
            IconImage.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Malgun Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(82, 10);
            label8.Name = "label8";
            label8.Size = new Size(304, 45);
            label8.TabIndex = 21;
            label8.Text = "Add / Edit Snippet";
            // 
            // SourceLanguageLabel
            // 
            SourceLanguageLabel.AutoSize = true;
            SourceLanguageLabel.Location = new Point(408, 54);
            SourceLanguageLabel.Name = "SourceLanguageLabel";
            SourceLanguageLabel.Size = new Size(101, 15);
            SourceLanguageLabel.TabIndex = 23;
            SourceLanguageLabel.Text = "Source Language:";
            // 
            // SnippetForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(1329, 512);
            Controls.Add(SourceLanguageLabel);
            Controls.Add(IconImage);
            Controls.Add(label8);
            Controls.Add(ExitButton);
            Controls.Add(CloseButton);
            Controls.Add(SnippetLanguageDropdown);
            Controls.Add(SnippetSaveButton);
            Controls.Add(AnalysisText);
            Controls.Add(AnalyzeButton);
            Controls.Add(panel1);
            Controls.Add(CodeSnippetText);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "SnippetForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Code Snippet Tool";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)IconImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Button CloseButton;
        private Button ExitButton;
        private Label CreatedOnLabel;
        private Label CreatedByLabel;
        private PictureBox IconImage;
        private Label label8;
        private Label SourceLanguageLabel;

        //private TabControl tabControl2;
        //private TabPage tabPage4;
        //private Button TranslateDeleteButton;
        //private Button TranslateSaveButton;
        //private Button TranslateReviewButton;
        //private Button TranslateButton;
        //private RichTextBox TranslationText;
        //private ComboBox TranslationLanguageDropdown;
        //private TabPage tabPage5;
        //private RichTextBox AnalysisText;
        //private Button AnalyzeButton;
        //private Panel panel1;
        //private RichTextBox SnippetDescription;
        //private TextBox SnippetName;
        //private Label label3;
        //private Label label2;
        //private Label label1;
        //private RichTextBox CodeSnippetText;
        //private Label label4;
        //private Button SnippetSaveButton;
        //private ComboBox SnippetLanguageDropdown;


    }
}
