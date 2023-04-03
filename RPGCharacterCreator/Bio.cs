using RPGCharacterCreator.Core;

namespace RPGCharacterCreator
{
    internal class Bio : ObservableObject
    {
        private string _charName { get; set; }
        private string _charBirthday { get; set; }
        private string _charGender { get; set; }
        private string _charAge { get; set; }
        private string _charBio { get; set; }

        public string CharName { get { return _charName; } set { _charName = value; OnPropertyChanged(); } }
        public string CharBirthday { get { return _charBirthday; } set { _charBirthday = value; OnPropertyChanged(); } }
        public string CharGender { get { return _charGender; } set { _charGender = value; OnPropertyChanged(); } }
        public string CharAge { get { return _charAge; } set { _charAge = value; OnPropertyChanged(); } }
        public string CharBio { get { return _charBio; } set { _charBio = value; OnPropertyChanged(); } }


        public Bio()
        {

        }

        public Bio(Bio aBio)
        {
            _charName = aBio.CharName;
            _charBirthday = aBio.CharBirthday;
            _charGender = aBio.CharGender;
            _charAge = aBio.CharAge;
            _charBio = aBio.CharBio;
        }

    }
}
