using System.Collections.Generic;

namespace RPGCharacterCreator
{
    public abstract class Class
    {
        private string _className;
        private string _classDesciption;
        private List<string> _classPrimaryStats;
        private List<string> _classSecondaryStats;
        private List<string> _classSkills;
        private List<string> _classAbilities;

        public abstract string ClassName { get; set; }

        public abstract string ClassDescription { get; set; }
        public abstract List<string> ClassPrimaryStats
        {
            get; set;
        }
        public abstract List<string> ClassSecondaryStats
        {
            get; set;
        }
        public abstract List<string> ClassSkills
        {
            get; set;
        }
        public abstract List<string> ClassAbilities
        {
            get; set;
        }

    }

    public class Warrior : Class
    {
        private string _className = "Warrior";
        private string _classDesciption = "This guy fights on the front lines";
        private List<string> _classPrimaryStats = new List<string> { "Strength", "Constition" };
        private List<string> _classSecondaryStats = new List<string> { "Dexterity" };
        private List<string> _classSkills = new List<string> { "Athletics", };
        private List<string> _classAbilities = new List<string> { "Taunt", "Shield Bash" };

        public override string ClassName
        {
            get { return _className; }
            set { _className = value; }
        }

        public override string ClassDescription
        {
            get { return _classDesciption; }
            set { _classDesciption = value; }
        }

        public override List<string> ClassPrimaryStats
        {
            get { return _classPrimaryStats; }
            set { _classPrimaryStats = value; }
        }
        public override List<string> ClassSecondaryStats
        {
            get { return _classSecondaryStats; }
            set { _classSecondaryStats = value; }
        }

        public override List<string> ClassSkills
        {
            get { return _classSkills; }
            set { _classSkills = value; }
        }
        public override List<string> ClassAbilities
        {
            get { return _classAbilities; }
            set { _classAbilities = value; }
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

        public override string ClassName
        {
            get { return _className; }
            set { _className = value; }
        }

        public override string ClassDescription
        {
            get { return _classDesciption; }
            set { _classDesciption = value; }
        }

        public override List<string> ClassPrimaryStats
        {
            get { return _classPrimaryStats; }
            set { _classPrimaryStats = value; }
        }
        public override List<string> ClassSecondaryStats
        {
            get { return _classSecondaryStats; }
            set { _classSecondaryStats = value; }
        }

        public override List<string> ClassSkills
        {
            get { return _classSkills; }
            set { _classSkills = value; }
        }
        public override List<string> ClassAbilities
        {
            get { return _classAbilities; }
            set { _classAbilities = value; }
        }

    }
}
