namespace BonusCalculatorApp
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
            this.salaryTextBox = new System.Windows.Forms.TextBox();
            this.bonusTextBox = new System.Windows.Forms.TextBox();
            this.salaryLebel = new System.Windows.Forms.Label();
            this.bonusLebel = new System.Windows.Forms.Label();
            this.caluculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // salaryTextBox
            // 
            this.salaryTextBox.Location = new System.Drawing.Point(267, 40);
            this.salaryTextBox.Name = "salaryTextBox";
            this.salaryTextBox.Size = new System.Drawing.Size(186, 20);
            this.salaryTextBox.TabIndex = 0;
            // 
            // bonusTextBox
            // 
            this.bonusTextBox.Location = new System.Drawing.Point(267, 77);
            this.bonusTextBox.Name = "bonusTextBox";
            this.bonusTextBox.Size = new System.Drawing.Size(186, 20);
            this.bonusTextBox.TabIndex = 1;
            // 
            // salaryLebel
            // 
            this.salaryLebel.AutoSize = true;
            this.salaryLebel.Location = new System.Drawing.Point(185, 43);
            this.salaryLebel.Name = "salaryLebel";
            this.salaryLebel.Size = new System.Drawing.Size(36, 13);
            this.salaryLebel.TabIndex = 2;
            this.salaryLebel.Text = "Salary";
            // 
            // bonusLebel
            // 
            this.bonusLebel.AutoSize = true;
            this.bonusLebel.Location = new System.Drawing.Point(185, 80);
            this.bonusLebel.Name = "bonusLebel";
            this.bonusLebel.Size = new System.Drawing.Size(37, 13);
            this.bonusLebel.TabIndex = 3;
            this.bonusLebel.Text = "Bonus";
            // 
            // caluculateButton
            // 
            this.caluculateButton.Location = new System.Drawing.Point(188, 124);
            this.caluculateButton.Name = "caluculateButton";
            this.caluculateButton.Size = new System.Drawing.Size(75, 23);
            this.caluculateButton.TabIndex = 4;
            this.caluculateButton.Text = "Calculate";
            this.caluculateButton.UseVisualStyleBackColor = true;
            this.caluculateButton.Click += new System.EventHandler(this.caluculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(291, 123);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 5;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(394, 124);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 6;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 336);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.caluculateButton);
            this.Controls.Add(this.bonusLebel);
            this.Controls.Add(this.salaryLebel);
            this.Controls.Add(this.bonusTextBox);
            this.Controls.Add(this.salaryTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox salaryTextBox;
        private System.Windows.Forms.TextBox bonusTextBox;
        private System.Windows.Forms.Label salaryLebel;
        private System.Windows.Forms.Label bonusLebel;
        private System.Windows.Forms.Button caluculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button ExitButton;
    }
}

