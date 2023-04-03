using RPGCharacterCreator.Core;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RPGCharacterCreator.WVVM.ViewModel
{
    class OverviewViewModel : ObservableObject
    {
        private Bio _overviewBio = new Bio();

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
        public OverviewViewModel(BioViewModel bioVM)
        {
            OverviewBio = bioVM.TempBio;
        }
    }
}
