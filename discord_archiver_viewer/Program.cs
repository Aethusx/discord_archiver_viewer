using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace discord_archiver_viewer
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 

        public static mainForm MainForm; 
        public static sqlForm SQLForm;
        public static avatarForm AvatarForm;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MainForm = new mainForm();
            SQLForm = new sqlForm(MainForm);
            AvatarForm = new avatarForm(MainForm);
            Application.Run(MainForm);
        }
    }
}
