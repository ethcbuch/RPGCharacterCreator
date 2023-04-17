using RPGCharacterCreator.Core;
using RPGCharacterCreator.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace RPGCharacterCreator.MVVM.ViewModel
{


    //class manages what view the user will see   
    internal class MainViewModel : ObservableObject
    {

        CharacterBuilder builder;

        CharacterDirector director;

        //properties of type RelayCommand,(connects button with action to be performed)
        public RelayCommand HomeViewCommand { get; set; }

        public RelayCommand BioViewCommand { get; set; }
        public RelayCommand PortraitViewCommand { get; set; }
        public RelayCommand ClassViewCommand { get; set; }
        public RelayCommand RaceViewCommand { get; set; }
        public RelayCommand BackgroundViewCommand { get; set; }
        public RelayCommand StatsViewCommand { get; set; }
        public RelayCommand AlignmentViewCommand { get; set; }
        public RelayCommand OverviewViewCommand { get; set; }

        public RelayCommand ThemeCommand { get; set; }

        //properties with type of view to to be shown(home,bio,class,overview)
        public HomeViewModel homeVM { get; set; }

        public BioViewModel bioVM { get; set; }
        public PortraitViewModel portraitVM { get; set; }
        public RaceViewModel raceVM { get; set; }

        public ClassViewModel classVM { get; set; }
        public BackgroundViewModel backgroundVM { get; set; }
        public StatsViewModel statsVM { get; set; }

        public OverviewViewModel overviewVM { get; set; }

        public AlignmentViewModel alignmentVM { get; set; }

        public ThemeFactory themeFactory { get; set; }

        public Theme theme { get; set; }

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

        private bool _buttChecked;
        public bool ButtChecked
        {
            get { return _buttChecked; }
            set
            {
                _buttChecked = value;
                OnPropertyChanged();
            }
        }

        int characterCount = 0;

        Portrait charPortrait = new Portrait();

        //constructor sets up main view
        public MainViewModel()
        {
            //creates instances of the views that user can see/select from
            homeVM = new HomeViewModel();
            bioVM = new BioViewModel();
            portraitVM = new PortraitViewModel();
            classVM = new ClassViewModel();
            raceVM = new RaceViewModel();
            backgroundVM = new BackgroundViewModel();
            statsVM = new StatsViewModel();
            alignmentVM = new AlignmentViewModel();
            overviewVM = new OverviewViewModel(bioVM, portraitVM, classVM, raceVM, backgroundVM, statsVM, alignmentVM);

            

            builder = new GeneralCharacterBuilder();

            director = new CharacterDirector(builder);

            //the users view will be automatically be set to the homeVM
            CurrentView = homeVM;


            ThemeCommand = new RelayCommand(o =>
            {
                theme = themeFactory.createTheme((string)o);
            });

            //lambda is ready to be called when button is clicked
            HomeViewCommand = new RelayCommand(o =>
            {
                CurrentView = homeVM;
                bioVM.TempBio = new Bio();
                portraitVM.APortrait = new Portrait();
                classVM.AClass = new Class();
                raceVM.ARace = new Race();
                backgroundVM.ABackground = new Model.Background();
                statsVM.CharStats = new Stats();
                alignmentVM.AAlignment = new Alignment();
                ButtCancel = false;

            });

            BioViewCommand = new RelayCommand(o =>
            {
                CurrentView = bioVM;
            });

            PortraitViewCommand = new RelayCommand(o =>
            {

                CurrentView = portraitVM;
            });

            RaceViewCommand = new RelayCommand(o => { CurrentView = raceVM; });

            ClassViewCommand = new RelayCommand(o =>
            {

                CurrentView = classVM;
            });

            OverviewViewCommand = new RelayCommand(o =>
            {
                overviewVM.OverviewBio = bioVM.TempBio;
                overviewVM.OverviewPortrait = portraitVM.APortrait;
                overviewVM.OverviewClass = classVM.AClass;
                overviewVM.OverviewRace = raceVM.ARace;
                overviewVM.OverviewBackground = backgroundVM.ABackground;
                overviewVM.OverviewAlignment = alignmentVM.AAlignment;
                overviewVM.OverviewStats = statsVM.CharStats;

                CurrentView = overviewVM;
            });

            homeVM.CreateCharacterCommand = new RelayCommand(o =>
            {
                CurrentView = bioVM;
                ButtCancel = true;
            });

            BackgroundViewCommand = new RelayCommand(o =>
            {
                CurrentView = backgroundVM;
            });

            StatsViewCommand = new RelayCommand(o =>
            {
                CurrentView = statsVM;
            });

            AlignmentViewCommand = new RelayCommand(o =>
            {
                CurrentView = alignmentVM;
            });

            homeVM.EditCharacterCommand = new RelayCommand(o =>
            {

                if (homeVM.currentCharacterIndex == -1)
                {
                    return;
                }
                else
                {
                    bioVM.TempBio = homeVM.CharCollection[homeVM.currentCharacterIndex].characterBio;
                    portraitVM.APortrait = homeVM.CharCollection[homeVM.currentCharacterIndex].characterPortrait;
                    classVM.AClass = homeVM.CharCollection[homeVM.currentCharacterIndex].characterClass;
                    raceVM.ARace = homeVM.CharCollection[homeVM.currentCharacterIndex].characterRace;
                    backgroundVM.ABackground = homeVM.CharCollection[homeVM.currentCharacterIndex].characterBackground;
                    statsVM.CharStats = homeVM.CharCollection[homeVM.currentCharacterIndex].characterStats;
                    alignmentVM.AAlignment = homeVM.CharCollection[homeVM.currentCharacterIndex].characterAlignment;


                    overviewVM.FinishVis = Visibility.Hidden;
                    overviewVM.EditVis = Visibility.Visible;

                    CurrentView = bioVM;
                    ButtCancel = true;
                }

            });

            overviewVM.FinalizeButtonCommand = new RelayCommand(o =>
            {
                homeVM.CharCollection.Add(director.makeGeneralCharacter(builder, overviewVM.OverviewBio, overviewVM.OverviewPortrait, overviewVM.OverviewClass, overviewVM.OverviewRace, overviewVM.OverviewBackground, overviewVM.OverviewStats, overviewVM.OverviewAlignment, characterCount));

                characterCount++;
                director.getBuilder().reset();

                //resets everything for next character
                overviewVM.OverviewBio = new Bio();
                overviewVM.OverviewPortrait = new Portrait();
                overviewVM.OverviewClass = new Class();
                overviewVM.OverviewRace = new Race();
                overviewVM.OverviewBackground = new Model.Background();
                overviewVM.OverviewStats = new Stats();
                overviewVM.OverviewAlignment = new Alignment();


                bioVM.TempBio = new Bio();
                portraitVM.APortrait = new Portrait();
                classVM.AClass = new Class();
                raceVM.ARace = new Race();
                backgroundVM.ABackground = new Model.Background();
                statsVM.CharStats = new Stats();
                alignmentVM.AAlignment = new Alignment();

                homeVM.LabelVis = Visibility.Hidden;

                CurrentView = homeVM;

                ButtCancel = false;
                ButtChecked = false;
            });

            overviewVM.FinalizeEditButtonCommand = new RelayCommand(o =>
            {
            homeVM.CharCollection[homeVM.currentCharacterIndex] = director.makeGeneralCharacter(builder, overviewVM.OverviewBio, overviewVM.OverviewPortrait, overviewVM.OverviewClass, overviewVM.OverviewRace, overviewVM.OverviewBackground, overviewVM.OverviewStats, overviewVM.OverviewAlignment, homeVM.currentCharacterIndex);

            //resets everything for next character
            overviewVM.OverviewBio = new Bio();
            overviewVM.OverviewPortrait = new Portrait();
            overviewVM.OverviewClass = new Class();
            overviewVM.OverviewRace = new Race();
            overviewVM.OverviewBackground = new Model.Background();
            overviewVM.OverviewStats = new Stats();
            overviewVM.OverviewAlignment = new Alignment();


            bioVM.TempBio = new Bio();
            portraitVM.APortrait = new Portrait();
            classVM.AClass = new Class();
            raceVM.ARace = new Race();
            backgroundVM.ABackground = new Model.Background();
            statsVM.CharStats = new Stats();
            alignmentVM.AAlignment = new Alignment();

            overviewVM.FinishVis = Visibility.Visible;
            overviewVM.EditVis = Visibility.Hidden;

            homeVM.LabelVis = Visibility.Hidden;

            CurrentView = homeVM;

            ButtCancel = false;
            ButtChecked = false;
        });

        }
}
}
