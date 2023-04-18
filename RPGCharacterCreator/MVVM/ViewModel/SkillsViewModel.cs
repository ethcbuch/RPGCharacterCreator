using RPGCharacterCreator.Core;
using RPGCharacterCreator.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGCharacterCreator.MVVM.ViewModel
{
    class SkillsViewModel : ObservableObject
    {
        private Skills _charSkills;

        public Skills CharSkills
        {
            get { return _charSkills; }
            set
            {
                _charSkills = value;
                OnPropertyChanged();
            }
        }

        private Theme _skillsTheme;

        public Theme SkillsTheme
        {
            get { return _skillsTheme; }
            set { _skillsTheme = value; OnPropertyChanged(); }
        }
    }
}
