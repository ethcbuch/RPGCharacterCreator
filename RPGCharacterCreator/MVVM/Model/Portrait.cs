using RPGCharacterCreator.Core;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGCharacterCreator.MVVM.Model
{
    internal class Portrait : ObservableObject
    {
        private string _portraitPath { get; set; } = "/Images/placeholder.png";

        public string PortraitPath
        {
            get { return _portraitPath; }
            set { _portraitPath = value; OnPropertyChanged(); }
        }

        public string[] arrays;
        String sdira = System.AppDomain.CurrentDomain.BaseDirectory + "Images";


        public void getPortraits ()
        {
            arrays = Directory.GetFiles(sdira, "*", SearchOption.AllDirectories).Where(s => (Path.GetExtension(s).ToLower() == ".png" )).ToArray();
        }


        public Portrait()
        {
            getPortraits();
        }
    }
        

    

}
