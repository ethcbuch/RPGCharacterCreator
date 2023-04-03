using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGCharacterCreator
{
    public class Class
    {
        private string _className;
        private string _classDesciption;
        private List<string> _classPrimaryStats;
        private List<string> _classSecondaryStats;
        private List<string> _classSkills;
        private List<string> _classAbilities;

        public string ClassName
        {
            get { return _className; }
            set { _className = value; }
        }

        public string ClassDescription
        {
            get { return _classDesciption; }
            set { _classDesciption = value; }
        }

        public List<string> ClassPrimaryStats
        {
            get { return _classPrimaryStats; }
            set { _classPrimaryStats = value; }
        }
        public List<string> ClassSecondaryStats
        {
            get { return _classSecondaryStats; }
            set { _classSecondaryStats = value; }
        }
        public List<string> ClassSkills
        {
            get { return _classSkills; }
            set { _classSkills = value; }
        }
        public List<string> ClassAbilities
        {
            get { return _classAbilities; }
            set { _classAbilities = value; }
        }

    }

    public class Warrior : Class
    {
        private string _className = "Warrior";
        private string _classDesciption = "This guy fights on the front lines";
        private List<string> _classPrimaryStats = new List<string> { "Strength", "Constition" };
        private List<string> _classSecondaryStats = new List<string> { "Dexterity"};
        private List<string> _classSkills = new List<string> { "Athletics", };
        private List<string> _classAbilities = new List<string> { "Taunt" };

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
