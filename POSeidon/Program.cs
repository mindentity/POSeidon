using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace POSeidon
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            var attribs = assembly.GetCustomAttributes(typeof(GuidAttribute), true);
            var appGuid = attribs[0] as GuidAttribute;
            bool createdNew;
            string mutexName = String.Format("Global\\{{{0}}}", appGuid.Value);
            Mutex mutex = new Mutex(true, mutexName, out createdNew);
            if (createdNew)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                LoginForm loginForm = new LoginForm();
                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    Application.Run(new MainForm());
                }
                mutex.ReleaseMutex();
            } else
            {
                MessageBox.Show("POSeidon is already running!", "POSeidon", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
