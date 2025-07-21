using AppTestMVVMBehavior.Services;
using AppTestMVVMBehavior.ViewModels.Componentes;
using AppTestMVVMBehavior.ViewModels.Pages;
using AppTestMVVMBehavior.ViewModels.Windows;
using AppTestMVVMBehavior.Views.Pages;
using AppTestMVVMBehavior.Views.Windows;
using CommunityToolkit.Mvvm.Messaging;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.IO;
using System.Windows.Threading;
using Wpf.Ui;
using Wpf.Ui.DependencyInjection;

namespace AppTestMVVMBehavior
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        // The.NET Generic Host provides dependency injection, configuration, logging, and other services.
        // https://docs.microsoft.com/dotnet/core/extensions/generic-host
        // https://docs.microsoft.com/dotnet/core/extensions/dependency-injection
        // https://docs.microsoft.com/dotnet/core/extensions/configuration
        // https://docs.microsoft.com/dotnet/core/extensions/logging
        private static readonly IHost _host = Host
            .CreateDefaultBuilder()
            .ConfigureAppConfiguration(c => { c.SetBasePath(Path.GetDirectoryName(AppContext.BaseDirectory)); })
            .ConfigureServices((context, services) =>
            {
                services.AddNavigationViewPageProvider();

                services.AddHostedService<ApplicationHostService>();

                // Theme manipulation
                services.AddSingleton<IThemeService, ThemeService>();

                // TaskBar manipulation
                services.AddSingleton<ITaskBarService, TaskBarService>();

                // Service containing navigation, same as INavigationWindow... but without window
                services.AddSingleton<INavigationService, NavigationService>();

                // Main window with navigation
                services.AddSingleton<INavigationWindow, MainWindow>();
                //ViewModels
                services.AddSingleton<MainWindowViewModel>();
                services.AddTransient<UsersListViewModel>();
                services.AddTransient<UserDetailViewModel>();
                services.AddSingleton<DashboardViewModel>();
                services.AddTransient<DataViewModel>();
                services.AddSingleton<SettingsViewModel>();
                services.AddSingleton<SliderManipulateViewModel>();
                services.AddSingleton<ProgresSliderViewModel>();

                //Messengers
                services.AddSingleton<IMessenger>(WeakReferenceMessenger.Default);

                //Pages
                services.AddSingleton<DashboardPage>();
                services.AddTransient<DataPage>();
                services.AddSingleton<SettingsPage>();
                services.AddSingleton<UsersView>(); 
                services.AddSingleton<SliderManipulatePage>();
                services.AddSingleton<ProgresSliderPage>();
            }).Build();

        /// <summary>
        /// Gets services.
        /// </summary>
        public static IServiceProvider Services
        {
            get { return _host.Services; }
        }

        /// <summary>
        /// Occurs when the application is loading.
        /// </summary>
        private async void OnStartup(object sender, StartupEventArgs e)
        {
            await _host.StartAsync();
        }

        /// <summary>
        /// Occurs when the application is closing.
        /// </summary>
        private async void OnExit(object sender, ExitEventArgs e)
        {
            await _host.StopAsync();

            _host.Dispose();
        }

        /// <summary>
        /// Occurs when an exception is thrown by an application but not handled.
        /// </summary>
        private void OnDispatcherUnhandledException(object sender, DispatcherUnhandledExceptionEventArgs e)
        {
            // For more info see https://docs.microsoft.com/en-us/dotnet/api/system.windows.application.dispatcherunhandledexception?view=windowsdesktop-6.0
        }
    }
}
