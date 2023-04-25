using RPGCharacterCreator.Core;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;

namespace RPGCharacterCreator
{


    [XmlInclude(typeof(Warrior))]
    [XmlInclude(typeof(Rogue))]
    [XmlInclude(typeof(Paladin))]
    [XmlInclude(typeof(Ranger))]
    [XmlInclude(typeof(Wizard))]
    [XmlInclude(typeof(Bard))]
    [XmlInclude(typeof(Barbarian))]
    [XmlInclude(typeof(Monk))]
    [XmlInclude(typeof(Druid))]
    [XmlInclude(typeof(Cleric))]
    public class Class : ObservableObject
    {
        private string _className { get; set; }
        private string _classDesciption { get; set; }
        private ObservableCollection<string> _classPrimaryStats { get; set; }
        private ObservableCollection<string> _classSecondaryStats { get; set; }
        private ObservableCollection<string> _classSkills
        {
            get; set;
        }
        private ObservableCollection<string> _classAbilities
        {
            get; set;
        }

        public string ClassName { get { return _className; } set { _className = value; OnPropertyChanged(); } }
        public  string ClassDescription { get { return _classDesciption; } set { _classDesciption = value; OnPropertyChanged(); } }
        public ObservableCollection<string> ClassPrimaryStats { get { return _classPrimaryStats; } set { _classPrimaryStats = value; OnPropertyChanged(); } }
        public ObservableCollection<string> ClassSecondaryStats { get { return _classSecondaryStats; } set { _classSecondaryStats = value; OnPropertyChanged(); } }
        public ObservableCollection<string> ClassSkills { get { return _classSkills; } set { _classSkills = value; OnPropertyChanged(); } }
        public ObservableCollection<string> ClassAbilities { get { return _classAbilities; } set { _classAbilities = value; OnPropertyChanged(); } }
    }

    public class Warrior : Class
    {
        private string _className { get; set; } = "Warrior";
        private string _classDesciption { get; set; } = "This guy fights on the front lines";
        private ObservableCollection<string> _classPrimaryStats { get; set; } = new ObservableCollection<string> { "Strength", "Constition" };
        private ObservableCollection<string> _classSecondaryStats { get; set; } = new ObservableCollection<string> { "Dexterity" };
        private ObservableCollection<string> _classSkills { get; set; } = new ObservableCollection<string> { "Athletics", };
        private ObservableCollection<string> _classAbilities { get; set; } = new ObservableCollection<string> { "Taunt", "Shield Bash" };

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

        public new ObservableCollection<string> ClassPrimaryStats
        {
            get { return _classPrimaryStats; }
            set { _classPrimaryStats = value; OnPropertyChanged(); }
        }
        public new ObservableCollection<string> ClassSecondaryStats
        {
            get { return _classSecondaryStats; }
            set { _classSecondaryStats = value; OnPropertyChanged(); }
        }

        public new ObservableCollection<string> ClassSkills
        {
            get { return _classSkills; }
            set { _classSkills = value; OnPropertyChanged(); }
        }
        public new ObservableCollection<string> ClassAbilities
        {
            get { return _classAbilities; }
            set { _classAbilities = value; OnPropertyChanged(); }
        }

    }
    public class Rogue : Class
    {
        private string _className = "Rogue";
        private string _classDesciption = "This is one sneaky boi";
        private ObservableCollection<string> _classPrimaryStats = new ObservableCollection<string> { "Dexterity", "Luck" };
        private ObservableCollection<string> _classSecondaryStats = new ObservableCollection<string> { "Charisma" };
        private ObservableCollection<string> _classSkills = new ObservableCollection<string> { "Lockpicking", "Pickpocket" };
        private ObservableCollection<string> _classAbilities = new ObservableCollection<string> { "Critical Mastery", "Sneak Attack" };

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

        public new ObservableCollection<string> ClassPrimaryStats
        {
            get { return _classPrimaryStats; }
            set { _classPrimaryStats = value; }
        }
        public new ObservableCollection<string> ClassSecondaryStats
        {
            get { return _classSecondaryStats; }
            set { _classSecondaryStats = value; }
        }

        public new ObservableCollection<string> ClassSkills
        {
            get { return _classSkills; }
            set { _classSkills = value; }
        }
        public new ObservableCollection<string> ClassAbilities
        {
            get { return _classAbilities; }
            set { _classAbilities = value; }
        }

    }

    //class for Paladin (concrete class which inheirts from the Class class)
    public class Paladin : Class
    {
        private string _className { get; set; } = "Paladin";
        private string _classDesciption { get; set; } = "A holy knight, dedicated to righteousness and justice.";
        private ObservableCollection<string> _classPrimaryStats { get; set; } = new ObservableCollection<string> { "Strength", "Charisma" };
        private ObservableCollection<string> _classSecondaryStats { get; set; } = new ObservableCollection<string> { "Wisdom" };
        private ObservableCollection<string> _classSkills { get; set; } = new ObservableCollection<string> { "Religion", "Persuasion" };
        private ObservableCollection<string> _classAbilities { get; set; } = new ObservableCollection<string> { "Lay on Hands", "Divine Smite" };

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

        public new ObservableCollection<string> ClassPrimaryStats
        {
            get { return _classPrimaryStats; }
            set { _classPrimaryStats = value; OnPropertyChanged(); }
        }

        public new ObservableCollection<string> ClassSecondaryStats
        {
            get { return _classSecondaryStats; }
            set { _classSecondaryStats = value; OnPropertyChanged(); }
        }

        public new ObservableCollection<string> ClassSkills
        {
            get { return _classSkills; }
            set { _classSkills = value; OnPropertyChanged(); }
        }

        public new ObservableCollection<string> ClassAbilities
        {
            get { return _classAbilities; }
            set { _classAbilities = value; OnPropertyChanged(); }
        }
    }

    //class for Ranger (concrete class which inheirts from the Class class)
    public class Ranger : Class
    {
        private string _className { get; set; } = "Ranger";
        private string _classDesciption { get; set; } = "Skilled hunter and tracker.";
        private ObservableCollection<string> _classPrimaryStats { get; set; } = new ObservableCollection<string> { "Dexterity", "Wisdom" };
        private ObservableCollection<string> _classSecondaryStats { get; set; } = new ObservableCollection<string> { "Strength" };
        private ObservableCollection<string> _classSkills { get; set; } = new ObservableCollection<string> { "Survival", "Animal Handling" };
        private ObservableCollection<string> _classAbilities { get; set; } = new ObservableCollection<string> { "Favored Enemy", "Natural Explorer" };
            
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

        public new ObservableCollection<string> ClassPrimaryStats
        {
            get { return _classPrimaryStats; }
            set { _classPrimaryStats = value; OnPropertyChanged(); }
        }

        public new ObservableCollection<string> ClassSecondaryStats
        {
            get { return _classSecondaryStats; }
            set { _classSecondaryStats = value; OnPropertyChanged(); }
        }

        public new ObservableCollection<string> ClassSkills
        {
            get { return _classSkills; }
            set { _classSkills = value; OnPropertyChanged(); }
        }

        public new ObservableCollection<string> ClassAbilities
        {
            get { return _classAbilities; }
            set { _classAbilities = value; OnPropertyChanged(); }
        }
    }

    //class for Paladin (concrete class which inheirts from the Class class)
    public class Wizard : Class
    {
        private string _className { get; set; } = "Wizard";
        private string _classDesciption { get; set; } = "A master of arcane magic.";
        private ObservableCollection<string> _classPrimaryStats { get; set; } = new ObservableCollection<string> { "Intelligence", "Wisdom" };
        private ObservableCollection<string> _classSecondaryStats { get; set; } = new ObservableCollection<string> { "Constitution" };
        private ObservableCollection<string> _classSkills { get; set; } = new ObservableCollection<string> { "Arcana", "History" };
        private ObservableCollection<string> _classAbilities { get; set; } = new ObservableCollection<string> { "Spellcasting", "Arcane Recovery" };

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

        public new ObservableCollection<string> ClassPrimaryStats
        {
            get { return _classPrimaryStats; }
            set { _classPrimaryStats = value; OnPropertyChanged(); }
        }

        public new ObservableCollection<string> ClassSecondaryStats
        {
            get { return _classSecondaryStats; }
            set { _classSecondaryStats = value; OnPropertyChanged(); }
        }

        public new ObservableCollection<string> ClassSkills
        {
            get { return _classSkills; }
            set { _classSkills = value; OnPropertyChanged(); }
        }

        public new ObservableCollection<string> ClassAbilities
        {
            get { return _classAbilities; }
            set { _classAbilities = value; OnPropertyChanged(); }
        }
    }

    //class for Bard (concrete class which inheirts from the Class class)
    public class Bard : Class
    {
        private string _className { get; set; } = "Bard";
        private string _classDesciption { get; set; } = "A master of music, storytelling, and magic.";
        private ObservableCollection<string> _classPrimaryStats { get; set; } = new ObservableCollection<string> { "Charisma", "Dexterity" };
        private ObservableCollection<string> _classSecondaryStats { get; set; } = new ObservableCollection<string> { "Constitution" };
        private ObservableCollection<string> _classSkills { get; set; } = new ObservableCollection<string> { "Performance", "Persuasion" };
        private ObservableCollection<string> _classAbilities { get; set; } = new ObservableCollection<string> { "Spellcasting", "Bardic Inspiration" };

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

        public new ObservableCollection<string> ClassPrimaryStats
        {
            get { return _classPrimaryStats; }
            set { _classPrimaryStats = value; OnPropertyChanged(); }
        }

        public new ObservableCollection<string> ClassSecondaryStats
        {
            get { return _classSecondaryStats; }
            set { _classSecondaryStats = value; OnPropertyChanged(); }
        }

        public new ObservableCollection<string> ClassSkills
        {
            get { return _classSkills; }
            set { _classSkills = value; OnPropertyChanged(); }
        }

        public new ObservableCollection<string> ClassAbilities
        {
            get { return _classAbilities; }
            set { _classAbilities = value; OnPropertyChanged(); }
        }
    }

    //class for Barbarian (concrete class which inheirts from the Class class)
    public class Barbarian : Class
    {
        private string _className { get; set; } = "Barbarian";
        private string _classDesciption { get; set; } = "Wild savage who uses brute force and rage to overpower their enemies.";
        private ObservableCollection<string> _classPrimaryStats { get; set; } = new ObservableCollection<string> { "Strength", "Constitution" };
        private ObservableCollection<string> _classSecondaryStats { get; set; } = new ObservableCollection<string> { "Dexterity" };
        private ObservableCollection<string> _classSkills { get; set; } = new ObservableCollection<string> { "Intimidation", "Survival" };
        private ObservableCollection<string> _classAbilities { get; set; } = new ObservableCollection<string> { "Rage", "Reckless Attack" };

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

        public new ObservableCollection<string> ClassPrimaryStats
        {
            get { return _classPrimaryStats; }
            set { _classPrimaryStats = value; OnPropertyChanged(); }
        }
        public new ObservableCollection<string> ClassSecondaryStats
        {
            get { return _classSecondaryStats; }
            set { _classSecondaryStats = value; OnPropertyChanged(); }
        }

        public new ObservableCollection<string> ClassSkills
        {   
            get { return _classSkills; }
            set { _classSkills = value; OnPropertyChanged(); }
        }
        public new ObservableCollection<string> ClassAbilities
        {
            get { return _classAbilities; }
            set { _classAbilities = value; OnPropertyChanged(); }
        }
    }

    //class for Monk (concrete class which inheirts from the Class class)
    public class Monk : Class
    {
        private string _className { get; set; } = "Monk";
        private string _classDesciption { get; set; } = "Master of martial arts, using their training and discipline to defeat their foes.";
        private ObservableCollection<string> _classPrimaryStats { get; set; } = new ObservableCollection<string> { "Dexterity", "Wisdom" };
        private ObservableCollection<string> _classSecondaryStats { get; set; } = new ObservableCollection<string> { "Constitution" };
        private ObservableCollection<string> _classSkills { get; set; } = new ObservableCollection<string> { "Acrobatics", "Athletics" };
        private ObservableCollection<string> _classAbilities { get; set; } = new ObservableCollection<string> { "Flurry of Blows", "Deflect Missiles" };

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

        public new ObservableCollection<string> ClassPrimaryStats
        {
            get { return _classPrimaryStats; }
            set { _classPrimaryStats = value; OnPropertyChanged(); }
        }
        public new ObservableCollection<string> ClassSecondaryStats
        {
            get { return _classSecondaryStats; }
            set { _classSecondaryStats = value; OnPropertyChanged(); }
        }

        public new ObservableCollection<string> ClassSkills
        {
            get { return _classSkills; }
            set { _classSkills = value; OnPropertyChanged(); }
        }
        public new ObservableCollection<string> ClassAbilities
        {
            get { return _classAbilities; }
            set { _classAbilities = value; OnPropertyChanged(); }
        }
    }

    //class for Druid (concrete class which inheirts from the Class class)
    public class Druid : Class
    {
        private string _className { get; set; } = "Druid";
        private string _classDesciption { get; set; } = "A divine spellcaster who draws magic from the natural world";
        private ObservableCollection<string> _classPrimaryStats { get; set; } = new ObservableCollection<string> { "Wisdom", "Dexterity" };
        private ObservableCollection<string> _classSecondaryStats { get; set; } = new ObservableCollection<string> { "Constitution" };
        private ObservableCollection<string> _classSkills { get; set; } = new ObservableCollection<string> { "Animal Handling", "Nature","Survival" };
        private ObservableCollection<string> _classAbilities { get; set; } = new ObservableCollection<string> { "Wild Shape", "Nature Magic" };

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

        public new ObservableCollection<string> ClassPrimaryStats
        {
            get { return _classPrimaryStats; }
            set { _classPrimaryStats = value; OnPropertyChanged(); }
        }
        public new ObservableCollection<string> ClassSecondaryStats
        {
            get { return _classSecondaryStats; }
            set { _classSecondaryStats = value; OnPropertyChanged(); }
        }

        public new ObservableCollection<string> ClassSkills
        {
            get { return _classSkills; }
            set { _classSkills = value; OnPropertyChanged(); }
        }
        public new ObservableCollection<string> ClassAbilities
        {
            get { return _classAbilities; }
            set { _classAbilities = value; OnPropertyChanged(); }
        }
    }

    //class for Cleric (concrete class which inheirts from the Class class)
    public class Cleric : Class
    {
        private string _className { get; set; } = "Cleric";
        private string _classDesciption { get; set; } = "A holy spellcaster devoted to a particular deity.";
        private ObservableCollection<string> _classPrimaryStats { get; set; } = new ObservableCollection<string> { "Wisdom", "Charisma" };
        private ObservableCollection<string> _classSecondaryStats { get; set; } = new ObservableCollection<string> { "Strength" };
        private ObservableCollection<string> _classSkills { get; set; } = new ObservableCollection<string> { "History", "Insight","Medicine","Persuasion" };
        private ObservableCollection<string> _classAbilities { get; set; } = new ObservableCollection<string> { "Turn Undead", "Divine Magic" };

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

        public new ObservableCollection<string> ClassPrimaryStats
        {
            get { return _classPrimaryStats; }
            set { _classPrimaryStats = value; OnPropertyChanged(); }
        }
        public new ObservableCollection<string> ClassSecondaryStats
        {
            get { return _classSecondaryStats; }
            set { _classSecondaryStats = value; OnPropertyChanged(); }
        }

        public new ObservableCollection<string> ClassSkills
        {
            get { return _classSkills; }
            set { _classSkills = value; OnPropertyChanged(); }
        }
        public new ObservableCollection<string> ClassAbilities
        {
            get { return _classAbilities; }
            set { _classAbilities = value; OnPropertyChanged(); }
        }
    }
}
