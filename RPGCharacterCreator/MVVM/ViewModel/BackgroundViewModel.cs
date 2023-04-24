using RPGCharacterCreator.Core;
using RPGCharacterCreator.MVVM.Model;
using System.Windows.Media.Media3D;

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


        private Theme _backgroundTheme;

        public Theme BackgroundTheme
        {
            get { return _backgroundTheme; }
            set { _backgroundTheme = value; OnPropertyChanged(); }
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
                //I hate this but it works. Abackground.BackgroundSkills is a empty list and we need to have the values of noble.BackgroundSkills so we create a new full list for
                //ABackground.Background skills using ObsevableCollection<string>(noble.Backgroundskills) which copies over its values.
                Noble noble = new Noble();
                ABackground = new Noble();

                ABackground.BackgroundSkills = new System.Collections.ObjectModel.ObservableCollection<string>(noble.BackgroundSkills);
                OnPropertyChanged();
            });

            SageButtonCommand = new RelayCommand(o =>
            {
                Sage sage = new Sage();
                ABackground = new Sage();

                ABackground.BackgroundSkills = new System.Collections.ObjectModel.ObservableCollection<string>(sage.BackgroundSkills);
                OnPropertyChanged();
            });

            KnightButtonCommand = new RelayCommand(o =>
            {
                Knight knight = new Knight();
                ABackground = new Knight();

                ABackground.BackgroundSkills = new System.Collections.ObjectModel.ObservableCollection<string>(knight.BackgroundSkills);
                OnPropertyChanged();
            });

            SpyButtonCommand = new RelayCommand(o =>
            {
                Spy spy = new Spy();
                ABackground = new Spy();
                ABackground.BackgroundSkills = new System.Collections.ObjectModel.ObservableCollection<string>(spy.BackgroundSkills);
                OnPropertyChanged();
            });

            SmugglerButtonCommand = new RelayCommand(o =>
            {
                Smuggler smug = new Smuggler();
                ABackground = new Smuggler();

                ABackground.BackgroundSkills = new System.Collections.ObjectModel.ObservableCollection<string>(smug.BackgroundSkills);
                OnPropertyChanged();
            });

            SailorButtonCommand = new RelayCommand(o =>
            {
                Sailor sailor = new Sailor();
                ABackground = new Sailor();

                ABackground.BackgroundSkills = new System.Collections.ObjectModel.ObservableCollection<string>(sailor.BackgroundSkills);
                OnPropertyChanged();
            });

            SoldierButtonCommand = new RelayCommand(o =>
            {
                Soldier sold = new Soldier();
                ABackground = new Soldier();

                ABackground.BackgroundSkills = new System.Collections.ObjectModel.ObservableCollection<string>(sold.BackgroundSkills);
                OnPropertyChanged();
            });

            EntertainerButtonCommand = new RelayCommand(o =>
            {
                Entertainer enter = new Entertainer();
                ABackground = new Entertainer();

                ABackground.BackgroundSkills = new System.Collections.ObjectModel.ObservableCollection<string>(enter.BackgroundSkills);
                OnPropertyChanged();
            });

            AcolyteButtonCommand = new RelayCommand(o =>
            {
                Acolyte acol = new Acolyte();
                ABackground = new Acolyte();

                ABackground.BackgroundSkills = new System.Collections.ObjectModel.ObservableCollection<string>(acol.BackgroundSkills);
                OnPropertyChanged();
            });

            CriminalButtonCommand = new RelayCommand(o =>
            {
                Criminal crim = new Criminal();
                ABackground = new Criminal();

                ABackground.BackgroundSkills = new System.Collections.ObjectModel.ObservableCollection<string>(crim.BackgroundSkills);
                OnPropertyChanged();
            });
        }
    }
}
