using System;
using System.Windows.Forms;
using RegistryUtils;
using System.Runtime.InteropServices;

namespace ColorfulTitleBars
{
    static class Program
    {
        private static void VerifyAndLaunch()
        {
            if (WindowCustomizationUtility.IsWindows10())
            {
                Application.Run(new MainForm());
            }
            else
            {
                MessageBox.Show(
                    Strings.IncompatibleSystemErrorMessage,
                    Strings.IncompatibleSystemErrorTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        [DllImport("Shcore.dll")]
        static extern int SetProcessDpiAwareness(int PROCESS_DPI_AWARENESS);

        // According to https://msdn.microsoft.com/en-us/library/windows/desktop/dn280512(v=vs.85).aspx
        private enum DpiAwareness
        {
            None = 0,
            SystemAware = 1,
            PerMonitorAware = 2
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            SetProcessDpiAwareness((int)DpiAwareness.PerMonitorAware);

            VerifyAndLaunch();
        }
    }
}
