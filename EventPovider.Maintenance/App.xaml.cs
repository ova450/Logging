using ova.common.logging.EventProvider.Data;
using System.Windows;

namespace ova.common.logging.EventProvider.Maintenance 
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            using Context db = new Context();
            db.SaveChanges();
            db.Dispose();
        }
    }
}
