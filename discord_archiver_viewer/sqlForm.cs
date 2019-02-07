using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace discord_archiver_viewer
{
    public partial class sqlForm : Form
    {
        mainForm mainForm = null;

        public sqlForm(mainForm MainForm)
        {
            InitializeComponent();
            mainForm = MainForm;
        }

        private void sqlForm_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (mainForm.dbConnection == null)
            {
                queryLabel.Text = "No Database was opened.";
                return;
            }
                
            /* needs fixing */
            resultBox.Clear();
            try
            {
                SQLiteCommand command = new SQLiteCommand(queryBox.Text, mainForm.dbConnection);
                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    resultBox.Text = resultBox.Text + reader.GetString(0) + "\n";
                }

            }
            catch (Exception ex)
            {
                queryLabel.Text = ex.Message;
            }
        }

        private void sqlForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}
