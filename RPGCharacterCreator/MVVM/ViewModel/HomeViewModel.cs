﻿using RPGCharacterCreator.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGCharacterCreator.MVVM.ViewModel
{
    internal class HomeViewModel
    {

        public RelayCommand CreateCharacterCommand { get; set; }

        public MainViewModel mainVM { get; set; }

        public HomeViewModel()
        {
            CreateCharacterCommand = new RelayCommand(o =>
            {
                mainVM.CurrentView = mainVM.bioVM;

            });
        }
    }
}
