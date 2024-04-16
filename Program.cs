
using Supermarket_mevp.Model;
using Supermarket_mevp.Views;
using Supermarket_mevp._Repositories;
using Supermarket_mevp.Properties;
using Supermarket_mevp.Presenter;
namespace Supermarket_mevp
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
            string sqlConnectionSring = Settings.Default.SqlConnection;
            IMainView view = new MainView();
            new MainPresenter(view, sqlConnectionSring);
            Application.Run((Form) view);
            // IPayModeRepository repository= new PayModeRepository(sqlConnectionSring);
        }
    }
}