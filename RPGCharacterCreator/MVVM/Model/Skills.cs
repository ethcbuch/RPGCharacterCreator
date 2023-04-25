using RPGCharacterCreator.Core;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace RPGCharacterCreator.MVVM.Model
{
    public class Skills : ObservableObject
    {


        private ObservableCollection<string> _skillsList { get; set; } = new ObservableCollection<string> { "Acrobatics", "Animal Handling", "Arcana", "Athletics", "Deception", "History", "Insight", "Intimidation", "Investigation", 
			                                                                                                "Medicine", "Nature", "Perception", "Performance", "Persuasion", "Religion", "Sleight of Hand", "Stealth", "Survival" };

		public ObservableCollection<string> SkillsList
		{
			get { return _skillsList; }
			set { _skillsList = value; OnPropertyChanged(); }
		}

        private ObservableCollection<string> _chosenList { get; set; } = new ObservableCollection<string>();

        public ObservableCollection<string> ChosenList
        {
            get { return _chosenList; }
            set { _chosenList = value; OnPropertyChanged(); }
        }


    }
}
