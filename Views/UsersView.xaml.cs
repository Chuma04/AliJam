namespace AliJam.Views;

public partial class UsersView : ContentPage
{
	public UsersView()
	{
        InitializeComponent();
        BindingContext = new UsersViewModel();
	}
}