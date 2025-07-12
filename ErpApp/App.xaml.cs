using Microsoft.Extensions.DependencyInjection;
using System.Windows;

namespace ErpApp
{
    public partial class App : Application
    {
        private readonly ServiceProvider _serviceProvider;

        public App(ServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            var mainWindow = _serviceProvider.GetRequiredService<MainWindow>();
            mainWindow.Show();
        }
    }
}
