using RPGCharacterCreator.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace RPGCharacterCreator.MVVM.Model
{

    [XmlInclude(typeof(Noble))]
    [XmlInclude(typeof(Sage))]
    public class Background : ObservableObject
    {
        private string _backgroundName { get; set; }
        private string _backgroundDescription { get; set; }
        private List<string> _backgroundSkills { get; set; } = new List<string>();

        public  string BackgroundName { get { return _backgroundName; } set { _backgroundName = value; OnPropertyChanged(); } }
        public string BackgroundDescription { get { return _backgroundDescription; } set { _backgroundDescription = value; OnPropertyChanged(); } }
        public List<string> BackgroundSkills { get { return _backgroundSkills; } set { _backgroundSkills = value; OnPropertyChanged(); } }


    }

    public class Noble : Background
    {
        private string _backgroundName = "Noble";
        private string _backgroundDescription = "You understand wealth, power, and privilege. You carry a noble title, and your family owns land, collects taxes, and wields significant political influence. You might be a pampered aristocrat unfamiliar with work or discomfort, a former merchant just elevated to the nobility, or a disinherited scoundrel with a disproportionate sense of entitlement. Or you could be an honest, hard-working landowner who cares deeply about the people who live and work on your land, keenly aware of your responsibility to them.";
        private List<string> _backgroundSkills = new List<string> { "History", "Persuasion" };

        public new string BackgroundName { get { return _backgroundName; } set { _backgroundName = value; OnPropertyChanged(); } }

        public new string BackgroundDescription { get { return _backgroundDescription; } set { _backgroundDescription = value; OnPropertyChanged(); } }
        public new List<string> BackgroundSkills { get { return _backgroundSkills; } set { _backgroundSkills = value; OnPropertyChanged(); } }

    }

    public class Sage : Background
    {
        private string _backgroundName = "Sage";
        private string _backgroundDescription = "You spent years learning the lore of the multiverse. You scoured manuscripts, studied scrolls, and listened to the greatest experts on the subjects that interest you. Your efforts have made you a master in your fields of study.";
        private List<string> _backgroundSkills = new List<string> { "Arcana", "History" };

        public  new string BackgroundName { get { return _backgroundName; } set { _backgroundName = value; OnPropertyChanged(); } }

        public new string BackgroundDescription { get { return _backgroundDescription; } set { _backgroundDescription = value; OnPropertyChanged(); } }
        public new List<string> BackgroundSkills { get { return _backgroundSkills; } set { _backgroundSkills = value; OnPropertyChanged(); } }

    }
}