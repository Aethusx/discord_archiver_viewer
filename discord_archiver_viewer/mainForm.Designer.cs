namespace discord_archiver_viewer
{
    partial class mainForm
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
            this.mainView = new System.Windows.Forms.ListView();
            this.UserIdd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Username = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Discriminator = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Content = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MessageId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Attachment_Filename = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Timestamp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sQLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usernameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.discriminatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.messageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.attachmentFilenameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userPanel = new System.Windows.Forms.Panel();
            this.timeStampLabel = new System.Windows.Forms.Label();
            this.attachmentLabel = new System.Windows.Forms.Label();
            this.avatarButton = new System.Windows.Forms.Button();
            this.attachmentButton = new System.Windows.Forms.Button();
            this.idLabel = new System.Windows.Forms.Label();
            this.discriminatorLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.avatarBox = new System.Windows.Forms.PictureBox();
            this.databaseOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.mainMenuStrip.SuspendLayout();
            this.userPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatarBox)).BeginInit();
            this.SuspendLayout();
            // 
            // mainView
            // 
            this.mainView.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.mainView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.UserIdd,
            this.Username,
            this.Discriminator,
            this.Content,
            this.MessageId,
            this.Attachment_Filename,
            this.Timestamp});
            this.mainView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainView.FullRowSelect = true;
            this.mainView.Location = new System.Drawing.Point(0, 24);
            this.mainView.MultiSelect = false;
            this.mainView.Name = "mainView";
            this.mainView.Size = new System.Drawing.Size(492, 368);
            this.mainView.TabIndex = 0;
            this.mainView.UseCompatibleStateImageBehavior = false;
            this.mainView.View = System.Windows.Forms.View.Details;
            this.mainView.SelectedIndexChanged += new System.EventHandler(this.mainView_SelectedIndexChanged);
            // 
            // UserIdd
            // 
            this.UserIdd.Text = "User Id";
            this.UserIdd.Width = 0;
            // 
            // Username
            // 
            this.Username.Text = "Username";
            // 
            // Discriminator
            // 
            this.Discriminator.Text = "Discriminator";
            this.Discriminator.Width = 53;
            // 
            // Content
            // 
            this.Content.Text = "Message";
            this.Content.Width = 221;
            // 
            // MessageId
            // 
            this.MessageId.Text = "Message Id";
            this.MessageId.Width = 0;
            // 
            // Attachment_Filename
            // 
            this.Attachment_Filename.Text = "Attachment Filename";
            // 
            // Timestamp
            // 
            this.Timestamp.Text = "Timestamp";
            this.Timestamp.Width = 0;
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.sQLToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(492, 24);
            this.mainMenuStrip.TabIndex = 1;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadDatabaseToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // loadDatabaseToolStripMenuItem
            // 
            this.loadDatabaseToolStripMenuItem.Name = "loadDatabaseToolStripMenuItem";
            this.loadDatabaseToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.loadDatabaseToolStripMenuItem.Text = "Load Database";
            this.loadDatabaseToolStripMenuItem.Click += new System.EventHandler(this.loadDatabaseToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // sQLToolStripMenuItem
            // 
            this.sQLToolStripMenuItem.Name = "sQLToolStripMenuItem";
            this.sQLToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sQLToolStripMenuItem.Text = "SQL";
            this.sQLToolStripMenuItem.Click += new System.EventHandler(this.sQLToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usernameToolStripMenuItem,
            this.discriminatorToolStripMenuItem,
            this.messageToolStripMenuItem,
            this.attachmentFilenameToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.viewToolStripMenuItem.Text = "Hide/View";
            // 
            // usernameToolStripMenuItem
            // 
            this.usernameToolStripMenuItem.Name = "usernameToolStripMenuItem";
            this.usernameToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.usernameToolStripMenuItem.Text = "Username";
            this.usernameToolStripMenuItem.Click += new System.EventHandler(this.usernameToolStripMenuItem_Click);
            // 
            // discriminatorToolStripMenuItem
            // 
            this.discriminatorToolStripMenuItem.Name = "discriminatorToolStripMenuItem";
            this.discriminatorToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.discriminatorToolStripMenuItem.Text = "Discriminator";
            this.discriminatorToolStripMenuItem.Click += new System.EventHandler(this.discriminatorToolStripMenuItem_Click);
            // 
            // messageToolStripMenuItem
            // 
            this.messageToolStripMenuItem.Name = "messageToolStripMenuItem";
            this.messageToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.messageToolStripMenuItem.Text = "Message";
            this.messageToolStripMenuItem.Click += new System.EventHandler(this.messageToolStripMenuItem_Click);
            // 
            // attachmentFilenameToolStripMenuItem
            // 
            this.attachmentFilenameToolStripMenuItem.Name = "attachmentFilenameToolStripMenuItem";
            this.attachmentFilenameToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.attachmentFilenameToolStripMenuItem.Text = "Attachment Filename";
            this.attachmentFilenameToolStripMenuItem.Click += new System.EventHandler(this.attachmentFilenameToolStripMenuItem_Click);
            // 
            // userPanel
            // 
            this.userPanel.Controls.Add(this.timeStampLabel);
            this.userPanel.Controls.Add(this.attachmentLabel);
            this.userPanel.Controls.Add(this.avatarButton);
            this.userPanel.Controls.Add(this.attachmentButton);
            this.userPanel.Controls.Add(this.idLabel);
            this.userPanel.Controls.Add(this.discriminatorLabel);
            this.userPanel.Controls.Add(this.usernameLabel);
            this.userPanel.Controls.Add(this.avatarBox);
            this.userPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.userPanel.Location = new System.Drawing.Point(0, 302);
            this.userPanel.Name = "userPanel";
            this.userPanel.Size = new System.Drawing.Size(492, 90);
            this.userPanel.TabIndex = 2;
            // 
            // timeStampLabel
            // 
            this.timeStampLabel.AutoSize = true;
            this.timeStampLabel.Location = new System.Drawing.Point(82, 65);
            this.timeStampLabel.Name = "timeStampLabel";
            this.timeStampLabel.Size = new System.Drawing.Size(0, 13);
            this.timeStampLabel.TabIndex = 8;
            // 
            // attachmentLabel
            // 
            this.attachmentLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.attachmentLabel.AutoSize = true;
            this.attachmentLabel.Location = new System.Drawing.Point(363, 68);
            this.attachmentLabel.Name = "attachmentLabel";
            this.attachmentLabel.Size = new System.Drawing.Size(0, 13);
            this.attachmentLabel.TabIndex = 7;
            // 
            // avatarButton
            // 
            this.avatarButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.avatarButton.Location = new System.Drawing.Point(366, 11);
            this.avatarButton.Name = "avatarButton";
            this.avatarButton.Size = new System.Drawing.Size(114, 23);
            this.avatarButton.TabIndex = 6;
            this.avatarButton.Text = "View Avatar";
            this.avatarButton.UseVisualStyleBackColor = true;
            this.avatarButton.Click += new System.EventHandler(this.avatarButton_Click);
            // 
            // attachmentButton
            // 
            this.attachmentButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.attachmentButton.Location = new System.Drawing.Point(366, 40);
            this.attachmentButton.Name = "attachmentButton";
            this.attachmentButton.Size = new System.Drawing.Size(114, 23);
            this.attachmentButton.TabIndex = 3;
            this.attachmentButton.Text = "View Attachment";
            this.attachmentButton.UseVisualStyleBackColor = true;
            this.attachmentButton.Visible = false;
            this.attachmentButton.Click += new System.EventHandler(this.attachmentButton_Click);
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(82, 50);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(0, 13);
            this.idLabel.TabIndex = 5;
            // 
            // discriminatorLabel
            // 
            this.discriminatorLabel.AutoSize = true;
            this.discriminatorLabel.Location = new System.Drawing.Point(82, 34);
            this.discriminatorLabel.Name = "discriminatorLabel";
            this.discriminatorLabel.Size = new System.Drawing.Size(0, 13);
            this.discriminatorLabel.TabIndex = 4;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.usernameLabel.Location = new System.Drawing.Point(82, 14);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(0, 20);
            this.usernameLabel.TabIndex = 3;
            // 
            // avatarBox
            // 
            this.avatarBox.Location = new System.Drawing.Point(12, 14);
            this.avatarBox.Name = "avatarBox";
            this.avatarBox.Size = new System.Drawing.Size(64, 64);
            this.avatarBox.TabIndex = 0;
            this.avatarBox.TabStop = false;
            // 
            // databaseOpenFileDialog
            // 
            this.databaseOpenFileDialog.FileName = "discord.db";
            this.databaseOpenFileDialog.Filter = "Database files (*.db)|*.db|All files (*.*)|*.*";
            this.databaseOpenFileDialog.Title = "Select database file";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 392);
            this.Controls.Add(this.userPanel);
            this.Controls.Add(this.mainView);
            this.Controls.Add(this.mainMenuStrip);
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "mainForm";
            this.ShowIcon = false;
            this.Text = "Discord Archiver Database Viewer ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.userPanel.ResumeLayout(false);
            this.userPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatarBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView mainView;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.Panel userPanel;
        private System.Windows.Forms.ColumnHeader UserIdd;
        private System.Windows.Forms.ColumnHeader Username;
        private System.Windows.Forms.ColumnHeader Discriminator;
        private System.Windows.Forms.ColumnHeader Content;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadDatabaseToolStripMenuItem;
        private System.Windows.Forms.PictureBox avatarBox;
        private System.Windows.Forms.Label discriminatorLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.ColumnHeader MessageId;
        private System.Windows.Forms.Button attachmentButton;
        private System.Windows.Forms.Button avatarButton;
        private System.Windows.Forms.Label attachmentLabel;
        private System.Windows.Forms.OpenFileDialog databaseOpenFileDialog;
        private System.Windows.Forms.ColumnHeader Attachment_Filename;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sQLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem attachmentFilenameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem discriminatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usernameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem messageToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader Timestamp;
        private System.Windows.Forms.Label timeStampLabel;
    }
}

