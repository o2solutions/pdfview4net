using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Annotations
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            CheckForQuadrifoglio();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AppForm());
        }

        public static void CheckForQuadrifoglio()
        {
            string platform = IntPtr.Size == 4 ? "x86" : "x64";
            string path = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            string quadrifoglioPath = path + "\\" + platform + "\\O2S.Graphics.Quadrifoglio.dll";

            if (!System.IO.File.Exists(quadrifoglioPath))
            {
                throw new ApplicationException(
                    $"File {quadrifoglioPath} does not exist. " +
                    $"Please copy the x86/x64 folders from InstallFolder\\Redist\\Quadrifoglio to {path}\\"
                    );
            }
        }
    }
}