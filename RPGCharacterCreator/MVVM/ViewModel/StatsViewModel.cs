using RPGCharacterCreator.Core;
using RPGCharacterCreator.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGCharacterCreator.MVVM.ViewModel
{
    class StatsViewModel : ObservableObject
    {

        public RelayCommand AddStrengthCommand { get; set; }
        public RelayCommand SubtractStrengthCommand { get; set; }
        public RelayCommand AddDexterityCommand { get; set; }
        public RelayCommand SubtractDexterityCommand { get; set; }
        public RelayCommand AddIntelligenceCommand { get; set; }
        public RelayCommand SubtractIntelligenceCommand { get; set; }
        public RelayCommand AddWisdomCommand { get; set; }
        public RelayCommand SubtractWisdomCommand { get; set; }
        public RelayCommand AddConstitutionCommand { get; set; }
        public RelayCommand SubtractConstitutionCommand { get; set; }
        public RelayCommand AddCharismaCommand { get; set; }
        public RelayCommand SubtractCharismaCommand { get; set; }
        public RelayCommand AddLuckCommand { get; set; }
        public RelayCommand SubtractLuckCommand { get; set; }

        private Theme _statsTheme;

        public Theme StatsTheme
        {
            get { return _statsTheme; }
            set { _statsTheme = value; }
        }

        private Stats _charStats = new Stats();

        public Stats CharStats
        {
            get
            {
                return _charStats;
            }
            set
            {
                _charStats = value;
                OnPropertyChanged();
            }
        }

        public StatsViewModel()
        {
            AddStrengthCommand = new RelayCommand(o =>
            {
                CharStats.Strength++;
                OnPropertyChanged();
            });
            SubtractStrengthCommand = new RelayCommand(o =>
            {
                if (CharStats.Strength > 0) 
                {
                    CharStats.Strength--;
                    OnPropertyChanged();
                }
            });

            AddDexterityCommand = new RelayCommand(o =>
            {
                CharStats.Dexterity++;
                OnPropertyChanged();
            });
            SubtractDexterityCommand = new RelayCommand(o =>
            {
                if (CharStats.Dexterity > 0)
                {
                    CharStats.Dexterity--;
                    OnPropertyChanged();
                }
            });

            AddIntelligenceCommand = new RelayCommand(o =>
            {
                CharStats.Intelligence++;
                OnPropertyChanged();
            });
            SubtractIntelligenceCommand = new RelayCommand(o =>
            {
                if (CharStats.Intelligence > 0)
                {
                    CharStats.Intelligence--;
                    OnPropertyChanged();
                }
            });

            AddWisdomCommand = new RelayCommand(o =>
            {
                CharStats.Wisdom++;
                OnPropertyChanged();
            });
            SubtractWisdomCommand = new RelayCommand(o =>
            {
                if (CharStats.Wisdom > 0)
                {
                    CharStats.Wisdom--;
                    OnPropertyChanged();
                }
            });

            AddConstitutionCommand = new RelayCommand(o =>
            {
                CharStats.Constitution++;
                OnPropertyChanged();
            });
            SubtractConstitutionCommand = new RelayCommand(o =>
            {
                if (CharStats.Constitution > 0)
                {
                    CharStats.Constitution--;
                    OnPropertyChanged();
                }
            });

            AddCharismaCommand = new RelayCommand(o =>
            {
                CharStats.Charisma++;
                OnPropertyChanged();
            });
            SubtractCharismaCommand = new RelayCommand(o =>
            {
                if (CharStats.Charisma > 0)
                {
                    CharStats.Charisma--;
                    OnPropertyChanged();
                }
            });

            AddLuckCommand = new RelayCommand(o =>
            {
                CharStats.Luck++;
                OnPropertyChanged();
            });
            SubtractLuckCommand = new RelayCommand(o =>
            {
                if (CharStats.Luck > 0)
                {
                    CharStats.Luck--;
                    OnPropertyChanged();
                }
            });

        }
    }
}
