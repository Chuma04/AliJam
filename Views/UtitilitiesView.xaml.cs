namespace AliJam.Views;

public partial class UtitilitiesView : ContentPage
{
	public UtitilitiesView()
	{
        InitializeComponent();
        BindingContext = new UtilitiesViewModel();
    }
}