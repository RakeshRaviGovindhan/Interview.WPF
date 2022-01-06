using InterviewWPF.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewWPF.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private readonly NavigationManager _navigationManager;
        public ViewModelBase CurrentViewModel => _navigationManager.CurrentViewModel;

        public MainViewModel(NavigationManager navigationManager)
        {
            _navigationManager = navigationManager;
            _navigationManager.CurrentViewModelChanged += OnCurrentViewModelChanged;
        }

        private void OnCurrentViewModelChanged()
        {
            OnPropertyChanged(nameof(CurrentViewModel));
        }
    }
}
