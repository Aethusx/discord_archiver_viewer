using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace discord_archiver_viewer
{
    public partial class mainForm : Form
    {
        public SQLiteConnection dbConnection = null;
        List<User> users = new List<User>();
        public User currentUser = null;
        string attachment_button_location = String.Empty;

        public mainForm()
        {
            InitializeComponent();
        }

        void LoadDatabase(string database)
        {
            mainView.Items.Clear();

            dbConnection = new SQLiteConnection("Data Source=" + database + ";Version=3;");
            dbConnection.Open();

            SQLiteCommand command = new SQLiteCommand("SELECT * FROM Users", dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                users.Add(new User(Convert.ToInt32(reader["UserId"]), Convert.ToString(reader["Username"]), Convert.ToUInt16(reader["Discriminator"]), Convert.ToInt64(reader["Id"]), Convert.ToString(reader["Avatar"])));
            }

            command = new SQLiteCommand("SELECT UserId,Message,Id,Attachment_Filename FROM Messages", dbConnection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                User user = users.First(s => s.userId == Convert.ToInt32(reader["UserId"]));
                ListViewItem item = new ListViewItem();
                item.Text = user.userId.ToString();
                item.SubItems.Add(user.username);
                item.SubItems.Add(user.discriminator.ToString());
                item.SubItems.Add(Convert.ToString(reader["Message"]));
                item.SubItems.Add(Convert.ToString(reader["Id"]));
                if(Convert.ToString(reader["Attachment_Filename"]) != "NULL")
                    item.SubItems.Add(Convert.ToString(reader["Attachment_Filename"]));
                mainView.Items.Add(item);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            databaseOpenFileDialog.InitialDirectory = Environment.CurrentDirectory;
        }

        private void mainView_SelectedIndexChanged(object sender, EventArgs e)
        {
            attachmentButton.Visible = false;
            if (mainView.SelectedItems.Count > 0)
            {
                currentUser = users.First(s => s.userId == Convert.ToInt32(mainView.SelectedItems[0].Text));
                avatarBox.ImageLocation = currentUser.avatar_url + "?size=64"; //GetAvatarUrl(user.id.ToString(), user.avatar.ToString());
                usernameLabel.Text = currentUser.username;
                discriminatorLabel.Text = currentUser.discriminator.ToString();
                idLabel.Text = "Id: " + currentUser.id.ToString();

                SQLiteCommand command = new SQLiteCommand("SELECT Attachment_URL,Attachment_Filename,Timestamp FROM Messages WHERE Id='" + mainView.SelectedItems[0].SubItems[4].Text + "';", dbConnection);
                SQLiteDataReader reader = command.ExecuteReader();
                while(reader.Read())
                {
                    string timestamp = Convert.ToString(reader["Timestamp"]);
                    timeStampLabel.Text = (timestamp.Length > 13) ? Convert.ToString(timestamp).Remove(timestamp.Length - 13).Replace("T", " ") : "Invalid Timestamp";
                    if (Convert.ToString(reader["Attachment_URL"]) != "NULL")
                    {
                        attachmentButton.Visible = true;
                        attachment_button_location = Convert.ToString(reader["Attachment_URL"]);
                        attachmentLabel.Text = Convert.ToString(reader["Attachment_Filename"]);
                    }
                    else
                    {
                        attachmentButton.Visible = false;
                        attachment_button_location = String.Empty;
                        attachmentLabel.Text = String.Empty;
                    }
                }


            }
        }

        private void attachmentButton_Click(object sender, EventArgs e)
        {
            if(attachment_button_location != String.Empty)
                System.Diagnostics.Process.Start(attachment_button_location);
        }

        private void avatarButton_Click(object sender, EventArgs e)
        {
            if (currentUser != null)
            {
                Program.AvatarForm.Show();
                Program.AvatarForm.SetAvatar(128);
            }
        }

        private void loadDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            DialogResult result = databaseOpenFileDialog.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                LoadDatabase(databaseOpenFileDialog.FileName);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(dbConnection != null)
                dbConnection.Close();
            GC.Collect();
            Environment.Exit(0);
        }

        private void sQLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.SQLForm.Show();
        }

        private void attachmentFilenameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainView.Columns[5].Width = (mainView.Columns[5].Width > 0) ? 0 : 45;
        }

        private void discriminatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainView.Columns[2].Width = (mainView.Columns[5].Width > 0) ? 0 : 45;
        }

        private void usernameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainView.Columns[1].Width = (mainView.Columns[5].Width > 0) ? 0 : 45;
        }

        private void messageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainView.Columns[3].Width = (mainView.Columns[5].Width > 0) ? 0 : 45;
        }
    }
}
