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
        public Bio characterBio;
        public Class characterClass;
        public Background characterBackground;
        public Race characterRace;

        public GeneralCharacter()
        {
        }

        public class Bio
        {
            string charName;
            string charBirthday;
            string charGender;
            string charAge;
            string charBio;

            public Bio(string charName, string charAge, string charBirthday, string charGender, string charBio)
            {
                this.charName = charName;
                this.charBirthday = charBirthday;
                this.charGender = charGender;
                this.charAge = charAge;
                this.charBio = charBio;
            }
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

        void buildBio(string charName, string charAge, string charBD, string charGender, string charBio);

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

        public GeneralCharacter character = new GeneralCharacter();

        public void reset()
        {
            character = new GeneralCharacter();
        }

        public void buildBio(string charName, string charAge, string charBD, string charGender, string charBio)
        {
            character.characterBio = new GeneralCharacter.Bio(charName, charAge, charBD, charGender, charBio);
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
            return character;
        }

    }


    internal class CharacterDirector
    {
        private CharacterBuilder charBuilder;

        public CharacterDirector(CharacterBuilder aCharacterBuilder)
        {
            charBuilder = aCharacterBuilder;
        }

        //void changeBuilder(CharacterBuilder aCharacterBuilder) { }

        public CharacterBuilder getBuilder()
        {
            return charBuilder;
        }

        public GeneralCharacter makeGeneralCharacter(CharacterBuilder aCharacterBuilder)
        {
            GeneralCharacter character = new GeneralCharacter();

            return character;
        }

    }
}
