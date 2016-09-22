namespace KnockKnock
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
            this.submitButton = new System.Windows.Forms.Button();
            this.labelText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // submitButton
            // 
            this.submitButton.AutoSize = true;
            this.submitButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.Location = new System.Drawing.Point(94, 118);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(94, 27);
            this.submitButton.TabIndex = 0;
            this.submitButton.Text = "Who\'s there?";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // labelText
            // 
            this.labelText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelText.Location = new System.Drawing.Point(-2, 70);
            this.labelText.Margin = new System.Windows.Forms.Padding(0);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(286, 21);
            this.labelText.TabIndex = 1;
            this.labelText.Text = "Knock, Knock!";
            this.labelText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 211);
            this.Controls.Add(this.labelText);
            this.Controls.Add(this.submitButton);
            this.Name = "Form1";
            this.Text = "Knock Knock";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label labelText;
    }
}

