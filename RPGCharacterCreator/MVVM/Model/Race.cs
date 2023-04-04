using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGCharacterCreator.MVVM.Model
{
    public abstract class Race
    {
        private string _raceName;
        private string _raceDesciption;
        private List<string> _raceTraits;

        public abstract string RaceName { get; set; }
        public abstract string RaceDescription { get; set; }
        public abstract List<string> RaceTraits { get; set; }
    }

    public class Human : Race
    {
        private string _raceName = "Human";
        private string _raceDesciption = "Humans are the youngest of the common races, late to arrive on the world scene and short-lived in comparison to dwarves, elves, and dragons. Perhaps it is because of their shorter lives that they strive to achieve as much as they can in the years they are given. Or maybe they feel they have something to prove to the elder races, and that’s why they build their mighty empires on the foundation of conquest and trade. Whatever drives them, humans are the innovators, the achievers, and the pioneers of the worlds. ";
        private List<string> _raceTraits = new List<string> { "Persevering ", "Unlucky" };

        public override string RaceName
        {
            get { return _raceName; }
            set { _raceName = value; }
        }

        public override string RaceDescription
        {
            get { return _raceDesciption; }
            set { _raceDesciption = value; }
        }

        public override List<string> RaceTraits
        {
            get { return _raceTraits; }
            set { _raceTraits = value; }
        }
    }
    public class Dwarf : Race
    {
        private string _raceName = "Dwarf";
        private string _raceDesciption = "Though they stand well under 5 feet tall, dwarves are so broad and compact that they can weigh as much as a human standing nearly two feet taller. Their courage and endurance are also easily a match for any of the larger folk.";
        private List<string> _raceTraits = new List<string> { "Trustworthy", "Pefectionist" };

        public override string RaceName
        {
            get { return _raceName; }
            set { _raceName = value; }
        }

        public override string RaceDescription
        {
            get { return _raceDesciption; }
            set { _raceDesciption = value; }
        }

        public override List<string> RaceTraits
        {
            get { return _raceTraits; }
            set { _raceTraits = value; }
        }
    }

}