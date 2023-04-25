using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGCharacterCreator.MVVM.Model
{
    public class Abilites
    {
        public ObservableCollection<string> CharAbilites { get; set; } = new ObservableCollection<string>();
    }
}
