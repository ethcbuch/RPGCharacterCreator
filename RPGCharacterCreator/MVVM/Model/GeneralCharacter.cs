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
        public Stats characterStats { get; set; }
        public Alignment characterAlignment { get; set; }
        private int _characterNumber { get; set; }
        public int CharacterNumber { get { return _characterNumber; } set { _characterNumber = value; } }

    }
}
