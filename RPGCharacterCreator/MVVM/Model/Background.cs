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
        private List<string> _backgroundSkills;

        public abstract string BackgroundName { get; set; }

        public abstract string BackgroundDescription { get; set; }
        public abstract List<string> BackgroundSkills { get; set; }


    }

    public class Noble : Background
    {
        private string _backgroundName;
        private string _backgroundDescription;
        private List<string> _backgroundSkills;

        public override string BackgroundName { get { return _backgroundName; } set { _backgroundName = value; } }

        public override string BackgroundDescription { get { return _backgroundName; } set { _backgroundName = value; } }
        public override List<string> BackgroundSkills { get { return _backgroundSkills; } set { _backgroundSkills = value; } }

    }
}

