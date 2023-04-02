using RPGCharacterCreator.Core;

namespace RPGCharacterCreator.WVVM.ViewModel
{
    internal class BioViewModel : ObservableObject
    {


        private Bio _tempBio;

        public Bio TempBio
        {
            get
            {
                return _tempBio;
            }
            set
            {
                _tempBio = value;
                OnPropertyChanged();
            }
        }



        public BioViewModel()
        {
        }

    }
}
