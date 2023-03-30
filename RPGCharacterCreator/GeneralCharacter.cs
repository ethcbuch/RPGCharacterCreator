namespace RPGCharacterCreator
{

    public enum Classes
    {
        Warrior,
        Rogue,
        Mage
    }

    public enum Races
    {
        Human,
        Elf,
        Dwarf
    }

    public enum Backgrounds
    {
        Noble,
        Peasant,
        Sage
    }


    internal class GeneralCharacter
    {
        protected Bio characterBio;
        protected Class characterClass;
        protected Background characterBackground;
        protected Race characterRace;

        public GeneralCharacter()
        {

        }

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

            public Bio()
            {
            }

            public Bio(string charName, string charBirthday, string charGender, int charAge, string charBio)
            {
                this.charName = charName;
                this.charBirthday = charBirthday;
                this.charGender = charGender;
                this.charAge = charAge;
                this.charBio = charBio;


            }

            public string getCharName() { return charName; }

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

        public class Race
        {

        }

        public class Human : Race
        {

        }

        public class Background
        {
            string backgroundName;
            string backgroundDesc;
            string backgroundSkills;

            public string getBackgroundName() { return backgroundName; }
            public string getBackgroundDesc() { return backgroundDesc; }
            public string getBackgroundSkills() { return backgroundSkills; }

        }

        public class Noble : Background
        {
            string backgroundName;
            string backgroundDesc;
            string backgroundSkills;

            public Noble()
            {
                backgroundName = "Noble";
                backgroundDesc = "placeholder";
                backgroundSkills = "placeholder";
            }

        }
    }

    interface CharacterBuilder
    {
        void reset();

        GeneralCharacter.Bio buildBio();

        void buildPortrait();

        GeneralCharacter.Class buildClass(Classes aClass);

        GeneralCharacter.Race buildRace(Races aRace);

        GeneralCharacter.Background buildBackground(Backgrounds aBackgroud);

        void buildStats();

        void buildSkills();

        void buildAlignment();

        GeneralCharacter GetCharacter();

    }

    internal class GeneralCharacterBuilder : CharacterBuilder
    {

        GeneralCharacter aChar;

        public void reset()
        {
            aChar = new GeneralCharacter();
        }

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

        public GeneralCharacter.Race buildRace(Races aRace)
        {
            GeneralCharacter.Race race = new GeneralCharacter.Race();

            return race;
        }

        public GeneralCharacter.Background buildBackground(Backgrounds aBackground)
        {
            GeneralCharacter.Background background = new GeneralCharacter.Background();

            return background;

        }

        public void buildStats() { }

        public void buildSkills() { }

        public void buildAlignment() { }

        public GeneralCharacter GetCharacter()
        {
            aChar = new GeneralCharacter();
            return aChar;
        }

    }


    class CharacterDirector
    {
        CharacterBuilder aCharacterBuilder;

        CharacterDirector(CharacterBuilder aCharacterBuilder) { }

        //void changeBuilder(CharacterBuilder aCharacterBuilder) { }

        GeneralCharacter makeGeneralCharacter(CharacterBuilder aCharacterBuilder)
        {
            return null;
        }

    }
}
