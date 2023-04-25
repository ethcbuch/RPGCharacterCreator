using RPGCharacterCreator.Core;
using RPGCharacterCreator.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Xml;
using System.Xml.Serialization;

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
        public RelayCommand SkillsViewCommand { get; set; }
        public RelayCommand AlignmentViewCommand { get; set; }
        public RelayCommand OverviewViewCommand { get; set; }

        public RelayCommand CloseCommand { get; set; }
        public RelayCommand ThemeCommand { get; set; }

        //properties with type of view to to be shown(home,bio,class,overview)
        public HomeViewModel homeVM { get; set; }

        public BioViewModel bioVM { get; set; }
        public PortraitViewModel portraitVM { get; set; }
        public RaceViewModel raceVM { get; set; }

        public ClassViewModel classVM { get; set; }
        public BackgroundViewModel backgroundVM { get; set; }
        public StatsViewModel statsVM { get; set; }
        public SkillsViewModel skillsVM { get; set; }

        public OverviewViewModel overviewVM { get; set; }

        public AlignmentViewModel alignmentVM { get; set; }

        public ThemeFactory themeFactory { get; set; }

        private Theme _mainTheme;

        public Theme MainTheme
        {
            get { return _mainTheme; }
            set { _mainTheme = value; OnPropertyChanged(); }
        }


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
            skillsVM = new SkillsViewModel();
            alignmentVM = new AlignmentViewModel();
            overviewVM = new OverviewViewModel(bioVM, portraitVM, classVM, raceVM, backgroundVM, statsVM, alignmentVM, skillsVM);

            //Read from the xml file the characters created in previous sessions
            XmlSerializer xs = new XmlSerializer(typeof(ObservableCollection<GeneralCharacter>));

            if (File.Exists("characters.xml"))
            {
                using (StreamReader rd = new StreamReader("characters.xml"))
                {
                    homeVM.CharCollection = xs.Deserialize(rd) as ObservableCollection<GeneralCharacter>;
                }
            }
            else
            {
                XmlWriter xmlWriter = XmlWriter.Create("characters.xml");
            }


            characterCount = homeVM.CharCollection.Count;

            if (characterCount > 0)
            {
                homeVM.LabelVis = Visibility.Hidden;
            }

            //Sets default dark theme
            themeFactory = new ThemeFactory();

            MainTheme = themeFactory.createTheme("dark");
            homeVM.HomeTheme = themeFactory.createTheme("dark");
            bioVM.BioTheme = themeFactory.createTheme("dark");
            portraitVM.PortraitTheme = themeFactory.createTheme("dark");
            classVM.ClassTheme = themeFactory.createTheme("dark");
            raceVM.RaceTheme = themeFactory.createTheme("dark");
            backgroundVM.BackgroundTheme = themeFactory.createTheme("dark");
            alignmentVM.AlignmentTheme = themeFactory.createTheme("dark");
            statsVM.StatsTheme = themeFactory.createTheme("dark");
            skillsVM.SkillsTheme = themeFactory.createTheme("dark");
            overviewVM.OverviewTheme = themeFactory.createTheme("dark");

            builder = new GeneralCharacterBuilder();

            director = new CharacterDirector(builder);

            //the users view will be automatically be set to the homeVM
            CurrentView = homeVM;


            ThemeCommand = new RelayCommand(o =>
            {
                MainTheme = themeFactory.createTheme((string)o);
                homeVM.HomeTheme = themeFactory.createTheme((string)o);
                bioVM.BioTheme = themeFactory.createTheme((string)o);
                portraitVM.PortraitTheme = themeFactory.createTheme((string)o);
                classVM.ClassTheme = themeFactory.createTheme((string)o);
                raceVM.RaceTheme = themeFactory.createTheme((string)o);
                backgroundVM.BackgroundTheme = themeFactory.createTheme((string)o);
                alignmentVM.AlignmentTheme = themeFactory.createTheme((string)o);
                statsVM.StatsTheme = themeFactory.createTheme((string)o);
                skillsVM.SkillsTheme = themeFactory.createTheme((string)o);
                overviewVM.OverviewTheme = themeFactory.createTheme((string)o);
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

            RaceViewCommand = new RelayCommand(o =>
            {
                CurrentView = raceVM;
            });

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
                overviewVM.OverviewSkills = skillsVM.CharSkills;
                overviewVM.OverviewAbilites.CharAbilites = classVM.AClass.ClassAbilities;

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

            SkillsViewCommand = new RelayCommand(o =>
            {

                if (backgroundVM.ABackground != null)
                {
                    //if the background changes resets the skills menu.
                    if (backgroundVM.ABackground != skillsVM.ChosenBackground)
                    {
                        skillsVM.CharSkills = new Skills();
                        skillsVM.CharSkills.ChosenList = new ObservableCollection<string>(backgroundVM.ABackground.BackgroundSkills);

                        foreach (var item in skillsVM.CharSkills.ChosenList) { skillsVM.CharSkills.SkillsList.Remove(item); }
                    }

                }

                skillsVM.ChosenBackground = backgroundVM.ABackground;




                CurrentView = skillsVM;
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
                    skillsVM.CharSkills = homeVM.CharCollection[homeVM.currentCharacterIndex].characterSkills;
                    overviewVM.OverviewAbilites = homeVM.CharCollection[homeVM.currentCharacterIndex].characterAbilites;

                    overviewVM.FinishVis = Visibility.Hidden;
                    overviewVM.EditVis = Visibility.Visible;

                    CurrentView = bioVM;
                    ButtCancel = true;
                }

            });

            overviewVM.FinalizeButtonCommand = new RelayCommand(o =>
            {
                homeVM.CharCollection.Add(director.makeGeneralCharacter(builder, overviewVM.OverviewBio, overviewVM.OverviewPortrait, overviewVM.OverviewClass, overviewVM.OverviewRace, overviewVM.OverviewBackground, overviewVM.OverviewStats, overviewVM.OverviewAlignment, overviewVM.OverviewSkills, overviewVM.OverviewAbilites));

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
                overviewVM.OverviewSkills = new Skills();
                overviewVM.OverviewAbilites = new Abilites();


                bioVM.TempBio = new Bio();
                portraitVM.APortrait = new Portrait();
                classVM.AClass = new Class();
                raceVM.ARace = new Race();
                backgroundVM.ABackground = new Model.Background();
                statsVM.CharStats = new Stats();
                alignmentVM.AAlignment = new Alignment();
                skillsVM.CharSkills = new Skills();


                homeVM.LabelVis = Visibility.Hidden;

                CurrentView = homeVM;

                ButtCancel = false;
                ButtChecked = false;
            });

            overviewVM.FinalizeEditButtonCommand = new RelayCommand(o =>
            {
                homeVM.CharCollection[homeVM.currentCharacterIndex] = director.makeGeneralCharacter(builder, overviewVM.OverviewBio, overviewVM.OverviewPortrait, overviewVM.OverviewClass, overviewVM.OverviewRace, overviewVM.OverviewBackground, overviewVM.OverviewStats, overviewVM.OverviewAlignment, overviewVM.OverviewSkills, overviewVM.OverviewAbilites);

                director.getBuilder().reset();

                //resets everything for next character
                overviewVM.OverviewBio = new Bio();
                overviewVM.OverviewPortrait = new Portrait();
                overviewVM.OverviewClass = new Class();
                overviewVM.OverviewRace = new Race();
                overviewVM.OverviewBackground = new Model.Background();
                overviewVM.OverviewStats = new Stats();
                overviewVM.OverviewAlignment = new Alignment();
                overviewVM.OverviewSkills = new Skills();
                overviewVM.OverviewAbilites = new Abilites();


                bioVM.TempBio = new Bio();
                portraitVM.APortrait = new Portrait();
                classVM.AClass = new Class();
                raceVM.ARace = new Race();
                backgroundVM.ABackground = new Model.Background();
                statsVM.CharStats = new Stats();
                alignmentVM.AAlignment = new Alignment();
                skillsVM.CharSkills = new Skills();


                overviewVM.FinishVis = Visibility.Visible;
                overviewVM.EditVis = Visibility.Hidden;

                homeVM.LabelVis = Visibility.Hidden;

                CurrentView = homeVM;

                ButtCancel = false;
                ButtChecked = false;
            });


            CloseCommand = new RelayCommand(o =>
            {
                //Reads charCollection to xml file
                using (TextWriter writer = new StreamWriter("characters.xml"))
                {
                    xs.Serialize(writer, homeVM.CharCollection);
                }

                System.Windows.Application.Current.Shutdown();
            });





        }
    }
}
