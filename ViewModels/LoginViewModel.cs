namespace AliJam.ViewModels
{
    public partial class LoginViewModel : BaseViewModel
    {
        [ObservableProperty]
        public UserLoginModel userLoginModel = new();

        [RelayCommand]
        public void Login() 
        {
            Shell.Current.GoToAsync($"//{nameof(MainPage)}");
        }
    }
}
