using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGCharacterCreator.MVVM.ViewModel
{
    internal class CharacterViewModel
    {

        public GeneralCharacter currentCharacter { get; set; }

        public CharacterViewModel(GeneralCharacter currentCharacter) 
        { 
        this.currentCharacter = currentCharacter;
        
        
        }
    }
}
