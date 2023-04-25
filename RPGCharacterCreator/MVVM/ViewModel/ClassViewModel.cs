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
                Rogue rogue = new Rogue();
                AClass = new Rogue();

                AClass.ClassAbilities = new ObservableCollection<string>(rogue.ClassAbilities);
            });

            //check

            PaladinButtonCommand = new RelayCommand(o =>
            {
                Paladin paladin = new Paladin();
                AClass = new Paladin();

                AClass.ClassAbilities = new ObservableCollection<string>(paladin.ClassAbilities);
            });

            RangerButtonCommand = new RelayCommand(o =>
            {
                Ranger ranger = new Ranger();
                AClass = new Ranger();

                AClass.ClassAbilities = new ObservableCollection<string>(ranger.ClassAbilities);
            });

            WizardButtonCommand = new RelayCommand(o =>
            {
                Wizard wizard = new Wizard();
                AClass = new Wizard();

                AClass.ClassAbilities = new ObservableCollection<string>(wizard.ClassAbilities);
            });

            BardButtonCommand = new RelayCommand(o =>
            {
                Bard bard = new Bard();
                AClass = new Bard();

                AClass.ClassAbilities = new ObservableCollection<string>(bard.ClassAbilities);
            });

            BarbarianButtonCommand = new RelayCommand(o =>
            {
                Barbarian barbarian = new Barbarian();
                AClass = new Barbarian();

                AClass.ClassAbilities = new ObservableCollection<string>(barbarian.ClassAbilities);
            });

            MonkButtonCommand = new RelayCommand(o =>
            {
                Monk monk = new Monk();
                AClass = new Monk();

                AClass.ClassAbilities = new ObservableCollection<string>(monk.ClassAbilities);
            });

            ClericButtonCommand = new RelayCommand(o =>
            {
                Cleric cleric = new Cleric();
                AClass = new Cleric();

                AClass.ClassAbilities = new ObservableCollection<string>(cleric.ClassAbilities);
            });

            DruidButtonCommand = new RelayCommand(o =>
            {
                Druid druid = new Druid();
                AClass = new Druid();

                AClass.ClassAbilities = new ObservableCollection<string>(druid.ClassAbilities);
            });


        }


    }
}
