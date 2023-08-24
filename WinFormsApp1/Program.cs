using CryptoHandler;
using PasswordHandler;
using System.Windows.Forms;

namespace WinFormsApp1
{
    internal static class Program
    {

        public static string ExePath;
        public static AESVaultEncryptor Cryptor;
        public static VaultDataFileManager Vault;
        
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            ExePath = Environment.CurrentDirectory + "\\";
            Application.Run(new LoginInstallForm());
            if(Vault != null)
                Application.Run(new MainMenuForm(Cryptor, Vault));


        }

       
    }
}