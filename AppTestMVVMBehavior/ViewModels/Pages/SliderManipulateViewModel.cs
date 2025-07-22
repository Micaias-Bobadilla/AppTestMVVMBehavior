using CommunityToolkit.Mvvm.Messaging;
using CommunityToolkit.Mvvm.Messaging.Messages;
using Wpf.Ui.Abstractions.Controls;

namespace AppTestMVVMBehavior.ViewModels.Pages
{
    
    public partial  class SliderManipulateViewModel :ObservableRecipient, INavigationAware
    {

        [ObservableProperty]
        public float _SliderValue;


        public SliderManipulateViewModel()
        {
            
        }


        public Task OnNavigatedToAsync()
        {
            return Task.CompletedTask;
        }

        public Task OnNavigatedFromAsync()
        {
            return Task.CompletedTask;
        }

        public void Receive(ValueChangedMessage<float> message)
        {
            SliderValue = message.Value;
        }
    }
}
