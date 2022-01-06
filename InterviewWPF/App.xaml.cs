using InterviewWPF.Navigation;
using InterviewWPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace InterviewWPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        protected override void OnStartup(StartupEventArgs e)
        {
            NavigationManager navigationManager = new NavigationManager();
            navigationManager.CurrentViewModel = new HomeViewModel(navigationManager);

            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(navigationManager)
            };
            MainWindow.Show();

            base.OnStartup(e);
        }

    }

}
