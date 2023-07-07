namespace AliJam.Views;

public partial class SettingsView : ContentPage
{
	public SettingsView()
	{
        InitializeComponent();
        BindingContext = new SettingsViewModel();
    }
}