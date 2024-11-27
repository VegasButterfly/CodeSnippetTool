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
            textBox1 = new TextBox();
            maskedTextBox1 = new MaskedTextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            label3 = new Label();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(155, 86);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(159, 23);
            textBox1.TabIndex = 0;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(155, 126);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(159, 23);
            maskedTextBox1.TabIndex = 1;
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
            // button1
            // 
            button1.Location = new Point(140, 179);
            button1.Name = "button1";
            button1.Size = new Size(164, 23);
            button1.TabIndex = 4;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
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
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(286, 230);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(106, 15);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Alexandria Roberts";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(425, 270);
            Controls.Add(linkLabel1);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(maskedTextBox1);
            Controls.Add(textBox1);
            Name = "LoginForm";
            Text = "";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private MaskedTextBox maskedTextBox1;
        private Label label1;
        private Label label2;
        private Button button1;
        private Label label3;
        private LinkLabel linkLabel1;
    }
}
