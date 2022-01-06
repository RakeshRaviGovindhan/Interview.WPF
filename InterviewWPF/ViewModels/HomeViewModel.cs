using InterviewWPF.Commands;
using InterviewWPF.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace InterviewWPF.ViewModels
{
    public class HomeViewModel : ViewModelBase
    {
        public string WelcomePage => "Welcome to Home Page";
        public ICommand NavigateAccountCommand { get;  }

        public HomeViewModel(NavigationManager navigationManager)
        {
            NavigateAccountCommand = new NavigationCommand<AccountViewModel>(navigationManager, 
                () => new AccountViewModel(navigationManager));
        }
    }
}
