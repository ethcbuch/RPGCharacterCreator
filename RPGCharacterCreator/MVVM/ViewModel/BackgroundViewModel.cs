using RPGCharacterCreator.Core;
using RPGCharacterCreator.MVVM.Model;

namespace RPGCharacterCreator.MVVM.ViewModel
{
    class BackgroundViewModel : ObservableObject
    {
        public RelayCommand NobleButtonCommand { get; set; }

        public RelayCommand SageButtonCommand { get; set; }


        private Theme _backgroundTheme;

        public Theme BackgroundTheme
        {
            get { return _backgroundTheme; }
            set { _backgroundTheme = value; }
        }

        private Background _aBackground;

        public Background ABackground
        {
            get { return _aBackground; }
            set
            {
                _aBackground = value;
                OnPropertyChanged();
            }
        }


        public BackgroundViewModel()
        {

            NobleButtonCommand = new RelayCommand(o =>
            {
                ABackground = new Noble();
                OnPropertyChanged();
            });

            SageButtonCommand = new RelayCommand(o =>
            {
                ABackground = new Sage();
                OnPropertyChanged();
            });
        }
    }
}