using System;
using RPGCharacterCreator.Core;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPGCharacterCreator.MVVM.Model;
using System.Collections.ObjectModel;

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

        private Theme _raceTheme;

        public Theme RaceTheme
        {
            get { return _raceTheme; }
            set { _raceTheme = value; OnPropertyChanged(); }
        }

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
                Human human = new Human();
                ARace = new Human();

                ARace.RaceTraits = new ObservableCollection<string>(human.RaceTraits);
            });

            DwarfButtonCommand = new RelayCommand(o =>
            {
                Dwarf dwarf = new Dwarf();
                ARace = new Dwarf();

                ARace.RaceTraits = new ObservableCollection<string>(dwarf.RaceTraits);
            });

            ElfButtonCommand = new RelayCommand(o =>
            {
                Elf elf = new Elf();
                ARace = new Elf();

                ARace.RaceTraits = new ObservableCollection<string>(elf.RaceTraits);
                OnPropertyChanged();
            });

            OrcButtonCommand = new RelayCommand(o =>
            {
                Orc orc = new Orc();
                ARace = new Orc();

                ARace.RaceTraits = new ObservableCollection<string>(orc.RaceTraits);
                OnPropertyChanged();
            });

            HalflingButtonCommand = new RelayCommand(o =>
            {
                Halfling halfling = new Halfling();
                ARace = new Halfling();

                ARace.RaceTraits = new ObservableCollection<string>(halfling.RaceTraits);
                OnPropertyChanged();
            });

            GnomeButtonCommand = new RelayCommand(o =>
            {
                Gnome gnome = new Gnome();
                ARace = new Gnome();

                ARace.RaceTraits = new ObservableCollection<string>(gnome.RaceTraits);
                OnPropertyChanged();
            });

            GoblinButtonCommand = new RelayCommand(o =>
            {
                Goblin goblin = new Goblin();
                ARace = new Goblin();

                ARace.RaceTraits = new ObservableCollection<string>(goblin.RaceTraits);
                OnPropertyChanged();
            });

            DragonButtonCommand = new RelayCommand(o =>
            {
                Dragon dragon = new Dragon();
                ARace = new Dragon();

                ARace.RaceTraits = new ObservableCollection<string>(dragon.RaceTraits);
            });

            CyborgButtonCommand = new RelayCommand(o =>
            {
                Cyborg cyborg = new Cyborg();
                ARace = new Human();

                ARace.RaceTraits = new ObservableCollection<string>(cyborg.RaceTraits);
                OnPropertyChanged();
            });

            FaerieButtonCommand = new RelayCommand(o =>
            {
                Faerie faerie = new Faerie();
                ARace = new Faerie();

                ARace.RaceTraits = new ObservableCollection<string>(faerie.RaceTraits);
                OnPropertyChanged();
            });
        }
    }
}
