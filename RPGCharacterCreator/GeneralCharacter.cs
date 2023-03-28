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
        protected Bio characterBio;
        protected Class characterClass;

        public GeneralCharacter(Bio characterBio, Class characterClass) 
        {
            this.characterBio = characterBio;
            this.characterClass = characterClass;

        }

        public class Bio
        {
            string charName;
            string charBirthday;
            string charGender;
            int charAge;
            string charBio;
            
            public Bio(string charName, string charBirthday, string charGender, int charAge, string charBio) 
            {
                this.charName = charName;
                this.charBirthday = charBirthday;
                this.charGender = charGender;
                this.charAge = charAge;
                this.charBio = charBio;


            }

            public Bio()
            {
            }

            public string getCharName () { return charName; }

            public string getCharBirthday() { return charBirthday; }

            public string getCharGender() { return charGender; }

            public int getCharAge() { return charAge; }

            public string getCharBio() { return charBio; }
        }

        public class Class
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
                classDescription = "placeholder";
                primaryStats = "Strength";
                secondaryStats = "Agility";

            }
        }
    }

    public enum Classes
    {
        Warrior,
        Rogue,
        Mage
    }

    interface CharacterBuilder
    {
        void reset();

        GeneralCharacter.Bio buildBio();

        void buildPortrait();

        GeneralCharacter.Class buildClass(Classes aClass);

        void buildRace();

        void buildBackground();

        void buildStats();

        void buildSkills();

        void buildAlignment();

        GeneralCharacter GetCharacter();
        
    }

    internal class GeneralCharacterBuilder : CharacterBuilder 
    {

        GeneralCharacter aChar;

        public void reset() { }

        public GeneralCharacter.Bio buildBio()
        {
            GeneralCharacter.Bio bio = new GeneralCharacter.Bio();

            return bio;
        }

        public void buildPortrait() { }

        public GeneralCharacter.Class buildClass(Classes aClass) 
        {
            if (aClass == Classes.Warrior) 
            {
                GeneralCharacter.Warrior war = new GeneralCharacter.Warrior();
                return war;
            }
            else { return null; }
        }

        public void buildRace() { }

         public void buildBackground() { }

        public void buildStats() { }

        public void buildSkills() { }

        public void buildAlignment() { }

        public GeneralCharacter GetCharacter() 
        {

            return aChar; 
        }

    }
}
