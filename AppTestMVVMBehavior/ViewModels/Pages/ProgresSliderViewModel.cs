using AppTestMVVMBehavior.Services;
using CommunityToolkit.Mvvm.Messaging;
using CommunityToolkit.Mvvm.Messaging.Messages;

namespace AppTestMVVMBehavior.ViewModels.Pages
{
    public partial class ProgresSliderViewModel : ObservableRecipient, IRecipient<ValueChangedMessage<float>>, ICleanup
    {

        [ObservableProperty]
        private float _sliderRecibedValue;

        public ProgresSliderViewModel()
        {
            IsActive = true;
        }

        public void Receive(ValueChangedMessage<float> message)
        {
            SliderRecibedValue = message.Value;
        }

        public void Cleanup()
        {
            IsActive = false; // Esto desuscribe automáticamente al ViewModel del Messenger
        }
    }
}
