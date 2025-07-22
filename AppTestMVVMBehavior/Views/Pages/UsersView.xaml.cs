using AppTestMVVMBehavior.ViewModels.Pages;
using System.Windows.Controls;

namespace AppTestMVVMBehavior.Views.Pages
{
    /// <summary>
    /// Lógica de interacción para UsersView.xaml
    /// </summary>
    public partial class UsersView : Page
    {
        public UserViewModel ViewModel { get; }
        public UsersView(UserViewModel viewModel)
        {
            ViewModel = viewModel;
            DataContext = this;
            InitializeComponent();
        }
    }
}
