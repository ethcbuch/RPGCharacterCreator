using RPGCharacterCreator.Core;

namespace RPGCharacterCreator.WVVM.ViewModel
{



    internal class MainViewModel : ObservableObject
    {
        public RelayCommand HomeViewCommand { get; set; }

        public RelayCommand BioViewCommand { get; set; }
        public RelayCommand ClassViewCommand { get; set; }
        public RelayCommand OverviewViewCommand { get; set; }


        public HomeViewModel homeVM { get; set; }

        public BioViewModel bioVM { get; set; }

        public ClassViewModel classVM { get; set; }

        public OverviewViewModel overviewVM { get; set; }

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



        public MainViewModel()
        {
            homeVM = new HomeViewModel();
            bioVM = new BioViewModel();
            classVM = new ClassViewModel();
            overviewVM = new OverviewViewModel(bioVM);

            CurrentView = homeVM;

            HomeViewCommand = new RelayCommand(o =>
            {
                CurrentView = homeVM;

            });

            BioViewCommand = new RelayCommand(o =>
            {
                CurrentView = bioVM;
            });


            ClassViewCommand = new RelayCommand(o =>
            {
                CurrentView = classVM;
            });

            OverviewViewCommand = new RelayCommand(o =>
            {

                CurrentView = overviewVM;
            });
        }
    }
}
