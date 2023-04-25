using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGCharacterCreator.MVVM.Model
{

    public interface CharacterBuilder
    {
        void reset();

        void buildBio(Bio aBio);

        void buildPortrait(Portrait aPortrait);

        void buildClass(Class aClass);

        void buildRace(Race aRace);

        void buildBackground(Background aBackgroud);

        void buildStats(Stats CharStats);

        void buildSkills(Skills CharSkills);

        void buildAlignment(Alignment aAlignment);

        void buildAbilities(Abilites abilites);
        GeneralCharacter GetCharacter();

    }

    public class GeneralCharacterBuilder : CharacterBuilder
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

        public void buildStats(Stats CharStats)
        {
            character.characterStats = CharStats;
        }

        public void buildSkills(Skills CharSkills)
        {
            character.characterSkills = CharSkills;

        }

        public void buildAlignment(Alignment aAlignment)
        {
            character.characterAlignment = aAlignment;
        }

        public void buildAbilities(Abilites abilites)
        {
            character.characterAbilites = abilites;
        }

        public GeneralCharacter GetCharacter()
        {
            return character;
        }

    }
}
