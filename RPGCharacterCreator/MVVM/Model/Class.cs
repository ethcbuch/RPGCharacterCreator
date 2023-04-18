using RPGCharacterCreator.Core;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace RPGCharacterCreator
{
    public class Class : ObservableObject
    {
        private string _className { get; set; }
        private string _classDesciption { get; set; }
        private List<string> _classPrimaryStats { get; set; }
        private List<string> _classSecondaryStats { get; set; }
        private List<string> _classSkills
        {
            get; set;
        }
        private List<string> _classAbilities
        {
            get; set;
        }

        public string ClassName { get { return _className; } set { _className = value; OnPropertyChanged(); } }
        public  string ClassDescription { get { return _className; } set { _className = value; OnPropertyChanged(); } }
        public  List<string> ClassPrimaryStats { get { return _classPrimaryStats; } set { _classPrimaryStats = value; OnPropertyChanged(); } }
        public  List<string> ClassSecondaryStats { get { return _classSecondaryStats; } set { _classSecondaryStats = value; OnPropertyChanged(); } }
        public  List<string> ClassSkills { get { return _classSkills; } set { _classSkills = value; OnPropertyChanged(); } }
        public  List<string> ClassAbilities { get { return _classAbilities; } set { _classAbilities = value; OnPropertyChanged(); } }
    }

    public class Warrior : Class
    {
        private string _className { get; set; } = "Warrior";
        private string _classDesciption { get; set; } = "This guy fights on the front lines";
        private List<string> _classPrimaryStats { get; set; } = new List<string> { "Strength", "Constition" };
        private List<string> _classSecondaryStats { get; set; } = new List<string> { "Dexterity" };
        private List<string> _classSkills { get; set; } = new List<string> { "Athletics", };
        private List<string> _classAbilities { get; set; } = new List<string> { "Taunt", "Shield Bash" };

        public new  string ClassName
        {
            get { return _className; }
            set { _className = value; }
        }

        public new string ClassDescription
        {
            get { return _classDesciption; }
            set { _classDesciption = value; OnPropertyChanged(); }
        }

        public new List<string> ClassPrimaryStats
        {
            get { return _classPrimaryStats; }
            set { _classPrimaryStats = value; OnPropertyChanged(); }
        }
        public new List<string> ClassSecondaryStats
        {
            get { return _classSecondaryStats; }
            set { _classSecondaryStats = value; OnPropertyChanged(); }
        }

        public new List<string> ClassSkills
        {
            get { return _classSkills; }
            set { _classSkills = value; OnPropertyChanged(); }
        }
        public new List<string> ClassAbilities
        {
            get { return _classAbilities; }
            set { _classAbilities = value; OnPropertyChanged(); }
        }

    }
    public class Rogue : Class
    {
        private string _className = "Rogue";
        private string _classDesciption = "This is one sneaky boi";
        private List<string> _classPrimaryStats = new List<string> { "Dexterity", "Luck" };
        private List<string> _classSecondaryStats = new List<string> { "Charisma" };
        private List<string> _classSkills = new List<string> { "Lockpicking", "Pickpocket" };
        private List<string> _classAbilities = new List<string> { "Critical Mastery", "Sneak Attack" };

        public new string ClassName
        {
            get { return _className; }
            set { _className = value; }
        }

        public new string ClassDescription
        {
            get { return _classDesciption; }
            set { _classDesciption = value; }
        }

        public new List<string> ClassPrimaryStats
        {
            get { return _classPrimaryStats; }
            set { _classPrimaryStats = value; }
        }
        public new List<string> ClassSecondaryStats
        {
            get { return _classSecondaryStats; }
            set { _classSecondaryStats = value; }
        }

        public new List<string> ClassSkills
        {
            get { return _classSkills; }
            set { _classSkills = value; }
        }
        public new List<string> ClassAbilities
        {
            get { return _classAbilities; }
            set { _classAbilities = value; }
        }

    }
}
