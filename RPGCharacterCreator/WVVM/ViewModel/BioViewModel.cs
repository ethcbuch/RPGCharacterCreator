using RPGCharacterCreator.Core;
using RPGCharacterCreator.WVVM.View;

namespace RPGCharacterCreator.WVVM.ViewModel
{
    internal class BioViewModel : ObservableObject
    {
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
            BioView = new BioViewModel();
        }

    }
}
