using AppTestMVVMBehavior.Models;
using CommunityToolkit.Mvvm.Messaging;
using CommunityToolkit.Mvvm.Messaging.Messages;
using System.Collections.ObjectModel;
using Wpf.Ui.Abstractions.Controls;

namespace AppTestMVVMBehavior.ViewModels.Pages
{
    public class UserViewModel : ObservableObject, INavigationAware
    {
        private readonly IMessenger _messenger;

        private ObservableCollection<User> _Users;
        public UserViewModel(IMessenger messenger)
        {
            _messenger = messenger;

        }

        public async Task OnNavigatedFromAsync()
        {
            await Task.CompletedTask;
        }

        public async Task OnNavigatedToAsync()
        {
            _Users =
            [
               new("Bianca", "Zorio", "biancaz@gmail.com"),
                new("Micaias", "Bobadilla", "micaiasb@gmail.com"),
                new("Ana", "Rojas", "anar@gmail.com"),
                new("Hector", "Mendoza", "hmendoza@gmail.com"),

             ];

            _messenger.Send(new ValueChangedMessage<ObservableCollection<User>>(_Users));
            await Task.CompletedTask;
        }
    }
}
