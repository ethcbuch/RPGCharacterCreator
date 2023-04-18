using RPGCharacterCreator.Core;
using RPGCharacterCreator.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace RPGCharacterCreator.MVVM.ViewModel
{
    internal class OverviewViewModel : ObservableObject
    {
        public RelayCommand FinalizeButtonCommand { get; set; }

        public RelayCommand FinalizeEditButtonCommand { get; set; }

        private Theme _overviewTheme;

        public Theme OverviewTheme
        {
            get { return _overviewTheme; }
            set { _overviewTheme = value; OnPropertyChanged(); }
        }

        private Visibility _editVis = Visibility.Hidden;
        public Visibility EditVis
        {
            get { return _editVis; }
            set
            {
                _editVis = value;
                OnPropertyChanged();
            }
        }

        private Visibility _finishVis = Visibility.Visible;
        public Visibility FinishVis
        {
            get { return _finishVis; }
            set
            {
                _finishVis = value;
                OnPropertyChanged();
            }
        }

        private Bio _overviewBio;

        public Bio OverviewBio
        {
            get
            {
                return _overviewBio;
            }
            set
            {
                _overviewBio = value;
                OnPropertyChanged();
            }
        }

        private Portrait _overviewPortrait;

        public Portrait OverviewPortrait
        {
            get
            {
                return _overviewPortrait;
            }
            set
            {
                _overviewPortrait = value;
                OnPropertyChanged();
            }
        }

        private Class _overviewClass;

        public Class OverviewClass
        {
            get
            {
                return _overviewClass;
            }
            set
            {
                _overviewClass = value;
                OnPropertyChanged();
            }
        }

        private Race _overviewRace;
        public Race OverviewRace
        {
            get
            {
                return _overviewRace; 
            }
            set
            {
                _overviewRace = value;
                OnPropertyChanged();
            }
        }

        //added 
        private Background _overviewBackground;
        public Background OverviewBackground
        {
            get 
            {
                return _overviewBackground; 
            }
            set 
            { 
                _overviewBackground = value; 
                OnPropertyChanged(); 
            }
        }
        private Stats _overviewStats;

        public Stats OverviewStats
        {
            get
            {
                return _overviewStats;
            }
            set
            {
                _overviewStats = value;
                OnPropertyChanged();
            }
        }

        private Alignment _overviewAlignment;
        public Alignment OverviewAlignment
        {
            get
            { 
                return _overviewAlignment; 
            }
            set 
            { 
                _overviewAlignment = value; 
                OnPropertyChanged(); 
            }
        }

        public OverviewViewModel(BioViewModel bioVM, PortraitViewModel portraitVM, ClassViewModel classVM, RaceViewModel raceVM, BackgroundViewModel backgroundVM, StatsViewModel statsVM, AlignmentViewModel alignmentVM)
        {
            OverviewBio = bioVM.TempBio;
            OverviewPortrait = portraitVM.APortrait;
            OverviewClass = classVM.AClass;
            OverviewRace = raceVM.ARace;
            OverviewBackground = backgroundVM.ABackground;
            OverviewStats = statsVM.CharStats;
            OverviewAlignment = alignmentVM.AAlignment;
        }
    }
}
