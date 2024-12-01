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
        private System.Windows.Forms.Button AddSnippet;
        private System.Windows.Forms.DataGridView dataGridViewSnippets;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtAPIKey;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridViewLanguages;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            RefreshButton = new Button();
            DeleteSnippet = new Button();
            LoadSnippet = new Button();
            AddSnippet = new Button();
            dataGridViewSnippets = new DataGridView();
            label1 = new Label();
            tabPage2 = new TabPage();
            RefreshUserList = new Button();
            DeleteUser = new Button();
            LoadUser = new Button();
            AddUser = new Button();
            label3 = new Label();
            dataGridViewUsers = new DataGridView();
            tabPage3 = new TabPage();
            EditLanguage = new Button();
            DeleteLanguage = new Button();
            AddLanguage = new Button();
            label9 = new Label();
            txtAPIKey = new TextBox();
            label6 = new Label();
            textBox2 = new TextBox();
            maskedTextBox1 = new MaskedTextBox();
            label5 = new Label();
            label4 = new Label();
            dataGridViewLanguages = new DataGridView();
            label2 = new Label();
            textBox1 = new TextBox();
            label7 = new Label();
            ExitButton = new Button();
            searchTextBox = new TextBox();
            searchButton = new Button();
            label8 = new Label();
            IconImage = new PictureBox();
            label10 = new Label();
            label11 = new Label();
            SaveApiKey = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSnippets).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLanguages).BeginInit();
            ((System.ComponentModel.ISupportInitialize)IconImage).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(21, 75);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1294, 425);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.WhiteSmoke;
            tabPage1.Controls.Add(RefreshButton);
            tabPage1.Controls.Add(DeleteSnippet);
            tabPage1.Controls.Add(LoadSnippet);
            tabPage1.Controls.Add(AddSnippet);
            tabPage1.Controls.Add(dataGridViewSnippets);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1286, 397);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Snippets";
            // 
            // RefreshButton
            // 
            RefreshButton.Location = new Point(1042, 303);
            RefreshButton.Name = "RefreshButton";
            RefreshButton.Size = new Size(214, 64);
            RefreshButton.TabIndex = 7;
            RefreshButton.Text = "Refresh / List All";
            RefreshButton.UseVisualStyleBackColor = true;
            RefreshButton.Click += RefreshButton_Click;
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
            // AddSnippet
            // 
            AddSnippet.Location = new Point(1043, 14);
            AddSnippet.Name = "AddSnippet";
            AddSnippet.Size = new Size(213, 62);
            AddSnippet.TabIndex = 4;
            AddSnippet.Text = "Add Snippet";
            AddSnippet.UseVisualStyleBackColor = true;
            AddSnippet.Click += AddSnippet_Click;
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
            tabPage2.Controls.Add(RefreshUserList);
            tabPage2.Controls.Add(DeleteUser);
            tabPage2.Controls.Add(LoadUser);
            tabPage2.Controls.Add(AddUser);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(dataGridViewUsers);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1286, 397);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Users";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // RefreshUserList
            // 
            RefreshUserList.Location = new Point(1042, 303);
            RefreshUserList.Name = "RefreshUserList";
            RefreshUserList.Size = new Size(214, 64);
            RefreshUserList.TabIndex = 11;
            RefreshUserList.Text = "Refresh / List All";
            RefreshUserList.UseVisualStyleBackColor = true;
            RefreshUserList.Click += RefreshUserList_Click;
            // 
            // DeleteUser
            // 
            DeleteUser.Location = new Point(1043, 209);
            DeleteUser.Name = "DeleteUser";
            DeleteUser.Size = new Size(213, 67);
            DeleteUser.TabIndex = 10;
            DeleteUser.Text = "Delete Selected User";
            DeleteUser.UseVisualStyleBackColor = true;
            DeleteUser.Click += DeleteUser_Click;
            // 
            // LoadUser
            // 
            LoadUser.Location = new Point(1043, 108);
            LoadUser.Name = "LoadUser";
            LoadUser.Size = new Size(213, 67);
            LoadUser.TabIndex = 9;
            LoadUser.Text = "Load Selected User";
            LoadUser.UseVisualStyleBackColor = true;
            LoadUser.Click += LoadUser_Click;
            // 
            // AddUser
            // 
            AddUser.Location = new Point(1043, 14);
            AddUser.Name = "AddUser";
            AddUser.Size = new Size(213, 62);
            AddUser.TabIndex = 8;
            AddUser.Text = "Add User";
            AddUser.UseVisualStyleBackColor = true;
            AddUser.Click += AddUser_Click;
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
            dataGridViewUsers.Location = new Point(8, 50);
            dataGridViewUsers.Name = "dataGridViewUsers";
            dataGridViewUsers.Size = new Size(971, 333);
            dataGridViewUsers.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(SaveApiKey);
            tabPage3.Controls.Add(label11);
            tabPage3.Controls.Add(label10);
            tabPage3.Controls.Add(EditLanguage);
            tabPage3.Controls.Add(DeleteLanguage);
            tabPage3.Controls.Add(AddLanguage);
            tabPage3.Controls.Add(label9);
            tabPage3.Controls.Add(txtAPIKey);
            tabPage3.Controls.Add(label6);
            tabPage3.Controls.Add(textBox2);
            tabPage3.Controls.Add(maskedTextBox1);
            tabPage3.Controls.Add(label5);
            tabPage3.Controls.Add(label4);
            tabPage3.Controls.Add(dataGridViewLanguages);
            tabPage3.Controls.Add(label2);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1286, 397);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Settings";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // EditLanguage
            // 
            EditLanguage.Enabled = false;
            EditLanguage.Location = new Point(235, 165);
            EditLanguage.Name = "EditLanguage";
            EditLanguage.Size = new Size(167, 23);
            EditLanguage.TabIndex = 10;
            EditLanguage.Text = "Edit Language";
            EditLanguage.UseVisualStyleBackColor = true;
            // 
            // DeleteLanguage
            // 
            DeleteLanguage.Enabled = false;
            DeleteLanguage.Location = new Point(235, 194);
            DeleteLanguage.Name = "DeleteLanguage";
            DeleteLanguage.Size = new Size(167, 23);
            DeleteLanguage.TabIndex = 9;
            DeleteLanguage.Text = "Delete Language";
            DeleteLanguage.UseVisualStyleBackColor = true;
            // 
            // AddLanguage
            // 
            AddLanguage.Enabled = false;
            AddLanguage.Location = new Point(235, 136);
            AddLanguage.Name = "AddLanguage";
            AddLanguage.Size = new Size(167, 23);
            AddLanguage.TabIndex = 8;
            AddLanguage.Text = "Add Language";
            AddLanguage.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F);
            label9.ForeColor = Color.Firebrick;
            label9.Location = new Point(138, 41);
            label9.Name = "label9";
            label9.Size = new Size(167, 15);
            label9.TabIndex = 7;
            label9.Text = "Disabled. Future Functionality.";
            // 
            // txtAPIKey
            // 
            txtAPIKey.Location = new Point(138, 67);
            txtAPIKey.Name = "txtAPIKey";
            txtAPIKey.Size = new Size(162, 23);
            txtAPIKey.TabIndex = 6;
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
            label5.Size = new Size(65, 15);
            label5.TabIndex = 2;
            label5.Text = "API Model:";
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
            // dataGridViewLanguages
            // 
            dataGridViewLanguages.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLanguages.Location = new Point(6, 125);
            dataGridViewLanguages.Name = "dataGridViewLanguages";
            dataGridViewLanguages.Size = new Size(215, 144);
            dataGridViewLanguages.TabIndex = 0;
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
            ExitButton.Location = new Point(1191, 25);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(124, 35);
            ExitButton.TabIndex = 1;
            ExitButton.Text = "&Exit Program";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(894, 32);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.PlaceholderText = "Search Criteria";
            searchTextBox.Size = new Size(194, 23);
            searchTextBox.TabIndex = 2;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(1094, 31);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(75, 23);
            searchButton.TabIndex = 3;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += SearchButton_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Malgun Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(82, 9);
            label8.Name = "label8";
            label8.Size = new Size(304, 45);
            label8.TabIndex = 6;
            label8.Text = "Code Snippet Tool";
            // 
            // IconImage
            // 
            IconImage.Image = (Image)resources.GetObject("IconImage.Image");
            IconImage.InitialImage = (Image)resources.GetObject("IconImage.InitialImage");
            IconImage.Location = new Point(21, 13);
            IconImage.Name = "IconImage";
            IconImage.Size = new Size(55, 42);
            IconImage.SizeMode = PictureBoxSizeMode.Zoom;
            IconImage.TabIndex = 7;
            IconImage.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F);
            label10.ForeColor = Color.Firebrick;
            label10.Location = new Point(138, 99);
            label10.Name = "label10";
            label10.Size = new Size(167, 15);
            label10.TabIndex = 11;
            label10.Text = "Disabled. Future Functionality.";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F);
            label11.ForeColor = Color.Firebrick;
            label11.Location = new Point(28, 173);
            label11.Name = "label11";
            label11.Size = new Size(167, 15);
            label11.TabIndex = 12;
            label11.Text = "Disabled. Future Functionality.";
            // 
            // SaveApiKey
            // 
            SaveApiKey.Location = new Point(306, 66);
            SaveApiKey.Name = "SaveApiKey";
            SaveApiKey.Size = new Size(98, 23);
            SaveApiKey.TabIndex = 13;
            SaveApiKey.Text = "Save";
            SaveApiKey.UseVisualStyleBackColor = true;
            SaveApiKey.Click += SaveApiKey_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(1329, 512);
            Controls.Add(IconImage);
            Controls.Add(label8);
            Controls.Add(searchButton);
            Controls.Add(searchTextBox);
            Controls.Add(ExitButton);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
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
            ((System.ComponentModel.ISupportInitialize)dataGridViewLanguages).EndInit();
            ((System.ComponentModel.ISupportInitialize)IconImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ExitButton;
        private Button LoadSnippet;
        private Button DeleteSnippet;
        private Button RefreshButton;
        private TextBox searchTextBox;
        private Button searchButton;
        private Label label8;
        private Label label9;
        private PictureBox IconImage;
        private Button RefreshUserList;
        private Button DeleteUser;
        private Button LoadUser;
        private Button AddUser;
        private Button AddLanguage;
        private Button EditLanguage;
        private Button DeleteLanguage;
        private Button SaveApiKey;
        private Label label11;
        private Label label10;
    }
}
