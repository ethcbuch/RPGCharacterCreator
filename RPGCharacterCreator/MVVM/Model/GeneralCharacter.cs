using RPGCharacterCreator.Core;
using RPGCharacterCreator.MVVM.Model;
using RPGCharacterCreator.MVVM.View;
using System.Collections.ObjectModel;

namespace RPGCharacterCreator
{
    public class GeneralCharacter
    {
        public Bio characterBio { get; set; }
        public Portrait characterPortrait { get; set; } = new Portrait();
        public Class characterClass { get; set; }
        public Background characterBackground { get; set; }
        public Race characterRace { get; set; }
        public Skills characterSkills { get; set; } 
        public Stats characterStats { get; set; }
        public Alignment characterAlignment { get; set; }
        public Abilites characterAbilites { get; set; }
    }
}
