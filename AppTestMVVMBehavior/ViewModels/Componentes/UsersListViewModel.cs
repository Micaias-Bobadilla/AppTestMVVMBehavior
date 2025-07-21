using AppTestMVVMBehavior.Models;
using CommunityToolkit.Mvvm.Messaging;
using CommunityToolkit.Mvvm.Messaging.Messages;
using System.Collections.ObjectModel;

namespace AppTestMVVMBehavior.ViewModels.Componentes
{
    public partial class UsersListViewModel : ObservableObject
    {
        private readonly IMessenger _Messenger;


        [ObservableProperty]
        private User? _selectedUser;

        [ObservableProperty]
        public ObservableCollection<User> _Users;

        public UsersListViewModel()
        {

        }

        public UsersListViewModel(IMessenger messger)
        {
            _Messenger = messger;
            Users = new ObservableCollection<User>
            {
                new("Ana", "García", "ana.garcia@email.com"),
                new("Luis", "Ramos", "luis.ramos@email.com"),
                new("Sara", "Vega", "sara.vega@email.com")
            };
        }

        partial void OnSelectedUserChanged(User? value)
        {
            if (value is not null)
            {
                _Messenger.Send(new ValueChangedMessage<User>(value));
            }
        }
    }
}
