using System;
using RPGCharacterCreator.Core;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPGCharacterCreator.MVVM.Model;

namespace RPGCharacterCreator.MVVM.ViewModel
{
    internal class RaceViewModel: ObservableObject
    {
        public RelayCommand HumanButtonCommand { get; set; }

        public RelayCommand DwarfButtonCommand { get; set; }

        private Race _aRace;

        public Race ARace
        {
            get { return _aRace; }
            set
            {
                _aRace = value;
                OnPropertyChanged();
            }
        }


        public RaceViewModel()
        {

            HumanButtonCommand = new RelayCommand(o =>
            {
                ARace = new Human();
                OnPropertyChanged();
            });

            DwarfButtonCommand = new RelayCommand(o =>
            {
                ARace = new Dwarf();
                OnPropertyChanged();
            });
        }
    }
}
