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
        private string _classDesciption = "Bad";
        private List<string> _classPrimaryStats;
        private List<string> _classSecondaryStats;

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

    }

    public class Warrior : Class
    {
        private string _className = "Warrior";
        private string _classDesciption = "This guy fights on the front lines";
        private List<string> _classPrimaryStats = new List<string> { "Strength", "Constition" };
        private List<string> _classSecondaryStats = new List<string> { "Dexterity"};

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

    }
}
