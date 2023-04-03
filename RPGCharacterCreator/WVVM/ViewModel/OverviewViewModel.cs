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

        public OverviewViewModel(BioViewModel bioVM, ClassViewModel classVM)
        {
            OverviewBio = bioVM.TempBio;
            OverviewClass = classVM.AClass;

        }
    }
}
