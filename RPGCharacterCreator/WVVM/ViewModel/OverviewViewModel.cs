using RPGCharacterCreator.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGCharacterCreator.WVVM.ViewModel
{
    class OverviewViewModel : ObservableObject
    {

        private string _charName;

        public string CharName
        {
            get { return _charName; }
            set
            {
                
                _charName = Creator.director.getBuilder().GetCharacter().characterBio.getCharName();
                OnPropertyChanged();
            }
        }

        private string _charAge;

        public string CharAge
        {
            get { return _charAge; }
            set { _charAge = Creator.director.getBuilder().GetCharacter().characterBio.getCharAge(); }
        }

        private string _charBirthday;

        public string CharBirthday
        {
            get { return _charBirthday; }
            set
            {
                _charBirthday = Creator.director.getBuilder().GetCharacter().characterBio.getCharBirthday();
            }
        }

        private string _charGender;

        public string CharGender
        {
            get { return _charGender; }
            set
            {
                _charGender = Creator.director.getBuilder().GetCharacter().characterBio.getCharGender();
            }
        }

        private string _charBio;

        public string CharBio
        {
            get { return _charBio; }
            set
            {
                _charBio = Creator.director.getBuilder().GetCharacter().characterBio.getCharBio();
            }
        }
    }
}
