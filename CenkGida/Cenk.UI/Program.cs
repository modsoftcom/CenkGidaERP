using Cenk.UI.Views;
using System;
using System.Globalization;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace Cenk.UI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Properties.Settings.Default.DBDir = Application.StartupPath;
                Properties.Settings.Default.Save();

                // Create a new object, representing the German culture.  
                CultureInfo culture = CultureInfo.CreateSpecificCulture("tr");

                // The following line provides localization for the application's user interface.  
                Thread.CurrentThread.CurrentUICulture = culture;

                // The following line provides localization for data formats.  
                Thread.CurrentThread.CurrentCulture = culture;
                

                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("tr-TR");
                System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("tr-TR");

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                DevExpress.Skins.SkinManager.EnableFormSkins();

                DevExpress.XtraEditors.WindowsFormsSettings.DefaultFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular);
                CheckFiles();
                Application.Run(new MasterForm());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        private static void CheckFiles()
        {
            string[] Dirs = new string[]
            {
              Application.StartupPath
            };
            foreach (string dir in Dirs)
            {
                if (!Directory.Exists(dir))
                {
                    Directory.CreateDirectory(dir);
                }
            }
            string[] Files = new string[]
            {
                Dirs[0] + "\\Customers.json",
                Dirs[0] + "\\Products.json",
                Dirs[0] + "\\Waybills.json",
                Dirs[0] + "\\Orders.json",
                Dirs[0] + "\\Logs.json"
            };
            foreach (string fname in Files)
            {
                if (!File.Exists(fname))
                {
                    File.Create(fname).Close();
                    File.WriteAllText(fname, "[]");
                }
            }

        }
    }
}
