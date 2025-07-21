using AppTestMVVMBehavior.ViewModels.Pages;
using System.Windows.Controls;

namespace AppTestMVVMBehavior.Views.Pages
{
    /// <summary>
    /// Lógica de interacción para SliderManipulatePage.xaml
    /// </summary>
    public partial class SliderManipulatePage : Page
    {
        public SliderManipulateViewModel ViewModel { get; }
        public SliderManipulatePage(SliderManipulateViewModel viewModel)
        {
            ViewModel = viewModel;
            DataContext = this;
            InitializeComponent();
        }
    }
}
