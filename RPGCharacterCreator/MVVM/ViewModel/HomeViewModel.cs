using RPGCharacterCreator.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGCharacterCreator.MVVM.ViewModel
{
    internal class HomeViewModel
    {
        public RelayCommand CreateCharacterCommand { get; set; }

        public Dictionary<GeneralCharacter, string> characterDict = new Dictionary<GeneralCharacter, string>();

    }
}
