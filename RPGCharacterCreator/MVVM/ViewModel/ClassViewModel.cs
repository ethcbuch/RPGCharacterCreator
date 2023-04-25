using RPGCharacterCreator.Core;
using RPGCharacterCreator.MVVM.Model;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;

namespace RPGCharacterCreator.MVVM.ViewModel
{
    internal class ClassViewModel : ObservableObject
    {

        public RelayCommand WarriorButtonCommand { get; set; }
        public RelayCommand RogueButtonCommand { get; set; }

        public RelayCommand PaladinButtonCommand { get; set; }
        public RelayCommand RangerButtonCommand { get; set; }
        public RelayCommand WizardButtonCommand { get; set; }
        public RelayCommand BardButtonCommand { get; set; }
        public RelayCommand BarbarianButtonCommand { get; set; }
        public RelayCommand MonkButtonCommand { get; set; }
        public RelayCommand ClericButtonCommand { get; set; }
        public RelayCommand DruidButtonCommand { get; set; }


        private Theme _classTheme;

        public Theme ClassTheme
        {
            get { return _classTheme; }
            set { _classTheme = value; OnPropertyChanged(); }
        }


        private Class _aClass = new Class();

        public Class AClass
        {
            get { return _aClass; }
            set
            {
                _aClass = value;
                OnPropertyChanged();
            }
        }


        public ClassViewModel()
        {

            WarriorButtonCommand = new RelayCommand(o =>
            {
                Warrior warrior = new Warrior();
                AClass = new Warrior();

                AClass.ClassAbilities = new ObservableCollection<string>(warrior.ClassAbilities);
            });

            RogueButtonCommand = new RelayCommand(o =>
            {
                AClass = new Rogue();
                OnPropertyChanged();
            });

            //check

            PaladinButtonCommand = new RelayCommand(o =>
            {
                AClass = new Paladin();
                OnPropertyChanged();
            });

            RangerButtonCommand = new RelayCommand(o =>
            {
                AClass = new Ranger();
                OnPropertyChanged();
            });

            WizardButtonCommand = new RelayCommand(o =>
            {
                AClass = new Wizard();
                OnPropertyChanged();
            });

            BardButtonCommand = new RelayCommand(o =>
            {
                AClass = new Bard();
                OnPropertyChanged();
            });

            BarbarianButtonCommand = new RelayCommand(o =>
            {
                AClass = new Barbarian();
                OnPropertyChanged();
            });

            MonkButtonCommand = new RelayCommand(o =>
            {
                AClass = new Monk();
                OnPropertyChanged();
            });

            ClericButtonCommand = new RelayCommand(o =>
            {
                AClass = new Cleric();
                OnPropertyChanged();
            });

            DruidButtonCommand = new RelayCommand(o =>
            {
                AClass = new Druid();
                OnPropertyChanged();
            });


        }


    }
}
