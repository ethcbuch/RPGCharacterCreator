using RPGCharacterCreator.Core;
using RPGCharacterCreator.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace RPGCharacterCreator.MVVM.ViewModel
{
    class SkillsViewModel : ObservableObject
    {

        public RelayCommand AddSkillCommand { get; set; }

        public RelayCommand RemoveSkillCommand { get; set; }

        private Skills _charSkills = new Skills();

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
        public SkillsViewModel()
        {
            AddSkillCommand = new RelayCommand(o =>
            {
                CharSkills.ChosenList.Add(CharSkills.SkillsList[(int)o]);
                CharSkills.SkillsList.RemoveAt((int)o);

                //Keeps everything is alphabetical order.
                var ob = CharSkills.ChosenList;

                var sorted = ob.OrderBy(n => n);

                ob = new ObservableCollection<string>(sorted);

                CharSkills.ChosenList = ob;

            });

            RemoveSkillCommand = new RelayCommand(o =>
            {
                CharSkills.SkillsList.Add(CharSkills.ChosenList[(int)o]);
                CharSkills.ChosenList.RemoveAt((int)o);

                //Keeps everything is alphabetical order.
                var ob = CharSkills.SkillsList;

                var sorted = ob.OrderBy(n => n);

                ob = new ObservableCollection<string>(sorted);

                CharSkills.SkillsList = ob;
            });
        }

    }
}
