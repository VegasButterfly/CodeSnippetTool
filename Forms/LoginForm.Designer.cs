namespace CodeSnippetTool
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtUsername = new TextBox();
            txtPassword = new MaskedTextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            LinkLabel_LinkedIn = new LinkLabel();
            LoginButton = new Button();
            linkLabel_GitHub = new LinkLabel();
            label4 = new Label();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(155, 86);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(159, 23);
            txtUsername.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(155, 126);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(159, 23);
            txtPassword.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(89, 89);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 2;
            label1.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(89, 129);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 3;
            label2.Text = "Password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Malgun Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(59, 9);
            label3.Name = "label3";
            label3.Size = new Size(304, 45);
            label3.TabIndex = 5;
            label3.Text = "Code Snippet Tool";
            // 
            // LinkLabel_LinkedIn
            // 
            LinkLabel_LinkedIn.AutoSize = true;
            LinkLabel_LinkedIn.Location = new Point(296, 246);
            LinkLabel_LinkedIn.Name = "LinkLabel_LinkedIn";
            LinkLabel_LinkedIn.Size = new Size(52, 15);
            LinkLabel_LinkedIn.TabIndex = 6;
            LinkLabel_LinkedIn.TabStop = true;
            LinkLabel_LinkedIn.Text = "LinkedIn";
            LinkLabel_LinkedIn.LinkClicked += linkLabel_LinkedIn_LinkClicked;
            // 
            // LoginButton
            // 
            LoginButton.Location = new Point(170, 173);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(125, 35);
            LoginButton.TabIndex = 7;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // linkLabel_GitHub
            // 
            linkLabel_GitHub.AutoSize = true;
            linkLabel_GitHub.Location = new Point(357, 246);
            linkLabel_GitHub.Name = "linkLabel_GitHub";
            linkLabel_GitHub.Size = new Size(45, 15);
            linkLabel_GitHub.TabIndex = 8;
            linkLabel_GitHub.TabStop = true;
            linkLabel_GitHub.Text = "GitHub";
            linkLabel_GitHub.LinkClicked += linkLabel_GitHub_LinkClicked;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(296, 222);
            label4.Name = "label4";
            label4.Size = new Size(106, 15);
            label4.TabIndex = 9;
            label4.Text = "Alexandria Roberts";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(425, 270);
            Controls.Add(label4);
            Controls.Add(linkLabel_GitHub);
            Controls.Add(LoginButton);
            Controls.Add(LinkLabel_LinkedIn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Name = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsername;
        private MaskedTextBox txtPassword;
        private Label label1;
        private Label label2;
        private Label label3;
        private LinkLabel LinkLabel_LinkedIn;
        private Button LoginButton;
        private LinkLabel linkLabel_GitHub;
        private Label label4;
    }
}
