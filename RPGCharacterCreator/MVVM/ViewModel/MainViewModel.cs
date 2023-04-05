using RPGCharacterCreator.Core;

namespace RPGCharacterCreator.MVVM.ViewModel
{


    //class manages what view the user will see   
    internal class MainViewModel : ObservableObject
    {
        //properties of type RelayCommand,(connects button with action to be performed)
        public RelayCommand HomeViewCommand { get; set; }

        public RelayCommand BioViewCommand { get; set; }
        //added
        public RelayCommand RaceViewCommand { get; set; }
        public RelayCommand ClassViewCommand { get; set; }
        //added
        public RelayCommand BackgroundViewCommand { get; set; }
        public RelayCommand OverviewViewCommand { get; set; }


        //properties with type of view to to be shown(home,bio,class,overview)
        public HomeViewModel homeVM { get; set; }

        public BioViewModel bioVM { get; set; }
        //added this
        public RaceViewModel raceVM { get; set; }

        public ClassViewModel classVM { get; set; }
        //added this in
        public BackgroundViewModel backgroundVM { get; set; }

        public OverviewViewModel overviewVM { get; set; }

        // _currentView of type object(allows for the storing of any type)
        private object _currentView;

        public object CurrentView
        {
            //returns the current view object is on
            get
            {
                return _currentView;
            }
            //sets _currentView to value (whatever its set to) and calls the OnPropertyChange()
            set
            {
                _currentView = value;
                //notifies that there has been changes
                OnPropertyChanged();
            }
        }


        //constructor sets up main view
        public MainViewModel()
        {
            //creates instances of the views that user can see/select from
            homeVM = new HomeViewModel();
            bioVM = new BioViewModel();
            //added raceVM
            raceVM = new RaceViewModel();
            classVM = new ClassViewModel();
            //ADDED THIS IN
            backgroundVM = new BackgroundViewModel();
            overviewVM = new OverviewViewModel(bioVM, classVM,raceVM,backgroundVM);

            //the users view will be automatically be set to the homeVM
            CurrentView = homeVM;

            //lambda is ready to be called when button is clicked
            HomeViewCommand = new RelayCommand(o =>{CurrentView = homeVM;});
            BioViewCommand = new RelayCommand(o =>{CurrentView = bioVM;});
            //added
            RaceViewCommand = new RelayCommand(o =>{CurrentView = raceVM;});

            ClassViewCommand = new RelayCommand(o =>
            {
                CurrentView = classVM;
            });
            BackgroundViewCommand = new RelayCommand(o => { CurrentView = backgroundVM; });

            OverviewViewCommand = new RelayCommand(o =>
            {
                //added raceVM
                overviewVM = new OverviewViewModel(bioVM, classVM,raceVM, backgroundVM);
                CurrentView = overviewVM;
            });
        }
    }
}
