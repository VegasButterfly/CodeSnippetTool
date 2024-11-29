namespace CodeSnippetTool
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewUsers;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridViewSnippets;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label label7;

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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            DeleteSnippet = new Button();
            LoadSnippet = new Button();
            button1 = new Button();
            dataGridViewSnippets = new DataGridView();
            label1 = new Label();
            tabPage2 = new TabPage();
            label3 = new Label();
            dataGridViewUsers = new DataGridView();
            tabPage3 = new TabPage();
            textBox3 = new TextBox();
            label6 = new Label();
            textBox2 = new TextBox();
            maskedTextBox1 = new MaskedTextBox();
            label5 = new Label();
            label4 = new Label();
            dataGridView3 = new DataGridView();
            label2 = new Label();
            textBox1 = new TextBox();
            label7 = new Label();
            ExitButton = new Button();
            RefreshButton = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSnippets).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(12, 64);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1322, 505);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(RefreshButton);
            tabPage1.Controls.Add(DeleteSnippet);
            tabPage1.Controls.Add(LoadSnippet);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(dataGridViewSnippets);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1314, 477);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Snippets";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // DeleteSnippet
            // 
            DeleteSnippet.Location = new Point(1043, 209);
            DeleteSnippet.Name = "DeleteSnippet";
            DeleteSnippet.Size = new Size(213, 67);
            DeleteSnippet.TabIndex = 6;
            DeleteSnippet.Text = "Delete Selected Snippet";
            DeleteSnippet.UseVisualStyleBackColor = true;
            DeleteSnippet.Click += DeleteSnippet_Click;
            // 
            // LoadSnippet
            // 
            LoadSnippet.Location = new Point(1043, 108);
            LoadSnippet.Name = "LoadSnippet";
            LoadSnippet.Size = new Size(213, 67);
            LoadSnippet.TabIndex = 5;
            LoadSnippet.Text = "Load Selected Snippet";
            LoadSnippet.UseVisualStyleBackColor = true;
            LoadSnippet.Click += LoadSnippet_Click;
            // 
            // button1
            // 
            button1.Location = new Point(1043, 14);
            button1.Name = "button1";
            button1.Size = new Size(213, 62);
            button1.TabIndex = 4;
            button1.Text = "Add Snippet";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridViewSnippets
            // 
            dataGridViewSnippets.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSnippets.Location = new Point(8, 50);
            dataGridViewSnippets.Name = "dataGridViewSnippets";
            dataGridViewSnippets.Size = new Size(971, 333);
            dataGridViewSnippets.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 14);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 2;
            label1.Text = "Snippet List";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(dataGridViewUsers);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1314, 477);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Users";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 14);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 1;
            label3.Text = "Users";
            // 
            // dataGridViewUsers
            // 
            dataGridViewUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUsers.Location = new Point(6, 32);
            dataGridViewUsers.Name = "dataGridViewUsers";
            dataGridViewUsers.Size = new Size(493, 193);
            dataGridViewUsers.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(textBox3);
            tabPage3.Controls.Add(label6);
            tabPage3.Controls.Add(textBox2);
            tabPage3.Controls.Add(maskedTextBox1);
            tabPage3.Controls.Add(label5);
            tabPage3.Controls.Add(label4);
            tabPage3.Controls.Add(dataGridView3);
            tabPage3.Controls.Add(label2);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1314, 477);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Settings";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(138, 67);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(162, 23);
            textBox3.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 70);
            label6.Name = "label6";
            label6.Size = new Size(50, 15);
            label6.TabIndex = 5;
            label6.Text = "API Key:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(138, 38);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(162, 23);
            textBox2.TabIndex = 4;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(138, 96);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(162, 23);
            maskedTextBox1.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 41);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 2;
            label5.Text = "API URL:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 99);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 1;
            label4.Text = "Endpoint:";
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(6, 125);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.Size = new Size(1289, 345);
            dataGridView3.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 14);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 0;
            label2.Text = "Settings";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(0, 0);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            // 
            // label7
            // 
            label7.Location = new Point(0, 0);
            label7.Name = "label7";
            label7.Size = new Size(100, 23);
            label7.TabIndex = 0;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(1205, 25);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(124, 35);
            ExitButton.TabIndex = 1;
            ExitButton.Text = "EXIT";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // RefreshButton
            // 
            RefreshButton.Location = new Point(1042, 303);
            RefreshButton.Name = "RefreshButton";
            RefreshButton.Size = new Size(214, 64);
            RefreshButton.TabIndex = 7;
            RefreshButton.Text = "Refresh";
            RefreshButton.UseVisualStyleBackColor = true;
            RefreshButton.Click += RefreshButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1346, 575);
            Controls.Add(ExitButton);
            Controls.Add(tabControl1);
            Name = "MainForm";
            Text = "Code Snippet Tool";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSnippets).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button ExitButton;
        private Button LoadSnippet;
        private Button DeleteSnippet;
        private Button RefreshButton;
    }
}
