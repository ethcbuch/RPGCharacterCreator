using RPGCharacterCreator.Core;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Concurrent;
using System.Windows;
using System.Diagnostics;

namespace RPGCharacterCreator.MVVM.ViewModel
{
    internal class HomeViewModel : ObservableObject
    {
        public RelayCommand CreateCharacterCommand { get; set; }

        public RelayCommand ChangeCharacterCommand { get; set; }

        public RelayCommand EditCharacterCommand { get; set; }
        public RelayCommand DeleteCharacterCommand { get; set; }

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

        public int currentCharacterIndex { get; set; } = -1;

        public ObservableCollection<GeneralCharacter> CharCollection { get; set; }

        public HomeViewModel()
        {
            CharCollection = new ObservableCollection<GeneralCharacter>();

            ChangeCharacterCommand = new RelayCommand(parameter =>
            {
                //added this in because was getting strange bugs IF
                // create a char, create a second char
                // click on the newly created char and edit name and finalize
                //click on the first char you created and edit without finalizing
                // edit the newly created char and change something and finalize
                // the changes will save onto the both

                //i think this fixed it
                if (currentCharacterIndex != -1)
                {
                    CharCollection[currentCharacterIndex] = AChar;
                }
                currentCharacterIndex = (int)parameter;
                GridVis = Visibility.Visible;
                AChar = CharCollection[(int)parameter];
            });

            DeleteCharacterCommand = new RelayCommand(parameter =>
            {
                //If no character is selected cannot delete
                if (currentCharacterIndex == -1)
                {
                    return;
                }
                else
                {
                    CharCollection.RemoveAt(currentCharacterIndex);
                    AChar = new GeneralCharacter();
                    //A character is no longer selected so value is reset.
                    currentCharacterIndex = -1;
                    //If there are no characters in the system then the a message is shown and the character dsiplay is hidden
                    if (CharCollection.Count == 0)
                    {
                        GridVis = Visibility.Hidden;
                        LabelVis = Visibility.Visible;
                    }
                }

            });
      
        }
    }
}

