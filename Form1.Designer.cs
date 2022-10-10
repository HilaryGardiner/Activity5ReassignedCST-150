namespace Activity5App
{
    partial class Form1
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
            this.selectFileLabel1 = new System.Windows.Forms.Label();
            this.lowerCaseLabel2 = new System.Windows.Forms.Label();
            this.firstWordLabel3 = new System.Windows.Forms.Label();
            this.lastWordLabel4 = new System.Windows.Forms.Label();
            this.longestWordLabel5 = new System.Windows.Forms.Label();
            this.mostVowelLabel6 = new System.Windows.Forms.Label();
            this.clickHereToSelectButton1 = new System.Windows.Forms.Button();
            this.displayFileTextBox1 = new System.Windows.Forms.TextBox();
            this.firstWordTextBox2 = new System.Windows.Forms.TextBox();
            this.lastWordTextBox3 = new System.Windows.Forms.TextBox();
            this.longestWordTextBox4 = new System.Windows.Forms.TextBox();
            this.mostVowelTextBox5 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // selectFileLabel1
            // 
            this.selectFileLabel1.AutoSize = true;
            this.selectFileLabel1.Location = new System.Drawing.Point(21, 21);
            this.selectFileLabel1.Name = "selectFileLabel1";
            this.selectFileLabel1.Size = new System.Drawing.Size(62, 15);
            this.selectFileLabel1.TabIndex = 0;
            this.selectFileLabel1.Text = "Select File:";
            // 
            // lowerCaseLabel2
            // 
            this.lowerCaseLabel2.AutoSize = true;
            this.lowerCaseLabel2.Location = new System.Drawing.Point(35, 101);
            this.lowerCaseLabel2.Name = "lowerCaseLabel2";
            this.lowerCaseLabel2.Size = new System.Drawing.Size(70, 15);
            this.lowerCaseLabel2.TabIndex = 1;
            this.lowerCaseLabel2.Text = "Lower Case:";
            // 
            // firstWordLabel3
            // 
            this.firstWordLabel3.AutoSize = true;
            this.firstWordLabel3.Location = new System.Drawing.Point(21, 247);
            this.firstWordLabel3.Name = "firstWordLabel3";
            this.firstWordLabel3.Size = new System.Drawing.Size(64, 15);
            this.firstWordLabel3.TabIndex = 2;
            this.firstWordLabel3.Text = "First Word:";
            // 
            // lastWordLabel4
            // 
            this.lastWordLabel4.AutoSize = true;
            this.lastWordLabel4.Location = new System.Drawing.Point(21, 294);
            this.lastWordLabel4.Name = "lastWordLabel4";
            this.lastWordLabel4.Size = new System.Drawing.Size(63, 15);
            this.lastWordLabel4.TabIndex = 3;
            this.lastWordLabel4.Text = "Last Word:";
            // 
            // longestWordLabel5
            // 
            this.longestWordLabel5.AutoSize = true;
            this.longestWordLabel5.Location = new System.Drawing.Point(21, 342);
            this.longestWordLabel5.Name = "longestWordLabel5";
            this.longestWordLabel5.Size = new System.Drawing.Size(84, 15);
            this.longestWordLabel5.TabIndex = 4;
            this.longestWordLabel5.Text = "Longest Word:";
            // 
            // mostVowelLabel6
            // 
            this.mostVowelLabel6.AutoSize = true;
            this.mostVowelLabel6.Location = new System.Drawing.Point(21, 378);
            this.mostVowelLabel6.Name = "mostVowelLabel6";
            this.mostVowelLabel6.Size = new System.Drawing.Size(71, 15);
            this.mostVowelLabel6.TabIndex = 5;
            this.mostVowelLabel6.Text = "Most Vowel:";
            // 
            // clickHereToSelectButton1
            // 
            this.clickHereToSelectButton1.BackColor = System.Drawing.Color.Orange;
            this.clickHereToSelectButton1.Location = new System.Drawing.Point(117, 21);
            this.clickHereToSelectButton1.Name = "clickHereToSelectButton1";
            this.clickHereToSelectButton1.Size = new System.Drawing.Size(251, 23);
            this.clickHereToSelectButton1.TabIndex = 6;
            this.clickHereToSelectButton1.Text = "Click here to select";
            this.clickHereToSelectButton1.UseVisualStyleBackColor = false;
            this.clickHereToSelectButton1.Click += new System.EventHandler(this.clickHereToSelectButton1_Click);
            // 
            // displayFileTextBox1
            // 
            this.displayFileTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.displayFileTextBox1.Location = new System.Drawing.Point(131, 101);
            this.displayFileTextBox1.Multiline = true;
            this.displayFileTextBox1.Name = "displayFileTextBox1";
            this.displayFileTextBox1.Size = new System.Drawing.Size(518, 100);
            this.displayFileTextBox1.TabIndex = 7;
            // 
            // firstWordTextBox2
            // 
            this.firstWordTextBox2.Location = new System.Drawing.Point(131, 239);
            this.firstWordTextBox2.Name = "firstWordTextBox2";
            this.firstWordTextBox2.Size = new System.Drawing.Size(518, 23);
            this.firstWordTextBox2.TabIndex = 8;
            // 
            // lastWordTextBox3
            // 
            this.lastWordTextBox3.Location = new System.Drawing.Point(131, 286);
            this.lastWordTextBox3.Name = "lastWordTextBox3";
            this.lastWordTextBox3.Size = new System.Drawing.Size(518, 23);
            this.lastWordTextBox3.TabIndex = 9;
            // 
            // longestWordTextBox4
            // 
            this.longestWordTextBox4.Location = new System.Drawing.Point(131, 334);
            this.longestWordTextBox4.Name = "longestWordTextBox4";
            this.longestWordTextBox4.Size = new System.Drawing.Size(518, 23);
            this.longestWordTextBox4.TabIndex = 10;
            // 
            // mostVowelTextBox5
            // 
            this.mostVowelTextBox5.Location = new System.Drawing.Point(131, 378);
            this.mostVowelTextBox5.Name = "mostVowelTextBox5";
            this.mostVowelTextBox5.Size = new System.Drawing.Size(518, 23);
            this.mostVowelTextBox5.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SpringGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mostVowelTextBox5);
            this.Controls.Add(this.longestWordTextBox4);
            this.Controls.Add(this.lastWordTextBox3);
            this.Controls.Add(this.firstWordTextBox2);
            this.Controls.Add(this.displayFileTextBox1);
            this.Controls.Add(this.clickHereToSelectButton1);
            this.Controls.Add(this.mostVowelLabel6);
            this.Controls.Add(this.longestWordLabel5);
            this.Controls.Add(this.lastWordLabel4);
            this.Controls.Add(this.firstWordLabel3);
            this.Controls.Add(this.lowerCaseLabel2);
            this.Controls.Add(this.selectFileLabel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label selectFileLabel1;
        private Label lowerCaseLabel2;
        private Label firstWordLabel3;
        private Label lastWordLabel4;
        private Label longestWordLabel5;
        private Label mostVowelLabel6;
        private Button clickHereToSelectButton1;
        private TextBox displayFileTextBox1;
        private TextBox firstWordTextBox2;
        private TextBox lastWordTextBox3;
        private TextBox longestWordTextBox4;
        private TextBox mostVowelTextBox5;
    }
}