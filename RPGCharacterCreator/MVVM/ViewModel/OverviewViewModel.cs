using RPGCharacterCreator.Core;
using RPGCharacterCreator.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RPGCharacterCreator.MVVM.ViewModel
{
    class OverviewViewModel : ObservableObject
    {
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

        public OverviewViewModel(BioViewModel bioVM, ClassViewModel classVM,RaceViewModel raceVM)
        {
            OverviewBio = bioVM.TempBio;
            OverviewClass = classVM.AClass;
            OverviewRace = raceVM.ARace;


        }
    }
}
