namespace CodeSnippetTool.Forms
{
    partial class UserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            IconImage = new PictureBox();
            label8 = new Label();
            CloseButton = new Button();
            UserSaveButton = new Button();
            UsernameLabel = new Label();
            PasswordLabel = new Label();
            EmailLabel = new Label();
            UsernameText = new TextBox();
            PasswordText = new TextBox();
            EmailText = new TextBox();
            RoleDropdown = new ComboBox();
            RoleLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)IconImage).BeginInit();
            SuspendLayout();
            // 
            // IconImage
            // 
            IconImage.Image = (Image)resources.GetObject("IconImage.Image");
            IconImage.InitialImage = (Image)resources.GetObject("IconImage.InitialImage");
            IconImage.Location = new Point(17, 23);
            IconImage.Name = "IconImage";
            IconImage.Size = new Size(55, 42);
            IconImage.SizeMode = PictureBoxSizeMode.Zoom;
            IconImage.TabIndex = 24;
            IconImage.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Malgun Gothic", 16F, FontStyle.Bold);
            label8.Location = new Point(101, 23);
            label8.Name = "label8";
            label8.Size = new Size(197, 30);
            label8.TabIndex = 23;
            label8.Text = "Add/Update User";
            // 
            // CloseButton
            // 
            CloseButton.Location = new Point(209, 390);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(138, 33);
            CloseButton.TabIndex = 26;
            CloseButton.Text = "Cancel";
            CloseButton.UseVisualStyleBackColor = true;
            CloseButton.Click += CloseButton_Click;
            // 
            // UserSaveButton
            // 
            UserSaveButton.Location = new Point(29, 390);
            UserSaveButton.Name = "UserSaveButton";
            UserSaveButton.Size = new Size(142, 33);
            UserSaveButton.TabIndex = 25;
            UserSaveButton.Text = "Save User";
            UserSaveButton.UseVisualStyleBackColor = true;
            UserSaveButton.Click += UserSaveButton_Click;
            // 
            // UsernameLabel
            // 
            UsernameLabel.AutoSize = true;
            UsernameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UsernameLabel.Location = new Point(17, 89);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new Size(87, 21);
            UsernameLabel.TabIndex = 27;
            UsernameLabel.Text = "Username";
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PasswordLabel.Location = new Point(17, 158);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(82, 21);
            PasswordLabel.TabIndex = 28;
            PasswordLabel.Text = "Password";
            // 
            // EmailLabel
            // 
            EmailLabel.AutoSize = true;
            EmailLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EmailLabel.Location = new Point(17, 230);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(53, 21);
            EmailLabel.TabIndex = 29;
            EmailLabel.Text = "Email";
            // 
            // UsernameText
            // 
            UsernameText.Location = new Point(40, 118);
            UsernameText.Name = "UsernameText";
            UsernameText.PlaceholderText = "Username";
            UsernameText.Size = new Size(283, 23);
            UsernameText.TabIndex = 30;
            // 
            // PasswordText
            // 
            PasswordText.Location = new Point(40, 191);
            PasswordText.Name = "PasswordText";
            PasswordText.PlaceholderText = "Password";
            PasswordText.Size = new Size(283, 23);
            PasswordText.TabIndex = 31;
            // 
            // EmailText
            // 
            EmailText.Location = new Point(40, 263);
            EmailText.Name = "EmailText";
            EmailText.PlaceholderText = "Email";
            EmailText.Size = new Size(283, 23);
            EmailText.TabIndex = 32;
            // 
            // RoleDropdown
            // 
            RoleDropdown.FormattingEnabled = true;
            RoleDropdown.Location = new Point(40, 337);
            RoleDropdown.Name = "RoleDropdown";
            RoleDropdown.Size = new Size(121, 23);
            RoleDropdown.TabIndex = 33;
            // 
            // RoleLabel
            // 
            RoleLabel.AutoSize = true;
            RoleLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RoleLabel.Location = new Point(17, 304);
            RoleLabel.Name = "RoleLabel";
            RoleLabel.Size = new Size(44, 21);
            RoleLabel.TabIndex = 34;
            RoleLabel.Text = "Role";
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(401, 453);
            Controls.Add(RoleLabel);
            Controls.Add(RoleDropdown);
            Controls.Add(EmailText);
            Controls.Add(PasswordText);
            Controls.Add(UsernameText);
            Controls.Add(EmailLabel);
            Controls.Add(PasswordLabel);
            Controls.Add(UsernameLabel);
            Controls.Add(CloseButton);
            Controls.Add(UserSaveButton);
            Controls.Add(IconImage);
            Controls.Add(label8);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "UserForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Code Snippet Tool";
            ((System.ComponentModel.ISupportInitialize)IconImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox IconImage;
        private Label label8;
        private Button CloseButton;
        private Button UserSaveButton;
        private Label UsernameLabel;
        private Label PasswordLabel;
        private Label EmailLabel;
        private TextBox UsernameText;
        private TextBox PasswordText;
        private TextBox EmailText;
        private ComboBox RoleDropdown;
        private Label RoleLabel;
    }
}