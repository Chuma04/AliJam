global using CommunityToolkit.Mvvm.Input;

namespace AliJam.ViewModels
{
    public partial class MainPageViewModel : BaseViewModel
    {
        [RelayCommand]
        public void GoToLogin()
        {
            Shell.Current.GoToAsync(nameof(LoginView));
        }
    }
}
