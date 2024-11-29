﻿namespace CodeSnippetTool
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
            label9 = new Label();
            ReviewedByLabel = new Label();
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
            CreatedOnLabel = new Label();
            CreatedByLabel = new Label();
            SnippetDescription = new RichTextBox();
            SnippetName = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            CodeSnippetText = new RichTextBox();
            SnippetSaveButton = new Button();
            SnippetLanguageDropdown = new ComboBox();
            CloseButton = new Button();
            ExitButton = new Button();
            label5 = new Label();
            tabControl2.SuspendLayout();
            tabPage4.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl2
            // 
            tabControl2.Controls.Add(tabPage4);
            tabControl2.Controls.Add(tabPage5);
            tabControl2.Enabled = false;
            tabControl2.Location = new Point(792, 59);
            tabControl2.Name = "tabControl2";
            tabControl2.SelectedIndex = 0;
            tabControl2.Size = new Size(527, 482);
            tabControl2.TabIndex = 15;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(label9);
            tabPage4.Controls.Add(ReviewedByLabel);
            tabPage4.Controls.Add(TranslateDeleteButton);
            tabPage4.Controls.Add(TranslateSaveButton);
            tabPage4.Controls.Add(TranslateReviewButton);
            tabPage4.Controls.Add(TranslateButton);
            tabPage4.Controls.Add(TranslationText);
            tabPage4.Controls.Add(TranslationLanguageDropdown);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(519, 454);
            tabPage4.TabIndex = 0;
            tabPage4.Text = "Translation";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 24F);
            label9.ForeColor = Color.Firebrick;
            label9.Location = new Point(98, 189);
            label9.Name = "label9";
            label9.Size = new Size(301, 45);
            label9.TabIndex = 22;
            label9.Text = "Future Functionality";
            // 
            // ReviewedByLabel
            // 
            ReviewedByLabel.AutoSize = true;
            ReviewedByLabel.Location = new Point(98, 425);
            ReviewedByLabel.Name = "ReviewedByLabel";
            ReviewedByLabel.Size = new Size(76, 15);
            ReviewedByLabel.TabIndex = 9;
            ReviewedByLabel.Text = "Reviewed By:";
            // 
            // TranslateDeleteButton
            // 
            TranslateDeleteButton.Enabled = false;
            TranslateDeleteButton.Location = new Point(476, 419);
            TranslateDeleteButton.Name = "TranslateDeleteButton";
            TranslateDeleteButton.Size = new Size(26, 23);
            TranslateDeleteButton.TabIndex = 5;
            TranslateDeleteButton.Text = "Delete";
            TranslateDeleteButton.UseVisualStyleBackColor = true;
            // 
            // TranslateSaveButton
            // 
            TranslateSaveButton.Enabled = false;
            TranslateSaveButton.Location = new Point(396, 420);
            TranslateSaveButton.Name = "TranslateSaveButton";
            TranslateSaveButton.Size = new Size(75, 23);
            TranslateSaveButton.TabIndex = 4;
            TranslateSaveButton.Text = "Save";
            TranslateSaveButton.UseVisualStyleBackColor = true;
            TranslateSaveButton.Click += TranslateSaveButton_Click;
            // 
            // TranslateReviewButton
            // 
            TranslateReviewButton.Enabled = false;
            TranslateReviewButton.Location = new Point(12, 421);
            TranslateReviewButton.Name = "TranslateReviewButton";
            TranslateReviewButton.Size = new Size(75, 23);
            TranslateReviewButton.TabIndex = 3;
            TranslateReviewButton.Text = "Review";
            TranslateReviewButton.UseVisualStyleBackColor = true;
            TranslateReviewButton.Click += TranslateReviewButton_Click;
            // 
            // TranslateButton
            // 
            TranslateButton.Enabled = false;
            TranslateButton.Location = new Point(427, 11);
            TranslateButton.Name = "TranslateButton";
            TranslateButton.Size = new Size(75, 23);
            TranslateButton.TabIndex = 2;
            TranslateButton.Text = "AI Translate";
            TranslateButton.UseVisualStyleBackColor = true;
            // 
            // TranslationText
            // 
            TranslationText.Enabled = false;
            TranslationText.Location = new Point(12, 43);
            TranslationText.Name = "TranslationText";
            TranslationText.Size = new Size(490, 371);
            TranslationText.TabIndex = 1;
            TranslationText.Text = "";
            // 
            // TranslationLanguageDropdown
            // 
            TranslationLanguageDropdown.FormattingEnabled = true;
            TranslationLanguageDropdown.Location = new Point(12, 12);
            TranslationLanguageDropdown.Name = "TranslationLanguageDropdown";
            TranslationLanguageDropdown.Size = new Size(121, 23);
            TranslationLanguageDropdown.TabIndex = 0;
            TranslationLanguageDropdown.Text = "Language";
            // 
            // tabPage5
            // 
            tabPage5.Location = new Point(4, 24);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(519, 454);
            tabPage5.TabIndex = 1;
            tabPage5.Text = "Translation2";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // AnalysisText
            // 
            AnalysisText.Location = new Point(407, 422);
            AnalysisText.Name = "AnalysisText";
            AnalysisText.Size = new Size(352, 110);
            AnalysisText.TabIndex = 13;
            AnalysisText.Text = "";
            // 
            // AnalyzeButton
            // 
            AnalyzeButton.Location = new Point(405, 393);
            AnalyzeButton.Name = "AnalyzeButton";
            AnalyzeButton.Size = new Size(75, 23);
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
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(29, 51);
            panel1.Name = "panel1";
            panel1.Size = new Size(357, 493);
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
            SnippetDescription.Location = new Point(16, 96);
            SnippetDescription.Name = "SnippetDescription";
            SnippetDescription.Size = new Size(313, 198);
            SnippetDescription.TabIndex = 6;
            SnippetDescription.Text = "";
            // 
            // SnippetName
            // 
            SnippetName.Location = new Point(16, 43);
            SnippetName.Name = "SnippetName";
            SnippetName.Size = new Size(314, 23);
            SnippetName.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 78);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 4;
            label3.Text = "Description";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 8);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 16;
            label4.Text = "Snippet";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 25);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 3;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(392, 59);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 12;
            label1.Text = "Code Snippet";
            // 
            // CodeSnippetText
            // 
            CodeSnippetText.Location = new Point(405, 80);
            CodeSnippetText.Name = "CodeSnippetText";
            CodeSnippetText.Size = new Size(354, 298);
            CodeSnippetText.TabIndex = 11;
            CodeSnippetText.Text = "";
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
            // SnippetLanguageDropdown
            // 
            SnippetLanguageDropdown.FormattingEnabled = true;
            SnippetLanguageDropdown.Location = new Point(491, 51);
            SnippetLanguageDropdown.Name = "SnippetLanguageDropdown";
            SnippetLanguageDropdown.Size = new Size(121, 23);
            SnippetLanguageDropdown.TabIndex = 18;
            SnippetLanguageDropdown.Text = "Language";
            // 
            // CloseButton
            // 
            CloseButton.Location = new Point(1029, 550);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(138, 33);
            CloseButton.TabIndex = 19;
            CloseButton.Text = "CLOSE";
            CloseButton.UseVisualStyleBackColor = true;
            CloseButton.Click += CloseButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(1188, 20);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(124, 35);
            ExitButton.TabIndex = 20;
            ExitButton.Text = "EXIT";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Malgun Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(29, 3);
            label5.Name = "label5";
            label5.Size = new Size(304, 45);
            label5.TabIndex = 21;
            label5.Text = "Code Snippet Tool";
            // 
            // SnippetForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1349, 595);
            Controls.Add(label5);
            Controls.Add(ExitButton);
            Controls.Add(CloseButton);
            Controls.Add(SnippetLanguageDropdown);
            Controls.Add(SnippetSaveButton);
            Controls.Add(tabControl2);
            Controls.Add(AnalysisText);
            Controls.Add(AnalyzeButton);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(CodeSnippetText);
            Name = "SnippetForm";
            Text = "Snippet";
            tabControl2.ResumeLayout(false);
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private Button CloseButton;
        private Button ExitButton;
        private Label ReviewedByLabel;
        private Label CreatedOnLabel;
        private Label CreatedByLabel;
        private Label label5;
        private Label label9;

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
