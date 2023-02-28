using Robosender.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Robosender.ViewModels
{
    internal class AuthorizationWindowViewModel : ObservableObject
    {
        private string _secretKey;
        private bool _isViewVisible=true;

        public string SecretKey 
        {
            get 
            { 
                return _secretKey; 
            }
            set
            { 
                _secretKey = value;
                OnPropertyChanged();
            }
        }
        public bool IsViewVisible
        {
            get
            {
                return _isViewVisible;
            }
            set 
            {
                _isViewVisible = value;
                OnPropertyChanged();
            }
        }

        public ICommand LoginCommand { get; }

        public AuthorizationWindowViewModel()
        {
            LoginCommand = new RelayCommand(ExecuteLoginCommand, CanExecuteLoginCommand);
        }

        private bool CanExecuteLoginCommand(object arg)
        {
            bool isValidData=true;
            if (string.IsNullOrWhiteSpace(SecretKey)) isValidData=false;
            return isValidData;
        }

        private void ExecuteLoginCommand(object obj)
        {
            var isValidUser = true;
            if (isValidUser)
            {
                IsViewVisible = false;
            }
            else
            {

            }
        }
    }
}
