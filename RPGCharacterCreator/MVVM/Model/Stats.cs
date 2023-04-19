using RPGCharacterCreator.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGCharacterCreator.MVVM.Model
{
    public class Stats : ObservableObject
    {
        private int _strength = 50;

        public int Strength
        {
            get { return _strength; }
            set { _strength = value; OnPropertyChanged(); }
        }

        private int _dexterity = 50;

        public int Dexterity
        {
            get { return _dexterity; }
            set { _dexterity = value; OnPropertyChanged(); }
        }

        private int _intelligence = 50;

        public int Intelligence
        {
            get { return _intelligence; }
            set { _intelligence = value; OnPropertyChanged(); }
        }

        private int _wisdom = 50;

        public int Wisdom
        {
            get { return _wisdom; }
            set { _wisdom = value; OnPropertyChanged(); }
        }

        private int _constitution = 50;

        public int Constitution
        {
            get { return _constitution; }
            set { _constitution = value; OnPropertyChanged(); }
        }

        private int _charisma = 50;

        public int Charisma
        {
            get { return _charisma; }
            set { _charisma = value; OnPropertyChanged(); }
        }

        private int _luck = 50;

        public int Luck
        {
            get { return _luck; }
            set { _luck = value; OnPropertyChanged(); }
        }


    }
}
