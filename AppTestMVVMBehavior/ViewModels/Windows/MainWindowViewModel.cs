using System.Collections.ObjectModel;
using Wpf.Ui.Controls;

namespace AppTestMVVMBehavior.ViewModels.Windows
{
    public partial class MainWindowViewModel : ObservableObject
    {
        [ObservableProperty]
        private string _applicationTitle = "WPF UI - AppTestMVVMBehavior";

        [ObservableProperty]
        private ObservableCollection<object> _menuItems = new()
        {
            new NavigationViewItem()
            {
                Content = "Home",
                Icon = new SymbolIcon { Symbol = SymbolRegular.Home24 },
                TargetPageType = typeof(Views.Pages.DashboardPage)
            },
            new NavigationViewItem()
            {
                Content = "User",
                Icon = new SymbolIcon { Symbol = SymbolRegular.Person24 },
                TargetPageType = typeof(Views.Pages.UsersView)
            },
            new NavigationViewItem()
            {
                Content= "Slider",
                Icon = new SymbolIcon { Symbol = SymbolRegular.Production24 },
                TargetPageType = typeof(Views.Pages.SliderManipulatePage)
            },
            new NavigationViewItem()
            {
                Content= "ProgresSlider",
                Icon = new SymbolIcon { Symbol = SymbolRegular.BatteryCharge24 },
                TargetPageType = typeof(Views.Pages.ProgresSliderPage)
            }

        };

        [ObservableProperty]
        private ObservableCollection<object> _footerMenuItems = new()
        {
            new NavigationViewItem()
            {
                Content = "Settings",
                Icon = new SymbolIcon { Symbol = SymbolRegular.Settings24 },
                TargetPageType = typeof(Views.Pages.SettingsPage)
            }
        };

        [ObservableProperty]
        private ObservableCollection<MenuItem> _trayMenuItems = new()
        {
            new MenuItem { Header = "Home", Tag = "tray_home" }
        };
    }
}
