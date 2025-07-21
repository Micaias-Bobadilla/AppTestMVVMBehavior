using CommunityToolkit.Mvvm.Messaging;
using CommunityToolkit.Mvvm.Messaging.Messages;

namespace AppTestMVVMBehavior.ViewModels.Pages
{
    
    public partial  class SliderManipulateViewModel :ObservableObject
    {

        [ObservableProperty]
        public float _SliderValue;

        private readonly IMessenger _messenger;

        public SliderManipulateViewModel(IMessenger messenger)
        {
            _messenger = messenger;
        }

        partial void OnSliderValueChanged(float value)
        {
            _messenger.Send(new ValueChangedMessage<float>(value));    
        }
    }
}
