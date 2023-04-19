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

internal class Elf : Race
{
    private string _raceName = "Elf";
    private string _raceDesciption = "Elves are a magical people of otherworldly grace, living in the world but not entirely part of it. They live in places of ethereal beauty, in the midst of ancient forests or in silvery spires glittering with faerie light, where soft music drifts through the air and gentle fragrances waft on the breeze.";
    private List<string> _raceTraits = new List<string> { "Keen senses", "Long-lived" };

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

internal class Orc : Race
{
    private string _raceName = "Orc";
    private string _raceDesciption = "Orcs are fierce, brutish creatures known for their strength and aggression. They are often seen as violent and uncivilized by other races, but their society is actually quite structured, with a strong emphasis on strength and loyalty to one's clan.";
    private List<string> _raceTraits = new List<string> { "Aggressive", "Strong" };

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

internal class Halfling : Race
{
    private string _raceName = "Halfling";
    private string _raceDesciption = "Halflings are a small and unassuming folk, known for their love of good food and comfortable living. They are often underestimated by other races, but their small size and quick wits make them surprisingly agile and resourceful in a tight spot.";
    private List<string> _raceTraits = new List<string> { "Lucky", "Agile" };

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

internal class Gnome : Race
{
    private string _raceName = "Gnome";
    private string _raceDescription = "Gnomes are a diminutive, wiry race of tinkers who live underground. Though gnomes love jokes of all kinds, particularly puns and pranks, they are also talented engineers and inventors.";
    private List<string> _raceTraits = new List<string> { "Curious", "Inventive" };

    public new string RaceName
    {
        get { return _raceName; }
        set { _raceName = value; OnPropertyChanged(); }
    }

    public new string RaceDescription
    {
        get { return _raceDescription; }
        set { _raceDescription = value; OnPropertyChanged(); }
    }

    public new List<string> RaceTraits
    {
        get { return _raceTraits; }
        set { _raceTraits = value; OnPropertyChanged(); }
    }
}

internal class Goblin : Race
{
    private string _raceName = "Goblin";
    private string _raceDescription = "Goblins are small, mischievous humanoids who live in caves, abandoned mines, and other dark, underground places. They are known for their love of shiny objects, their ability to create explosive devices, and their general tendency to cause chaos and destruction.";
    private List<string> _raceTraits = new List<string> { "Clever", "Chaotic" };

    public new string RaceName
    {
        get { return _raceName; }
        set { _raceName = value; OnPropertyChanged(); }
    }

    public new string RaceDescription
    {
        get { return _raceDescription; }
        set { _raceDescription = value; OnPropertyChanged(); }
    }

    public new List<string> RaceTraits
    {
        get { return _raceTraits; }
        set { _raceTraits = value; OnPropertyChanged(); }
    }
}

internal class Dragon : Race
{
    private string _raceName = "Dragon";
    private string _raceDescription = "Dragons are ancient, powerful reptilian creatures that can breathe fire or frost. They hoard treasure, guard ancient ruins, and sometimes take human form to interact with mortals. They are highly intelligent and often possess magical abilities.";
    private List<string> _raceTraits = new List<string> { "Proud", "Avaricious" };

    public new string RaceName
    {
        get { return _raceName; }
        set { _raceName = value; OnPropertyChanged(); }
    }

    public new string RaceDescription
    {
        get { return _raceDescription; }
        set { _raceDescription = value; OnPropertyChanged(); }
    }

    public new List<string> RaceTraits
    {
        get { return _raceTraits; }
        set { _raceTraits = value; OnPropertyChanged(); }
    }
}
internal class Cyborg : Race
{
    private string _raceName = "Cyborg";
    private string _raceDescription = "Cyborgs are beings who have had mechanical or technological components integrated with their bodies. They are often highly skilled in technology and combat, and may have abilities beyond those of normal humans or machines.";
    private List<string> _raceTraits = new List<string> { "Adaptive", "Precise" };

    public new string RaceName
    {
        get { return _raceName; }
        set { _raceName = value; OnPropertyChanged(); }
    }

    public new string RaceDescription
    {
        get { return _raceDescription; }
        set { _raceDescription = value; OnPropertyChanged(); }
    }

    public new List<string> RaceTraits
    {
        get { return _raceTraits; }
        set { _raceTraits = value; OnPropertyChanged(); }
    }
}


internal class Faerie : Race
{
    private string _raceName = "Faerie";
    private string _raceDescription = "Faeries are small, magical beings that dwell in hidden places within the natural world. They are known for their mischievous nature and powerful magic, which they often use to play pranks on unsuspecting humans. However, they can also be kind and helpful to those they deem worthy of their aid.";
    private List<string> _raceTraits = new List<string> { "Mischievous", "Magical" };

    public new string RaceName
    {
        get { return _raceName; }
        set { _raceName = value; OnPropertyChanged(); }
    }

    public new string RaceDescription
    {
        get { return _raceDescription; }
        set { _raceDescription = value; OnPropertyChanged(); }
    }

    public new List<string> RaceTraits
    {
        get { return _raceTraits; }
        set { _raceTraits = value; OnPropertyChanged(); }
    }
}
