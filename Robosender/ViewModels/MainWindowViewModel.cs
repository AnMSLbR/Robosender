using Robosender.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Robosender.ViewModels
{
    internal class MainWindowViewModel : ObservableObject
    {
        public AccountsViewModel AccountsVM { get; set; }
        public MainViewModel MainVM { get; set; }
        public ICommand AccountsViewCommand { get; set; }
        public ICommand MainViewCommand { get; set; }

        private object _currentView;
        public object CurrentView
        {
            get
            {
                return _currentView;
            }
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }
        public MainWindowViewModel()
        {
            AccountsVM = new AccountsViewModel();
            MainVM = new MainViewModel();
            CurrentView = AccountsVM;

            AccountsViewCommand = new RelayCommand(o =>
            {
                CurrentView = AccountsVM;
            });

            MainViewCommand = new RelayCommand(o =>
            {
                CurrentView = MainVM;
            });
        }
    }
}
