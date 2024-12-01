namespace CodeSnippetTool.Forms
{
    partial class TranslationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TranslationTab = new TabControl();
            Translation = new TabPage();
            label9 = new Label();
            ReviewedByLabel = new Label();
            TranslateDeleteButton = new Button();
            TranslateSaveButton = new Button();
            TranslateReviewButton = new Button();
            TranslateButton = new Button();
            TranslationText = new RichTextBox();
            TranslationLanguageDropdown = new ComboBox();
            Translation2 = new TabPage();
            TranslationTab.SuspendLayout();
            Translation.SuspendLayout();
            SuspendLayout();
            // 
            // TranslationTab
            // 
            TranslationTab.Controls.Add(Translation);
            TranslationTab.Controls.Add(Translation2);
            TranslationTab.Enabled = false;
            TranslationTab.Location = new Point(135, 62);
            TranslationTab.Name = "TranslationTab";
            TranslationTab.SelectedIndex = 0;
            TranslationTab.Size = new Size(531, 326);
            TranslationTab.TabIndex = 16;
            // 
            // Translation
            // 
            Translation.Controls.Add(label9);
            Translation.Controls.Add(ReviewedByLabel);
            Translation.Controls.Add(TranslateDeleteButton);
            Translation.Controls.Add(TranslateSaveButton);
            Translation.Controls.Add(TranslateReviewButton);
            Translation.Controls.Add(TranslateButton);
            Translation.Controls.Add(TranslationText);
            Translation.Controls.Add(TranslationLanguageDropdown);
            Translation.Location = new Point(4, 24);
            Translation.Name = "Translation";
            Translation.Padding = new Padding(3);
            Translation.Size = new Size(523, 298);
            Translation.TabIndex = 0;
            Translation.Text = "Translation";
            Translation.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 24F);
            label9.ForeColor = Color.Firebrick;
            label9.Location = new Point(101, 192);
            label9.Name = "label9";
            label9.Size = new Size(301, 45);
            label9.TabIndex = 22;
            label9.Text = "Future Functionality";
            // 
            // ReviewedByLabel
            // 
            ReviewedByLabel.AutoSize = true;
            ReviewedByLabel.Location = new Point(101, 428);
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
            // 
            // TranslateButton
            // 
            TranslateButton.Enabled = false;
            TranslateButton.Location = new Point(347, 11);
            TranslateButton.Name = "TranslateButton";
            TranslateButton.Size = new Size(155, 23);
            TranslateButton.TabIndex = 2;
            TranslateButton.Text = "AI Translate";
            TranslateButton.UseVisualStyleBackColor = true;
            // 
            // TranslationText
            // 
            TranslationText.Enabled = false;
            TranslationText.Location = new Point(12, 43);
            TranslationText.Name = "TranslationText";
            TranslationText.Size = new Size(490, 238);
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
            // Translation2
            // 
            Translation2.Location = new Point(4, 24);
            Translation2.Name = "Translation2";
            Translation2.Padding = new Padding(3);
            Translation2.Size = new Size(523, 298);
            Translation2.TabIndex = 1;
            Translation2.Text = "Translation";
            Translation2.UseVisualStyleBackColor = true;
            // 
            // TranslationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TranslationTab);
            Name = "TranslationForm";
            Text = "TranslationForm";
            TranslationTab.ResumeLayout(false);
            Translation.ResumeLayout(false);
            Translation.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl TranslationTab;
        private TabPage Translation;
        private Label label9;
        private Label ReviewedByLabel;
        private Button TranslateDeleteButton;
        private Button TranslateSaveButton;
        private Button TranslateReviewButton;
        private Button TranslateButton;
        private RichTextBox TranslationText;
        private ComboBox TranslationLanguageDropdown;
        private TabPage Translation2;
    }
}