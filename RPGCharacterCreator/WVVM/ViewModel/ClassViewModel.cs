using RPGCharacterCreator.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGCharacterCreator.WVVM.ViewModel
{


   
    internal class ClassViewModel
    {

        public RelayCommand WarriorButtonCommand { get; set; }
        public ClassViewModel()
        {
            WarriorButtonCommand = new RelayCommand(o =>
            {
                 = homeVM;

            });
        }
        

    }
}
