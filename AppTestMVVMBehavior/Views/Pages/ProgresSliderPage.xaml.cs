using AppTestMVVMBehavior.Services;
using AppTestMVVMBehavior.ViewModels.Pages;
using System.Windows.Controls;

namespace AppTestMVVMBehavior.Views.Pages
{
    /// <summary>
    /// Lógica de interacción para ProgresSliderPage.xaml
    /// </summary>
    public partial class ProgresSliderPage : Page
    {
        public ProgresSliderViewModel ViewModel { get; }
        public ProgresSliderPage(ProgresSliderViewModel viewModel)
        {
            ViewModel = viewModel;
            DataContext = this;
            InitializeComponent();
        }
    }
}
