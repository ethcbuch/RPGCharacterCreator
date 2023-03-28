using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace RPGCharacterCreator
{
    internal class GeneralCharacter
    {
        Bio characterBio;
        Class characterClass;


        internal class Bio
        {
            string charName;
            string charBirthday;
            string charGender;
            string charAge;
            string charBio;
            
            public string getCharName () { return charName; }

            public string getCharBirthday() { return charBirthday; }

            public string getCharGender() { return charGender; }

            public string getCharAge() { return charAge; }

            public string getCharBio() { return charBio; }
        }

        internal class Class
        {
            string className;
            string classDescription;
            string primaryStats;
            string secondaryStats;

            public string getClassName() { return className; }
            public string getClassDescription() { return classDescription;} 
            public string getPrimaryStats() {  return primaryStats; }

            public string getSecondaryStats() {  return secondaryStats;}

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

    internal class GeneralCharacterBuilder : CharacterBuilder 
    {

        GeneralCharacter aChar;

        public void reset() { }

        public void buildBio()
        {
        }

        public void buildPortrait() { }

        public void buildClass(Classes aClass) 
        {
            if (aClass == Classes.Warrior) 
            {
                GeneralCharacter.Warrior war = new GeneralCharacter.Warrior();
            }
        }

        public void buildRace() { }

         public void buildBackground() { }

        public void buildStats() { }

        public void buildSkills() { }

        public void buildAlignment() { }

    }
}
