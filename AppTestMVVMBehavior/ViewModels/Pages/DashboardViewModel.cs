namespace AppTestMVVMBehavior.ViewModels.Pages
{
    public partial class DashboardViewModel : ObservableObject
    {
        [ObservableProperty]
        private int _counter = 0;

        [RelayCommand(IncludeCancelCommand =true)]
        private async Task OnCounterIncrementAsync(CancellationToken token)
        {
            try
            {
                await Task.Delay(7000, token);
                Counter++;
            }
            catch (OperationCanceledException)
            {

            }
        }
    }
}
