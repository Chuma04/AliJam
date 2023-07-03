using CommunityToolkit.Mvvm.ComponentModel;

namespace AliJam.ViewModels
{
    public partial class BaseViewModel : ObservableObject
    {
        [NotifyPropertyChangedFor(nameof(IsNotBusy))]
        [ObservableProperty]
        bool isBusy;

        public bool IsNotBusy => !isBusy;
    }
}
