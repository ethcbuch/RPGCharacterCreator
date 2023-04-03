using RPGCharacterCreator.Core;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace RPGCharacterCreator.WVVM.ViewModel
{



    internal class ClassViewModel : ObservableObject
    {

        public RelayCommand WarriorButtonCommand { get; set; }

        private Class _aClass = new Class();

        public Class AClass
        {
            get { return _aClass; }
            set
            {
                _aClass = value;
                OnPropertyChanged();
            }
        }


        public ClassViewModel()
        {
            Task.Run(() => { while (true) { Debug.WriteLine(AClass.ClassDescription); Thread.Sleep(1000); } });
            WarriorButtonCommand = new RelayCommand(o =>
            {
                AClass = new Warrior();
                OnPropertyChanged();
            });
        }


    }
}
