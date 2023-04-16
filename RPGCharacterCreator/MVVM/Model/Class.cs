using RPGCharacterCreator.Core;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace RPGCharacterCreator
{
    internal class Class : ObservableObject
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

    internal class Warrior : Class
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

    internal class Rogue : Class
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


    internal class Paladin : Class
    {
        private string _className { get; set; } = "Paladin";
        private string _classDesciption { get; set; } = "A holy knight, dedicated to righteousness and justice.";
        private List<string> _classPrimaryStats { get; set; } = new List<string> { "Strength", "Charisma" };
        private List<string> _classSecondaryStats { get; set; } = new List<string> { "Wisdom" };
        private List<string> _classSkills { get; set; } = new List<string> { "Religion", "Persuasion" };
        private List<string> _classAbilities { get; set; } = new List<string> { "Lay on Hands", "Divine Smite" };

        public new string ClassName
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


    internal class Ranger : Class
    {
        private string _className { get; set; } = "Ranger";
        private string _classDesciption { get; set; } = "Skilled hunter and tracker.";
        private List<string> _classPrimaryStats { get; set; } = new List<string> { "Dexterity", "Wisdom" };
        private List<string> _classSecondaryStats { get; set; } = new List<string> { "Strength" };
        private List<string> _classSkills { get; set; } = new List<string> { "Survival", "Animal Handling" };
        private List<string> _classAbilities { get; set; } = new List<string> { "Favored Enemy", "Natural Explorer" };

        public new string ClassName
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


    internal class Wizard : Class
    {
        private string _className { get; set; } = "Wizard";
        private string _classDesciption { get; set; } = "A master of arcane magic.";
        private List<string> _classPrimaryStats { get; set; } = new List<string> { "Intelligence", "Wisdom" };
        private List<string> _classSecondaryStats { get; set; } = new List<string> { "Constitution" };
        private List<string> _classSkills { get; set; } = new List<string> { "Arcana", "History" };
        private List<string> _classAbilities { get; set; } = new List<string> { "Spellcasting", "Arcane Recovery" };

        public new string ClassName
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


    internal class Bard : Class
    {
        private string _className { get; set; } = "Bard";
        private string _classDesciption { get; set; } = "A master of music, storytelling, and magic.";
        private List<string> _classPrimaryStats { get; set; } = new List<string> { "Charisma", "Dexterity" };
        private List<string> _classSecondaryStats { get; set; } = new List<string> { "Constitution" };
        private List<string> _classSkills { get; set; } = new List<string> { "Performance", "Persuasion" };
        private List<string> _classAbilities { get; set; } = new List<string> { "Spellcasting", "Bardic Inspiration" };

        public new string ClassName
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

    internal class Barbarian : Class
    {
        private string _className { get; set; } = "Barbarian";
        private string _classDesciption { get; set; } = "Wild savage who uses brute force and rage to overpower their enemies.";
        private List<string> _classPrimaryStats { get; set; } = new List<string> { "Strength", "Constitution" };
        private List<string> _classSecondaryStats { get; set; } = new List<string> { "Dexterity" };
        private List<string> _classSkills { get; set; } = new List<string> { "Intimidation", "Survival" };
        private List<string> _classAbilities { get; set; } = new List<string> { "Rage", "Reckless Attack" };

        public new string ClassName
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

    internal class Monk : Class
    {
        private string _className { get; set; } = "Monk";
        private string _classDesciption { get; set; } = "Master of martial arts, using their training and discipline to defeat their foes.";
        private List<string> _classPrimaryStats { get; set; } = new List<string> { "Dexterity", "Wisdom" };
        private List<string> _classSecondaryStats { get; set; } = new List<string> { "Strength" };
        private List<string> _classSkills { get; set; } = new List<string> { "Acrobatics", "Athletics" };
        private List<string> _classAbilities { get; set; } = new List<string> { "Flurry of Blows", "Deflect Missiles" };

        public new string ClassName
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

    internal class Druid : Class
    {
        private string _className { get; set; } = "Druid";
        private string _classDesciption { get; set; } = "A divine spellcaster who draws magic from the natural world";
        private List<string> _classPrimaryStats { get; set; } = new List<string> { "Wisdom", "Dexterity" };
        private List<string> _classSecondaryStats { get; set; } = new List<string> { "Constitution" };
        private List<string> _classSkills { get; set; } = new List<string> { "Animal Handling", "Nature","Survival" };
        private List<string> _classAbilities { get; set; } = new List<string> { "Wild Shape", "Nature Magic" };

        public new string ClassName
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

    internal class Cleric : Class
    {
        private string _className { get; set; } = "Cleric";
        private string _classDesciption { get; set; } = "A holy spellcaster devoted to a particular deity.";
        private List<string> _classPrimaryStats { get; set; } = new List<string> { "Wisdom", "Charisma" };
        private List<string> _classSecondaryStats { get; set; } = new List<string> { "Consitution" };
        private List<string> _classSkills { get; set; } = new List<string> { "History", "Insight","Medicine","Persuasion" };
        private List<string> _classAbilities { get; set; } = new List<string> { "Turn Undead", "Divine Magic" };

        public new string ClassName
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



































}
