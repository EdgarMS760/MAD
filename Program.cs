using Microsoft.Extensions.Configuration;

namespace MAD
{
    internal static class Program
    {
        public static IConfiguration? Configuration;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var builder = new ConfigurationBuilder().AddJsonFile("appsettings.json", optional:true, reloadOnChange: true);
            Configuration = builder.Build();
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new FORM_Login());
        }

    }

}