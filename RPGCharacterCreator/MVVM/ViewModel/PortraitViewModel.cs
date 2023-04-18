using Microsoft.Win32;
using RPGCharacterCreator.Core;
using RPGCharacterCreator.MVVM.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGCharacterCreator.MVVM.ViewModel
{
    class PortraitViewModel : ObservableObject
    {

        public RelayCommand ChoosePortraitCommand { get; set; }

        public RelayCommand ImportPortraitCommand { get; set; }

        private Theme _portraitTheme;

        public Theme PortraitTheme
        {
            get { return _portraitTheme; }
            set { _portraitTheme = value; OnPropertyChanged(); }
        }


        private Portrait _aPortrait = new Portrait();

        public Portrait APortrait
        {
            get { return _aPortrait; }
            set
            {
                _aPortrait = value;
                OnPropertyChanged();
            }
        }
        public string[] arrays { get; set; }
        String sdira = System.AppDomain.CurrentDomain.BaseDirectory + "Images//Portraits";


        public void getPortraits()
        {
            arrays = Directory.GetFiles(sdira, "*", SearchOption.AllDirectories).Where(s => (Path.GetExtension(s).ToLower() == ".jpg")).ToArray();
        }

        public PortraitViewModel()
        {
            getPortraits();

            ChoosePortraitCommand = new RelayCommand(o =>
            {
                APortrait.PortraitPath = arrays[(int)o];
                OnPropertyChanged();
            });

            ImportPortraitCommand = new RelayCommand(o =>
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();

                openFileDialog.Filter = "Image files (*.png;*.jpeg)|*.png;*.jpeg|All files (*.*)|*.*";

                openFileDialog.ShowDialog();

                APortrait.PortraitPath = openFileDialog.FileName;

                OnPropertyChanged();
            });
        }
    }
}
