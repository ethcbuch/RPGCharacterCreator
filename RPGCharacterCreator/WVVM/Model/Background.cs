using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGCharacterCreator.WVVM.Model
{
    public class Background
    {
        string backgroundName;
        string backgroundDesc;
        string backgroundSkills;

        public string getBackgroundName() { return backgroundName; }
        public string getBackgroundDesc() { return backgroundDesc; }
        public string getBackgroundSkills() { return backgroundSkills; }

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

