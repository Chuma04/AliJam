namespace AliJam.Views;

public partial class TransactionsView : ContentPage
{
	public TransactionsView()
	{
        InitializeComponent();
        BindingContext = new TransactionsViewModel();
    }
}