﻿using RPGCharacterCreator.Core;

namespace RPGCharacterCreator.WVVM.ViewModel
{


    //class manages what view the user will see   
    internal class MainViewModel : ObservableObject
    {
        //properties of type RelayCommand,(connects button with action to be performed)
        public RelayCommand HomeViewCommand { get; set; }

        public RelayCommand BioViewCommand { get; set; }
        public RelayCommand ClassViewCommand { get; set; }
        public RelayCommand OverviewViewCommand { get; set; }


        //properties with type of view to to be shown(home,bio,class,overview)
        public HomeViewModel homeVM { get; set; }

        public BioViewModel bioVM { get; set; }

        public ClassViewModel classVM { get; set; }

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
            classVM = new ClassViewModel();
            overviewVM = new OverviewViewModel(bioVM, classVM);

            //the users view will be automatically be set to the homeVM
            CurrentView = homeVM;

            //lambda is ready to be called when button is clicked
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
