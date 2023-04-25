using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGCharacterCreator.MVVM.Model
{
    public class CharacterDirector
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

        public GeneralCharacter makeGeneralCharacter(CharacterBuilder aCharacterBuilder, Bio aBio, Portrait aPortrait, Class aClass, Race aRace, Background aBackground, Stats CharStats, Alignment aAlignment, Skills CharSkills, Abilites CharAbilites)
        {
            aCharacterBuilder.buildBio(aBio);
            aCharacterBuilder.buildPortrait(aPortrait);
            aCharacterBuilder.buildClass(aClass);
            aCharacterBuilder.buildRace(aRace);
            aCharacterBuilder.buildBackground(aBackground);
            aCharacterBuilder.buildAlignment(aAlignment);
            aCharacterBuilder.buildStats(CharStats);
            aCharacterBuilder.buildSkills(CharSkills);
            aCharacterBuilder.buildAbilities(CharAbilites);
            return aCharacterBuilder.GetCharacter();

        }

    }
}
