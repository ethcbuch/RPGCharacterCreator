using RPGCharacterCreator.MVVM.Model;

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

    }
    interface CharacterBuilder
    {
        void reset();

        void buildBio(Bio aBio);

        void buildPortrait();

        Class buildClass(Classes aClass);

        Race buildRace(Races aRace);

        Background buildBackground(Backgrounds aBackgroud);

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

        public Race buildRace(Races aRace)
        {
            Race race = new Race();

            return race;
        }

        public Background buildBackground(Backgrounds aBackground)
        {
            Background background = new Background();

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
