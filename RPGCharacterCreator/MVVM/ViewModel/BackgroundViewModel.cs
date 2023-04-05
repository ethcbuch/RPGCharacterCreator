using RPGCharacterCreator.Core;
using RPGCharacterCreator.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGCharacterCreator.MVVM.ViewModel
{
    class BackgroundViewModel: ObservableObject
    {
        public RelayCommand NobleButtonCommand { get; set; }

        public RelayCommand SageButtonCommand { get; set; }

        private Background _aBackground;

        public Background ABackground
        {
            get { return _aBackground; }
            set
            {
                _aBackground = value;
                OnPropertyChanged();
            }
        }


        public BackgroundViewModel()
        {

            NobleButtonCommand = new RelayCommand(o =>
            {
                ABackground = new Noble();
                OnPropertyChanged();
            });

            SageButtonCommand = new RelayCommand(o =>
            {
                ABackground = new Sage();
                OnPropertyChanged();
            });
        }
    }
}
