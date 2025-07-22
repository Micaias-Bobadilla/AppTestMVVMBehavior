using AppTestMVVMBehavior.Models;
using CommunityToolkit.Mvvm.Messaging;
using CommunityToolkit.Mvvm.Messaging.Messages;
using System.Collections.ObjectModel;
using Wpf.Ui.Abstractions.Controls;

namespace AppTestMVVMBehavior.ViewModels.Componentes
{
    public partial class UsersListViewModel : ObservableRecipient, IRecipient<ValueChangedMessage<ObservableCollection<User>>>, INavigationAware
    {
        private readonly IMessenger _Messenger;


        [ObservableProperty]
        private User? _selectedUser;

        [ObservableProperty]
        public ObservableCollection<User> _Users;

        public UsersListViewModel(IMessenger messger)
        {
            _Messenger = messger;
        }

        partial void OnSelectedUserChanged(User? value)
        {
            if (value is not null)
            {
                _Messenger.Send(new ValueChangedMessage<User>(value));
            }
        }

        public void Receive(ValueChangedMessage<ObservableCollection<User>> message)
        {
            Users = message.Value;
        }

        public async Task OnNavigatedToAsync()
        {
            IsActive = true;
            await Task.CompletedTask;
        }

        public async Task OnNavigatedFromAsync()
        {
            await Task.CompletedTask;
        }
    }
}
