namespace discord_archiver_viewer
{
    partial class sqlForm
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
            this.queryLabel = new System.Windows.Forms.Label();
            this.queryBox = new System.Windows.Forms.TextBox();
            this.executeButton = new System.Windows.Forms.Button();
            this.resultBox = new System.Windows.Forms.RichTextBox();
            this.errorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // queryLabel
            // 
            this.queryLabel.AutoSize = true;
            this.queryLabel.Location = new System.Drawing.Point(12, 9);
            this.queryLabel.Name = "queryLabel";
            this.queryLabel.Size = new System.Drawing.Size(38, 13);
            this.queryLabel.TabIndex = 0;
            this.queryLabel.Text = "Query:";
            // 
            // queryBox
            // 
            this.queryBox.Location = new System.Drawing.Point(56, 6);
            this.queryBox.Name = "queryBox";
            this.queryBox.Size = new System.Drawing.Size(247, 20);
            this.queryBox.TabIndex = 1;
            // 
            // executeButton
            // 
            this.executeButton.Location = new System.Drawing.Point(309, 6);
            this.executeButton.Name = "executeButton";
            this.executeButton.Size = new System.Drawing.Size(64, 20);
            this.executeButton.TabIndex = 2;
            this.executeButton.Text = "Execute";
            this.executeButton.UseVisualStyleBackColor = true;
            this.executeButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // resultBox
            // 
            this.resultBox.Location = new System.Drawing.Point(12, 32);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(361, 185);
            this.resultBox.TabIndex = 3;
            this.resultBox.Text = "";
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(12, 220);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 13);
            this.errorLabel.TabIndex = 4;
            // 
            // sqlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 242);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.executeButton);
            this.Controls.Add(this.queryBox);
            this.Controls.Add(this.queryLabel);
            this.Name = "sqlForm";
            this.ShowIcon = false;
            this.Text = "SQL Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.sqlForm_FormClosing);
            this.Load += new System.EventHandler(this.sqlForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label queryLabel;
        private System.Windows.Forms.TextBox queryBox;
        private System.Windows.Forms.Button executeButton;
        private System.Windows.Forms.RichTextBox resultBox;
        private System.Windows.Forms.Label errorLabel;
    }
}