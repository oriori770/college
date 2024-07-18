using college.DAL;
using college.forms;
using Microsoft.Extensions.Configuration;

namespace college
{
    internal  class Program
    {

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.


            var config = new ConfigurationBuilder()
                     .AddUserSecrets<Program>()
                     .Build();
            string? conn = config["ConnectionString"];
            string? dbName = config["DefaultDB"];
            DbContext dbCtx = new DbContext(conn);
            dbCtx.CheckConnectionToDefaultDB(dbName);


            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm1(dbCtx));
        }
    }
}