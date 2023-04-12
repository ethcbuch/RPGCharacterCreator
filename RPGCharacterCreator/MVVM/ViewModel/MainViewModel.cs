﻿using RPGCharacterCreator.Core;
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
    internal class MainViewModel :  ObservableObject
    { 

        CharacterBuilder builder;

        CharacterDirector director;

        //properties of type RelayCommand,(connects button with action to be performed)
        public RelayCommand HomeViewCommand { get; set; }

        public RelayCommand BioViewCommand { get; set; }
        public RelayCommand ClassViewCommand { get; set; }
        public RelayCommand RaceViewCommand { get; set; }
        public RelayCommand BackgroundViewCommand { get; set; }
        public RelayCommand OverviewViewCommand { get; set; }


        //properties with type of view to to be shown(home,bio,class,overview)
        public HomeViewModel homeVM { get; set; }

        public BioViewModel bioVM { get; set; }
        public RaceViewModel raceVM { get; set; }

        public ClassViewModel classVM { get; set; }
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

        int characterCount = 0;

        //constructor sets up main view
        public MainViewModel()
        {
            //creates instances of the views that user can see/select from
            homeVM = new HomeViewModel();
            bioVM = new BioViewModel();
            classVM = new ClassViewModel();
            raceVM = new RaceViewModel();
            backgroundVM = new BackgroundViewModel();
            overviewVM = new OverviewViewModel(bioVM, classVM, raceVM, backgroundVM);
            CharacterViewModel characterVM = new CharacterViewModel(homeVM.currentCharacter);


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

            RaceViewCommand = new RelayCommand(o => { CurrentView = raceVM; });

            ClassViewCommand = new RelayCommand(o =>
            {

                CurrentView = classVM;
            });

            OverviewViewCommand = new RelayCommand(o =>
            {
                overviewVM.OverviewClass = classVM.AClass;
                overviewVM.OverviewRace = raceVM.ARace;
                overviewVM.OverviewBackground = backgroundVM.ABackground;

                CurrentView = overviewVM;
            });

            homeVM.CreateCharacterCommand = new RelayCommand(o =>
            {
                CurrentView = bioVM;
                ButtCancel = true;
            });

            BackgroundViewCommand = new RelayCommand(o => { CurrentView = backgroundVM; });


            overviewVM.FinalizeButtonCommand = new RelayCommand(o =>
            {
                homeVM.CharCollection.Add(director.makeGeneralCharacter(builder, overviewVM.OverviewBio, overviewVM.OverviewClass, overviewVM.OverviewRace, overviewVM.OverviewBackground, characterCount));
                
                characterCount++;
                director.getBuilder().reset();

                //resets everything for next character
                overviewVM.OverviewBio = new Bio();
                overviewVM.OverviewClass = new Class();
                overviewVM.OverviewRace = new Race();
                overviewVM.OverviewBackground = new Model.Background();
                classVM.AClass = new Class();
                bioVM.TempBio = new Bio();
                raceVM.ARace = new Race();
                backgroundVM.ABackground = new Model.Background();

                CurrentView = homeVM;
                ButtCancel = false;
            });

            homeVM.ChangeCharacterCommand = new RelayCommand(parameter =>
            {
                homeVM.currentCharacter = homeVM.CharCollection[(int)parameter];
                characterVM.currentCharacter = homeVM.CharCollection[(int)parameter];

                if (homeVM.ChildView != characterVM)
                {
    
                    homeVM.ChildView = characterVM;
                }
                else
                    characterVM = new CharacterViewModel(homeVM.currentCharacter);


            });
        }
    }
}
