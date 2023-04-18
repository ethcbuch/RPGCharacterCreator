using RPGCharacterCreator.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace RPGCharacterCreator.MVVM.Model
{
    public class Skills : ObservableObject
    {


        private List<string> _skillsList { get; set; } = new List<string> { "Acrobatics", "Animal Handling", "Arcana", "Athletics", "Deception", "History", "Insight", "Intimidation", "Investigation", 
			                                                            "Medicine", "Nature", "Perception", "Performance", "Persuasion", "Religion", "Sleight of Hand", "Stealth", "Survival" };

		public List<string> SkillsList
		{
			get { return _skillsList; }
			set { _skillsList = value; OnPropertyChanged(); }
		}

        private List<string> _chosenList { get; set; } = new List<string> { "Fat"};

        public List<string> ChosenList
        {
            get { return _chosenList; }
            set { _chosenList = value; OnPropertyChanged(); }
        }


    }
}
