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
    public class AccountViewModel : ViewModelBase
    {
        public string WelcomePage => "Welcome to Account Page";
        public ICommand NavigateHomeCommand { get; }

        public AccountViewModel(NavigationManager navigationManager)
        {
            NavigateHomeCommand = new NavigationCommand<HomeViewModel>(navigationManager,
                () => new HomeViewModel(navigationManager));
        }
    }
}
