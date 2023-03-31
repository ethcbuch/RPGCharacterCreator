using RPGCharacterCreator.Core;

namespace RPGCharacterCreator.WVVM.ViewModel
{
    internal class BioViewModel : ObservableObject
    {

        private string _charName;

        public string CharName
        {
            get { return _charName; }
            set
            {
                _charName = value;
                Creator.director.getBuilder().buildBio(CharName, CharAge, CharBirthday, CharGender, CharBio);
            }
        }

        private string _charAge;

        public string CharAge
        {
            get { return _charAge; }
            set { _charAge = value; }
        }

        private string _charBirthday;

        public string CharBirthday
        {
            get { return _charBirthday; }
            set
            {
                _charBirthday = value;
                Creator.director.getBuilder().buildBio(CharName, CharAge, CharBirthday, CharGender, CharBio);
            }
        }

        private string _charGender;

        public string CharGender
        {
            get { return _charGender; }
            set
            {
                _charGender = value;
                Creator.director.getBuilder().buildBio(CharName, CharAge, CharBirthday, CharGender, CharBio);
            }
        }

        private string _charBio = "Type your character's story here...";

        public string CharBio
        {
            get { return _charBio; }
            set
            {
                _charBio = value;
                Creator.director.getBuilder().buildBio(CharName, CharAge, CharBirthday, CharGender, CharBio);
            }
        }


        public BioViewModel()
        {

        }

    }
}
