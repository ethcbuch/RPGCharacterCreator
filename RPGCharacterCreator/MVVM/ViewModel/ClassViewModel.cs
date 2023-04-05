using RPGCharacterCreator.Core;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;

namespace RPGCharacterCreator.MVVM.ViewModel
{
    internal class ClassViewModel : ObservableObject
    {

        public RelayCommand WarriorButtonCommand { get; set; }

        public RelayCommand RogueButtonCommand { get; set; }

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

            WarriorButtonCommand = new RelayCommand(o =>
            {
                AClass = new Warrior();

                OnPropertyChanged();
            });

            RogueButtonCommand = new RelayCommand(o =>
            {
                AClass = new Rogue();
                OnPropertyChanged();
            });

            Task.Run(() => { while (true) { Debug.WriteLine(AClass.ClassName); Thread.Sleep(1000); } });

        }


    }
}
