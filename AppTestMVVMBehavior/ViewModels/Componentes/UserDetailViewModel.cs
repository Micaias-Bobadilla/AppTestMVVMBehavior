using AppTestMVVMBehavior.Models;
using CommunityToolkit.Mvvm.Messaging.Messages;
using CommunityToolkit.Mvvm.Messaging;
using Wpf.Ui.Abstractions.Controls;

namespace AppTestMVVMBehavior.ViewModels.Componentes
{
    public partial class UserDetailViewModel : ObservableRecipient, IRecipient<ValueChangedMessage<User>>, INavigationAware
    {
        [ObservableProperty]
        private string? _fullName;

        [ObservableProperty]
        private string? _email;

        public UserDetailViewModel(IMessenger messenger) : base(messenger)
        {
            IsActive = true;    
        }

        public UserDetailViewModel()
        {

        }

        public void Receive(ValueChangedMessage<User> message)
        {
            User selectedUser = message.Value;
            FullName = $"{selectedUser.FirstName} {selectedUser.LastName}";
            Email = selectedUser.Email;
        }
        /// <summary>
        /// Funcion para desuscribir automaticamente el messenger al cerrar el ViewModel o la ventana asociada.
        /// </summary>
        public void Cleanup()
        {
            IsActive = false; // Esto desuscribe automáticamente al ViewModel del Messenger
        }

        public Task OnNavigatedToAsync()
        {
            return Task.CompletedTask;
        }

        public Task OnNavigatedFromAsync()
        {
            return Task.CompletedTask;
        }
    }
}
