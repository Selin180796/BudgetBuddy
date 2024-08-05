using System.Collections.ObjectModel;
using System.ComponentModel;
using BudgetBuddy.Models;

namespace BudgetBuddy.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Expense> Expenses { get; set; }

        public MainViewModel()
        {
            Expenses = new ObservableCollection<Expense>();
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
