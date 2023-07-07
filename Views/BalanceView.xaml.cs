namespace AliJam.Views;

public partial class BalanceView : ContentPage
{
	public BalanceView()
	{
        InitializeComponent();
        BindingContext = new BalanceViewModel();
    }
}