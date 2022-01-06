using InterviewWPF.Navigation;
using InterviewWPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewWPF.Commands
{
    public class NavigationCommand<TViewModel> : CommandBase where TViewModel : ViewModelBase
    {
        public readonly NavigationManager _navigationManager;
        public readonly Func<TViewModel> _createViewModel;

        public NavigationCommand(NavigationManager navigationManager, Func<TViewModel> createViewModel)
        {
            _navigationManager = navigationManager;
            _createViewModel = createViewModel;
        }

        public override void Execute(object parameter)
        {
            _navigationManager.CurrentViewModel = _createViewModel();
        }
    }
}
