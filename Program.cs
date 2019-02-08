using System;
using System.Windows.Forms;

namespace Movie_Databse
{
    internal static class Program
    {
        public static bool IsDelete = false;
        public static bool IsDeleteMovie = false;

        // (32) Not much to say about these 2 bools, except why aren't they on their respective forms? 
        // Well they ought to be but i had planned to call them for my Unit Tests so i left them here for ease of access. They live here now.
        // -> Menu.cs

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frm_Login());
        }
    }
}