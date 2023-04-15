using RPGCharacterCreator.Core;
using RPGCharacterCreator.MVVM.Model;
using RPGCharacterCreator.MVVM.View;

namespace RPGCharacterCreator
{
    internal class GeneralCharacter
    {
        public Bio characterBio { get; set; }
        public Portrait characterPortrait { get; set; } = new Portrait();
        public Class characterClass { get; set; }
        public Background characterBackground { get; set; }
        public Race characterRace { get; set; } 
        public Alignment characterAlignment { get; set; }
        private int _characterNumber { get; set; }
        public int CharacterNumber { get { return _characterNumber; } set { _characterNumber = value; } }



    }
    interface CharacterBuilder
    {
        void reset();

        void buildBio(Bio aBio);

        void buildPortrait(Portrait aPortrait);

        void buildClass(Class aClass);

        void buildRace(Race aRace);

        void buildBackground(Background aBackgroud);

        void buildStats();

        void buildSkills();

        void buildAlignment(Alignment aAlignment);

        void setNumber(int number);

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
            character.characterBio = aBio;
        }

        public void buildPortrait(Portrait aPortrait) 
        {
            character.characterPortrait = aPortrait;
        }

        public void buildClass(Class aClass)
        {
               character.characterClass = aClass;
        }

        public void buildRace(Race aRace)
        {
                character.characterRace = aRace;
        }

        public void buildBackground(Background aBackground)
        {
            character.characterBackground = aBackground;

        }

        public void buildStats() { }

        public void buildSkills() { }

        public void buildAlignment(Alignment aAlignment)
        {
            character.characterAlignment = aAlignment;
        }

        public void setNumber(int number) { character.CharacterNumber = number; }

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

        void changeBuilder(CharacterBuilder aCharacterBuilder) { }

        public CharacterBuilder getBuilder()
        {
            return charBuilder;
        }

        public GeneralCharacter makeGeneralCharacter(CharacterBuilder aCharacterBuilder, Bio aBio, Portrait aPortrait, Class aClass, Race aRace, Background aBackground, int CharNumber)
        {
            aCharacterBuilder.buildBio(aBio);
            aCharacterBuilder.buildPortrait(aPortrait);
            aCharacterBuilder.buildClass(aClass);
            aCharacterBuilder.buildRace(aRace);
            aCharacterBuilder.buildBackground(aBackground);
            aCharacterBuilder.setNumber(CharNumber);

            return aCharacterBuilder.GetCharacter();

        }

    }
}
