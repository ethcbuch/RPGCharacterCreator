using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPGCharacterCreator.Core;

namespace RPGCharacterCreator.WVVM.ViewModel
{

   

    internal class MainViewModel : ObservableObject
    {

        public RelayCommand BioViewCommand { get; set; }
        public RelayCommand ClassViewCommand { get; set; }

        public BioViewModel bioVm { get; set; }

        public ClassViewModel classVm { get; set; }

        private object _currentView;

        public object CurrentView
        {
            get
            {
                return _currentView;
            }
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            bioVm = new BioViewModel();
            classVm = new ClassViewModel();

            CurrentView = bioVm;

            BioViewCommand = new RelayCommand( o =>
            {
                CurrentView = bioVm;
            });

            ClassViewCommand = new RelayCommand(o =>
            {
                CurrentView = classVm;
            });
        }
    }
}
