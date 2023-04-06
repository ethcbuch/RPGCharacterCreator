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

    //Class for Lawful good (concrete class which inheirts from the Alignment class)
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


    //Class for Chaotic Evil (concrete class which inheirts from the Alignment class)
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
}








