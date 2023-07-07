using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliJam.ViewModels
{
    [QueryProperty(nameof(Transaction), nameof(Transaction))]
    public partial class TransactionDetailsViewModel: BaseViewModel
    {
        [ObservableProperty]
        public TransactionModel transaction;
        
    }
}
