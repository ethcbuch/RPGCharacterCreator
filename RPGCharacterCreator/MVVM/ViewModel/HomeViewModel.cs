using RPGCharacterCreator.Core;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Concurrent;
using System.Windows;

namespace RPGCharacterCreator.MVVM.ViewModel
{
    internal class HomeViewModel : ObservableObject
    {
        public RelayCommand CreateCharacterCommand { get; set; }

        public RelayCommand ChangeCharacterCommand { get; set; }

        private object _childView;

        public object ChildView
        {
            //returns the current view object is on
            get
            {
                return _childView;
            }
            //sets _currentView to value (whatever its set to) and calls the OnPropertyChange()
            set
            {
                _childView = value;
                //notifies that there has been changes
                OnPropertyChanged();
            }
        }

        private Visibility _gridVis = Visibility.Hidden;
        public Visibility GridVis
        {
            get { return _gridVis; }
            set
            {
                _gridVis = value;
                OnPropertyChanged();
            }
        }

        private Visibility _labelVis = Visibility.Visible;
        public Visibility LabelVis
        {
            get { return _labelVis; }
            set
            {
                _labelVis = value;
                OnPropertyChanged();
            }
        }

        private GeneralCharacter _aChar = new GeneralCharacter();

        public GeneralCharacter AChar
        {
            get { return _aChar; }
            set
            {
                _aChar = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<GeneralCharacter> CharCollection { get; set; }

        public HomeViewModel()
        {
            CharCollection = new ObservableCollection<GeneralCharacter>();

            ChangeCharacterCommand = new RelayCommand(parameter =>
            {
                GridVis = Visibility.Visible;
                AChar = CharCollection[(int)parameter];

            });
        }

    }
}
