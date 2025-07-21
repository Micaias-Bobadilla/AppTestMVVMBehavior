using AppTestMVVMBehavior.ViewModels.Componentes;
using Microsoft.Extensions.DependencyInjection;
using System.Windows.Controls;

namespace AppTestMVVMBehavior.Views.Componentes
{
    /// <summary>
    /// Lógica de interacción para UserDetailsView.xaml
    /// </summary>
    public partial class UserDetailsView : UserControl
    {
        public UserDetailsView()
        {
            DataContext = App.Services.GetRequiredService<UserDetailViewModel>();
            InitializeComponent();
        }

        private void UserControl_Unloaded(object sender, RoutedEventArgs e)
        {
            var DAtaContext = DataContext as UserDetailViewModel;

            DAtaContext.Cleanup();
        }
    }
}
