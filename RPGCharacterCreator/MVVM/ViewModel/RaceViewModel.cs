using System;
using RPGCharacterCreator.Core;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPGCharacterCreator.MVVM.Model;

namespace RPGCharacterCreator.MVVM.ViewModel
{
    internal class RaceViewModel : ObservableObject
    {
        public RelayCommand HumanButtonCommand { get; set; }
        public RelayCommand DwarfButtonCommand { get; set; }
        public RelayCommand ElfButtonCommand { get; set; }
        public RelayCommand OrcButtonCommand { get; set; }
        public RelayCommand HalflingButtonCommand { get; set; }
        public RelayCommand GnomeButtonCommand { get; set; }
        public RelayCommand GoblinButtonCommand { get; set; }
        public RelayCommand DragonButtonCommand { get; set; }
        public RelayCommand CyborgButtonCommand { get; set; }
        public RelayCommand FaerieButtonCommand { get; set; }

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

            ElfButtonCommand = new RelayCommand(o =>
            {
                ARace = new Elf();
                OnPropertyChanged();
            });

            OrcButtonCommand = new RelayCommand(o =>
            {
                ARace = new Orc();
                OnPropertyChanged();
            });

            HalflingButtonCommand = new RelayCommand(o =>
            {
                ARace = new Halfling();
                OnPropertyChanged();
            });

            GnomeButtonCommand = new RelayCommand(o =>
            {
                ARace = new Gnome();
                OnPropertyChanged();
            });

            GoblinButtonCommand = new RelayCommand(o =>
            {
                ARace = new Goblin();
                OnPropertyChanged();
            });

            DragonButtonCommand = new RelayCommand(o =>
            {
                ARace = new Dragon();
                OnPropertyChanged();
            });

            CyborgButtonCommand = new RelayCommand(o =>
            {
                ARace = new Cyborg();
                OnPropertyChanged();
            });

            FaerieButtonCommand = new RelayCommand(o =>
            {
                ARace = new Faerie();
                OnPropertyChanged();
            });
        }
    }
}
