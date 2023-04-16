using RPGCharacterCreator.Core;
using RPGCharacterCreator.MVVM.Model;

namespace RPGCharacterCreator.MVVM.ViewModel
{
    class BackgroundViewModel : ObservableObject
    {
        public RelayCommand NobleButtonCommand { get; set; }

        public RelayCommand SageButtonCommand { get; set; }

        public RelayCommand KnightButtonCommand { get; set; }

        public RelayCommand SpyButtonCommand { get; set; }

        public RelayCommand SmugglerButtonCommand { get; set; }

        public RelayCommand SailorButtonCommand { get; set; }

        public RelayCommand SoldierButtonCommand { get; set; }

        public RelayCommand EntertainerButtonCommand { get; set; }

        public RelayCommand AcolyteButtonCommand { get; set; }

        public RelayCommand CriminalButtonCommand { get; set; }

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

            KnightButtonCommand = new RelayCommand(o =>
            {
                ABackground = new Knight();
                OnPropertyChanged();
            });

            SpyButtonCommand = new RelayCommand(o =>
            {
                ABackground = new Spy();
                OnPropertyChanged();
            });

            SmugglerButtonCommand = new RelayCommand(o =>
            {
                ABackground = new Smuggler();
                OnPropertyChanged();
            });

            SailorButtonCommand = new RelayCommand(o =>
            {
                ABackground = new Sailor();
                OnPropertyChanged();
            });

            SoldierButtonCommand = new RelayCommand(o =>
            {
                ABackground = new Soldier();
                OnPropertyChanged();
            });

            EntertainerButtonCommand = new RelayCommand(o =>
            {
                ABackground = new Entertainer();
                OnPropertyChanged();
            });

            AcolyteButtonCommand = new RelayCommand(o =>
            {
                ABackground = new Acolyte();
                OnPropertyChanged();
            });

            CriminalButtonCommand = new RelayCommand(o =>
            {
                ABackground = new Criminal();
                OnPropertyChanged();
            });
        }
    }
}
