namespace AliJam.ViewModels
{
    public partial class TransactionsViewModel : BaseViewModel
    {
        [ObservableProperty]
        public List<TransactionModel> transactions = new()
        {
            new TransactionModel { Id = 1, Amount = 100, Date = DateTime.Now, Name = "Test" },
            new TransactionModel { Id = 2, Amount = 200, Date = DateTime.Now, Name = "Test" },
            new TransactionModel { Id = 3, Amount = 300, Date = DateTime.Now, Name = "Test" },
            new TransactionModel { Id = 4, Amount = 400, Date = DateTime.Now, Name = "Test" },
            new TransactionModel { Id = 5, Amount = 500, Date = DateTime.Now, Name = "Test" },
        };
        [RelayCommand]
        public void ViewDetails(TransactionModel transaction)
        {
            Shell.Current.GoToAsync($"{nameof(TransactionDetailsView)}", 
                new Dictionary<string, object> { ["Transaction"] = transaction});
        }   
    }
}
