namespace CodeSnippetTool
{
    partial class SnippetForm
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
            tabControl2 = new TabControl();
            tabPage4 = new TabPage();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            richTextBox3 = new RichTextBox();
            comboBox1 = new ComboBox();
            tabPage5 = new TabPage();
            richTextBox2 = new RichTextBox();
            button1 = new Button();
            panel1 = new Panel();
            richTextBox4 = new RichTextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            richTextBox1 = new RichTextBox();
            label4 = new Label();
            button6 = new Button();
            tabControl2.SuspendLayout();
            tabPage4.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl2
            // 
            tabControl2.Controls.Add(tabPage4);
            tabControl2.Controls.Add(tabPage5);
            tabControl2.Location = new Point(792, 59);
            tabControl2.Name = "tabControl2";
            tabControl2.SelectedIndex = 0;
            tabControl2.Size = new Size(527, 482);
            tabControl2.TabIndex = 15;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(button5);
            tabPage4.Controls.Add(button4);
            tabPage4.Controls.Add(button3);
            tabPage4.Controls.Add(button2);
            tabPage4.Controls.Add(richTextBox3);
            tabPage4.Controls.Add(comboBox1);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(519, 454);
            tabPage4.TabIndex = 0;
            tabPage4.Text = "Translation";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(476, 419);
            button5.Name = "button5";
            button5.Size = new Size(26, 23);
            button5.TabIndex = 5;
            button5.Text = "Delete";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(396, 420);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 4;
            button4.Text = "Save";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(17, 421);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 3;
            button3.Text = "Review";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(427, 11);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 2;
            button2.Text = "AI Translate";
            button2.UseVisualStyleBackColor = true;
            // 
            // richTextBox3
            // 
            richTextBox3.Location = new Point(12, 43);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.Size = new Size(490, 371);
            richTextBox3.TabIndex = 1;
            richTextBox3.Text = "";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 12);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 0;
            comboBox1.Text = "Language";
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
            // richTextBox2
            // 
            richTextBox2.Location = new Point(407, 422);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(352, 110);
            richTextBox2.TabIndex = 13;
            richTextBox2.Text = "";
            // 
            // button1
            // 
            button1.Location = new Point(405, 393);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 14;
            button1.Text = "AI Analyze";
            button1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(richTextBox4);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(29, 51);
            panel1.Name = "panel1";
            panel1.Size = new Size(357, 493);
            panel1.TabIndex = 10;
            // 
            // richTextBox4
            // 
            richTextBox4.Location = new Point(17, 103);
            richTextBox4.Name = "richTextBox4";
            richTextBox4.Size = new Size(313, 198);
            richTextBox4.TabIndex = 6;
            richTextBox4.Text = "";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(16, 43);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(314, 23);
            textBox2.TabIndex = 5;
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
            // richTextBox1
            // 
            richTextBox1.Location = new Point(405, 80);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(354, 298);
            richTextBox1.TabIndex = 11;
            richTextBox1.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 20);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 16;
            label4.Text = "Snippet";
            // 
            // button6
            // 
            button6.Location = new Point(1173, 550);
            button6.Name = "button6";
            button6.Size = new Size(142, 33);
            button6.TabIndex = 17;
            button6.Text = "SAVE";
            button6.UseVisualStyleBackColor = true;
            // 
            // Snippet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1349, 595);
            Controls.Add(button6);
            Controls.Add(label4);
            Controls.Add(tabControl2);
            Controls.Add(richTextBox2);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(richTextBox1);
            Name = "Snippet";
            Text = "Snippet";
            tabControl2.ResumeLayout(false);
            tabPage4.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl2;
        private TabPage tabPage4;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private RichTextBox richTextBox3;
        private ComboBox comboBox1;
        private TabPage tabPage5;
        private RichTextBox richTextBox2;
        private Button button1;
        private Panel panel1;
        private RichTextBox richTextBox4;
        private TextBox textBox2;
        private Label label3;
        private Label label2;
        private Label label1;
        private RichTextBox richTextBox1;
        private Label label4;
        private Button button6;
    }
}