using System;
using System.Windows.Forms;

namespace ImageListDemo
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.SetCompatibleTextRenderingDefault(false);
            // apply fonts application wide
            Application.SetDefaultFont(new System.Drawing.Font("Gorgia", 12, System.Drawing.FontStyle.Regular));
            // running application
            Application.Run(new MainWindow());
        }
    }
}
