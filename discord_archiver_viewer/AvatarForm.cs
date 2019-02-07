using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace discord_archiver_viewer
{
    public partial class avatarForm : Form
    {
        mainForm mainForm = null;
        public avatarForm(mainForm MainForm)
        {
            InitializeComponent();
            mainForm = MainForm;
        }

        private void avatarForm_Load(object sender, EventArgs e)
        {

        }

        private void x32ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(mainForm.currentUser.avatar_url + "?size=32");
        }

        private void x64ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetAvatar(64);
        }

        private void x128lToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetAvatar(128);
        }
        
        private void x256ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetAvatar(256);
        }

        private void x512ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetAvatar(512);
        }

        private void avatarForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        public void SetAvatar(int size)
        {
            this.Height = size + 42;
            this.Width = size;
            avatarBox.ImageLocation = mainForm.currentUser.avatar_url + "?size=" + size;
        }

        /*private void avatarForm_Shown(object sender, EventArgs e)
        {
            if(mainForm.currentUser != null)
                SetAvatar(128);
        }*/

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(avatarBox.ImageLocation);
        }


    }
}
