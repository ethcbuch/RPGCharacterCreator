using RPGCharacterCreator.Core;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            get
            {
                _charName = Creator.director.getBuilder().GetCharacter().characterBio.getCharName();
                return _charName;
            }
            set
            {

                _charName = value;
            }
        }

        private string _charAge;

        public string CharAge
        {
            get
            {
                _charAge = Creator.director.getBuilder().GetCharacter().characterBio.getCharAge();
                return _charAge;
            }
            set
            {
                _charAge = value;
            }
        }

        private string _charBirthday;

        public string CharBirthday
        {
            get
            {
                _charBirthday = Creator.director.getBuilder().GetCharacter().characterBio.getCharBirthday();
                return _charBirthday;
            }
            set
            {
                _charBirthday = value;
            }

        }

        private string _charGender;

        public string CharGender
        {
            get
            {
                _charGender = Creator.director.getBuilder().GetCharacter().characterBio.getCharGender();
                return _charGender;
            }
            set
            {
                _charGender = value;

            }
        }

        private string _charBio;

        public string CharBio
        {
            get
            {
                _charBio = Creator.director.getBuilder().GetCharacter().characterBio.getCharBio();
                return _charBio;
            }
            set
            {
                _charBio = value;

            }
        }

        public OverviewViewModel()
        {

        }
    }
}
