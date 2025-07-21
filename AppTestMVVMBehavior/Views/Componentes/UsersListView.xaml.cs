using AppTestMVVMBehavior.ViewModels.Componentes;
using Microsoft.Extensions.DependencyInjection;
using System.Windows.Controls;

namespace AppTestMVVMBehavior.Views.Componentes
{
    /// <summary>
    /// Lógica de interacción para UsersListView.xaml
    /// </summary>
    public partial class UsersListView : UserControl
    {
        public UsersListView()
        {
            DataContext = App.Services.GetRequiredService<UsersListViewModel>();
            InitializeComponent();
        }
    }
}
