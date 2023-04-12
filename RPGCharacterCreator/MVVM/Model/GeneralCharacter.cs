﻿using RPGCharacterCreator.Core;
using RPGCharacterCreator.MVVM.Model;
using RPGCharacterCreator.MVVM.View;

namespace RPGCharacterCreator
{
    internal class GeneralCharacter
    {
        public Bio characterBio { get; set; }
        public Class characterClass { get; set; }
        public Background characterBackground { get; set; }
        public Race characterRace { get; set; } 

        private int _characterNumber { get; set; }
        public int CharacterNumber { get { return _characterNumber; } set { _characterNumber = value; } }

    }
    interface CharacterBuilder
    {
        void reset();

        void buildBio(Bio aBio);

        void buildPortrait();

        void buildClass(Class aClass);

        void buildRace(Race aRace);

        void buildBackground(Background aBackgroud);

        void buildStats();

        void buildSkills();

        void buildAlignment();

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

        public void buildPortrait() { }

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

        public void buildAlignment() { }

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

        public GeneralCharacter makeGeneralCharacter(CharacterBuilder aCharacterBuilder, Bio aBio, Class aClass, Race aRace, Background aBackground, int CharNumber)
        {
            aCharacterBuilder.buildBio(aBio);
            aCharacterBuilder.buildPortrait();
            aCharacterBuilder.buildClass(aClass);
            aCharacterBuilder.buildRace(aRace);
            aCharacterBuilder.buildBackground(aBackground);
            aCharacterBuilder.setNumber(CharNumber);

            return aCharacterBuilder.GetCharacter();

        }

    }
}
