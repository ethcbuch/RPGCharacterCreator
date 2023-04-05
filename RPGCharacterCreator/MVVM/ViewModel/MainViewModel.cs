using RPGCharacterCreator.Core;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace RPGCharacterCreator.MVVM.ViewModel
{


    //class manages what view the user will see   
    internal class MainViewModel :  ObservableObject
    { 

        CharacterBuilder builder;

        CharacterDirector director;

        public int characterCount = 0;


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

        private bool _buttCancel;
        public bool ButtCancel
        {
            get { return _buttCancel; }
            set
            {
                _buttCancel = value;
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


            builder = new GeneralCharacterBuilder();

            director = new CharacterDirector(builder);

            //the users view will be automatically be set to the homeVM
            CurrentView = homeVM;


            //lambda is ready to be called when button is clicked
            HomeViewCommand = new RelayCommand(o =>
            {
                CurrentView = homeVM;
                ButtCancel = false;

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
                overviewVM.OverviewClass = classVM.AClass;

                CurrentView = overviewVM;
            });

            homeVM.CreateCharacterCommand = new RelayCommand(o =>
            {
                CurrentView = bioVM;
                ButtCancel = true;
            });

            overviewVM.FinalizeButtonCommand = new RelayCommand(o =>
            {
                director.makeGeneralCharacter(builder, overviewVM.OverviewBio, overviewVM.OverviewClass);

                homeVM.characterDict.Add(builder.GetCharacter(), characterCount.ToString());
                characterCount++;


                CurrentView = homeVM;
                ButtCancel = false;
            });

        }
    }
}
