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
        }
    }
}