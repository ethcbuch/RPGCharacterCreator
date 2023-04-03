using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGCharacterCreator.MVVM.Model
{
    public abstract class Background
    {
        private string _backgroundName;
        private string _backgroundDescription;
        private List<string> _BackgroundSkills;

        public abstract string BackgroundName { get; set; }

        public abstract string BackgroundDescription { get; set; }
        public abstract List<string> ClassPrimaryStats
        {
            get; set;
        }


    }

    public class Noble : Background
    {
        string backgroundName;
        string backgroundDesc;
        string backgroundSkills;

        public Noble()
        {
            backgroundName = "Noble";
            backgroundDesc = "placeholder";
            backgroundSkills = "placeholder";
        }

    }
}

