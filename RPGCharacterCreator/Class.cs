using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGCharacterCreator
{
    public class Class
    {
        string className;
        string classDescription;
        string primaryStats;
        string secondaryStats;

        public string getClassName() { return className; }
        public string getClassDescription() { return classDescription; }
        public string getPrimaryStats() { return primaryStats; }
        public string getSecondaryStats() { return secondaryStats; }

    }

    public class Warrior : Class
    {
        string className;
        string classDescription;
        string primaryStats;
        string secondaryStats;

        public Warrior()
        {
            className = "Warrior";
            classDescription = "placeholder";
            primaryStats = "Strength";
            secondaryStats = "Agility";

        }
    }
}
