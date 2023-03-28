using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGCharacterCreator
{
    internal class GeneralCharacter
    {
        string charName;
        string charBirthday;
        string charGender;
        string charAge;
        string charBio;

        internal GeneralCharacter(string charName, string charBirthday, string charGender, string charAge, string charBio)
        {
            this.charName = charName;
            this.charBirthday = charBirthday;
            this.charGender = charGender;
            this.charAge = charAge;
            this.charBio = charBio;
        }

        internal class Class
        {
            string className;
            string classDescription;
            string primaryStats;
            string secondaryStats;

            string getClassName() { return className; }
            public string getClassDescription() { return classDescription;} 
            public string getPrimaryStats() {  return primaryStats; }

            public string getSecondaryStats() {  return secondaryStats;}

        }

        class Warrior : Class
        {
            string className;
            string classDescription;
            string primaryStats;
            string secondaryStats;

            public Warrior() 
            {
                className = "Warrior";

            }
        }
    }

    public enum Classes
    {
        Warrior
    }

    interface CharacterBuilder
    {
        void reset();

        void buildBio();

        void buildPortrait();

        void buildClass(Classes aClass);

        void buildRace();

        void buildBackground();

        void buildStats();

        void buildSkills();

        void buildAlignment();
        
    }
}
