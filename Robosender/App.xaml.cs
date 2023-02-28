using Robosender.ViewModels;
using Robosender.Views;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Robosender
{
    public partial class App : Application
    {
        protected void ApplicationStart(object sender, StartupEventArgs e)
        {
            var authorizationWindow = new AuthorizationWindow() { DataContext = new AuthorizationWindowViewModel() };
            authorizationWindow.Show();
            authorizationWindow.IsVisibleChanged += (s, ev) =>
            {
                if (authorizationWindow.IsVisible == false && authorizationWindow.IsLoaded)
                {
                    var mainWindow = new MainWindow() { DataContext = new MainWindowViewModel() };
                    mainWindow.Show();
                    authorizationWindow.Close();
                }
            };
        }
    }
}
