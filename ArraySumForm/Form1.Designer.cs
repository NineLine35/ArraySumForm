namespace ArraySumForm
{
    partial class Form1
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
            this.numberListBox = new System.Windows.Forms.ListBox();
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.enterNumLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.processButton = new System.Windows.Forms.Button();
            this.outputListBox = new System.Windows.Forms.ListBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // numberListBox
            // 
            this.numberListBox.FormattingEnabled = true;
            this.numberListBox.Location = new System.Drawing.Point(153, 12);
            this.numberListBox.Name = "numberListBox";
            this.numberListBox.Size = new System.Drawing.Size(55, 147);
            this.numberListBox.TabIndex = 0;
            // 
            // numberTextBox
            // 
            this.numberTextBox.Location = new System.Drawing.Point(20, 37);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(100, 20);
            this.numberTextBox.TabIndex = 1;
            // 
            // enterNumLabel
            // 
            this.enterNumLabel.AutoSize = true;
            this.enterNumLabel.Location = new System.Drawing.Point(17, 12);
            this.enterNumLabel.Name = "enterNumLabel";
            this.enterNumLabel.Size = new System.Drawing.Size(107, 13);
            this.enterNumLabel.TabIndex = 2;
            this.enterNumLabel.Text = "Enter your number(s):";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(32, 63);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // processButton
            // 
            this.processButton.Location = new System.Drawing.Point(32, 104);
            this.processButton.Name = "processButton";
            this.processButton.Size = new System.Drawing.Size(75, 23);
            this.processButton.TabIndex = 4;
            this.processButton.Text = "Process";
            this.processButton.UseVisualStyleBackColor = true;
            this.processButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // outputListBox
            // 
            this.outputListBox.FormattingEnabled = true;
            this.outputListBox.Location = new System.Drawing.Point(225, 12);
            this.outputListBox.Name = "outputListBox";
            this.outputListBox.Size = new System.Drawing.Size(55, 147);
            this.outputListBox.TabIndex = 5;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(32, 145);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 6;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 199);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.outputListBox);
            this.Controls.Add(this.processButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.enterNumLabel);
            this.Controls.Add(this.numberTextBox);
            this.Controls.Add(this.numberListBox);
            this.Name = "Form1";
            this.Text = "Array Sum";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox numberListBox;
        private System.Windows.Forms.TextBox numberTextBox;
        private System.Windows.Forms.Label enterNumLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button processButton;
        private System.Windows.Forms.ListBox outputListBox;
        private System.Windows.Forms.Button clearButton;
    }
}

