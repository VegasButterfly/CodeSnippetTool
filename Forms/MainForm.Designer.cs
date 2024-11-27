namespace CodeSnippetTool
{
    partial class MainForm
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            textBox1 = new TextBox();
            tabPage3 = new TabPage();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            dataGridView3 = new DataGridView();
            label4 = new Label();
            label5 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            textBox2 = new TextBox();
            label6 = new Label();
            textBox3 = new TextBox();
            label7 = new Label();
            button1 = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
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
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1314, 477);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Snippets";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(dataGridView2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1314, 477);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Users";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(1170, 23);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Search";
            textBox1.Size = new Size(157, 23);
            textBox1.TabIndex = 1;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 14);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 2;
            label1.Text = "Snippet List";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(8, 50);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1289, 446);
            dataGridView1.TabIndex = 3;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(13, 39);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(1295, 457);
            dataGridView2.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 31);
            label2.Name = "label2";
            label2.Size = new Size(123, 15);
            label2.TabIndex = 0;
            label2.Text = "Database Connection:";
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
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(18, 115);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.Size = new Size(240, 150);
            dataGridView3.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 91);
            label4.Name = "label4";
            label4.Size = new Size(80, 15);
            label4.TabIndex = 2;
            label4.Text = "Language List";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 290);
            label5.Name = "label5";
            label5.Size = new Size(96, 15);
            label5.TabIndex = 3;
            label5.Text = "Open AI API Key:";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(18, 308);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(240, 23);
            maskedTextBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(22, 53);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(236, 23);
            textBox2.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 347);
            label6.Name = "label6";
            label6.Size = new Size(78, 15);
            label6.TabIndex = 6;
            label6.Text = "Admin Email:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(18, 372);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(240, 23);
            textBox3.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Malgun Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(12, 1);
            label7.Name = "label7";
            label7.Size = new Size(304, 45);
            label7.TabIndex = 6;
            label7.Text = "Code Snippet Tool";
            // 
            // button1
            // 
            button1.Location = new Point(1170, 15);
            button1.Name = "button1";
            button1.Size = new Size(127, 23);
            button1.TabIndex = 4;
            button1.Text = "Add Snippet";
            button1.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1346, 581);
            Controls.Add(label7);
            Controls.Add(textBox1);
            Controls.Add(tabControl1);
            Name = "MainForm";
            Text = "MainForm";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TextBox textBox1;
        private TabPage tabPage3;
        private DataGridView dataGridView1;
        private Label label1;
        private Label label3;
        private DataGridView dataGridView2;
        private TextBox textBox3;
        private Label label6;
        private TextBox textBox2;
        private MaskedTextBox maskedTextBox1;
        private Label label5;
        private Label label4;
        private DataGridView dataGridView3;
        private Label label2;
        private Button button1;
        private Label label7;
    }
}