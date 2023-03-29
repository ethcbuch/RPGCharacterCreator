using RPGCharacterCreator.Core;
using RPGCharacterCreator.WVVM.View;
using System.ComponentModel;
using System.Windows;

namespace RPGCharacterCreator.WVVM.ViewModel
{
    internal class BioViewModel : ObservableObject
    {

        public BioViewModel bioVM { get; set; }

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

        public BioViewModel()
        {
            bioVM = new BioViewModel();
            CurrentView = bioVM;


        }

    }
}
