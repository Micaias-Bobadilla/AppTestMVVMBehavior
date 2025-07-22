using AppTestMVVMBehavior.Services;
using CommunityToolkit.Mvvm.Messaging;
using CommunityToolkit.Mvvm.Messaging.Messages;
using Wpf.Ui.Abstractions.Controls;

namespace AppTestMVVMBehavior.ViewModels.Pages
{
    public partial class ProgresSliderViewModel : ObservableRecipient, IRecipient<ValueChangedMessage<float>>, ICleanup, INavigationAware
    {

        [ObservableProperty]
        private float _sliderRecibedValue;

        private readonly IMessenger _messenger;

        public ProgresSliderViewModel(IMessenger messenger)
        {
            _messenger = messenger;
        }

        partial void OnSliderRecibedValueChanged(float value)
        {
            _messenger.Send(new ValueChangedMessage<float>(value));
        }

        public void Receive(ValueChangedMessage<float> message)
        {
            SliderRecibedValue = message.Value;
        }

        public void Cleanup()
        {
            IsActive = false; // Esto desuscribe automáticamente al ViewModel del Messenger
        }

        public Task OnNavigatedToAsync()
        {
            IsActive = true; // ¡Reactivamos el receptor aquí!
            return Task.CompletedTask;
        }

        public Task OnNavigatedFromAsync()
        {
          //  Cleanup(); // Opcional: puedes desactivarlo al salir de la página
            return Task.CompletedTask;
        }
    }
}
