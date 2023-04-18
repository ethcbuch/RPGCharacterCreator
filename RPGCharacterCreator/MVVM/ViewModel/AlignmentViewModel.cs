using RPGCharacterCreator.Core;
using RPGCharacterCreator.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGCharacterCreator.MVVM.ViewModel
{
    class AlignmentViewModel : ObservableObject
    {
        public RelayCommand LawfulGoodButtonCommand { get; set; }
        public RelayCommand ChaoticEvilButtonCommand { get; set; }

        private Theme _alignmentTheme;

        public Theme AlignmentTheme
        {
            get { return _alignmentTheme; }
            set { _alignmentTheme = value; OnPropertyChanged(); }
        }

        private Alignment _aAlignment;
        public Alignment AAlignment
        {
            get { return _aAlignment; }
            set
            {
                _aAlignment = value;
                OnPropertyChanged();
            }
        }

        public AlignmentViewModel()
        {
            LawfulGoodButtonCommand = new RelayCommand(o =>
            {
                AAlignment = new LawfulGood();
                OnPropertyChanged();
            });

            ChaoticEvilButtonCommand = new RelayCommand(o =>
            {
                AAlignment = new ChaoticEvil();
                OnPropertyChanged();
            });
        }
    }
}