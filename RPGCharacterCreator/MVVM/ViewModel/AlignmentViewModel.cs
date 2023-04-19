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
        public RelayCommand NeutralGoodButtonCommand { get; set; }
        public RelayCommand ChaoticGoodButtonCommand { get; set; }
        public RelayCommand LawfulNeutralButtonCommand { get; set; }
        public RelayCommand TrueNeutralButtonCommand { get; set; }
        public RelayCommand ChaoticNeutralButtonCommand { get; set; }
        public RelayCommand LawfulEvilButtonCommand { get; set; }
        public RelayCommand NeutralEvilButtonCommand { get; set; }
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

            NeutralGoodButtonCommand = new RelayCommand(o =>
            {
                AAlignment = new NeutralGood();
                OnPropertyChanged();
            });

            ChaoticGoodButtonCommand = new RelayCommand(o =>
            {
                AAlignment = new ChaoticGood();
                OnPropertyChanged();
            });

            LawfulNeutralButtonCommand = new RelayCommand(o =>
            {
                AAlignment = new LawfulNeutral();
                OnPropertyChanged();
            });

            TrueNeutralButtonCommand = new RelayCommand(o =>
            {
                AAlignment = new TrueNeutral();
                OnPropertyChanged();
            });

            ChaoticNeutralButtonCommand = new RelayCommand(o =>
            {
                AAlignment = new ChaoticNeutral();
                OnPropertyChanged();
            });

            LawfulEvilButtonCommand = new RelayCommand(o =>
            {
                AAlignment = new LawfulEvil();
                OnPropertyChanged();
            });

            NeutralEvilButtonCommand = new RelayCommand(o =>
            {
                AAlignment = new NeutralEvil();
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
