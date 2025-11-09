using System.Runtime.CompilerServices;

namespace WinFormsApp1
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
                splash.ShowDialog(); // Form3 kapanana kadar burasý bloklanýr
            }
            Application.Run(new Form4());
            
            
        }
    }
}