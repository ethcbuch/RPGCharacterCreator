using RPGCharacterCreator;
using RPGCharacterCreator.Core;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlInclude(typeof(Human))]

[XmlInclude(typeof(Dwarf))]
public class Race : ObservableObject
{
    private string _raceName { get; set; }
    private string _raceDesciption { get; set; }
    private List<string> _raceTraits { get; set; }

    public  string RaceName
    {
        get { return _raceName; }
        set { _raceName = value; OnPropertyChanged(); }
    }

    public  string RaceDescription
    {
        get { return _raceDesciption; }
        set { _raceDesciption = value; OnPropertyChanged(); }
    }

    public  List<string> RaceTraits
    {
        get { return _raceTraits; }
        set { _raceTraits = value; OnPropertyChanged(); }
    }


}

public class Human : Race
{
    private string _raceName = "Human";
    private string _raceDesciption = "Humans are the youngest of the common races, late to arrive on the world scene and short-lived in comparison to dwarves, elves, and dragons. Perhaps it is because of their shorter lives that they strive to achieve as much as they can in the years they are given. Or maybe they feel they have something to prove to the elder races, and that’s why they build their mighty empires on the foundation of conquest and trade. Whatever drives them, humans are the innovators, the achievers, and the pioneers of the worlds. ";
    private List<string> _raceTraits = new List<string> { "Persevering ", "Unlucky" };

    public new string RaceName
    {
        get { return _raceName; }
        set { _raceName = value; OnPropertyChanged(); }
    }

    public new string RaceDescription
    {
        get { return _raceDesciption; }
        set { _raceDesciption = value; OnPropertyChanged(); }
    }

    public new List<string> RaceTraits
    {
        get { return _raceTraits; }
        set { _raceTraits = value; OnPropertyChanged(); }
    }
}
public class Dwarf : Race
{
    private string _raceName = "Dwarf";
    private string _raceDesciption = "Though they stand well under 5 feet tall, dwarves are so broad and compact that they can weigh as much as a human standing nearly two feet taller. Their courage and endurance are also easily a match for any of the larger folk.";
    private List<string> _raceTraits = new List<string> { "Trustworthy", "Pefectionist" };

    public new string RaceName
    {
        get { return _raceName; }
        set { _raceName = value; OnPropertyChanged(); }
    }

    public new string RaceDescription
    {
        get { return _raceDesciption; }
        set { _raceDesciption = value; OnPropertyChanged(); }
    }

    public new List<string> RaceTraits
    {
        get { return _raceTraits; }
        set { _raceTraits = value; OnPropertyChanged(); }
    }
}