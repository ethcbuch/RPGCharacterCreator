using RPGCharacterCreator.Core;
using RPGCharacterCreator.MVVM.Model;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace RPGCharacterCreator.MVVM.ViewModel
{
    internal class BioViewModel : ObservableObject
    {


        private Bio _tempBio = new Bio();

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

        private Theme _bioTheme;

        public Theme BioTheme
        {
            get { return _bioTheme; }
            set { _bioTheme = value; OnPropertyChanged(); }
        }



        public BioViewModel()
        {
            //Task.Run(() => { while (true) { Debug.WriteLine(TempBio.CharName); Thread.Sleep(1000); } });




        }

    }
}
