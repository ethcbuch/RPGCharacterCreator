namespace RPGCharacterCreator
{
    public class Bio
    {
        private string _charName { get; set; }
        private string _charBirthday { get; set; }
        private string _charGender { get; set; }
        private string _charAge { get; set; }
        private string _charBio { get; set; }

        public string CharName { get { return _charName; } set { _charName = value; } }
        public string CharBirthday { get { return _charBirthday; } set { _charBirthday = value; } }
        public string CharGender { get { return _charGender; } set { _charGender = value; } }
        public string CharAge { get { return _charAge; } set { _charAge = value; } }
        public string CharBio { get { return _charBio; } set { _charBio = value; } }


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
