namespace sort.thread.homework
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
            this.inputOfSizeTextBox = new System.Windows.Forms.TextBox();
            this.startButton = new System.Windows.Forms.Button();
            this.bubbleSortOutputTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // inputOfSizeTextBox
            // 
            this.inputOfSizeTextBox.Location = new System.Drawing.Point(23, 40);
            this.inputOfSizeTextBox.Name = "inputOfSizeTextBox";
            this.inputOfSizeTextBox.Size = new System.Drawing.Size(151, 20);
            this.inputOfSizeTextBox.TabIndex = 0;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(23, 115);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(123, 30);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start sorting";
            this.startButton.UseVisualStyleBackColor = true;
            // 
            // bubbleSortOutputTextBox
            // 
            this.bubbleSortOutputTextBox.Location = new System.Drawing.Point(201, 40);
            this.bubbleSortOutputTextBox.Name = "bubbleSortOutputTextBox";
            this.bubbleSortOutputTextBox.Size = new System.Drawing.Size(135, 288);
            this.bubbleSortOutputTextBox.TabIndex = 2;
            this.bubbleSortOutputTextBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bubbleSortOutputTextBox);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.inputOfSizeTextBox);
            this.Name = "Form1";
            this.Text = "Sorting & Procecces";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.RichTextBox bubbleSortOutputTextBox;

        private System.Windows.Forms.Button startButton;

        private System.Windows.Forms.TextBox inputOfSizeTextBox;

        #endregion
    }
}