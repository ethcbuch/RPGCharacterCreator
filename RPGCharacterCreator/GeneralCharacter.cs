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


    internal class GeneralCharacter : Bio
    {
        public Bio characterBio;
        public Class characterClass;
        public Background characterBackground;
        public Race characterRace;

        

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

        void buildBio(Bio aBio);

        void buildPortrait();

        Class buildClass(Classes aClass);

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

        public void buildBio(Bio aBio)
        {
            character.characterBio = new Bio(aBio);
        }

        public void buildPortrait() { }

        public Class buildClass(Classes aClass)
        {
            if (aClass == Classes.Warrior)
            {
                Warrior war = new Warrior();
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
