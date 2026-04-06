using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace GT3RS
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            using (var splash = new Form3())
            {
                splash.ShowDialog(); 
            }
            Application.Run(new Form4());
            
            
        }
    }
}