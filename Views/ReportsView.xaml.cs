namespace AliJam.Views;

public partial class ReportsView : ContentPage
{
	public ReportsView()
	{
        InitializeComponent();
        BindingContext = new ReportsViewModel();
    }
}