namespace AliJam.Views;

public partial class AddUserView : ContentPage
{
	public AddUserView()
	{
        InitializeComponent();
        BindingContext = new AderUserViewModel();
    }
}