namespace AliJam.Views;

public partial class TransactionDetailsView : ContentPage
{
	public TransactionDetailsView()
	{
		InitializeComponent();
		BindingContext = new TransactionDetailsViewModel();
	}
}