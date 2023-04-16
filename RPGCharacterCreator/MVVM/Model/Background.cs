using RPGCharacterCreator.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGCharacterCreator.MVVM.Model
{
    internal class Background : ObservableObject
    {
        private string _backgroundName { get; set; }
        private string _backgroundDescription { get; set; }
        private List<string> _backgroundSkills { get; set; }

        public  string BackgroundName { get { return _backgroundName; } set { _backgroundName = value; OnPropertyChanged(); } }
        public string BackgroundDescription { get { return _backgroundDescription; } set { _backgroundDescription = value; OnPropertyChanged(); } }
        public List<string> BackgroundSkills { get { return _backgroundSkills; } set { _backgroundSkills = value; OnPropertyChanged(); } }


    }

    internal class Noble : Background
    {
        private string _backgroundName = "Noble";
        private string _backgroundDescription = "You understand wealth, power, and privilege. You carry a noble title, and your family owns land, collects taxes, and wields significant political influence. You might be a pampered aristocrat unfamiliar with work or discomfort, a former merchant just elevated to the nobility, or a disinherited scoundrel with a disproportionate sense of entitlement. Or you could be an honest, hard-working landowner who cares deeply about the people who live and work on your land, keenly aware of your responsibility to them.";
        private List<string> _backgroundSkills = new List<string> { "History", "Persuasion" };

        public new string BackgroundName { get { return _backgroundName; } set { _backgroundName = value; OnPropertyChanged(); } }

        public new string BackgroundDescription { get { return _backgroundDescription; } set { _backgroundDescription = value; OnPropertyChanged(); } }
        public new List<string> BackgroundSkills { get { return _backgroundSkills; } set { _backgroundSkills = value; OnPropertyChanged(); } }

    }

    internal class Sage : Background
    {
        private string _backgroundName = "Sage";
        private string _backgroundDescription = "You spent years learning the lore of the multiverse. You scoured manuscripts, studied scrolls, and listened to the greatest experts on the subjects that interest you. Your efforts have made you a master in your fields of study.";
        private List<string> _backgroundSkills = new List<string> { "Arcana", "History" };

        public  new string BackgroundName { get { return _backgroundName; } set { _backgroundName = value; OnPropertyChanged(); } }

        public new string BackgroundDescription { get { return _backgroundDescription; } set { _backgroundDescription = value; OnPropertyChanged(); } }
        public new List<string> BackgroundSkills { get { return _backgroundSkills; } set { _backgroundSkills = value; OnPropertyChanged(); } }

    }
    internal class Criminal : Background
    {
        private string _backgroundName = "Criminal";
        private string _backgroundDescription = "You are an experienced criminal who knows how to get things done. You have spent years operating outside the law, and you are comfortable with a life of deception and theft. You might have been part of a gang, worked as a smuggler, or run a small-time operation on your own.";
        private List<string> _backgroundSkills = new List<string> { "Deception", "Stealth" };

        public new string BackgroundName { get { return _backgroundName; } set { _backgroundName = value; OnPropertyChanged(); } }

        public new string BackgroundDescription { get { return _backgroundDescription; } set { _backgroundDescription = value; OnPropertyChanged(); } }
        public new List<string> BackgroundSkills { get { return _backgroundSkills; } set { _backgroundSkills = value; OnPropertyChanged(); } }
    }

    internal class Soldier : Background
    {
        private string _backgroundName = "Soldier";
        private string _backgroundDescription = "You are a veteran of war, trained to fight and kill. You might have served in an army, fought as a mercenary, or been part of a militia. Your experiences have left you with a keen eye for danger and a deep respect for those who fight alongside you.";
        private List<string> _backgroundSkills = new List<string> { "Athletics", "Intimidation" };

        public new string BackgroundName { get { return _backgroundName; } set { _backgroundName = value; OnPropertyChanged(); } }

        public new string BackgroundDescription { get { return _backgroundDescription; } set { _backgroundDescription = value; OnPropertyChanged(); } }
        public new List<string> BackgroundSkills { get { return _backgroundSkills; } set { _backgroundSkills = value; OnPropertyChanged(); } }
    }

    internal class Entertainer : Background
    {
        private string _backgroundName = "Entertainer";
        private string _backgroundDescription = "You are a performer who knows how to captivate an audience. You might be a musician, an actor, or a circus performer, and your skills have allowed you to travel the world and see many different cultures. You are outgoing and charming, and you enjoy being the center of attention.";
        private List<string> _backgroundSkills = new List<string> { "Acrobatics", "Performance" };

        public new string BackgroundName { get { return _backgroundName; } set { _backgroundName = value; OnPropertyChanged(); } }

        public new string BackgroundDescription { get { return _backgroundDescription; } set { _backgroundDescription = value; OnPropertyChanged(); } }
        public new List<string> BackgroundSkills { get { return _backgroundSkills; } set { _backgroundSkills = value; OnPropertyChanged(); } }
    }

    internal class Sailor : Background
    {
        private string _backgroundName = "Sailor";
        private string _backgroundDescription = "You have sailed the seas and oceans of the world, learning the ropes of navigation, how to handle a ship in a storm, and how to fish for food. You might have been a pirate, a sailor on a merchant vessel, or a member of a navy. You have seen more of the world than most people will ever know.";
        private List<string> _backgroundSkills = new List<string> { "Athletics", "Perception" };

        public new string BackgroundName { get { return _backgroundName; } set { _backgroundName = value; OnPropertyChanged(); } }

        public new string BackgroundDescription { get { return _backgroundDescription; } set { _backgroundDescription = value; OnPropertyChanged(); } }
        public new List<string> BackgroundSkills { get { return _backgroundSkills; } set { _backgroundSkills = value; OnPropertyChanged(); } }
    }


    internal class Acolyte : Background
    {
        private string _backgroundName = "Acolyte";
        private string _backgroundDescription = "You have spent your life in service to a religious institution. You have been trained in the ways of your faith and are knowledgeable about its teachings and rituals. You may be a priest, a monk, or a member of a religious order, or you could have been a devotee of a particular deity.";
        private List<string> _backgroundSkills = new List<string> { "Insight", "Religion" };

        public new string BackgroundName { get { return _backgroundName; } set { _backgroundName = value; OnPropertyChanged(); } }

        public new string BackgroundDescription { get { return _backgroundDescription; } set { _backgroundDescription = value; OnPropertyChanged(); } }
        public new List<string> BackgroundSkills { get { return _backgroundSkills; } set { _backgroundSkills = value; OnPropertyChanged(); } }
    }


    internal class Knight : Background
    {
        private string _backgroundName = "Knight";
        private string _backgroundDescription = "You are a warrior who has pledged service to a lord in exchange for land and title. You might be a noble, a member of a knightly order, or a self-made champion.";
        private List<string> _backgroundSkills = new List<string> { "Athletics", "Persuasion" };

        public new string BackgroundName { get { return _backgroundName; } set { _backgroundName = value; OnPropertyChanged(); } }

        public new string BackgroundDescription { get { return _backgroundDescription; } set { _backgroundDescription = value; OnPropertyChanged(); } }
        public new List<string> BackgroundSkills { get { return _backgroundSkills; } set { _backgroundSkills = value; OnPropertyChanged(); } }
    }

    internal class Spy : Background
    {
        private string _backgroundName = "Spy";
        private string _backgroundDescription = "You are a master of espionage and subterfuge, skilled in gathering information and influencing others. You might have been trained by a government agency or a private organization, or you might be a freelancer who sells your services to the highest bidder.";
        private List<string> _backgroundSkills = new List<string> { "Deception", "Stealth" };

        public new string BackgroundName { get { return _backgroundName; } set { _backgroundName = value; OnPropertyChanged(); } }

        public new string BackgroundDescription { get { return _backgroundDescription; } set { _backgroundDescription = value; OnPropertyChanged(); } }
        public new List<string> BackgroundSkills { get { return _backgroundSkills; } set { _backgroundSkills = value; OnPropertyChanged(); } }
    }

    internal class Smuggler : Background
    {
        private string _backgroundName = "Smuggler";
        private string _backgroundDescription = "You make your living by transporting illegal or restricted goods across borders or through dangerous territories. You might have a network of contacts and informants, or you might rely on your own wit and cunning to get the job done.";
        private List<string> _backgroundSkills = new List<string> { "Deception", "Stealth" };

        public new string BackgroundName { get { return _backgroundName; } set { _backgroundName = value; OnPropertyChanged(); } }

        public new string BackgroundDescription { get { return _backgroundDescription; } set { _backgroundDescription = value; OnPropertyChanged(); } }
        public new List<string> BackgroundSkills { get { return _backgroundSkills; } set { _backgroundSkills = value; OnPropertyChanged(); } }
    }

}