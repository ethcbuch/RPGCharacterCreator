using RPGCharacterCreator.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RPGCharacterCreator.MVVM.Model
{
    //class for alignment for the character
    internal class Alignment : ObservableObject
    {
        private string _alignmentName { get; set; }
        private string _alignmentDescription { get; set; }

        public string AlignmentName
        {
            get { return _alignmentName; }
            set { _alignmentName = value; OnPropertyChanged(); }
        }

        public string AlignmentDescription
        {
            get { return _alignmentDescription; }
            set { _alignmentDescription = value; OnPropertyChanged(); }
        }
    }

    //class for Lawful good (concrete class which inheirts from the Alignment class)
    internal class LawfulGood : Alignment
    {
        private string _alignmentName = "Lawful Good";
        private string _alignmentDescription = "Lawful Good characters always do the right thing as expected by society. They always follow the rules, tell the truth and help people out. They like order, trust and believe in people in positions of power, and they aim to be an upstanding citizen.";

        public new string AlignmentName
        {
            get { return _alignmentName; }
            set { _alignmentName = value; OnPropertyChanged(); }
        }

        public new string AlignmentDescription
        {
            get { return _alignmentDescription; }
            set { _alignmentDescription = value; OnPropertyChanged(); }
        }
    }

    //class for Chaotic Evil (concrete class which inheirts from the Alignment class)
    internal class ChaoticEvil : Alignment
    {
        private string _alignmentName = "Chaotic Evil";
        private string _alignmentDesciption = "A chaotic evil character tends to have no respect for rules, other people's lives, or anything but their own desires, which are typically selfish and cruel. They set a high value on personal freedom, but do not have much regard for the lives or freedom of other people. Chaotic evil characters do not work well in groups because they resent being given orders and usually do not behave themselves unless there is no alternative.";
        public new string AlignmentName
        {
            get { return _alignmentName; }
            set { _alignmentName = value; OnPropertyChanged(); }
        }

        public new string AlignmentDescription
        {
            get { return _alignmentDesciption; }
            set { _alignmentDesciption = value; OnPropertyChanged(); }
        }
    }


    //class for Lawful Neutral (concrete class which inheirts from the Alignment class)
    internal class LawfulNeutral : Alignment
    {
        private string _alignmentName = "Lawful Neutral";
        private string _alignmentDescription = "Lawful Neutral characters follow the rules without preference for good or evil. They strive to maintain balance and order in the world, and they believe in the concept of a society that is well-ordered and regulated.";

        public new string AlignmentName
        {
            get { return _alignmentName; }
            set { _alignmentName = value; OnPropertyChanged(); }
        }

        public new string AlignmentDescription
        {
            get { return _alignmentDescription; }
            set { _alignmentDescription = value; OnPropertyChanged(); }
        }
    }


    //class for True Neutral (concrete class which inheirts from the Alignment class)
    internal class TrueNeutral : Alignment
    {
        private string _alignmentName = "Neutral";
        private string _alignmentDescription = "Neutral characters are committed to the balance of things and believe in avoiding extremes. They value the balance of good and evil, order and chaos, and law and freedom. They may appear indecisive or uncommitted, but they are simply waiting for the right moment to act.";

        public new string AlignmentName
        {
            get { return _alignmentName; }
            set { _alignmentName = value; OnPropertyChanged(); }
        }

        public new string AlignmentDescription
        {
            get { return _alignmentDescription; }
            set { _alignmentDescription = value; OnPropertyChanged(); }
        }
    }

    //class for Chaotic Neutral (concrete class which inheirts from the Alignment class)
    internal class ChaoticNeutral : Alignment
    {
        private string _alignmentName = "Chaotic Neutral";
        private string _alignmentDescription = "Chaotic Neutral characters are unpredictable and value their personal freedom above all else. They believe in a world without order or control, and they tend to be individualistic, independent, and distrustful of authority. They may commit good or evil acts depending on their mood or whims.";

        public new string AlignmentName
        {
            get { return _alignmentName; }
            set { _alignmentName = value; OnPropertyChanged(); }
        }

        public new string AlignmentDescription
        {
            get { return _alignmentDescription; }
            set { _alignmentDescription = value; OnPropertyChanged(); }
        }
    }

    //class for Lawful Evil (concrete class which inheirts from the Alignment class)
    internal class LawfulEvil : Alignment
    {
        private string _alignmentName = "Lawful Evil";
        private string _alignmentDescription = "Lawful Evil characters believe in using the rules and order of society to gain power and control over others. They may appear honorable or even admirable, but they are willing to do whatever it takes to achieve their goals. They believe that the ends justify the means, and they are not afraid to use evil or immoral methods to achieve their aims.";

        public new string AlignmentName
        {
            get { return _alignmentName; }
            set { _alignmentName = value; OnPropertyChanged(); }
        }

        public new string AlignmentDescription
        {
            get { return _alignmentDescription; }
            set { _alignmentDescription = value; OnPropertyChanged(); }
        }
    }
    //class for Neutral Good (concrete class which inherits from the Alignment class)
    internal class NeutralGood : Alignment
    {
        private string _alignmentName = "Neutral Good";
        private string _alignmentDescription = "Neutral Good characters do the best they can to help others according to their needs. They are not committed to upholding the law or maintaining social order, but they also do not seek to disrupt it. They are kind-hearted and believe in the value of individual freedom and happiness, but not at the expense of others.";

        public new string AlignmentName
        {
            get { return _alignmentName; }
            set { _alignmentName = value; OnPropertyChanged(); }
        }

        public new string AlignmentDescription
        {
            get { return _alignmentDescription; }
            set { _alignmentDescription = value; OnPropertyChanged(); }
        }
    }

    // class for Chaotic Good (concrete class which inherits from the Alignment class)
    internal class ChaoticGood : Alignment
    {
        private string _alignmentName = "Chaotic Good";
        private string _alignmentDescription = "A chaotic good character acts as their conscience directs them with little regard for what others expect of them. They make their own way, but they're kind and benevolent. They believe in goodness and right but have little use for laws and regulations. They hate it when people try to intimidate others and tell them what to do. They follow their own moral compass, which, although good, may not agree with that of society.";

        public new string AlignmentName
        {
            get { return _alignmentName; }
            set { _alignmentName = value; OnPropertyChanged(); }
        }

        public new string AlignmentDescription
        {
            get { return _alignmentDescription; }
            set { _alignmentDescription = value; OnPropertyChanged(); }
        }
    }

    // class for Neutral Evil (concrete class which inherits from the Alignment class)
    internal class NeutralEvil : Alignment
    {
        private string _alignmentName = "Neutral Evil";
        private string _alignmentDescription = "Neutral Evil characters are interested only in themselves and their own advancement. They are not bound by any rules or loyalties, but they do not have the anarchic tendencies";
    public new string AlignmentName
        {
            get { return _alignmentName; }
            set { _alignmentName = value; OnPropertyChanged(); }
        }

        public new string AlignmentDescription
        {
            get { return _alignmentDescription; }
            set { _alignmentDescription = value; OnPropertyChanged(); }
        }
    }











}